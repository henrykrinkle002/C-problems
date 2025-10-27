public class Solution {
    public int SumOfLeftLeaves(TreeNode root) {
        return MoreLikeBFS(root, false); //default
    }

    private int MoreLikeBFS(TreeNode node, bool isLeft){
        if(node == null) return 0;

        if(node.left == null && node.right == null)
            return isLeft ? node.val : 0;

    return MoreLikeBFS(node.left, true) + MoreLikeBFS(node.right, false);
    }
}