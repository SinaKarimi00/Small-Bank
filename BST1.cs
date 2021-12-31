// using System;

// namespace p
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }

//}

// C# program to insert element in binary tree
using System;
using System.Collections.Generic;


namespace Small_Bank
{
class BST {

	/* A binary tree node has key, pointer to
	left child and a pointer to right child */
	public class Node {
		public int key;
		public string name;
		public Node left, right;

		// constructor
		public Node(int key, string name)
		{
			this.key = key;
			this.name = name;
			left = null;
			right = null;
		}
	}

	public static Node root;

	/* Inorder traversal of a binary tree*/
	public static void inorder(Node temp)
	{
		if (temp == null)
			return;

		inorder(temp.left);
		Console.Write(temp.key + " " + "And " + temp.name);
		inorder(temp.right);
	}

	/*function to insert element in binary tree */
	public static void insert(Node temp, int key, string name)
	{
		if (temp == null) {
			root = new Node(key, name);
			return;
		}
		Queue<Node> q = new Queue<Node>();
		q.Enqueue(temp);

		// Do level order traversal until we find
		// an empty place.
		while (q.Count != 0) {
			temp = q.Peek();
			q.Dequeue();

			if (temp.left == null) {
				temp.left = new Node(key, name);
				break;
			}
			else
				q.Enqueue(temp.left);

			if (temp.right == null) {
				temp.right = new Node(key, name);
				break;
			}
			else
				q.Enqueue(temp.right);
		}
	}


    public static bool ifNodeExists( Node node, int key, string name)
    {
        if (node == null)
            return false;
    
        if (node.key == key && node.name == name)return true;
    
        // then recur on left subtree /
        bool res1 = ifNodeExists(node.left, key, name);
    
        // node found, no need to look further
        if(res1)
            return true;
    
        // node is not found in left,
        // so recur on right subtree /
        bool res2 = ifNodeExists(node.right, key, name);
    
        return res2;
    }


    public static void deleteKey(int key, string name) { root = deleteRec(root, key, name); }
 
    /* A recursive function to
      delete an existing key in BST
     */
    public static Node deleteRec(Node root, int key, string name)
    {
        /* Base Case: If the tree is empty */
        if (root == null)
            return root;
 
        /* Otherwise, recur down the tree */
        if (key < root.key)
            root.left = deleteRec(root.left, key, name);
        else if (key > root.key)
            root.right = deleteRec(root.right, key, name);
 
        // if key is same as root's key, then This is the
        // node to be deleted
        else {
            // node with only one child or no child
            if (root.left == null)
                return root.right;
            else if (root.right == null)
                return root.left;
 
            // node with two children: Get the
            // inorder successor (smallest
            // in the right subtree)
            root.key = minValue(root.right);
 
            // Delete the inorder successor
            root.right = deleteRec(root.right, root.key, root.name);
        }
        return root;
    }
 
    public static int minValue(Node root)
    {
        int minv = root.key;
        while (root.left != null) {
            minv = root.left.key;
            root = root.left;
        }
        return minv;
    }

	// Driver code
	// public static void Main(String[] args)
	// {
	// 	// root = new Node(10);
	// 	// root.left = new Node(11);
	// 	// root.left.left = new Node(7);
	// 	// root.right = new Node(9);
	// 	// root.right.left = new Node(15);
	// 	// root.right.right = new Node(8);

	// 	// Console.Write(
	// 	// 	"Inorder traversal before insertion:");
	// 	// inorder(root);
    //     int x = 4;
    //     int key = 12;
    //     while(x > 0)
    //     {
    //         key++;
    //         insert(root, key);
    //         x--;
    //     }


	// 	Console.Write(
	// 		"\nInorder traversal after insertion:");
	// 	inorder(root);

    //     // if (BinarySearchTree.Search(root,1).key != 1)
    //     // {
    //     //     Node findNode = BinarySearchTree.Search(root,1);
    //     //     Console.WriteLine(findNode.key);

    //     // }

    //     if (ifNodeExists(root, 12))
    //         Console.WriteLine("YES");
    //     else
    //         Console.WriteLine("NO");

	// }
}
}
// This code is contributed by Rajput-Ji

