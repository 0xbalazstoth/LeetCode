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
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> list = new List<int>();
        _PreorderTraversal(root, list);
        return list;
    }
    
    private void _PreorderTraversal(TreeNode node, IList<int> list)
    {
        if(node == null)
        {
            return;
        }
        list.Add(node.val);
        _PreorderTraversal(node.left, list);
        _PreorderTraversal(node.right, list);
    }
}