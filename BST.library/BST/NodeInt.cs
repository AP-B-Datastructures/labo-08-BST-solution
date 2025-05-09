using System;

namespace bst_linkedlist.library.BST;

public class NodeInt
{
    public int Value { get; set; }

    public NodeInt(int value)
    {
        this.Value = value;
    }

    public NodeInt Left { get; set; }
    public NodeInt Right { get; set; }
    public override string ToString()
    {
        return this.Value.ToString();
    }
}
