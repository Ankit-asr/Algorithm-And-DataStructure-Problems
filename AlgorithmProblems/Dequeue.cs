using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    public class Dequeue<T> where T : IComparable
    {
        Node<T> head;

        public void AddFront(T item)
        {
            Node<T> node = new Node<T>(item);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = this.head;
                this.head = node;
                node.next = temp;
            }
        }
        public void AddRare(T item)
        {
            Node<T> node = new Node<T>(item);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public T RemoveFront()
        {
            if (this.head == null)
            {
                return default(T);
            }
            Node<T> temp = this.head;
            this.head = temp.next;
            return temp.data;
        }
        public T RemoveRear()
        {
            T tempData;
            if (this.head == null)
            {
                return default(T);
            }
            if (this.head.next == null)
            {
                tempData = this.head.data;
                this.head = null;
                return tempData;
            }
            Node<T> temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            tempData = temp.next.data;
            temp.next = null;
            return tempData;
        }
        public void Display()
        {
            if (this.head == null)
            {
                Console.WriteLine("Dequeue is empty");
            }
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine(this.head.data);
                    this.head = this.head.next;
                }
            }
        }
        public bool IsEmpty()
        {
            if (this.head == null)
                return true;
            else
                return false;
        }
        public int Size()
        {
            int count = 0;
            if (this.head == null)
                return 0;
            while (this.head != null)
            {
                count++;
                this.head = this.head.next;
            }
            return count;
        }
    }
}
