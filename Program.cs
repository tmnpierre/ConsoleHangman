class Program
{
    static void Main(string[] args)
    {
        try
        {
            var resultat = Pendu.ObtenirMotEtIndiceAleatoire();
            string mot = resultat.Mot;
            string indice = resultat.Indice;

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
