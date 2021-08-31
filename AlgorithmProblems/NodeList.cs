using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    public class NodeList<T>
    {
        public T data;
        public NodeList<T> next;
        public NodeList(T data)
        {
            this.data = data;
        }
    }
}
