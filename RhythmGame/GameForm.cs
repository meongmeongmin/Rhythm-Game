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
        }

        void PlayMusic(string musicName)
        {
            string musicPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", $"{musicName}.flac");
            
            if (File.Exists(musicPath) == false)
            {
                MessageBox.Show($"음악 파일을 찾을 수 없습니다: {musicPath}");
                return;
            }

            if (_audioFile == null)
            {
                _audioFile = new AudioFileReader(musicPath);
                _waveOut = new WaveOutEvent();
                _waveOut.Init(_audioFile);
            }

            if (isPaused)
                _audioFile.Position = _currentPosition; // 저장된 위치에서 재생

            isPaused = false;
            _waveOut.Play();
        }

        void PauseMusic()
        {
            if (_waveOut != null && _audioFile != null)
            {
                _currentPosition = _audioFile.Position; // 현재 재생 위치 저장
                _waveOut.Stop();
                isPaused = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)   // 현재 이 폼이 닫힐 때(Close) 자동 호출
        {
            _waveOut?.Stop();
            _waveOut?.Dispose();
            _audioFile?.Dispose();
            base.OnFormClosing(e);
        }

        #region UI
        void homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Close();

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        void settingsButton_Click(object sender, EventArgs e)
        {
            PauseMusic();

            Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Owner = this;
            settingsForm.ShowDialog();
            Show();

            PlayMusic(_musicName);
        }
        #endregion
    }
}
