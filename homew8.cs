using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> s = new List<Student>();
            Student s1 = new Student();
            s1.Fname = "Sonali";
            s1.Lname = "Patro";
            s1.Grade.Push('A');
            s1.Grade.Push('A');
            s1.Grade.Push('A');
            s1.Grade.Push('A');
            s1.Grade.Push('A');
            s.Add(s1);
            Student s2 = new Student();
            s2.Fname = "Karan";
            s2.Lname = "Vala";
            s2.Grade.Push('A');
            s2.Grade.Push('B');
            s2.Grade.Push('D');
            s2.Grade.Push('A');
            s2.Grade.Push('B');
            s.Add(s2);
            Student s3 = new Student();
            s3.Fname = "Sanchari";
            s3.Lname = "Dan";
            s3.Grade.Push('A');
            s3.Grade.Push('B');
            s3.Grade.Push('A');
            s3.Grade.Push('A');
            s3.Grade.Push('A');
            s.Add(s3);
            course c = new course();
            c.Name = "Programming with C#";
            c.S = s;
            c.ListStudent();
        }
    }
    class Student
    {
        private string fname, lname;
        private Stack<char> grade = new Stack<char>();

        public Stack<char> Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

    }

    class course
    {
        List<Student> s = new List<Student>();

        internal List<Student> S
        {
            get { return s; }
            set { s = value; }
        }

       
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public void ListStudent()
        {
            int i = 1;
            
            foreach (Student S in s)
            {
                Console.WriteLine("Details of Student {0}: \n", i);
                Console.WriteLine("Name : {0} {1}\n", S.Fname, S.Lname);
                Console.WriteLine("The grades are :{0} {1} {2} {3} {4} \n", S.Grade.Pop(), S.Grade.Pop(), S.Grade.Pop(), S.Grade.Pop(), S.Grade.Pop());
                i++;
            }
        }
    }
}

        