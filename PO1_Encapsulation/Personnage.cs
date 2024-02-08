using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    internal class Personnage
    {
        private string nom;
        private int pointDeVie;
        private int pointsDePuissance;

        public string Nom { get => nom; set => nom = value; }
        public int PointDeVie { 
            get => pointDeVie;
            set
            {
                if (value > 0)
                {
                    pointDeVie = value;
                }
                else
                {
                    pointDeVie = 0;
                }
            }
        }
        public int PointsDePuissance { get => pointsDePuissance; set => pointsDePuissance = value; }

        public bool EstEnVie
        {
            get
            {
                if(pointDeVie > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
