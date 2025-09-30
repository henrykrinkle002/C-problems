public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        int m=matrix.Length, n=matrix[0].Length;
        int cleft=0, cright=n-1, rtop=0, rbottom=m-1;
        var res = new List<int>();
        var direction = "top";
        var next_Direction = new Dictionary<string, string>{
            {"top", "right"},
            {"right", "bottom"},
            {"bottom", "left"},
            {"left", "top"}
        };

        while(res.Count != m*n){
            if(direction=="top"){
                for(int j=cleft; j<=cright; j++)
                    res.Add(matrix[rtop][j]);
                rtop++;    
            }
            else if(direction=="right"){
                for(int i=rtop; i<=rbottom; i++)
                    res.Add(matrix[i][cright]);
                cright--;    
            }  
            else if(direction=="bottom"){
                for(int j=cright; j>=cleft; j--)
                    res.Add(matrix[rbottom][j]);
                rbottom--;
            } 
            else if(direction=="left"){
                for(int i=rbottom; i>=rtop; i--)
                    res.Add(matrix[i][cleft]);
            cleft++;
            }

        direction = next_Direction[direction]; 
        }
        return res;
    }
}