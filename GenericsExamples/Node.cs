using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{

    //To implement the public default constructor inside the generics, we need to use the New() constraint at the top
    class Node<K, T> where T : new()
    {
        public K Key;
        public T Item;
        public Node<K, T> NextNode;
        public Node()
        {
            Key = default(K);
            Item = new T();
            NextNode = null;
        }
    }
}
