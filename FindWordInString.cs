namespace ApplicationProgramming;

public class FindWordInString
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter string:");
        string inputString = Console.ReadLine();
        Console.WriteLine("Enter word want to search:");
        string wordtoSearch = Console.ReadLine();
        int count = countOccurrences(inputString, wordtoSearch);
        Console.WriteLine($"Word found {count} times in the string");

        int countOccurrences(string str,
            string word)
        {
            
            string[] a = str.Split(' ');
    
    
            count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (word.Equals(a[i]))
                    count++;
            }
    
            return count;
        }
        {
        }
    }
}