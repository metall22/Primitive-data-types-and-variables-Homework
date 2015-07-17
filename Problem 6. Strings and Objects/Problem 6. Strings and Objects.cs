using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";
            string word2 = "World";
            object word3 = word + " " + word2;
            string result = (string)word3;
            Console.WriteLine(result);
        }
    }
}
