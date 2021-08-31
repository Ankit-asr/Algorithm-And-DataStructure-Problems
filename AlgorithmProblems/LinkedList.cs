using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    public class LinkedList<T> where T : IComparable
    {
        public NodeList<T> head;
        /// <summary>
        /// Add data to list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            NodeList<T> node = new NodeList<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                NodeList<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;

            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        /// <summary>
        /// Sort list in ascending order
        /// </summary>
        public void SortOrderList()
        {
            NodeList<T> current = head, index = null;
            T temp;
            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.next;
                    while (index != null)
                    {
                        if (current.data.CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
        /// <summary>
        /// Display list 
        /// </summary>
        public void Display()
        {
            NodeList<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        /// <summary>
        /// Concatinate all list items to string and return string
        /// </summary>
        /// <returns></returns>
        public string ReturnString()
        {
            NodeList<T> temp = this.head;
            string fileWriteData = "";
            bool checkFirst = true;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            while (temp != null)
            {
                if (checkFirst)
                {
                    fileWriteData += temp.data;
                    checkFirst = false;
                }
                else
                    fileWriteData += "," + temp.data.ToString();
                temp = temp.next;
            }
            return fileWriteData;
        }
        /// <summary>
        /// search specific value in list if found return true 1 else return 0
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int search(T value)
        {
            Console.WriteLine("value :" + value);
            NodeList<T> node = this.head;
            while (node != null)
            {
                if (node.data.CompareTo(value) == 0)
                {
                    return 1;
                }
                node = node.next;
            }
            return 0;
        }
        /// <summary>
        /// Find specific number and delete from list
        /// </summary>
        /// <param name="searchData"></param>
        /// <returns></returns>
        public bool SearchAndDelete(T searchData)
        {
            NodeList<T> previous = this.head;
            if (previous == null)
            {
                return false;
            }
            if (previous.data.CompareTo(searchData) == 0)
            {
                this.head = this.head.next;
                return true;
            }
            NodeList<T> tempNode = this.head.next;

            while (tempNode != null)
            {
                if (tempNode.data.CompareTo(searchData) == 0)
                {
                    previous.next = tempNode.next;
                    return true;
                }
                previous = tempNode;
                tempNode = tempNode.next;
            }
            return false;
        }
        /// <summary>
        /// return size of list
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            NodeList<T> node = this.head;
            int count = 0;
            if (node == null)
                return count;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            return count;
        }
    }
}
