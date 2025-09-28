public class Solution {
    public IList<IList<int>> Combine(int n, int k)
{
    var res = new List<IList<int>>();
    var tempRes = new List<int>();

    void Backtrack(int start)
{
    if (tempRes.Count == k)
    {
        res.Add(tempRes.ToArray());
        return;
    }

    var required = k - tempRes.Count;
    var left = n - start + 1;

    if (left < required)
        return;

    Backtrack(start + 1);

    tempRes.Add(start);
    Backtrack(start + 1);
    tempRes.RemoveAt(tempRes.Count - 1);
    }

    Backtrack(1);
    return res;
}
}