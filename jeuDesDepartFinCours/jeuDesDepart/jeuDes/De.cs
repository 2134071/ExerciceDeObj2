namespace jeuDes
{
    public class De
    {
        // Atributs
        private int[] _facesDe;
        private int _valeurDe;

        public event EventHandler? ChangementDeValeur;
        // STATIC
        // Le _generateurNombre est le même pour tous les objets de type De.
        // On parle ici d'un attribut de classe (appartient à la classe et non aux objets).
        private static Random _generateurNombre = new Random();

        // PROPRIÉTÉ
        // Remplace les accesseurs standards.
        // Donne l'impression d'utiliser directement un attribut.
        // Sans set, il s'agit d'une propriété en lecture seule.
        // On essaie d'éviter les set pour respecter le principe TELL, DON'T ASK.
        public int ValeurDe
        {
            get { return GetValeurDe(); }
            // set reçoit une valeur du type de la propriété nommée value.
            // set { SetValeurDe(value); }
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

        // Si on ne lie pas la propriété à un attribut, alors le compilateur va en générer un.
        // Si le set n'est pas présent, alors on ne pourra pas changer la valeur après initialisation.
        // Si on veut pouvoir changer la valeur de Selectionne dans la classe, mais pas en dehors, on peut mettre le set en privée (get reste publique).
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

        /*
        Retourner un code d'erreur dans une méthode n'oblige pas le développeur à le tester.
        Lever une exception dans une méthode oblige le développeur à la traiter.
        Avec le mécanisme des exceptions, l'erreur bloque l'exécution du programme si le
        développeur n'a pas prévu un traitement.
        */
        public int GetFace(int indice)
        {
            if (indice < 0 || indice > 5)
            {
                throw new Exception("Dé : Indice hors limites");
            }
            return _facesDe[indice];
        }

        // Tell, Don't Ask
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

        // Surcharge d'opérateurs
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
        // Les opérateurs surchargés doivent être static.
        // La méthode appartient à la classe, elle est partageée entre les objets.
        static public int operator +(De de1, De de2)
        {
            //Utilisation
            //  De deGauche = new De();
            //  De deDroite = new De();
            //  int deGauchePlusDeDroite = deGauche + deDroite;

            return de1._valeurDe + de2._valeurDe;
        }

        static public int operator +(De de1, int valeurAjout)
        {
            //Utilisation
            //  De deGauche = new De();
            //  int deGauchePlus42 = deGauche + 42;

            return de1._valeurDe + valeurAjout;
        }

        static public int operator +(int valeurAjout, De de1)
        {
            //Utilisation
            //  De deDroite = new De();
            //  int deGauchePlus42 = 42 + deDroite;

            return de1._valeurDe + valeurAjout;
        }

        //static public De operator +(De de1, De de2)
        //{
        //    //Utilisation
        //    //  De deGauche = new De();
        //    //  De deDroite = new De();
        //    //  De deGauchePlusDeDroite = deGauche + deDroite;

        //    De resultat = new De();
        //    resultat._valeurDe = de1._valeurDe + de2._valeurDe;
        //    return resultat;
        //}

        /*
        Toutes les classes héritent du type Object.
        Celui-ci contient les méthodes:
            .ToString()
            .Equals()
            .GetType()
            .GetHashCode()
        Il est possible de redefinir ces méthodes pour nos classes.
        */
        // override permet de redéfinir une méthode identifiée comme virtual dans la classe de base (ici Object).
        public override bool Equals(object? obj)
        {
            // Utilisation
            //  De de1 = new De();
            //  De de2 = new De();
            //  bool egale = de1 == de2;
            //  bool egale2 = de1.Equals(de2);

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
