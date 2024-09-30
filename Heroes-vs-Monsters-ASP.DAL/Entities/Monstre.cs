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

        #endregion
        #region Constructeurs
            De d6 = new De(1, 6);
            De d4 = new De(1, 4);
        protected Monstre() : base()
        {
            Or = d6.Jetdede();
            Cuir = d4.Jetdede();
        }
        #endregion
    }
}