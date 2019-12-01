using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleContainers;

namespace App
{
    class Program
    {
        static void PrintList<T>(List<T> current)
        {
            while (current != null)
            {
                Console.WriteLine(current.Item);
                current = current.Next;
            }
        }
        static void Main(string[] args)
        {
            var item1 = new List<int>(50);
            var item2  = item1.Append(60);
            var item3 = item2.Append(70);
            PrintList(item1);
            Console.ReadKey();
            Console.WriteLine("====================================");

            item1.Append(51);
            PrintList(item1);
            Console.ReadKey();

            Console.WriteLine("====================================");

            item1
                .Next
                .Next
                .Append(65)
                .Insert(63);


            PrintList(item1);
            Console.ReadKey();

            Console.WriteLine("====================================");

            item1 = item1.Insert(45);


            PrintList(item1);
            Console.ReadKey();

            Console.WriteLine("====================================");
            item3
                .Previous
                .Delete();

            item3.Delete();



            PrintList(item1);
            Console.ReadKey();

        }
    }
}
