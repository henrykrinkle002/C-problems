public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
       //take the word and split into characters sort and save it another string
       List<string> result = new();

       foreach(var word in words){
            if(result.Count > 0 && IsAnagram(result[^1], word))
                continue; //if the word already exists skip through
            result.Add(word);
       }
       return result; 
    }
    //if the function returns false we save the new word as another variable and skip the similar words.
    public bool IsAnagram(string a, string b){
        if(a.Length != b.Length) return false;
        char[] ca = a.ToCharArray();
        char[] cb = b.ToCharArray();
        Array.Sort(ca);
        Array.Sort(cb);
        return new string(ca) == new string(cb);
    }
}