namespace ConsoleApp1.Classes;

public class StringManipulationApp
{
    private string[] _stringArray = Array.Empty<string>();

    public void Main()
    {
        StringArrayManipulator();
    }

    private void StringArrayManipulator()
    {
        AddString("Hello");
        AddString("My");
        AddString("Name");
        AddString("Is");
        AddString("Arthur");

        PrintArray(_stringArray);
        
        Console.WriteLine(" ");
        FindLongestWord(_stringArray);
        FindShortestWord(_stringArray);
        Console.WriteLine(" ");
        
        ReverseStrings(_stringArray);
        
        AddString("Goodbye!");
        
        PrintArray(_stringArray);
    }

    private void ReverseStrings(string[] inStringArray)
    {
        Console.WriteLine("Every word in array reversed: ");
        
        for (int i = 0; i < inStringArray.Length; i++)
        {
            char[] charArray = inStringArray[i].ToCharArray();
            Array.Reverse(charArray);

            var newString = new string(charArray);
            inStringArray[i] = newString;
        }
    }

    private void FindShortestWord(string[] inStringArray)
    {
        var shortestWordCount = inStringArray.Min(w => w.Length);
        var shortestWord = inStringArray.FirstOrDefault(x => x.Length == shortestWordCount);

        if (shortestWord != null)
        {
            PrintSpecialWord(shortestWord, shortestWordCount, "Shortest");   
        }
    }

    private void FindLongestWord(string[] inStringArray)
    {
        var longestWordCount = inStringArray.Max(w => w.Length);
        var longestWord = inStringArray.LastOrDefault(x => x.Length == longestWordCount);

        if (longestWord != null)
        {
            PrintSpecialWord(longestWord, longestWordCount, "Longest");   
        }
    }

    private void PrintSpecialWord(string stringToPrint, int symbolCount, string nameOfSpecialString)
    {
        Console.WriteLine(nameOfSpecialString + " word in an Array: " + stringToPrint);
        Console.WriteLine("It contains " + symbolCount + " characters in a word!");
    }

    private void AddString(string newString)
    {
        Array.Resize(ref _stringArray, _stringArray.Length + 1);
        _stringArray[_stringArray.Length - 1] = newString;
    }

    private void PrintArray(string[] inStringArray)
    {
        if (inStringArray.Length > 0)
        {
            foreach (var str in inStringArray)
            {
                Console.WriteLine(str);
            }
        }
        else
        {
            Console.WriteLine("Warning! Your array is empty! Nothing to print!");
        }   
    }
}