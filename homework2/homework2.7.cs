using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min, avg, sum; //最大值、最小值、平均数、和
            int[] arr = new int[] { 0, 1, 2, 5, 7, 8, 11 };
            max = arr[0];  min = arr[0];
            sum = 0;
            Console.WriteLine("数组如下：");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
                if (i>max)
                {
                    max = i;
                }
                if(i<min)
                {
                    min = i;
                }
                sum += i;
            }
            avg = sum / (arr.Length);
            Console.Write("\n");
            Console.Write("数组的最大值、最小值、平均数、元素和分别为：" + max + "、" + min + "、" + avg + "、" + sum);
            Console.ReadKey();
        }
    }
}
