using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve_1
{
    class heroes
    {
        /*public List<Characters> Heroes = new List<Characters> {
            new Characters("Kung Fu Harry", 2, 2, 5, 5, 120),
            new Characters("Super Hunden Dino",6,8, 2, 8, 70),
            new Characters("Hurtig Karl", 5, 2, 3, 3, 90),
            new Characters("Gift Gunner", 1, 13, 5, 5, 90),
            new Characters("Minimusen Mikkel", 9, 9, 9, 9, 40),
            new Characters("Katten Tiger", 3,6,4,9,35),
            new Characters("Gummigeden ivan", 6, 6, 8, 8, 70),
            new Characters("Elgen Egon", 5, 11 ,4, 4, 90)
         };*/

        public static void Kung_Fu_Harry()
        {
            Characters hero = new Characters("Kung Fu Harry", 2, 2, 5, 5, 120);
            Console.WriteLine(hero.HeroName);
        }

        public static void Super_hunden_Dino()
        {
            Characters hero = new Characters("Super Hunden Dino", 6, 8, 2, 8, 70);
            Console.WriteLine(hero.HeroName);
        }
    }
}
