using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create an object from class 'Box' ");
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();

            //Modify attributes of the objects
            box1.setPanjang(5);
            box1.setLebar(9);
            box1.setTinggi(10);

            box2.setPanjang(4);
            box2.setLebar(11);
            box2.setTinggi(4);

            box3.setPanjang(5);
            box3.setLebar(5);
            box3.setTinggi(5);

            //calculating box volume
            Console.WriteLine("Volume of Box1 : " + box1.getVolume());
            Console.WriteLine("Volume of Box2 : " + box2.getVolume());
            Console.WriteLine("Volume of Box3 : " + box3.getVolume());
        }
    }

    class Box
    {
        private double panjang;
        private double lebar;
        private double tinggi;

        public void setPanjang(double n)
        {
            panjang = n;
        }
        public void setLebar(double n)
        {
            lebar = n;
        }
        public void setTinggi(double n)
        {
            tinggi = n;
        }
        public double getVolume()
        {
            return panjang * lebar * tinggi;
        }
    }
}
