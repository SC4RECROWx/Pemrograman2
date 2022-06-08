using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20212205078_Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var adalah sebuah variabel yang menyesuaikan isi variabel
            //jika var berisi string maka akan menjadi string dan jika di isi int akan jadi int
            //writeline dan write berbeda jika write tidak akan baris baru
            //sedangkan writeline akan membuat baris baru setelah output
            var nama = "akbar";
            var umur = 21;
            float nomor = 2.2F;
            Console.WriteLine(nama);
            Console.WriteLine(umur);
            Console.WriteLine(nomor);

            //angka mynum bisa dirubah mengikuti alur
            int mynum = 15;
            mynum = 16;
            Console.WriteLine(mynum);

            //const adalah variabel yang nilai nya tak bisa berubah
            const int myn = 17;
            Console.WriteLine(myn);

            //variabel dalam C# adalah int, bool, char, string, double

            //display variabel dengan kombinasi +
            string name = "Nur Muhammad Akbar";
            Console.WriteLine("Hello " + name);
            string firstname = "Nur ";
            string middlename = "Muhammad ";
            string lastname = "Akbar";
            Console.WriteLine(firstname + middlename + lastname);

            //untuk numerik
            int x = 45, y = 65;
            Console.WriteLine(x + y); //print value x + y

            //Scientific Numbers
            //e3f menambahkan 3 nol dan 4fD menambahkan 4 Nol
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            //boolean cuma menampilkan true & false
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            //Char cuma bisa di isi 1 huruf
            char mygrade = 'A';
            Console.WriteLine(mygrade);

            //string untuk menyimpan teks
            string greeting = "Selamat Pagi :)";
            Console.WriteLine(greeting);

            //long digunakan saat int tidak cukup memori
            long mynumber = 15000000000L;
            Console.WriteLine(mynumber);

            /*
              dalam C# ADA 2 CASTING
              implisit mengonversi tipe yan lebih kecil ke ukuran tipe yang lebih besar
              char => int => long => float => double
              
              eksplisit mengonversi tipe yang lebih besar ke tipe ukuran yang lebih kecil
              double => float => long => int => char
             */
            //contoh implisit
            int myint = 9;
            double mydouble = myint; //automatic casting int to double

            Console.WriteLine(myint); //Output 9
            Console.WriteLine(mydouble); //Output 9

            //contoh eksplisit
            double myDouble = 10.78;
            int myInt = (int)myDouble; //Manual casting double to int

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);

            //Metode Konversi
            int myINT = 10;
            double myDOUBLE = 5.25;
            bool mybool = true;

            Console.WriteLine(Convert.ToString(myINT)); //Mengubah int ke string
            Console.WriteLine(Convert.ToDouble(myINT)); //Mengubah int ke double
            Console.WriteLine(Convert.ToInt32(myDOUBLE)); //Mengubah double ke int
            Console.WriteLine(Convert.ToString(mybool)); //Mengubah bool ke string

            //User Input 
            //write dan writeline berbeda jika writeline akan membuat baris baru setelah output
            Console.Write("Enter UserName : "); //output enter username
            string username = Console.ReadLine(); //memasukkan isi writeline ke dalam variabel username
            Console.WriteLine("User name Is " + username);

            /* implisit error tak bisa mengonversi string ke int
     
            Console.Write("Enter Your Age : ");
            int age = Console.ReadLine();
            Console.WriteLine("Your Age is : " + age);
            */

            //code yang benar adalah ini
            Console.Write("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age : " + age);

            //OPERATOR
            int i = 50 + 100;
            Console.WriteLine(i);

            int sum1 = 100 + 50; //100 + 50 = 150
            int sum2 = sum1 + 250; // 150 + 250 = 400
            int sum3 = sum2 + sum2; //400 + 400 = 800
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            /*jenis OPERATOR
            + Penjumlahan
            - Pengurangan
            * Perkalian
            / Pembagian
            % Modulus
            ++ Increment
            -- Decrement
            */

            //ASSIGMENT OPERATOR
            int X = 10;
            X += 5;
            Console.WriteLine(X);

            /* Operator Assignment
            OPERATOR        Example                 Same AS
             =              x = 5	                x = 5	
            +=	            x += 3	                x = x + 3	
            -=	            x -= 3	                x = x - 3	
            *=	            x *= 3	                x = x * 3	
            /=	            x /= 3	                x = x / 3	
            %=	            x %= 3	                x = x % 3	
            &=	            x &= 3	                x = x & 3	
            |=	            x |= 3	                x = x | 3	
            ^=	            x ^= 3	                x = x ^ 3	
            >>=	            x >>= 3	                x = x >> 3	
            <<=	            x <<= 3	                x = x << 3
            */

            /*
            COMPARISON OPERATOR
            Operator        Nama                            Example
            ==              Equal to                        x == y
            !=              Not equal                       x != y
            >               Greater than                    x > y
            <               Less than                       x<y
            >=              Greater than or equal to        x >= y
            <=              Less than or equal to           x <= y
            */

            /*
            Logical Operators
            && Logical AND      Returns true if both statements are true
            || Logical OR       Returns true if one of the statements is true
            !  Logical Not      Reverse the result, returns false if the result is true
            */

        }
    }
}
