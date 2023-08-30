using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuDes
{
    public class Joueur
    {
        private string _nom;
        private int _points;

        public string Nom { get => _nom; set => _nom = value; }

        public int Points { get => _points; }

        public Joueur(string nom,int points)
        {
            Nom = nom;
            _points = points;
        }
        public Joueur()
        {
            Nom = "Anonyme";
            _points = 0;
        }

        public void AdditionnerPoints(int points)
        {
            _points += points;
        }
    }
}
