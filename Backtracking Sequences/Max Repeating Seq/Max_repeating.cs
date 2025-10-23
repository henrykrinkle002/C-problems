public class Solution {
    public int MaxRepeating(string sequence, string word) {
        string t = word;
        int len = 0;
        while(sequence.Contains(t)){
            len++;
            t += word;
        }        
        return len;
    }
}