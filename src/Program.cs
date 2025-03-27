namespace NormalTree;

class Program
{
    static int Main()
    {
        var family = new Tree<string>("Family");

        var father = new Node<string>("father");
        var son1 = new Node<string>("son1");
        var son2 = new Node<string>("son2");
        var son3 = new Node<string>("son3");

        var grandson1 = new Node<string>("grandson1");
        var grandson2 = new Node<string>("grandson2");
        var grandson3 = new Node<string>("grandson3");
        var grandson4 = new Node<string>("grandson4");
        var grandson5 = new Node<string>("grandson5");
        var grandson6 = new Node<string>("grandson6");


        family.Root.AddChild(father);
        father.AddChild(son1);
        father.AddChild(son2);
        father.AddChild(son3);

        son1.AddChild(grandson1);
        son1.AddChild(grandson2);


        son2.AddChild(grandson3);
        son2.AddChild(grandson4);


        son3.AddChild(grandson5);
        son3.AddChild(grandson6);

        Print.PrintTree(family.Root);

        return 0;
    }
}
