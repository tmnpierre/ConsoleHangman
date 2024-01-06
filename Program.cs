using ConsoleHangman;

class Program
{
    static void Main(string[] args)
    {
        string motADeviner = "exemple";
        Pendu jeuPendu = new Pendu(motADeviner);
        PenduConsoleUI ui = new PenduConsoleUI(jeuPendu);
        ui.Jouer();
    }
}
