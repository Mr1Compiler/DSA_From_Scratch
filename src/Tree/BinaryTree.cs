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
	public BinaryTreeNode<T> Root { get; set; }

	public BinaryTree(T value) => Root = new BinaryTreeNode<T>(value);

	public void Insert(T value)
	{
		

	}
}

