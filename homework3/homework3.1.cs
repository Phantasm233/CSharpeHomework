using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape shape;
                shape = Factory.getShape("circle");
                shape.Draw();
                shape.Erase();
            }
            catch(Exception ex)
            {
                Console.WriteLine("绘制图形无法识别！");
            }
            Console.ReadKey();
        }
    }

    //公共接口
    interface Shape
    {
        void Draw();
        void Erase();
    }

    //实现公共接口的具体图形类
    class Circle : Shape
    {
        public Circle()
        {
            Console.WriteLine("创建圆！");
        }
        public void Draw()
        {
            Console.WriteLine("画圆！");
        }
        public void Erase()
        {
            Console.WriteLine("清除圆！");
        }
    }

    class Triangle : Shape
    {
        public Triangle()
        {
            Console.WriteLine("创建三角形！");
        }
        public void Draw()
        {
            Console.WriteLine("画三角形！");
        }
        public void Erase()
        {
            Console.WriteLine("清除三角形！");
        }
    }

    class Square : Shape
    {
        public Square()
        {
            Console.WriteLine("创建正方形！");
        }
        public void Draw()
        {
            Console.WriteLine("画正方形！");
        }
        public void Erase()
        {
            Console.WriteLine("清除正方形！");
        }
    }

    //工厂类
    class Factory
    {
        public static Shape getShape(string type)
        {
            Shape shape = null;
            if(type.Equals("circle"))
            {
                shape = new Circle();
                Console.WriteLine("初始化圆！");
            }
            else if(type.Equals("triangle"))
            {
                shape = new Triangle();
                Console.WriteLine("初始化三角形！");
            }
            else if(type.Equals("square"))
            {
                shape = new Square();
                Console.WriteLine("初始化正方形！");
            }
            else
            {
                Console.WriteLine("UnsupportedShapeException!");
            }
            return shape;
        }
    }
}
