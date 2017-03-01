using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
    }
    class Person
    {
        public string name;
        public int age;
        public string city;
        public string ans;
        public char grade;
        public Person() { }
        public Person(string name, int a, string c)
        {
            this.name = name;
            this.age = a;
            this.city = c;
        }
    }
    class Student : Person
    {
        public string name;
        public string school;
        public string subject;
        public Student(string n, string s, string sub) {
            this.name = n;
            this.school = s;
            this.subject = sub;
        }
       
        public void taketest(){
            Console.WriteLine("What is the capital of Doha?");
            ans = Console.ReadLine();
        }
    }
    class Teacher : Person
    {
        public string name;
        public int age;
        public void gradetest(string ans){
            if (ans == "Doha")
            {
                grade = 'A';
            }
        }
        public Teacher(string n, int a)
        {
            this.name = n;
            this.age = a;
        }
    }
    
}
