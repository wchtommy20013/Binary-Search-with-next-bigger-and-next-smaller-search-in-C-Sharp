using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BinarySearch {
    class Test {
        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 6, 7, 8, 11, 12, 13, 13, 13, 14};
            int value = 13;
            int exact = BinarySearch.Exact(value, arr, arr.Length);
            int bigger = BinarySearch.NextBigger(value, arr, arr.Length);
            int smaller = BinarySearch.NextSmaller(value, arr, arr.Length);
            Console.Write("{");
            for(int i = 0; i < arr.Length - 1; i++) {
                Console.Write(" " + arr[i] + ",");
            }
            Console.WriteLine( " " + arr[arr.Length - 1] + " }");
            Console.WriteLine("Finding: " + value);
            Console.WriteLine("------------------------");
            Console.WriteLine("Exact position: " + (exact == -1 ? "Not found" : exact.ToString()));
            Console.WriteLine("Next Bigger Value: " + (bigger == -1 ? "Not found" : arr[bigger].ToString()));
            Console.WriteLine("Next Smaller Value: " + (smaller == -1 ? "Not found" : arr[smaller].ToString()));

            Console.ReadKey();
        }
    }
}
