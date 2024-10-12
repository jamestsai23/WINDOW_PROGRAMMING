using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Magic : chess
    {
        public string character = "法師";
        public int hp = 70;
        public int mp = 25;
        public int atk = 20;
        public int atkRange = 2;
        public int moveRange = 2;

        public virtual void Skill() {
            atk = 40;
        }
    }
}
