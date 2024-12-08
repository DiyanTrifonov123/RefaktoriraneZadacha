using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefaktoriraneZadacha
{
    internal class Program
    {
        public static void Main()
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.Append(1);
            numbers.Append(2);
            numbers.Append(3);
            numbers.Append(4);
            numbers.Append(5);
            var evenNumbers = SplitList(numbers, "even");
            var oddNumbers = SplitList(numbers, "odd");
            Console.WriteLine("Списък с четни числа:");
            evenNumbers.PrintList();
            Console.WriteLine("Списък с нечетни числа:");
            oddNumbers.PrintList();
        }
    }
}
