﻿namespace OOPTemelKavramlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             * Yeniden kullanılabilirlik..... (Reusability)
             * Genişletilebilirlik (Extensibility)
             * Bakımı yapılabilir (Maintability).
             * Ölçeklenebilir (Scalability)
             * 
             * 
             */

            Personel yeniYazilimci = new Personel();
            Personel yeniMuhasebeci = new Personel();

            yeniYazilimci.ad = "Türkay";
            yeniMuhasebeci.ad = "Derya";

            Console.WriteLine("Yaşınızı girin");

            Personel p1 = new Personel();
            p1.ad = "Ayşenur";

            Personel p2 = p1;

            p2.ad = "Eda";

            Console.WriteLine(p1.ad);
            Console.ReadLine();
        }
    }
}