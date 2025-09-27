public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) return new List<string>();

        var letters = new Dictionary<char, string>{
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

        var ans = new Queue<string>();
        ans.Enqueue(""); 
        for (int i = 0; i < digits.Length; i++){
            char d = digits[i];
            // int letter = letters[num];
            string mapped = letters[d];
            int size = ans.Count;            
        for (int j = 0; j < size; j++){            
            var t =  ans.Dequeue();
            foreach (char alpha in mapped.ToCharArray())
                ans.Enqueue(t+alpha);                            
        }
 }      
    return ans.ToList();
        }
}