using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{
    public abstract class Monstre : Personnage
    {
        #region Propriétés
        public int Or { get; protected set; }
        public int Cuir { get; protected set; }
        #endregion
        #region Constructeurs
        protected Monstre(string nom) : base(nom)
        {
            De d6 = new De(1, 6);
            De d4 = new De(1, 4);
            Or = d6.Jetdede();
            Cuir = d4.Jetdede();
        }
        #endregion
    }
}