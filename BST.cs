namespace Assignment_7._3
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Left = null;
            Right = null;
            Value = value;
        }
    }

    public class BST
    {
        public Node Root { get; set; }

        public BST()
        {
            Root = null;
        }

        public void Add(int value)
        {
            Node tempRoot = Root;
            Node newNode = new(value);

            if (Root != null)
            {
                while (tempRoot != null)
                {
                    if (newNode.Value == tempRoot.Value)
                    {
                        Console.WriteLine($"Value ({value}) already exists in the tree.\n");
                        return;
                    }

                    if (newNode.Value > tempRoot.Value)
                    {
                        if (tempRoot.Right == null)
                        {
                            tempRoot.Right = newNode;
                            return;
                        }
                        else tempRoot = tempRoot.Right;

                    }
                    else
                    {
                        if (tempRoot.Left == null)
                        {
                            tempRoot.Left = newNode;
                            return;
                        }
                        else tempRoot = tempRoot.Left;
                    }
                }
            }
            else Root = newNode;
        }

        public void InOrderTraversal(Node tempRoot)
        {
            if (tempRoot != null)
            {
                InOrderTraversal(tempRoot.Left);
                Console.Write(tempRoot.Value + " ");
                InOrderTraversal(tempRoot.Right);
            }
        }

        public bool Search(int value, out Node result)
        {
            Node tempNode = Root;

            while (tempNode != null)
            {
                // if found, return true and resulting Node
                if (tempNode.Value == value)
                {
                    result = tempNode;
                    Console.WriteLine($"Value ({value}) found!");
                    return true;
                }
                
                // if not found, traverse tree
                if (value < tempNode.Value)
                {
                    tempNode = tempNode.Left; 
                }
                else
                {
                    tempNode = tempNode.Right;
                }
            }
            
            // if not found in entire tree, return false and return null
            result = null;
            Console.WriteLine($"Value ({value}) not found.");
            return false;
        }
    }
}
