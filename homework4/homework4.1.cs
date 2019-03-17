using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();
            //注册事件
            clock.Endclock += ShowEnd;
            clock.DoClock();

            Console.ReadKey();
        }

        static void ShowEnd(object sender,ClockEventArgs e)
        {
            Console.WriteLine("计时结束！共计" + e.time + "秒！");
        }
    }
    //声明参数类型
     public class ClockEventArgs:EventArgs
    {
        public int time;  //计时时间
    }
    //声明委托类型
    public delegate void ClockEventHandler(object sender, ClockEventArgs e);
    //定义事件源
    public class Clock
    {
        //声明闹钟事件
        public event ClockEventHandler Endclock;

        public void DoClock()
        {
            Console.WriteLine("请输入计时时间（秒数）：");
            int counttime = int.Parse(Console.ReadLine());
            Console.WriteLine("正在计时中……");
            for(int i=0;i<counttime;i++)
            {
                System.Threading.Thread.Sleep(1000);
            }
            if(Endclock!=null)
            {
                ClockEventArgs args = new ClockEventArgs();
                args.time = counttime;
                Endclock(this, args);
            }
        }
    }
}
