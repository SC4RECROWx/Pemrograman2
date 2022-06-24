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
            Box box4 = new Box(6, 4, 8);

            //Modify attributes of the objects
            box1.panjang = 5;
            box1.lebar = 9;
            box1.tinggi = 10;

            box2.panjang = 4;
            box2.lebar = 11;
            box2.tinggi = 4;

            box3.panjang = 5;
            box3.lebar = 5;
            box3.tinggi = 5;

            //calculating box volume
            Console.WriteLine("Volume of Box1 : " + box1.getVolume());
            Console.WriteLine("Volume of Box2 : " + box2.getVolume());
            Console.WriteLine("Volume of Box3 : " + box3.getVolume());
            Console.WriteLine("Volume of Box4 : " + box4.getVolume());
        }
    }

    class Box
    {
        //Constructor example 1
        public Box()
        {
            Console.WriteLine("An Object of Box being created....");
        }

        //constructor example 2
        public Box(double panjang = 0, double lebar = 0, double tinggi = 0)
        {
            Console.WriteLine("An Object of box being created...");
            this.panjang = panjang;
            this.lebar = lebar;
            this.tinggi = tinggi;
        }

        public double panjang { get; set; }
        public double lebar { get; set; }
        public double tinggi { get; set; }

        public double getVolume()
        {
            return panjang * lebar * tinggi;
        }
    }
}
