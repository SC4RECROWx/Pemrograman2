using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class Tebak_Kata
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nLets Play ! TEBKA KATA");

            string[] kamus_kata = {"tennis", "raket", "lapangan", "wasit", "atlit",
                                    "inside", "referee", "sepatu", "kaos", "medali",
                                    "ronde", "pemain", "peringkat", "penalti", "court"};

            Random rdm = new Random();
            int word_idx = rdm.Next(0, kamus_kata.Length);
            int counter = 0;
            char[] word_chr = kamus_kata[word_idx].ToCharArray();
            string[] hidden = new string[word_chr.Length];
            bool GameOver = false;
            bool ketemu = false;
            int kesempatan = 7;

            for (int i = 0; i < hidden.Length; i++)
            {
                hidden[i] = "_";
            }

            //loop
            while (!GameOver)
            {
                Console.WriteLine("\nKesempatan : " + kesempatan);
                Console.Write($"\nKata dengan {word_chr.Length} huruf : ");

                for (int i = 0; i < hidden.Length; i++)
                {
                    Console.Write(hidden[i] + " ");
                }

                Console.Write("\nInput Huruf dari tebakan anda : ");
                char huruf = char.Parse(Console.ReadLine());

                ketemu = false;
                for (int i = 0; i < word_chr.Length; i++)
                {
                    if (word_chr[i].Equals(huruf))
                    {
                        Console.WriteLine($"Huruf {huruf} ditemukan...");
                        hidden[i] = Convert.ToString(huruf);
                        counter++;
                        ketemu = true;
                    }
                    if (counter == word_chr.Length)
                    {
                        Console.WriteLine("won");
                        GameOver = true;
                        
                    }
                }

                if (!ketemu)
                {
                    Console.WriteLine("huruf tidak ditemukan");
                    kesempatan--;
                    if(kesempatan == 0)
                    {
                        Console.WriteLine("Lose...");
                        GameOver = true;
                    }
                }
            }
            Console.WriteLine("Jawabannya adalah ");
            for (int i = 0; i < word_chr.Length; i++)
            {
                Console.Write(word_chr[i] + " ");
            }
            Console.WriteLine("Game Over...");
        }
    }
}
