class Program
{
    static void Main(string[] args)
    {
        try
        {
            var (mot, indice) = Pendu.ObtenirMotEtIndiceAleatoire();
            Pendu jeuPendu = new Pendu(mot, indice);
            PenduConsoleUI ui = new PenduConsoleUI(jeuPendu);
            ui.Jouer();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Une erreur est survenue: " + ex.Message);
        }
    }
}
