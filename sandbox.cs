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
            string[] bintang = new string[5];

            for(int i = 0; i < hidden.Length; i++)
            {
                hidden[i] = "_";
            }
            for (int i = 0; i < bintang.Length; i++)
            {
                bintang[i] = "*";
            }

            //loop
            while (!GameOver)
            {
                //kesempatan
                for(int i = 0; i < bintang.Length; i++)
                {
                    Console.Write(bintang[i] + " ");
                }
                Console.Write($"\nKata dengan {word_chr.Length} HURUF : ");
                for(int i = 0; i < hidden.Length; i++)
                {
                    Console.Write(hidden[i] + " ");
                }

                Console.Write("\nInput Huruf dari tebakan anda : ");
                char huruf = char.Parse(Console.ReadLine());

                for(int i = 0; i < word_chr.Length; i++)
                {
                    if (word_chr[i].Equals(huruf))
                    {
                        Console.WriteLine($"Huruf {huruf} ditemukan...");
                        hidden[i] = Convert.ToString(huruf);
                        counter++;
                    }
                    else if (word_chr[i] != huruf)
                    {
                        Console.WriteLine($"Huruf {huruf} Tidak Ditemukan...");
                        bintang[i] = Convert.ToString("*")
                        counter++;
                    }
