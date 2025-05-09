using System;

namespace bst_linkedlist.library.BST;

public class TreeInt
{
    public NodeInt Root { get; set; }
    public int Count => throw new NotImplementedException();
    public int Height => throw new NotImplementedException();

    public void Insert(int value)
    {
        throw new NotImplementedException();
    }

    public bool Contains(int value)
    {
        throw new NotImplementedException();
    }

    public int Remove(int value)
    {
        Root = Remove(Root, value);
        return value;
    }

    public NodeInt Find(int value)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    private NodeInt Remove(NodeInt root, int value)
    {
        if (root == null)
            return null;

        //First descend the tree to find the node with the specified value
        if (root.Value > value)
        {
            root.Left = Remove(root.Left, value);
            return root;
        }
        else if (root.Value < value)
        {
            root.Right = Remove(root.Right, value);
            return root;
        }

        //found the node with the requested value, let"s remove it
        if (root.Left == null) // max. 1 child
            return root.Right;
        if (root.Right == null) // max. 1 child
            return root.Left;

        var min = FindMinValue(root.Right);
        var newn = Remove(root, min);                //remove the original node
        root.Value = min;                       //take over the value
        return newn;
    }

    private int FindMinValue(NodeInt root)
    {
        if (root == null)
            return -1;
        if (root.Left != null)
            return FindMinValue(root.Left);
        return root.Value;
    }
}
