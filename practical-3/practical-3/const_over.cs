using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_3
{
    class const_over
        {
            public int ID { get; set; }
            public string Name { get; set; }
            String name, branch;
            int enroll;
            const_over(String Stname)
            {
                name = Stname;
                Console.WriteLine("1st Constructor:");
                Console.WriteLine("Student Name is " + Stname);
            }
            const_over(String Stname, String Stbranch)
            {
                name = Stname;
                branch = Stbranch;
                Console.WriteLine("2nd Constructor:");
                Console.WriteLine(Stname + " is in " + Stbranch + " branch");
            }
            const_over(String Stname, String Stbranch, int Stenroll)
            {
                name = Stname;
                branch = Stbranch;
                enroll = Stenroll;
                Console.WriteLine("3rd Constructor:");
                Console.WriteLine(Stname + " is in " + Stbranch + " having " + Stenroll + " Enrollment ");
            }
            static void Main(string[] args)
            {
                const_over p = new const_over("john");
                const_over p1 = new const_over("john", "Computer");
               const_over p2 = new const_over("john", "Computer", 82);
                Console.ReadLine();


            }
        }
    }


