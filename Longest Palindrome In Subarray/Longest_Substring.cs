public class Solution {
    public string LongestPalindrome(string s) {

        int start = 0, maxlen = 1;
        
        for(int i=0; i<s.Length; i++){
            ExpandCenter(s, i, i, ref start, ref maxlen);

            ExpandCenter(s, i, i+1, ref start, ref maxlen);
        }
    return s.Substring(start, maxlen);
    }


        private void ExpandCenter(string s, int left, int right, ref int start, ref int maxlen){
            while(left >= 0 && right < s.Length && s[left] == s[right]){
                left--;
                right++;
            }

            int len = right - left - 1;
            if(len > maxlen){
                start = left+1;
                maxlen = len;
            }
        }
}