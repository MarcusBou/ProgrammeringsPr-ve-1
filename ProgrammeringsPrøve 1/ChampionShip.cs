using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProgrammeringsPrøve_1
{
    class ChampionShip
    {
        private string hero1, hero2, hero3, hero4, hero5,hero6, hero7, hero8, semifinal1, semifinal2, semifinal3, semifinal4, final1, final2;

        #region get set

        public String Hero1 { set { hero1 = value; } get { return hero1; } }
        public String Hero2 { set { hero2 = value; } get { return hero2; } }
        public String Hero3 { set { hero3 = value; } get { return hero3; } }
        public String Hero4 { set { hero4 = value; } get { return hero4; } }
        public String Hero5 { set { hero5 = value; } get { return hero5; } }
        public String Hero6 { set { hero6 = value; } get { return hero6; } }
        public String Hero7 { set { hero7 = value; } get { return hero7; } }
        public String Hero8 { set { hero8 = value; } get { return hero8; } }
        public String Semifinal1 { set { semifinal1 = value; } get { return semifinal1; } }
        public String Semifinal2 { set { semifinal2 = value; } get { return semifinal2; } }
        public String SemiFinal3 { set { semifinal3 = value; } get { return semifinal3; } }
        public String SemiFinal4 { set { semifinal4 = value; } get { return semifinal4; } }
        public String Final1 { set { final1 = value; } get { return final1; } }
        public String Final2 { set { final2 = value; } get { return final2; } }

        #endregion

        public ChampionShip()
        {

        }


        public static void championScreen()
        { 
            Battle.battle();
        }
    }
}
