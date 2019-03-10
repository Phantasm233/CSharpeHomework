using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ReaderFactory factory;  //抽象工厂
                PhotoReader reader;  //抽象产品
                factory = new GIF_ReaderFactory();
                reader = factory.Createreader();
                reader.Readphoto();
            }
            catch(Exception ex)
            {
                Console.WriteLine("无效的图片读取器！");
            }
            Console.ReadKey();
        }
    }

    //图片读取器：抽象产品
    interface PhotoReader
    {
        void Readphoto();
    }

    //图片读取器：具体产品
    class GIF_Reader:PhotoReader
    {
        public void Readphoto()
        {
            Console.WriteLine("读取GIF图片！");
        }
    }
    class JPG_Reader:PhotoReader
    {
        public void Readphoto()
        {
            Console.WriteLine("读取JPG图片！");
        }
    }
    class PNG_Reader : PhotoReader
    {
        public void Readphoto()
        {
            Console.WriteLine("读取PNG图片！");
        }
    }

    //图片读取器工厂接口：抽象工厂
    interface ReaderFactory
    {
        PhotoReader Createreader();
    }

    //图片读取器工厂类：具体工厂
    class GIF_ReaderFactory:ReaderFactory
    {
        public PhotoReader Createreader()
        {
            PhotoReader reader = new GIF_Reader();
            Console.WriteLine("创建GIF图片读取器！");
            return reader;
        }
    }
    class JPG_ReaderFactory : ReaderFactory
    {
        public PhotoReader Createreader()
        {
            PhotoReader reader = new JPG_Reader();
            Console.WriteLine("创建JPG图片读取器！");
            return reader;
        }
    }
    class PNG_ReaderFactory : ReaderFactory
    {
        public PhotoReader Createreader()
        {
            PhotoReader reader = new PNG_Reader();
            Console.WriteLine("创建PNG图片读取器！");
            return reader;
        }
    }
}
