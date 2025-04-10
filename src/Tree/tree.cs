namespace NormalTree;

public class Node<T>
{
    public T Value { get; set; } // Value
    public List<Node<T>> Children { get; set; } // Node Children

    public Node(T val)
    {
        this.Value = val;
        Children = new List<Node<T>>();
    }

    public void AddChild(Node<T> child)
    {
        Children.Add(child);
    }
}

public class Tree<T>
{
    public Node<T> Root { get; private set; }

    // That gonna be soo good 
    public Tree(T rootValue)
    {
        Root = new Node<T>(rootValue); // Assinging value to the root node
    }
}

abstract class Operations 
{
    public static void PrintTree<T>(Node<T> node, string indent = "  ")
    {
        //Priting the Node value
        Console.WriteLine(indent + node.Value);

        //Printing the Children of Node 
        foreach (var child in node.Children)
        {
            PrintTree(child, indent + "  ");
        }
    }
}
