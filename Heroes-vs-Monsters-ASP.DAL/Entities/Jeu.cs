using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{
    public class Jeu
    {
        public void Combat(Heros hero, Monstre monstre)
        {
            int pointDeVieInitial = hero.PointsDeVie;
            Console.WriteLine($"{hero.Nom} rencontre {monstre.Nom} !");

            while (hero.PointsDeVie > 0 && monstre.PointsDeVie > 0)
            {
                hero.Frappe(monstre);
                if (monstre.PointsDeVie > 0)
                {
                    monstre.Frappe(hero);
                }
            }

            if (hero.PointsDeVie > 0)
            {
                Console.WriteLine($"{hero.Nom} a vaincu {monstre.Nom} !");
                Console.WriteLine($"Récompense: Or = {monstre.Or}, Cuir = {monstre.Cuir}");
                hero.RestaurerPointDeVie();
            }
            else
            {
                Console.WriteLine($"{monstre.Nom} a vaincu {hero.Nom} !");
            }
        }
    }
}
