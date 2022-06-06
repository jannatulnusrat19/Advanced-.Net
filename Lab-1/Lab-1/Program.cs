using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        class student
        {
            public int id { get; set; }
            public string name { get; set; }
            public DateTime dob { get; set; }
            public double cgpa { get; set; }
           
            public void ShowInfo()
            {
                Console.WriteLine("Name:"+name);
                Console.WriteLine("ID:" + id);
                Console.WriteLine("DOB:" + dob);
                Console.WriteLine("CGPA:" + cgpa);
            }
        }
        static void Main(string[] args)
        {
            //int[] nums = new int[5] { 10, 12, 50, 60, 70 };
            // var filter=(from n in nums where n>40 select n).ToArray();
            //Console.WriteLine(filter);
            student s1 = new student();
            s1.id = 1;
            s1.name = "Turna";
            s1.dob = DateTime.Parse("01-04-2000");
            s1.cgpa = 2.5;

            student s2 = new student();
            s2.id = 2;
            s2.name = "Nusrat";
            s2.dob = DateTime.Parse("01-04-2000");
            s2.cgpa = 2.9;

            student s3 = new student();
            s3.id = 3;
            s3.name = "Jannat";
            s3.dob = DateTime.Parse("01-04-2000");
            s3.cgpa = 3.4;

            student s4 = new student();
            s4.id = 4;
            s4.name = "Nahid";
            s4.dob = DateTime.Parse("01-04-2000");
            s4.cgpa = 3.7;

            student s5 = new student();
            s5.id = 5;
            s5.name = "";
            s5.dob = DateTime.Parse("01-04-2000");
            s5.cgpa = 3.9;
            List<student> students = new List<student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            Console.WriteLine("Task-01");
            var A= (from n in students where n.cgpa>3 select n).ToList();
            foreach (var i in A)
            {
                i.ShowInfo();

            }
            Console.WriteLine("Task-02");
            var B = (from n in students where n.cgpa > 2.5 && n.id > 3  select n).ToArray();
            foreach (var i in B)
            {
                i.ShowInfo();
           }

            Console.WriteLine("Task-03");
            var C = (from n in students where (DateTime.Today.Year - n.dob.Year) > 18  select n).ToArray();
            foreach (var i in B)
            {
                i.ShowInfo();
            }
            Console.WriteLine("Task-04");
            var D = (from n in students select new {id=n.id, cgpa=n.cgpa}).ToArray();
            foreach (var i in D)
            {
                Console.WriteLine(i.id);
                Console.WriteLine((i.cgpa));
                Console.WriteLine();

            }




        }
        
    }
}
