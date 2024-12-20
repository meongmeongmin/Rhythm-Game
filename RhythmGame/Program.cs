﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhythmGame
{
    internal static class Program
    {
        // 키 셋팅 기본값
        public static Keys Rane1Key = Keys.A;
        public static Keys Rane2Key = Keys.S;
        public static Keys Rane3Key = Keys.D;
        public static Keys Rane4Key = Keys.F;

        // 음악 볼륨 기본값
        public static int MusicVolume = 1;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
