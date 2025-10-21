public static string countInstallationSequences(int n)
    {
            //     The pattern matches the Fibonacci Sequence
    //     Dictionary<int, BigInteger> memo = new();
    //     //to Overcome big integers
    //     BigInteger Dp(int k){
    //         if(k == 0 || k == 1) return 1;
    //         if(memo.ContainsKey(k)) return memo[k];
            
    //         BigInteger val = Dp(k-1) + Dp(k-2);
    //         memo[k] = val;
    //         return val;
    //     }
    //     return Dp(n).ToString();
    // }
        string addString(string a, string b){
            string result = "";
            int i=a.Length-1, j=b.Length-1, carry=0;
            
            while(i>=0 || j>=0 || carry > 0){    // Loop through the numbers, carry > 0 means last digit to add the carry value
                int x = (i>=0)? a[i] - '0':0; //incase carry > 0 but i = -1
                int y = (j>=0)? b[j] - '0':0; //incase carry > 0 but j = -1
                int sum = x + y + carry; // find sum individually rather than together to overcome big numbers
                result = (char)(sum % 10 + '0') + result;
                carry = sum/10;
                i--; j--;
            }
            return result;
        }
        
        
    if(n == 0 || n == 1) return "1";
    string prev1 = "1";
    string prev2 = "1";
    string curr = "";
    
    for(int i=2; i<=n; i++){    //Loop through n
        curr = addString(prev1, prev2);
        prev2 = prev1;
        prev1 = curr;
    }
    
    return curr;
    }

}