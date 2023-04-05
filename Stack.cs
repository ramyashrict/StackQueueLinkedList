using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueLinkedList
{
     class Stack
    {
             public static void Main(string[] args)
            {
            Stack st = new Stack();
                st.Push(70);
                st.Push(30);
                st.Push(56);

                foreach (Object obj in st)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("The number of elements in the stack " + st.Count);
                Console.WriteLine("Does the stack contain the elements 3 " + st.Contains(3));
                Console.ReadKey();
            }
        }
    }


