public static long getAutoSaveInterval(int n)
    {
            var memo = new Dictionary<int, long>();
            long Backtracking(int k){
                 if (k == 0) return 1;
                 if (k == 1) return 2;
                if (memo.ContainsKey(k)) return memo[k];

                long val = Backtracking(k - 1) + Backtracking(k - 2);
                memo[k] = val;
                return val;
            }
            return Backtracking(n);
    }