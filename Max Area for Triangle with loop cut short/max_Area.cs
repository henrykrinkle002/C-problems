public class Solution {
    public double LargestTriangleArea(int[][] points) {
        double res = 0;
        // Area = 0.5​×∣x1(y2−y3)+x2(y3−y1)+x3(y1−y2)|
        for(var i=0; i<points.Length; i++){
            int x1 = points[i][0];
            int y1 = points[i][1];
            for(var j=i+1; j<points.Length; j++){ // doesn't have to loop entire array
                int x2 = points[j][0];
                int y2 = points[j][1];
                    for(var k=j+1; k<points.Length; k++){ // doesn't have to loop entire array
                        int x3 = points[k][0];
                        int y3 = points[k][1];
                        res = Math.Max(res, 0.5* Math.Abs(x1*(y2-y3) + x2*(y3-y1) + x3*(y1-y2)));
                }
            }
        }
        return res;
    }
}