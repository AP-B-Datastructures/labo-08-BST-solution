using System;

namespace bst_linkedlist.library.BST;


    public class NodeInt
    {
        public NodeInt(int value)
        {
            Value = value;
        }

        public int Value { get; set; }

        public NodeInt Left { get; set; }
        public NodeInt Right { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }