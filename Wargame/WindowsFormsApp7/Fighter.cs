using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Fighter : chess
    {
        public string character = "戰士";
        public int hp = 100;
        public int mp = 15;
        public int atk = 30;
        public int atkRange = 1;
        public int moveRange = 2;

        public virtual void Skill() {
            hp += 15;
        }
    }
}
