using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{
    public abstract class Heros : Personnage
    {
        #region Propriétés
        public int PointDeVieMax {  get; protected set; }
        #endregion
        #region Constructeurs
        protected Heros(string nom) : base(nom)
        {
            PointDeVieMax = PointsDeVie;
        }
        #endregion
        #region Méthode 
        public void RestaurerPointDeVie()
        { 
            PointsDeVie = PointDeVieMax;
            Console.WriteLine($"{Nom} restaure ses points de vie après ce dur combat !");
        }

        #endregion
    }
}