using System.Collections;
using System.Text;

public class Solution
{
    public static int UniqueMorseRepresentations(string[] words)
    {
        string[] morseCode = new string[] {".-", "-...", "-.-.", "-..",
                                           ".", "..-.", "--.", "....", 
                                           "..", ".---", "-.-", ".-..", 
                                           "--", "-.", "---", ".--.", 
                                           "--.-", ".-.", "...", "-", 
                                           "..-", "...-", ".--", "-..-", 
                                           "-.--", "--.."};

        List<string> morse = new List<string>();

        for(int i = 0;i < words.Length;i++)
        {
            string countWord = "";

            for(int j = 0; j < words[i].Length;j++)
            {
                countWord += morseCode[words[i][j] - 97];
            }

            morse.Add(countWord);
        }

        morse = morse.Distinct().ToList();
        Console.WriteLine(morse.Count);
        return morse.Count();
    }

    public static void Main(string[] args)
    {

        string[] words = new string[] { "gin", "zen", "gig", "msg" };
        int count = UniqueMorseRepresentations(words);
    }
}