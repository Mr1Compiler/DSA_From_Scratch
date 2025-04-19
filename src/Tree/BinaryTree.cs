using System.ComponentModel.Design;

namespace NormalTree;

public class BinaryTreeNode<T>
{
	public T Value { get; set; }
	public BinaryTreeNode<T>? Left { get; set; } = null;
	public BinaryTreeNode<T>? Right { get; set; } = null;

	public BinaryTreeNode(T value) => Value = value;
}

public class BinaryTree<T>
{
	public BinaryTreeNode<T>? Root { get; set; }
	public BinaryTree() => Root = null;

	public void Insert(T value)
	{
		var newNode = new BinaryTreeNode<T>(value);

		if (Root == null)
		{
			Root = newNode;
			return;
		}

		Queue<BinaryTreeNode<T>> queue = new();
		queue.Enqueue(Root); // Queuse contains Root 

		while (queue.Count > 0)
		{
			var current = queue.Dequeue(); // Root 

			if (current.Left == null)
			{
				current.Left = newNode;
				break;
			}
			else
			{
				queue.Enqueue(current.Left);
			}

			if (current.Right == null)
			{
				current.Right = newNode;
				break;
			}
			else
			{
				queue.Enqueue(current.Right);
			}
		}
	}

	public void PrintTree()
	{
		PrintTree(Root, 0);
	}

	private void PrintTree(BinaryTreeNode<T> root, int space)
	{
		int COUNT = 10;  // Distance between levels to adjust the visual representation
		if (root == null)
			return;


		space += COUNT;
		PrintTree(root.Right, space); // Print right subtree first, then root, and left subtree last


		Console.WriteLine();
		for (int i = COUNT; i < space; i++)
			Console.Write(" ");
		Console.WriteLine(root.Value); // Print the current node after space


		PrintTree(root.Left, space); // Recur on the left child
	}
}

