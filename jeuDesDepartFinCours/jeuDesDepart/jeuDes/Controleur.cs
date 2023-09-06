namespace jeuDes
{
    internal class Controleur
    {
        // Un objet est toujours une référence

        public const int MaxDes = 5;
        public const int MaxJoueur = 3;
        private De[] _lesDesDuJeu = new De[MaxDes];
        private Joueur[] _lesJoueurDuJeu = new Joueur[MaxJoueur];
        public int JoueurCourant = 0;
        private int _nombreTours = 1;
        public int NombreTours => _nombreTours;
        public event EventHandler JoueurCourantChange;
        public event EventHandler<FinPartieEventArgs> PartieTerminee;
        public Controleur()
        {
            // Création de dés avec valeurs particulières
            _lesDesDuJeu[0] = new De(2, 4, 6, 8, 10, 12);
            _lesDesDuJeu[1] = new De(2, 4, 6, 8, 10, 12);
            _lesDesDuJeu[2] = new De(2, 4, 6, 8, 10, 12);
            _lesDesDuJeu[3] = new De(2, 4, 6, 8, 10, 12);
            _lesDesDuJeu[4] = new De(2, 4, 6, 8, 10, 12);
            _lesJoueurDuJeu[0] = new Joueur("Joueur 1", 0);
            _lesJoueurDuJeu[1] = new Joueur("Joueur 2", 0);
            _lesJoueurDuJeu[2] = new Joueur("Joueur 3", 0);
        }
        // Ce n'est pas une copie du dé qui est retournée mais le dé en tant que tel (type référence)
        public De ObtenirDe(int indice)
        {
            return _lesDesDuJeu[indice];
        }
        public void AjouterPointDe()
        {
            int sommeDes = 0;
            for (int cpt = 0; cpt < MaxDes; cpt++)
            {
                sommeDes = _lesDesDuJeu[cpt].ValeurDe + sommeDes;
            }

            AjouterPoint(sommeDes);
        }
        public void PasserAuJoueurSuivant()
        {
            JoueurCourant = (JoueurCourant + 1) % MaxJoueur;
            if (JoueurCourant == 0)
            {
                _nombreTours++;
            }
            OnJoueurCourantChange();
        }

        protected virtual void OnJoueurCourantChange()
        {
            JoueurCourantChange?.Invoke(this, EventArgs.Empty);
        }

        public void AjouterPoint(int sommeDes)
        {
            _lesJoueurDuJeu[JoueurCourant].AdditionnerPoints(sommeDes);
            VerifierFinJeu();
        }

        public Joueur ObtenirJoueur(int joueur)
        {
            if (joueur < 0 || joueur > (MaxJoueur - 1))
            {
                throw new Exception("Les joueurs du jeu : Indice hors limites!");
            }

            return _lesJoueurDuJeu[joueur];
        }

        public bool isGagnant()
        {
            if (_lesJoueurDuJeu[JoueurCourant].Points >= 100)
            {
                return true;
            }
            return false;
        }
        private void VerifierFinJeu()
        {
            if (isGagnant())
            {
                var gagnant = ObtenirJoueur(JoueurCourant);
                var finPartieEventArgs = new FinPartieEventArgs(_nombreTours, gagnant.Nom);
                PartieTerminee?.Invoke(this, finPartieEventArgs);
            }
        }

        public int ObtenirDeFace(int indiceDe, int indiceFace)
        {
            try
            {
                De de = ObtenirDe(indiceDe);

                return de.GetFace(indiceFace);
            }
            catch (Exception)
            {
                // Contrôleur fait sa gestion d'erreur
                MessageBox.Show("Catch dans Controleur.ObtenirDeFace");
                // Rethrow
                throw;
            }
        }

        /*
        Et qu'en est-il des paramètres?
            - Paramètre par valeur : void fonction(int N)
            - Paramètre par référence : void fonction(ref int N)
                Attention, il faut aussi spécifier le mot ref lors de l'appel de la fonction :
                    int nombre = 10;
                    ...
                    fonction(ref nombre);
                    ...
            - Un objet est déjà une référence lorsqu'il est envoyé en paramètre.
              Sa valeur est donc automatiquement changée.
        */
        public void BrasserLesDes()
        {
            foreach (De de in _lesDesDuJeu)
            {
                de.Brasser();
            }
        }
    }
    public class FinPartieEventArgs : EventArgs
    {
        public int NombreTours { get; }
        public string NomGagnant { get; }

        public FinPartieEventArgs(int nombreTours, string nomGagnant)
        {
            NombreTours = nombreTours;
            NomGagnant = nomGagnant;
        }
    }
}
