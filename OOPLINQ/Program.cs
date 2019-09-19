using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join(", ", Enumerable.Range(10, 41)));
            //Console.WriteLine(string.Join(", ", Enumerable.Range(10, 41).Where((i) => i % 3 == 0)));
            //Console.WriteLine(string.Concat(Enumerable.Repeat("LINQ", 10)));
            //Console.WriteLine(string.Join(", ", "aaa;abb;ccc;dap".Split(';').Where(str => str.Contains('a'))));
            //Console.WriteLine(string.Join(", ", "aaa;abb;ccc;dap".Split(';').Where(str => str.Contains('a')).Select(str => str.Count(letter => letter == 'a'))));
            //Console.WriteLine(string.Join(", ", "aaa;xabbx;abb;ccc;dap".Split(';').Select(str => str.Contains("abb"))));
            Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Max());



            Console.ReadKey();
        }
    }
}
