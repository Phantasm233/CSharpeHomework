using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入两个数字:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("两个数字之积为{0}", num1*num2);
            Console.ReadKey();
        }
    }
}
