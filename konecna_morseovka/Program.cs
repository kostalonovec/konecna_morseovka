// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        var morseovka = new Morseovka();
        
        string textToEncode = "chobotnice";
        string encodedText = morseovka.Encode(textToEncode);
        Console.WriteLine("Encoded text: " + encodedText);

        string textToDecode = encodedText;
        string decodedText = morseovka.Decode(textToDecode);
        Console.WriteLine("Decoded text: " + decodedText);

        Console.ReadLine();
    }
}
