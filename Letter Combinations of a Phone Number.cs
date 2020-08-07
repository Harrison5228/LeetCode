public class Solution {
    public IList<string> LetterCombinations(string digits) {
        
        List<string> result = new List<string>();
        
        if(digits == "")
        {
            return result;
        }
        
        Dictionary<char, List<string>> number_word = new Dictionary<char, List<string>>();
        number_word.Add('2', new List<string> { "a", "b", "c" });
        number_word.Add('3', new List<string> { "d", "e", "f" });
        number_word.Add('4', new List<string> { "g", "h", "i" });
        number_word.Add('5', new List<string> { "j", "k", "l" });
        number_word.Add('6', new List<string> { "m", "n", "o" });
        number_word.Add('7', new List<string> { "p", "q", "r", "s" });
        number_word.Add('8', new List<string> { "t", "u", "v" });
        number_word.Add('9', new List<string> { "w", "x", "y", "z" });

        if (digits.Length == 1)
        {
            return number_word.Where(w => w.Key == digits[0]).FirstOrDefault().Value;
        }
        else if (digits.Length < 3)
        {
            result = Combine(number_word.Where(w => w.Key == digits[0]).FirstOrDefault().Value, number_word.Where(w => w.Key == digits[1]).FirstOrDefault().Value);
        }
        else
        {
            result = Combine(number_word.Where(w => w.Key == digits[0]).FirstOrDefault().Value, number_word.Where(w => w.Key == digits[1]).FirstOrDefault().Value);

            for (int i = 2; i < digits.Length; i++)
            {
                result = Combine(result, number_word.Where(w => w.Key == digits[i]).FirstOrDefault().Value);
            }

        }
        return result;
    }
    
    public List<string> Combine(List<string> s1, List<string> s2)
    {
        List<string> result = new List<string>();

        foreach (var item in s1)
        {
            foreach (var item2 in s2)
            {
                result.Add(item + item2);
            }
        }

        return result;
    }
}
