using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class Stack<T> where T : IComparable
    {

        public Node<T> head;
        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = this.head;
                head = node;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted", node.data);
        }
        public void Pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} Pop", head.data);
            this.head = this.head.next;
        }
        public void Peek()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Peek element is :" + this.head.data);
            }
        }

        public bool IsEmpty()
        {
            if (this.head == null)
                return true;
            else
                return false;
        }
        public void ShowStack()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}