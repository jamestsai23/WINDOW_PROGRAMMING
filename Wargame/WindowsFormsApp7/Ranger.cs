using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Ranger : chess
    {
        public string character = "遊俠";
        public int hp = 90;
        public int mp = 10;
        public int atk = 30;
        public int atkRange = 3;
        public int moveRange = 1;

        public virtual void Skill() {
            atkRange = 4;
        }
    }
}
