using System.Text;

class Morseovka
{
    private readonly Dictionary<string, string> _encodeDictionary = new Dictionary<string, string>()
    {
        { "ch", "----" },
        { "a", ".-" },
        { "b", "-..." },
        { "c", "-.-." },
        { "d", "-.." },
        { "e", "." },
        { "f", "..-." },
        { "g", "--." },
        { "h", "...." },
        { "i", ".." },
        { "j", ".---" },
        { "k", "-.-" },
        { "l", ".-.." },
        { "m", "--" },
        { "n", "-." },
        { "o", "---" },
        { "p", ".--." },
        { "q", "--.-" },
        { "r", ".-." },
        { "s", "..." },
        { "t", "-" },
        { "u", "..-" },
        { "v", "...-" },
        { "w", ".--" },
        { "x", "-..-" },
        { "y", "-.--" },
        { "z", "--.." },
        { "0", "-----" },
        { "1", ".----" },
        { "2", "..---" },
        { "3", "...--" },
        { "4", "....-" },
        { "5", "....." },
        { "6", "-...." },
        { "7", "--..." },
        { "8", "---.." },
        { "9", "----." },
        { " ", " " },
        { ".", ".-.-.-" },
        { ",", "--..--" },
        { "?", "..--.." },
        { "!", "-.-.--" },
        { "(", "-.--." },
        { ")", "-.--.-" },
        { "&", ".-..." },
        { ":", "---..." },
        { ";", "-.-.-." },
        { "=", "-...-" },
        { "+", ".-.-." },
        { "-", "-....-" },
        { "_", "..--.-" },
        { "\"", ".-..-." },
        { "$", "...-..-" },
        { "@", ".--.-." }
    };
    
    private readonly Dictionary<string, string> _decodeDictionary;
    public Morseovka()
    {
        _decodeDictionary = _encodeDictionary.ToDictionary(x => x.Value, x => x.Key);
    }

    public string Encode(string text)
    {
        
        List<string> pismena= nenavidimch(text);

        List<string> zakodovani = new List<string>();

        foreach (string i in pismena) {
            zakodovani.Add(_encodeDictionary[i.ToString().ToLower()]);
        }

        string kod = string.Join("/", zakodovani);
        return kod;
        
    }
    
    public string Decode(string kod)
    {
        var result = new StringBuilder();
        var morseCodeWords = kod.Split("/");
        foreach (var morseCode in morseCodeWords)
        {
            if (_decodeDictionary.ContainsKey(morseCode))
                result.Append(_decodeDictionary[morseCode]);
        }


        return result.ToString();
        
        
    }
    
    
    private static List<string> nenavidimch(string text)
    {
        List<string> list = new List<string>();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'c')
            {
                        if (text[i + 1] == 'h')
                        {
                            list.Add("ch");
                            i++;
                        }
                        else { list.Add("c"); }
            }

            else { list.Add(text[i].ToString().ToLower()); }
        }
        return list;
    }


}