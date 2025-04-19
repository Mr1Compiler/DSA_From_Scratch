using System;
using System.Collections;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
namespace NormalTree;

class Program
{
	static void Main()
	{
		var binaryTree = new BinaryTree<int>();

		binaryTree.Insert(5);
		binaryTree.Insert(3);
		binaryTree.Insert(8);
		binaryTree.Insert(1);
		binaryTree.Insert(4);
		binaryTree.Insert(6);
		binaryTree.Insert(9);


		binaryTree.PrintTree();	
	}
}
