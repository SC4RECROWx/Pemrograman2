using System;
using System.Collections.Generic;

namespace datacollect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0
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
            var daftar_tebakan = new List<char>();

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
                //1
                Console.Write("\nInput Huruf dari tebakan anda : ");
                char huruf = char.Parse(Console.ReadLine());

                //2
                if (daftar_tebakan.Contains(huruf))
                {
                    Console.WriteLine("Huruf : " + huruf + "Telah di input..coba lagi");
                    continue;
                }
                else
                {
                    daftar_tebakan.Add(huruf);
                }
                //3
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
                        break;
                    }
                }
                //4
                if (!ketemu)
                {
                    Console.WriteLine("huruf tidak ditemukan");
                    kesempatan--;
                    if (kesempatan == 0)
                    {
                        Console.WriteLine("Lose...");
                        GameOver = true;
                    }
                }
            }
             Console.WriteLine("Jawabannya adalah ");
            for (int i = 0; i<word_chr.Length; i++)
            {
                Console.Write(word_chr[i] + " ");
            }
             Console.WriteLine("Game Over...");
        }
    }
}
