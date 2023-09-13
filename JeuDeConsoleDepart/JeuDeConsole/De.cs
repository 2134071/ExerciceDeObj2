using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeConsole
{
    public class De
    {
        private int[] _facesDe;
        private int _valeurDe;

        public event EventHandler? ChangementDeValeur;
        private static Random _generateurNombre = new Random();

        public int ValeurDe
        {
            get { return GetValeurDe(); }
        }

        public void VerifierEvenement(int valeurPrecedente)
        {
            ChangementValeur(valeurPrecedente);
        }

        private void ChangementValeur(int valeurPrecedente)
        {
            if (valeurPrecedente != this.ValeurDe)
            {
                ChangementDeValeur?.Invoke(this, EventArgs.Empty);
            }

        }

        public bool Selectionne { get; private set; }

        public De()
        {
            _facesDe = new int[] { 1, 2, 3, 4, 5, 6 };
            Brasser();
            Selectionne = false;
        }

        public De(int face1, int face2, int face3, int face4, int face5, int face6)
        {
            _facesDe = new int[6];
            _facesDe[0] = face1;
            _facesDe[1] = face2;
            _facesDe[2] = face3;
            _facesDe[3] = face4;
            _facesDe[4] = face5;
            _facesDe[5] = face6;
            Brasser();
            Selectionne = false;
        }

        private int GetValeurDe()
        {
            return _valeurDe;
        }

        private void SetValeurDe(int valeur)
        {
            if (valeur > _facesDe[5])
            {
                throw new Exception();
            }
            _valeurDe = valeur;
        }
        public int GetFace(int indice)
        {
            if (indice < 0 || indice > 5)
            {
                throw new Exception("Dé : Indice hors limites");
            }
            return _facesDe[indice];
        }
        public void Brasser()
        {
            int anciennevaleur = _valeurDe;
            int faceAleatoire = _generateurNombre.Next(6);

            _valeurDe = _facesDe[faceAleatoire];
            VerifierEvenement(anciennevaleur);
        }

        public void Selectionner()
        {
            Selectionne = true;
        }

        public void Deselectionner()
        {
            Selectionne = false;
        }

        public void InverserSelection()
        {
            Selectionne = !Selectionne;
        }

        static public int operator +(De de1, De de2)
        {

            return de1._valeurDe + de2._valeurDe;
        }

        static public int operator +(De de1, int valeurAjout)
        {
            return de1._valeurDe + valeurAjout;
        }

        static public int operator +(int valeurAjout, De de1)
        {
            return de1._valeurDe + valeurAjout;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null ||
                obj is not De ||
                _valeurDe != ((De)obj)._valeurDe)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return _valeurDe.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
