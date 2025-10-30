/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    TreeNode dummy = new TreeNode(); // 0 is a placeholder
    TreeNode curr; // Cursor

    public TreeNode IncreasingBST(TreeNode root) {
        if(root == null) return root;
        curr = dummy;// head -> cursor
        Inorder(root);
        return dummy.right; // right child of 0
    }

    private void Inorder(TreeNode root){
        if(root == null) return;

        Inorder(root.left);

        root.left = null;
        if(curr == null){
            curr = root;
        }
        else{
            curr.right = root;
        }
        curr = root;
        
        Inorder(root.right);

    }
}