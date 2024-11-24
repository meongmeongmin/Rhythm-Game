using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RhythmGame.Note;

namespace RhythmGame
{
    public class Note
    {
        public enum ELane
        {
            Lane1 = 1, 
            Lane2, 
            Lane3, 
            Lane4
        }

        public ELane Lane;
        public float Time;   // 노트 생성 시간 (초 단위)

        public Note(ELane lane, float time)
        {
            Time = time;
            Lane = lane;
        }
    }
}
