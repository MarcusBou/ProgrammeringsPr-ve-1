using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve_1
{
    class Characters
    {
        private string heroName;
        private int attackStart, attackEnd, defenceStart,defenceEnd, hitpoints;
        public string HeroName { set { heroName = value; } get { return heroName; } }

        public int AttackStart { set { attackStart = value; } get { return attackStart; } }
        public int AttackEnd { set { attackEnd = value; } get { return attackEnd; } }
        public int DefenceStart { set { defenceStart = value; } get { return defenceStart; } }
        public int DefenceEnd { set { defenceEnd = value; } get { return defenceEnd; } }
        public int Hitpoints { set { hitpoints = value; } get { return hitpoints; } }

        public Characters(string HeroNames, int AttackS, int AttackE, int defenceS,int defenceE, int hitponts)
        {
            this.heroName = HeroNames;
            this.attackStart = AttackS;
            this.attackEnd = AttackE;
            this.defenceStart = defenceS;
            this.defenceEnd = defenceE;
            this.hitpoints = hitponts;
        }
    }
}
