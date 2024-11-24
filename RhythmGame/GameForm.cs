using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;

namespace RhythmGame
{
    public partial class GameForm : Form
    {
        IWavePlayer _waveOut;
        AudioFileReader _audioFile;

        List<Note> _notes;
        Timer noteTimer = new Timer();

        string _musicName = "60's Cardin_Glen Check_Haute Couture";
        long _currentPosition;  // 현재 재생 위치 저장
        bool isPaused = false;  // 음악 일시 정지 여부

        public GameForm()
        {
            InitializeComponent();

            // 깜빡임 방지
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            PlayMusic(_musicName);
            InitializeTimer();
        }

        protected override CreateParams CreateParams    // 깜빡임 방지
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        void PlayMusic(string musicName)
        {
            string musicPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", $"{musicName}.flac");

            if (File.Exists(musicPath) == false)
            {
                MessageBox.Show($"음악 파일을 찾을 수 없습니다: {musicPath}");
                return;
            }

            if (_audioFile == null || _waveOut == null)
            {
                _audioFile = new AudioFileReader(musicPath);
                _waveOut = new WaveOutEvent();
                _waveOut.Init(_audioFile);
            }

            if (isPaused)
                _audioFile.Position = _currentPosition; // 저장된 위치에서 재생

            isPaused = false;
            _notes = GenerateNotes();
            _waveOut.Play();
        }

        List<Note> GenerateNotes()
        {
            List<Note> notes = new List<Note>();

            float bpm = 128;
            float secondsPerBeat = 60.0f / bpm; // 한 박자의 시간 간격

            float musicLength = (float)_audioFile.TotalTime.TotalSeconds;
            Random random = new Random();

            // 음악 길이에 따라 노트 생성
            for (float currentTime = 0; currentTime < musicLength; currentTime += secondsPerBeat)
            {
                Note.ELane lane = (Note.ELane)random.Next(1, 5);
                notes.Add(new Note(lane, currentTime));
            }

            return notes;
        }

        void InitializeTimer()
        {
            noteTimer.Interval = 16;    // 약 60FPS
            noteTimer.Tick += UpdateNotes;  // 16ms마다 호출
            noteTimer.Start();
        }

        void UpdateNotes(object sender, EventArgs e)
        {
            float currentTime = GetCurrentMusicTime();
            List<Note> notesToRemove = new List<Note>();

            // 노트 이동
            foreach (Control control in Controls)
            {
                if (control is Panel notePanel)
                    notePanel.Top += 5; // 노트를 아래로 이동
            }

            // 노트를 생성하여 화면에 표시
            foreach (Note note in _notes.ToList())
            {
                if (note.Time <= currentTime + 1.0f && note.Time > currentTime)
                {
                    Panel notePanel = new Panel
                    {
                        BackColor = Color.Blue,
                        Width = 100,
                        Height = 20,
                        Tag = note,
                        Left = GetLaneXPosition(note.Lane), // 레인 위치 계산
                        Top = 60    // 생성 위치(y 좌표)
                    };

                    Controls.Add(notePanel);
                    notesToRemove.Add(note);
                }
            }

            // 리스트에서 생성된 노트 제거
            foreach (var note in notesToRemove)
                _notes.Remove(note);
        }

        float GetCurrentMusicTime()
        {
            return (float)_audioFile.CurrentTime.TotalSeconds;
        }

        int GetLaneXPosition(Note.ELane lane)
        {
            switch (lane)
            {
                case Note.ELane.Lane1: return 7;
                case Note.ELane.Lane2: return 123;
                case Note.ELane.Lane3: return 240;
                case Note.ELane.Lane4: return 353;
                default: return 0;
            }
        }

        void PauseMusic()
        {
            noteTimer.Stop();

            if (_waveOut != null && _audioFile != null)
            {
                _currentPosition = _audioFile.Position; // 현재 재생 위치 저장
                _waveOut.Stop();
                isPaused = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)   // 현재 이 폼이 닫힐 때(Close) 자동 호출
        {
            noteTimer?.Dispose();
            _waveOut?.Stop();
            _waveOut?.Dispose();
            _audioFile?.Dispose();
            base.OnFormClosing(e);
        }

        #region UI
        void homeButton_Click(object sender, EventArgs e)
        {
            PauseMusic();

            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        void settingsButton_Click(object sender, EventArgs e)
        {
            PauseMusic();

            Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Owner = this;
            settingsForm.ShowDialog();
            Show();

            noteTimer.Start();
            PlayMusic(_musicName);
        }
        #endregion
    }
}
