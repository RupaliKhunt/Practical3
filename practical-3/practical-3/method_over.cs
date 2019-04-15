using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_3
{
    class method_over
    {
        public void add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Addition is:{0}", sum);
        }
        public void add()
        {
            int i, j, n;
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];
            int[,] crr1 = new int[50, 50];
            Console.Write("Input the size of the square matrix: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0},{1}:", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Input elements in the Second matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0},{1}:", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe First matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\nThe Second matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", brr1[i, j]);
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    crr1[i, j] = arr1[i, j] + brr1[i, j];
                }
            }
            Console.Write("\nAddition of Two Matrix:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", crr1[i, j]);
                }
            }
        }
        public void add(Vector a, Vector b)
        {
           
            Vector result=new Vector();
            result.x = a.x + b.x;
            result.y = a.y + b.y;
            result.z = a.z + b.z;
            Console.WriteLine("Addition of Two vectors is:");
            Console.WriteLine("<" + result.x + "," + result.y + "," + result.z + ">");

        }
    static void Main(string[] args)
    {
        method_over p = new method_over();
        Console.WriteLine("Value of a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Value of b:");
        int b = Convert.ToInt32(Console.ReadLine());
        p.add(a, b);
        p.add();
        Vector v1 = new Vector();
        Vector v2 = new Vector();
           // float x, y, z;
        Console.WriteLine("Enter 1st vector");
        Console.WriteLine("X:", v1.x);
       v1.x=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Y:", v1.y);
           v1.y= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Z:", v1.z);
          v1.z=  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd vector");
            Console.WriteLine("X:", v2.x);
            v2.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y:", v2.y);
            v2.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Z:", v2.z);
            v2.z = Convert.ToInt32(Console.ReadLine());
            p.add(v1, v2);

            Console.ReadLine();
    }
}

 
    public class Vector
        {
                  public float x, y,z;
                
        }
}

 
