﻿using System;
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
using static RhythmGame.Note;

namespace RhythmGame
{
    public partial class GameForm : Form
    {
        IWavePlayer _waveOut;
        AudioFileReader _audioFile;
        long _currentPosition;  // 현재 재생 위치 저장
        bool isPaused = false;  // 음악 일시 정지 여부

        string _musicName = "60's Cardin_Glen Check_Haute Couture";

        Timer _timer = new Timer();

        List<Note> _notes;
        int _score = 0;

        #region 노트
        int _noteSpeed = 5;

        int _noteWidth = 100;
        int _noteHeight = 25;
        #endregion

        #region 판정
        readonly int _judgmentTop;
        readonly int _judgmentBottom;
        readonly int _judgmentCenter;

        const int _judgmentPerfectThreshold = 10;
        const int _judgmentGoodThreshold = 20;
        #endregion

        Dictionary<ELane, Keys> _laneKeys = new Dictionary<ELane, Keys>
        {
            { ELane.Lane1, Program.Rane1Key },
            { ELane.Lane2, Program.Rane2Key },
            { ELane.Lane3, Program.Rane3Key },
            { ELane.Lane4, Program.Rane4Key }
        };

        public GameForm()
        {
            InitializeComponent();

            // 깜빡임 방지
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            // 판정 픽처 박스들이 dock라서 Top과 Bottom 대신에 Location Y로 했다
            _judgmentTop = judgmentTopPictureBox.Location.Y;    
            _judgmentBottom = judgmentBottomPictureBox.Location.Y;
            _judgmentCenter = (_judgmentTop + _judgmentBottom) / 2;

            InitializeTimer();
            StartGame();
        }

        protected override CreateParams CreateParams    // 깜빡임 방지
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        void InitializeTimer()
        {
            _timer.Interval = 16;    // 약 60FPS
            _timer.Tick += UpdateNotes;  // 16ms마다 호출
        }

        void StartGame()
        {
            _timer.Start();
            PlayMusic(_musicName);
            UpdateScore();
        }

        void PlayMusic(string musicName)
        {
            string musicPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", $"{musicName}.flac");  // flac 파일은 리소스 탐색기에서 가져올 수 없으므로 상대 경로를 통해 가져온다

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

            if (isPaused)   // 저장된 위치에서 재생
                _audioFile.Position = _currentPosition;

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
                ELane lane = (ELane)random.Next(1, 5);
                notes.Add(new Note(lane, currentTime));
            }

            return notes;
        }

        void UpdateNotes(object sender, EventArgs e)
        {
            float currentTime = (float)_audioFile.CurrentTime.TotalSeconds;
            List<Note> notes = new List<Note>();

            // 노트를 생성하여 화면에 표시
            foreach (Note note in _notes.ToList())
            {
                if (note.Time <= currentTime + 1.0f && note.Time > currentTime) // 노트 생성 시간 확인
                {
                    Panel notePanel = new Panel
                    {
                        BackgroundImage = GetNoteBackgroundImage(note.Lane),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Width = _noteWidth,
                        Height = _noteHeight,
                        Tag = note,
                        Left = GetLaneXPosition(note.Lane), // 레인 위치
                        Top = 40    // 생성 위치
                    };

                    Controls.Add(notePanel);
                    notes.Add(note);
                }
            }

            // 리스트에서 생성된 노트 제거
            foreach (var note in notes)
                _notes.Remove(note);

            var panels = Controls.OfType<Panel>().ToList();
            foreach (Control control in panels)
            {
                Note note = control.Tag as Note;
                if (note == null)
                    continue;

                control.Top += _noteSpeed;   // 노트를 아래로 이동

                // 화면 밖으로 벗어난 노트를 제거
                if (control.Top > _judgmentBottom)
                {
                    Controls.Remove(control);
                    control.Dispose();
                    ShowJudgmentEffect("Miss", Color.Red, GetLaneXPosition(note.Lane));
                }
            }
        }

        Image GetNoteBackgroundImage(ELane lane)
        {
            if (lane == ELane.Lane1 || lane == ELane.Lane3)
                return Properties.Resources.Note00;
            else
                return Properties.Resources.Note01;
        }

        int GetLaneXPosition(ELane lane)
        {
            switch (lane)
            {
                case ELane.Lane1:
                    return 3;
                case ELane.Lane2:
                    return 119;
                case ELane.Lane3:
                    return 235;
                case ELane.Lane4:
                    return 351;
                default:
                    return 0;
            }
        }

        void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Control control in Controls.OfType<Panel>().ToList())
            {
                Note note = control.Tag as Note;
                if (note == null)
                    continue;

                int noteTop = control.Top;
                int noteBottom = control.Top + control.Height;
                int noteCenter = noteTop + (control.Height / 2);

                if (noteBottom >= _judgmentTop && noteTop <= _judgmentBottom)   // 판정 영역 확인
                {
                    if (IsKeyPressed(e.KeyCode, note.Lane))
                    {
                        int distance = Math.Abs(noteCenter - _judgmentCenter);  // 판정 거리 계산
                        string judgment = GetJudgment(distance);
                        HandleJudgment(judgment, note.Lane);

                        // 노트 제거
                        Controls.Remove(control);
                        control.Dispose();
                        _notes.Remove(note);
                        
                        break;
                    }
                }
            }
        }

        bool IsKeyPressed(Keys keyPressed, ELane lane)
        {
            return _laneKeys.TryGetValue(lane, out Keys key) && keyPressed == key;
        }

        string GetJudgment(int distance)
        {
            if (distance <= _judgmentPerfectThreshold) 
                return "Perfect";
            else if (distance <= _judgmentGoodThreshold) 
                return "Good";
            return "Miss";
        }

        void HandleJudgment(string judgment, ELane lane)
        {
            int laneX = GetLaneXPosition(lane);

            switch (judgment)
            {
                case "Perfect":
                    _score += 100;
                    ShowJudgmentEffect(judgment, Color.Green, laneX);
                    break;
                case "Good":
                    _score += 50;
                    ShowJudgmentEffect(judgment, Color.Yellow, laneX);
                    break;
                case "Miss":
                    ShowJudgmentEffect(judgment, Color.Red, laneX);
                    break;
            }

            UpdateScore();
        }

        void PauseGame()
        {
            _timer.Stop();
            _waveOut.Stop();
            _currentPosition = _audioFile.Position; // 현재 재생 위치 저장
            isPaused = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)   // 현재 이 폼이 닫힐 때(Close) 자동 호출
        {
            _timer?.Stop(); 
            _timer?.Dispose();
            _waveOut?.Stop();
            _waveOut?.Dispose();
            _audioFile?.Dispose();
            base.OnFormClosing(e);
        }

        #region UI
        void UpdateScore()
        {
            scoreLabel.Text = $"{_score}";
        }

        void ShowJudgmentEffect(string judgment, Color color, int x)
        {
            Label effectLabel = new Label
            {
                Text = judgment,
                Font = new Font("Arial Rounded MT", 15, FontStyle.Bold),
                ForeColor = color,
                AutoSize = true,
                Location = new Point(x, (_judgmentTop + _judgmentCenter) / 2)
            };

            Controls.Add(effectLabel);

            // 0.5초 뒤에 제거
            Timer effectTimer = new Timer { Interval = 500 };
            effectTimer.Tick += (s, e) =>
            {
                effectTimer.Stop();
                effectLabel.Dispose();
                Controls.Remove(effectLabel);
                effectTimer.Dispose();
            };
            effectTimer.Start();
        }

        void homeButton_Click(object sender, EventArgs e)
        {
            PauseGame();

            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        void settingsButton_Click(object sender, EventArgs e)
        {
            PauseGame();

            Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Owner = this;
            settingsForm.ShowDialog();
            Show();

            StartGame();
        }
        #endregion
    }
}
