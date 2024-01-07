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
            // ... ajoutez d'autres mots et indices ici ...
        };

        Random random = new Random();
        int index = random.Next(motsEtIndices.Length);
        return motsEtIndices[index];
    }
}
