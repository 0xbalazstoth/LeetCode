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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> list = new List<int>();
        _InorderTraversal(root, list);
        return list;
    }
    
    private void _InorderTraversal(TreeNode node, IList<int> list)
    {
        if(node == null)
        {
            return;
        }
        _InorderTraversal(node.left, list);
        list.Add(node.val);
        _InorderTraversal(node.right, list);
    }
}