public class Stack<T>
{
	public List<T> Elements { get; set; } = new List<T>();

	public void Push(T element) => Elements.Add(element);

	public void Pop()
	{
		if (Size() > 0)
		{
			Elements.RemoveAt(Size() - 1);
		}
	}

	public void PrintElements()
	{
		foreach (T element in Elements)
		{
			Console.WriteLine($"{element}");
		}
	}

	public int Size() => Elements.Count;

	public T Top() => Elements[^1]; // Elements[Size() - 1]
}