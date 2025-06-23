using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    
    public bool IsAPalindrome(string word)
    {
        var reversed = new string(word.ToLower().Reverse().ToArray());
        return word.ToLower() == reversed;
    }
}