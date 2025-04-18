using System.Collections;
using System.Runtime.CompilerServices;

public class Stack<T> : IEnumerable<T>
{
	private List<T> Elements { get; set; } = new();

	public void Push(T element) => Elements.Add(element);

	public void Pop()
	{
		if (Size() > 0)
		{
			Elements.RemoveAt(Size() - 1);
		}
	}

	public int Size() => Elements.Count;

	public T Top() => Elements[^1]; // Elements[Size() - 1]

	public IEnumerator<T> GetEnumerator()
	{
		foreach (T item in Elements)
			yield return item;
	}

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}