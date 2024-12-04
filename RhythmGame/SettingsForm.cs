using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhythmGame
{
    public partial class SettingsForm : Form
    {
        int _selectedLaneKey = 0;   // 선택된 Lane Key (1~4)

        public SettingsForm()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            // 음악 볼륨 셋팅
            musicTrackBar.Value = Program.MusicVolume;

            // 키 셋팅
            _selectedLaneKey = 0;
            lane1KeyButton.Text = Program.Rane1Key.ToString();
            lane2KeyButton.Text = Program.Rane2Key.ToString();
            lane3KeyButton.Text = Program.Rane3Key.ToString();
            lane4KeyButton.Text = Program.Rane4Key.ToString();
        }

        void backButton_Click(object sender, EventArgs e)   // 뒤로 가기
        {
            Program.MusicVolume = musicTrackBar.Value;
            
            if (Owner is GameForm gameForm)
            {
                gameForm.WaveOut.Volume = musicTrackBar.Value / 10f;    // 음악 볼륨 설정 반영
                gameForm.UpdateLaneKeys();  // 키 설정 반영
            }

            Owner.Show();
            Close();
        }
        
        void LaneKeyButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "lane1KeyButton":
                        _selectedLaneKey = 1;
                        break;
                    case "lane2KeyButton":
                        _selectedLaneKey = 2;
                        break;
                    case "lane3KeyButton":
                        _selectedLaneKey = 3;
                        break;
                    case "lane4KeyButton":
                        _selectedLaneKey = 4;
                        break;
                    default:
                        _selectedLaneKey = 0;
                        break;
                }
            }
            else
                _selectedLaneKey = 0;

            UpdateButtonStyles();
        }

        void UpdateButtonStyles()
        {
            // 모든 버튼 초기화
            lane1KeyButton.BackColor = DefaultBackColor;
            lane2KeyButton.BackColor = DefaultBackColor;
            lane3KeyButton.BackColor = DefaultBackColor;
            lane4KeyButton.BackColor = DefaultBackColor;

            // 선택된 버튼 강조
            switch (_selectedLaneKey)
            {
                case 1:
                    lane1KeyButton.BackColor = Color.LightBlue;
                    break;
                case 2:
                    lane2KeyButton.BackColor = Color.LightBlue;
                    break;
                case 3:
                    lane3KeyButton.BackColor = Color.LightBlue;
                    break;
                case 4:
                    lane4KeyButton.BackColor = Color.LightBlue;
                    break;
            }
        }

        void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)   // 뒤로 가기
            {
                backButton_Click(sender, e);
                return;
            }

            if (CheckKeyDuplicate(e.KeyCode))
                return;

            switch (_selectedLaneKey)
            {
                case 1:
                    Program.Rane1Key = e.KeyCode;
                    lane1KeyButton.Text = e.KeyCode.ToString();
                    break;
                case 2:
                    Program.Rane2Key = e.KeyCode;
                    lane2KeyButton.Text = e.KeyCode.ToString();
                    break;
                case 3:
                    Program.Rane3Key = e.KeyCode;
                    lane3KeyButton.Text = e.KeyCode.ToString();
                    break;
                case 4:
                    Program.Rane4Key = e.KeyCode;
                    lane4KeyButton.Text = e.KeyCode.ToString();
                    break;
            }

            _selectedLaneKey = 0;
            UpdateButtonStyles();
        }

        bool CheckKeyDuplicate(Keys key)    // 키 셋팅 중복 검사
        {
            return key == Program.Rane1Key || key == Program.Rane2Key || key == Program.Rane3Key || key == Program.Rane4Key;
        }
    }
}
