namespace ConsoleHangman
{
    public class PenduConsoleUI
    {
        private Pendu _jeuPendu;

        public PenduConsoleUI(Pendu jeuPendu)
        {
            _jeuPendu = jeuPendu;
        }

        public void AfficherMasque()
        {
            Console.WriteLine("Mot à deviner: " + _jeuPendu.GetMasque());
        }

        public char DemanderLettre()
        {
            char lettre;
            do
            {
                Console.Write("Entrez une lettre: ");
                string input = Console.ReadLine();
                lettre = !string.IsNullOrWhiteSpace(input) && input.Length == 1 ? input[0] : ' ';
            } while (lettre == ' ');

            return lettre;
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
    }
}
