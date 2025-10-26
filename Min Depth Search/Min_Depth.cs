public class Solution {
    public int MinDepth(TreeNode root) {

       if(root == null) return 0; 
       var q = new Queue<(TreeNode, int)>();

       q.Enqueue((root, 1));
       int maxheight = 0;

       while(q.Count > 0){

        var (node, depth) = q.Dequeue();

        maxheight = Math.Max(maxheight, depth);
        
        if(node.left == null && node.right == null) return depth; //return height at this point

        if(node.left != null) 
            q.Enqueue((node.left, depth+1));

        if(node.right != null)
            q.Enqueue((node.right, depth+1));
       }

       return 0;
    }