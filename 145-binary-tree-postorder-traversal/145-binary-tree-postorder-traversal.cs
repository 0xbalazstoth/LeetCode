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
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> list = new List<int>();
        _PostorderTraversal(root, list);
        return list;
    }
    
    private void _PostorderTraversal(TreeNode node, IList<int> list)
    {
        if(node == null)
        {
            return;
        }
        _PostorderTraversal(node.left, list);
        _PostorderTraversal(node.right, list);
        list.Add(node.val);
    }
}