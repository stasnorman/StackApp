using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LIFO
            Stack<string> students = new Stack<string>();
            students.Push("Иван");
            students.Push("Михаил");
            students.Push("Сергей");
            students.Push("Наталья");

            for (int i = 0;  students.Count > 0; i++)
            {
                Console.WriteLine(students.Pop()) ;
            }

            Console.WriteLine();

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }       

            Console.ReadKey();
        }                
    }                    
}
