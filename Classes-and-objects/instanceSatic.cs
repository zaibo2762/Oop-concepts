using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects
{
    internal class instanceSatic
    {

        public int rollno;
        public string firstname;
        public string lastname;
        public int age;
        public static string schoolname = "ABC School";

        public static int fees = 4000;
        public static int getfees()
        {
            return fees;
        } public static int getfeesAnualincre()
        {
            return fees / 10;
        }
        public void printfulname()
        {
            string fullname = this.firstname + " " + this.lastname;
            Console.WriteLine("your full name is : {0}", fullname); 

        }
    }
}
