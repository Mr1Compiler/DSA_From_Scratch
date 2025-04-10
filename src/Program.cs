using System;
using System.Runtime.InteropServices;
namespace NormalTree;

class Program
{
    static void Main()
    {
        Stack<int> st = new Stack<int>();

        st.CreateStack();

        st.AddElement(1);
        st.AddElement(2);
        st.AddElement(3);
        st.AddElement(4);

        st.PrintElements();
        Console.WriteLine("Size is : {0}", st.NumberOfElements()); 

        st.RemoveElement();
        st.PrintElements();
        Console.WriteLine("Size is : {0}", st.NumberOfElements()); 
    }
}
