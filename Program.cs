using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace overloading
{
    public class Program
    {
        public int Add(int a)
        {
            return a + 10;
        }
        public int Add(out int a)
        {
            a = 30;
            return a + 3;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int[,] Add(int[,] a, int[,] b)
        {
            int[,] temp = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    temp[i, j] = a[i, j] + b[i, j];
            return temp;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 12;
            int[,] m1 = new int[,] { { 10, 20 }, { 30, 40 } };
            int[,] m2 = new int[,] { { 10, 20 }, { 30, 40 } };
            vector v1 = new vector();
            vector v2 = new vector();
            v1.x = 10;
            v1.y = 20;
            v1.z = 30;
            v2.x = 5;
            v2.y = 15;
            v2.z = 25;
            Program p1 = new Program();
            Console.WriteLine("Addition of simple two numbers"+p1.Add(a));
            Console.WriteLine("Addition using out object"+p1.Add(out a));
            Console.WriteLine("Addition of two numbers"+p1.Add(a, b));
            int[,] m3 = new int[2, 2];
            m3 = p1.Add(m1, m2);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine(m3[i, j] + " ");
            Console.ReadKey();
        }
    }
    public class vector
    {
        public int x;
        public int y;
        public int z;
    }
}
