using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesNamesReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!Please enter path to folder");
            string sName = Console.ReadLine();
            Console.WriteLine("Your path to folder ," + sName);


            Console.ReadKey();
        }
    }
}
