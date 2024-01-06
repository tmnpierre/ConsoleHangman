public class Pendu
{
    private string _masque;
    private int _nombreEssais;
    private string _motATrouver;

    public Pendu(string mot)
    {
        _motATrouver = mot;
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
}
