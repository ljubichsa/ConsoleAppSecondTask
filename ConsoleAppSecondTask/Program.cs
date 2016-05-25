using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSecondTask
{
    class Program
    {
        static void GetNumbers(IEnumerable<int> collection, int number)
        {
            foreach (var item in collection.SelectMany(x => collection
                                                            .Where(y => x + y == number)
                                                            .Select(y => new { x = x, y = y })))
                Console.WriteLine(item);
        } 

        static void Main(string[] args)
        {
            GetNumbers(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, 6);
            GetNumbers(new List<int>() { -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 6);
            GetNumbers(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8 }, 6);
            Console.Read();
        }
    }
}
