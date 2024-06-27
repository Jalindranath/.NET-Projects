using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_List
{
    class Node
    {
        
        int data;
        Node next;
        
        Node(int data)
        {
            this.data = data;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node(10);
            n.next = 20;

        }
    }
}
