using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtables using LinkedList");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "Be");
            hash.Add("2", "Or");
            hash.Add("3", "Not");
            hash.Add("4", "To");
            hash.Add("5", "Be");

            Console.WriteLine(hash.GetV("5"));
            Console.WriteLine(hash.GetV("0"));
        }
    }
}