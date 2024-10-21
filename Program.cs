namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();

            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(4);

            tree.PrintTreeInOrder(tree.Root);
        }
    }
}
