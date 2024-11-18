using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using y3s2_PROG_POE.Classes;

namespace y3s2_PROG_POE.Data
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        /// <summary>
        /// Default constructor for TreeNode
        /// </summary>
        /// <param name="value"></param>
        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;

        /// <summary>
        /// Insert a new value into the binary search tree
        /// </summary>
        /// <param name="value"></param>
        public void Insert(T value)
        {
            root = InsertRec(root, value);
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to insert a new value into the binary search tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private TreeNode<T> InsertRec(TreeNode<T> root, T value)
        {
            if (root == null)
            {
                root = new TreeNode<T>(value);
                return root;
            }

            if (value.CompareTo(root.Value) < 0)
            {
                root.Left = InsertRec(root.Left, value);
            }
            else if (value.CompareTo(root.Value) > 0)
            {
                root.Right = InsertRec(root.Right, value);
            }

            return root;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to search and retrieve a value in the binary search tree
        /// </summary>
        /// <returns></returns>
        public List<T> GetAllNodes()
        {
            var nodes = new List<T>();
            InOrderTraversal(root, nodes);
            return nodes;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to traverse the binary search tree in order
        /// </summary>
        /// <param name="node"></param>
        /// <param name="nodes"></param>
        private void InOrderTraversal(TreeNode<T> node, List<T> nodes)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, nodes);
                nodes.Add(node.Value);
                InOrderTraversal(node.Right, nodes);
            }
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
		/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/
