using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[101];
            int i = 2;
            for(;i<=100;i++)
            {
                if(arr[i]==0)
                {
                    for (int j = 2; j <= 100; j++)
                    {
                        if ((j % i == 0)&&(j!=i))
                        {
                            arr[j] = 1;
                        }
                    }
                }
            }
            Console.WriteLine("2~100之间所有的素数如下：");
            for(i=2;i<=100;i++)
            {
                if(arr[i]==0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
