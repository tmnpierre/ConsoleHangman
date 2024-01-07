public class Pendu
{
    private string _masque;
    private int _nombreEssais;
    private string _motATrouver;
    private string _indice;

    public Pendu(string mot, string indice)
    {
        if (string.IsNullOrWhiteSpace(mot) || !mot.All(char.IsLetter))
        {
            throw new ArgumentException("Le mot à deviner doit être non nul et ne contenir que des lettres.");
        }
        _motATrouver = mot.ToLower();
        _indice = indice;
        GenererMasque();
        _nombreEssais = 10;
    }

    private void GenererMasque()
    {
        _masque = new string('_', _motATrouver.Length);
    }

    public bool TestChar(char c)
    {
        bool found = false;
        char[] masqueArray = _masque.ToCharArray();

        for (int i = 0; i < _motATrouver.Length; i++)
        {
            if (_motATrouver[i] == c)
            {
                masqueArray[i] = c;
                found = true;
            }
        }

        _masque = new string(masqueArray);
        if (!found)
        {
            _nombreEssais--;
        }

        return found;
    }

    public bool TestWin()
    {
        return !_masque.Contains('_');
    }

    public string GetMasque()
    {
        return _masque;
    }

    public int GetNombreEssais()
    {
        return _nombreEssais;
    }

    public string GetMotATrouver()
    {
        return _motATrouver;
    }

    public string Indice
    {
        get { return _indice; }
    }

    public static (string Mot, string Indice) ObtenirMotEtIndiceAleatoire()
    {
        var motsEtIndices = new (string Mot, string Indice)[] {
        ("ordinateur", "Appareil électronique de traitement de l'information"),
        ("clavier", "Accessoire avec des touches pour saisir des données"),
        ("souris", "Dispositif de pointage pour ordinateur"),
        ("écran", "Surface d'affichage visuelle d'un ordinateur"),
        ("tableau", "Surface plane sur laquelle on écrit"),
        ("chaise", "Meuble pour s'asseoir"),
        ("fenêtre", "Ouverture dans un mur pour laisser entrer la lumière"),
        ("livre", "Ensemble de pages reliées contenant du texte ou des illustrations"),
        ("téléphone", "Appareil de communication à distance"),
        ("stylo", "Outil pour écrire ou dessiner"),
        ("bouteille", "Récipient pour liquides avec un goulot étroit"),
        ("lampe", "Appareil produisant de la lumière"),
        ("sac", "Conteneur souple pour transporter des objets"),
        ("horloge", "Instrument de mesure du temps"),
        ("photo", "Image prise par un appareil photographique"),
        ("papier", "Matériau fin utilisé pour écrire ou imprimer"),
        ("ciseaux", "Outil avec deux lames pour couper"),
        ("carte", "Représentation géographique plane d'une région"),
        ("fleur", "Partie colorée d'une plante produisant des graines"),
        ("cahier", "Ensemble de feuilles de papier utilisées pour écrire"),
        ("verre", "Récipient transparent pour boire"),
        ("montre", "Appareil portable indiquant l'heure"),
        ("porte", "Panneau mobile permettant d'entrer ou de sortir"),
        ("clé", "Outil pour actionner une serrure"),
        ("voiture", "Véhicule motorisé pour le transport de personnes"),
        ("arbre", "Plante ligneuse de grande taille"),
        ("ciel", "Espace visible au-dessus de la terre"),
        ("soleil", "Étoile autour de laquelle la terre gravite"),
        ("lune", "Satellite naturel de la terre"),
        ("étoile", "Corps céleste brillant dans le ciel nocturne")
    };

        Random random = new Random();
        int index = random.Next(motsEtIndices.Length);
        return motsEtIndices[index];
    }

}
