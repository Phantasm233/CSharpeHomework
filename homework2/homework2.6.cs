using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            string result;
            Console.Write("输入正整数：");
            input = int.Parse(Console.ReadLine());
            int i = 2;
            result = " ";
            for (; input >= 2;)
            {
                if (input % i == 0)
                {
                    result += i.ToString() + " ";
                    input = input / i;
                    i = 2;
                }
                else
                {
                    i++;
                }
            }
            Console.Write("该正整数所有的素数因子为:" + result);
            Console.ReadKey();
        }
    }
}
