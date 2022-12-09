using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  20. Задан одномерный массив А[1..15]. Определить сумму 
    четных положительных элементов массива с n-го по k-й. */

namespace Lab_4_1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int k = 14;

            int[] arr = new int[15];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");

            // Linq
            var result = arr.Where((x, i) => x > 0 && x % 2 == 0 && i >= n && i <= k).Sum();
            Console.WriteLine(result);

            // Классический способ
            int sum = 0;
            for (int i = n; i <= k; i++)            
                if (arr[i] > 0 && arr[i] % 2 == 0)
                    sum += arr[i];
            Console.WriteLine(sum);                
            
            Console.ReadLine();
        }
    }
}
