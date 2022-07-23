using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datacollect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> employee = new List<Person>();

            employee.Add(new Person("Clark", 25));
            employee.Add(new Person("Bruce", 28));

            foreach(var emp in employee)
            {
                Console.WriteLine(emp.nama + "," + emp.usia);
            }
        }
    }
    class Person
    {
        public string nama;
        public int usia;

        public Person(string nama, int usia)
        {
            this.nama = nama;
            this.usia = usia;
        }
    }
}
