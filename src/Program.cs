using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Xml.Linq;
namespace NormalTree;

class Program
{
	static void Main()
	{
		Stack<int> s = new Stack<int>();
		s.Push(12);
		s.Push(14);
		s.Push(16);


		foreach(var item in s)
		{
			Console.WriteLine(item);
		}
	}
}
