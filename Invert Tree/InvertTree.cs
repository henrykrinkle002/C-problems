public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return root;
        var q = new Queue<TreeNode>();

        q.Enqueue(root);
        
        while(q.Count > 0){
            TreeNode node = q.Dequeue();
            //Swap
            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;
            //print the root not just the vals in this case
            if(node.left != null) q.Enqueue(node.left);
            if(node.right != null) q.Enqueue(node.right);
        }
        return root;
    }