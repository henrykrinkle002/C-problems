public class Solution {
    public string MinWindow(string s, string t) {
        //lookup dictionary
        Span<int> need = stackalloc int[128];
        int left = 0, totalchars=0, minlen=int.MaxValue, start=0;
        for(int i=0; i<t.Length; i++)
            if(need[t[i] - 'A']++ == 0)
                totalchars++;
        
        for(int right=0; right<s.Length; right++){
            if(--need[s[right] - 'A'] == 0)
                totalchars--;
            
            while(totalchars == 0){
                if((right - left + 1) < minlen){
                    minlen = (right - left + 1);
                    start = left;
                }

                if(need[s[left] - 'A']++ == 0) totalchars++;
                left++;
            }

        }
        return minlen == int.MaxValue? string.Empty : s.Substring(start, minlen);
    }
}