using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace sayiokunus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // girilen sayının okunuşunu bulan bir algoritma
            Console.Write("2 Basamaklı bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int birler = sayi % 10;
            int onlar = sayi / 10;
            switch (onlar)
            {
                case 1:
                    Console.Write("On");
                    break;
                case 2:
                    Console.Write("Yirmi");
                    break;
                case 3:
                    Console.Write("Otuz");
                    break;
                case 4:
                    Console.Write("Kırk");
                    break;
                case 5:
                    Console.Write("Elli");
                    break;
                case 6:
                    Console.Write("Altmış");
                    break;
                case 7:
                    Console.Write("Yetmiş");
                    break;
                case 8:
                    Console.Write("Seksen");
                    break;
                case 9:
                    Console.Write("Doksan");
                    break;
            }
            switch (birler)
            {
                case 1:
                    Console.Write("bir");
                    break;
                case 2:
                    Console.Write("iki");
                    break;
                case 3:
                    Console.Write("üç");
                    break;
                case 4:
                    Console.Write("dört");
                    break;
                case 5:
                    Console.Write("beş");
                    break;
                case 6:
                    Console.Write("altı");
                    break;
                case 7:
                    Console.Write("yedi");
                    break;
                case 8:
                    Console.Write("sekiz");
                    break;
                case 9:
                    Console.Write("dokuz");
                    break;
            }
            Console.WriteLine("\nÇıkmak İçin Bir Tuşa Basın");
            Console.ReadKey();
        }
    }
}
