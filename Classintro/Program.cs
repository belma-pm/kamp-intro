﻿using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Berkay Demiroğ";
            kurs2.İzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "kerem Demiro";
            kurs3.İzlenmeOrani = 64;

            // Console.WriteLine(kurs1.KursAdi + ": " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };


            foreach (var kurs in kurslar)

            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
            }
        }


                //Console.WriteLine("Hello World!");

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int İzlenmeOrani { get; set; }
        }
    }
}
