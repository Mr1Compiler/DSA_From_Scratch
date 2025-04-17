using System;
using System.Runtime.InteropServices;
namespace NormalTree;

class Program
{
    static void Main()
    {
        Stack<int> st = new Stack<int>();

        st.Push(100); 
        st.Push(200); 
        st.Push(300);


        st.PrintElements();
		Console.WriteLine($"Top = {st.Top()}");
		Console.WriteLine($"Size => {st.Size()}");
        st.Pop();

        st.Pop();
        st.Pop();
       
        st.PrintElements();
		Console.WriteLine($"Size => {st.Size()}");
		Console.WriteLine($"Top = {st.Top()}");
    }
}
