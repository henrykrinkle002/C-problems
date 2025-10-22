public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = new List<IList<int>>();
        List<int> row = new List<int>();

        for(int i=0; i<numRows; i++){
            row.Insert(0, 1); //enter 1 at 0
            for(int j=1; j<row.Count - 1; j++){
                row[j] = row[j] + row[j+1];
            }
            triangle.Add(new List<int>(row)); //reference memory to new row
        }

        return triangle;
    }
}