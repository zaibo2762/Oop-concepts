using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects
{
    internal class employee
    {
        //int empid;
        //string empname;
        //int empage;
        ////Constructor
        //public employee(int empid,string empname,int empage) {
        //    this.empid = empid;
        //    this.empname = empname;
        //    this.empage = empage;

        //}
        ////public constructor() {
        ////    Console.WriteLine("Constructor invokes!");
        ////}
        //public int getid()
        //{

        //    return empid;
        //}
        //public string getidname()
        //{

        //    return empname;
        //}
        //public int getage()
        //{
        //    return empage;
        //}


        //contructor overloading
        //public employee() {
        //    Console.WriteLine("This is First Constructor!!");
        //}
        //public employee(int a, int b)
        //{
        //    Console.WriteLine("This is Second Constructor!!  {0}",(a+b));
        //}
        //public employee(int a, int b,int c)
        //{
        //    Console.WriteLine("This is Third Constructor!!  {0}", (a + b + c));
        //}

        ////Static Constructor

        //public static string personName;

        //public static int personAge;
        //static employee()
        //{
        //    personName = "Ali";
        //    personAge = 10;
        //    Console.WriteLine("Static Constructor Invoked !!!");
        //}
        //public employee()
        //{
        //    Console.WriteLine("Default Contructor Invoked!!");
        //}
        //public void getDetails()
        //{
        //    Console.WriteLine("Person Name is : {0}", personName);
        //    Console.WriteLine("PErson age is : {0}", personAge);
        //}

        //Copy Constructor

        //string name;
        //int age;
        //public employee(string name,int age) { 
        //this.name = name;
        //    this.age = age;
        //}
        //public employee(employee e) { //copy contructor
        //    this.name=e.name;
        //    this.age = e.age;
        //}
        //public void getData()
        //{
        //    Console.WriteLine("Name is : {0}",name);
        //    Console.WriteLine("Age is : {0}",age);
        //}

        //Private Contructor

        private employee()
        {

        }
        public static void gettime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
