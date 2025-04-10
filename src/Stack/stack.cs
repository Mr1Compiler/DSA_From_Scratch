public class Stack<T>
{
    public List<T> Elements { get; set; }

    public void CreateStack()
    {
        if (Elements == null)
            Elements = new List<T>();
    }
    public void AddElement(T element) => Elements.Add(element);

    public void RemoveElement() => Elements.RemoveAt(Elements.Count - 1);

    public void PrintElements()
    {
        foreach (T element in Elements)
        {
            Console.WriteLine($"{element}");
        }
    }

    public int NumberOfElements()
    {
        return Elements.Count;
    }
}