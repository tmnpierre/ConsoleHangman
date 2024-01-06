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
        Console.Write("Entrez une lettre: ");
        string input = Console.ReadLine();
        return !string.IsNullOrWhiteSpace(input) && input.Length == 1 ? input[0] : ' ';
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
