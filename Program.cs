class Program
{
    static void Main(string[] args)
    {
        try
        {
            string motADeviner = Pendu.ObtenirMotAleatoire();
            Pendu jeuPendu = new Pendu(motADeviner);
            PenduConsoleUI ui = new PenduConsoleUI(jeuPendu);
            ui.Jouer();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Une erreur est survenue: " + ex.Message);
        }
    }
}
