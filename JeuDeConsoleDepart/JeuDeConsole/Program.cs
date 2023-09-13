using JeuDeConsole;

Controller leJeu = new Controller();
bool partieTermine = leJeu.isGagnant();
AfficherMessageBienvenue();
AbonnerEvenements();


void AfficherMessageBienvenue()
{
    Console.SetCursorPosition(30, 1);
    Console.WriteLine("Bienvenue dans ce jeu de dés!");
}

while (!partieTermine)
{
    Console.ReadKey(); // Attend une touche de l'utilisateur pour donner le temps de voir l'affichage
    Brasser();
    JoueurSuivant();
}

void AbonnerEvenements()
{
    AfficherLesJoueurs();
    AbonnerEvenementDes();
    AbonnerJoueur();
    AbonnerJoueurCourant();
    FinirPartie();
    AfficherLesDes();
    AfficherJoueurCourant();
}

void FinirPartie()
{
    leJeu.PartieTerminee += LeJeu_PartieTerminee;
}

void LeJeu_PartieTerminee(object? sender, FinPartieEventArgs e)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Le joueur " + e.NomGagnant + " a gagné! en " + e.NombreTours + " tours!");
    Environment.Exit(0);
}

void AbonnerJoueurCourant()
{
    leJeu.JoueurCourantChange += LeJeu_JoueurCourantChange;
}

void LeJeu_JoueurCourantChange(object sender, EventArgs e)
{
    AfficherJoueurCourant();
}

void AbonnerJoueurrantChange(object sender, EventArgs e)
{
    AfficherJoueurCourant();
}

void AbonnerJoueur()
{
    for (int cpt = 0; cpt < Controller.MaxJoueur; cpt++)
    {
        Joueur joueur = leJeu.ObtenirJoueur(cpt);
        joueur.PointsChange += Joueur_PointsChange;
    }
}

void Joueur_PointsChange(object sender, EventArgs e)
{
    AfficherPoints();
}

void AbonnerEvenementDes()
{
    for (int cpt = 0; cpt < Controller.MaxDes; cpt++)
    {
        De de = leJeu.ObtenirDe(cpt);
        de.ChangementDeValeur += De_ChangementDeValeur;
    }
}

void De_ChangementDeValeur(object? sender, EventArgs e)
{
    AfficherLesDes();
}

void Brasser()
{
    De de;
    for (int cpt = 0; cpt < Controller.MaxDes; cpt++)
    {
        de = leJeu.ObtenirDe(cpt);
        de.Brasser();
    }
    leJeu.AjouterPointDe();
}

void AfficherLesDes()
{
    try
    {
        Console.SetCursorPosition(22, 3);
        Console.WriteLine("Dès :");
        Console.SetCursorPosition(44, 3);
        Console.WriteLine(leJeu.ObtenirDe(0).ValeurDe.ToString());
        Console.SetCursorPosition(48, 3);
        Console.WriteLine(leJeu.ObtenirDe(1).ValeurDe.ToString());
        Console.SetCursorPosition(52, 3);
        Console.WriteLine(leJeu.ObtenirDe(2).ValeurDe.ToString());
        Console.SetCursorPosition(56, 3);
        Console.WriteLine(leJeu.ObtenirDe(3).ValeurDe.ToString());
        Console.SetCursorPosition(60, 3);
        Console.WriteLine(leJeu.ObtenirDe(4).ValeurDe.ToString());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void AfficherPoints()
{
    Console.SetCursorPosition(68, 5);
    Console.WriteLine(leJeu.ObtenirJoueur(0).Points.ToString());
    Console.SetCursorPosition(68, 7);
    Console.WriteLine(leJeu.ObtenirJoueur(1).Points.ToString());
    Console.SetCursorPosition(68, 9);
    Console.WriteLine(leJeu.ObtenirJoueur(2).Points.ToString());
}

void AfficherLesJoueurs()
{
    try
    {
        Console.SetCursorPosition(22, 5);
        Console.WriteLine(leJeu.ObtenirJoueur(0).Nom + " :");
        Console.SetCursorPosition(22, 7);
        Console.WriteLine(leJeu.ObtenirJoueur(1).Nom + " :");
        Console.SetCursorPosition(22, 9);
        Console.WriteLine(leJeu.ObtenirJoueur(2).Nom + " :");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void AfficherJoueurCourant()
{
    Console.SetCursorPosition(22, 5);
    Console.WriteLine(leJeu.ObtenirJoueur(0).Nom + " :");
    Console.SetCursorPosition(22, 7);
    Console.WriteLine(leJeu.ObtenirJoueur(1).Nom + " :");
    Console.SetCursorPosition(22, 9);
    Console.WriteLine(leJeu.ObtenirJoueur(2).Nom + " :");

    if (leJeu.JoueurCourant == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(22, 5);
        Console.WriteLine(leJeu.ObtenirJoueur(0).Nom + " :");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (leJeu.JoueurCourant == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(22, 7);
        Console.WriteLine(leJeu.ObtenirJoueur(1).Nom + " :");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(22, 9);
        Console.WriteLine(leJeu.ObtenirJoueur(2).Nom + " :");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

void JoueurSuivant()
{
    leJeu.PasserAuJoueurSuivant();
}