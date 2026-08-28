var tree = new BST();

Console.Write("Enter number of values: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter value {i + 1}: ");
    int value = int.Parse(Console.ReadLine());
    tree.Insert(value);
}

Console.WriteLine("Inorder traversal:");
tree.InorderTraversal();

Console.Write("Enter a value to search: ");
int searchValue = int.Parse(Console.ReadLine());

Console.WriteLine($"Exists {searchValue}? " + tree.Search(searchValue));


class Node
{
    public int Value;
    public Node Left, Right;

    public Node(int value)
    {
        Value = value;
    }
}

class BST
{
    private Node root;

    public void Insert(int value)
    {
        root = InsertRec(root, value);
    }

    private Node InsertRec(Node node, int value)
    {
        if (node == null)
            return new Node(value);

        if (value < node.Value)
            node.Left = InsertRec(node.Left, value);
        else if (value > node.Value)
            node.Right = InsertRec(node.Right, value);

        return node;
    }

    public bool Search(int value)
    {
        return SearchRec(root, value);
    }

    private bool SearchRec(Node node, int value)
    {
        if (node == null)
            return false;

        if (node.Value == value)
            return true;

        return value < node.Value
            ? SearchRec(node.Left, value)
            : SearchRec(node.Right, value);
    }

    public void InorderTraversal()
    {
        InorderRec(root);
        Console.WriteLine();
    }

    private void InorderRec(Node node)
    {
        if (node != null)
        {
            InorderRec(node.Left);
            Console.Write(node.Value + " ");
            InorderRec(node.Right);
        }
    }
}