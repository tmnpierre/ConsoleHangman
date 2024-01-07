using System;

public class PenduConsoleUI
{
    private Pendu _jeuPendu;

    public PenduConsoleUI(Pendu jeuPendu)
    {
        _jeuPendu = jeuPendu;
    }

    public void Jouer()
    {
        Console.WriteLine("██████╗ ███████╗███╗   ██╗██████╗ ██╗   ██╗");
        Console.WriteLine("██╔══██╗██╔════╝████╗  ██║██╔══██╗╚██╗ ██╔╝");
        Console.WriteLine("██████╔╝█████╗  ██╔██╗ ██║██║  ██║ ╚████╔╝ ");
        Console.WriteLine("██╔═══╝ ██╔══╝  ██║╚██╗██║██║  ██║  ╚██╔╝  ");
        Console.WriteLine("██║     ███████╗██║ ╚████║██████╔╝   ██║   ");
        Console.WriteLine("╚═╝     ╚══════╝╚═╝  ╚═══╝╚═════╝    ╚═╝   ");
        Console.WriteLine("\nBienvenue dans le jeu du Pendu!");
        Console.WriteLine("Indice: " + _jeuPendu.Indice);

        while (!_jeuPendu.TestWin() && _jeuPendu.GetNombreEssais() > 0)
        {
            AfficherMasque();
            AfficherNombreEssais();
            char lettre = DemanderLettre();
            _jeuPendu.TestChar(lettre);
        }

        AfficherResultat();
    }

    public void AfficherMasque()
    {
        Console.WriteLine("Mot à deviner: " + _jeuPendu.GetMasque());
    }

    public char DemanderLettre()
    {
        while (true)
        {
            Console.Write("Entrez une lettre: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input) && input.Length == 1 && char.IsLetter(input[0]))
            {
                return char.ToLower(input[0]);
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer une seule lettre.");
            }
        }
    }

    public void AfficherResultat()
    {
        if (_jeuPendu.TestWin())
        {
            Console.WriteLine("Félicitations ! Vous avez trouvé le mot.");
        }
        else
        {
            Console.WriteLine("Désolé, vous avez perdu. Le mot était : " + _jeuPendu.GetMotATrouver());
        }
    }

    public void AfficherNombreEssais()
    {
        Console.WriteLine("Nombre d'essais restants: " + _jeuPendu.GetNombreEssais());
    }
}
