namespace jeuDes
{
    public partial class Form1 : Form
    {
        Controleur leJeu = new Controleur();

        public Form1()
        {
            InitializeComponent();
            AfficherLesDes();
            AfficherJoueurCourant();
        }

        private void btnBrasser_Click(object sender, EventArgs e)
        {
            De de;

            for (int cpt = 0; cpt < Controleur.MaxDes; cpt++)
            {
                de = leJeu.ObtenirDe(cpt);
                de.Brasser();
            }

            AfficherLesDes();
            InverserBoutons();
        }

        void AfficherLesDes()
        {
            // Utilisation des propriétés
            try
            {
                lblDe1.Text = leJeu.ObtenirDe(0).ValeurDe.ToString();
                lblDe2.Text = leJeu.ObtenirDe(1).ValeurDe.ToString();
                lblDe3.Text = leJeu.ObtenirDe(2).ValeurDe.ToString();
                lblDe4.Text = leJeu.ObtenirDe(3).ValeurDe.ToString();
                lblDe5.Text = leJeu.ObtenirDe(4).ValeurDe.ToString();
                //leJeu.ObtenirDeFace(4, 42);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void AfficherJoueurCourant()
        {
            lblJoueur1.BackColor = Control.DefaultBackColor;
            lblJoueur2.BackColor = Control.DefaultBackColor;
            lblJoueur3.BackColor = Control.DefaultBackColor;

            //if (leJeu.JoueurCourant == 0)
            //{
            //    lblJoueur1.BackColor = Color.Red;
            //}
            //else if (leJeu.JoueurCourant == 1)
            //{
            //    lblJoueur2.BackColor = Color.Red;
            //}
            //else
            //{
            //    lblJoueur3.BackColor = Color.Red;
            //}
        }

        private void btnJoueurSuivant_Click(object sender, EventArgs e)
        {
            InverserBoutons();
        }

        void InverserBoutons()
        {
            btnBrasser.Enabled = !btnBrasser.Enabled;
            btnJoueurSuivant.Enabled = !btnJoueurSuivant.Enabled;
        }
    }
}