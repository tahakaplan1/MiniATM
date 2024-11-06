using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secim;
            int bakiye = 10000;
            int yatırılantutar;
            int toplam;
            int cekilecektutar;

            do
            {
                Console.WriteLine("Mini ATM Uygulamasına Hoşgeldiniz");
                Console.WriteLine("Yapmak İstediğiniz işlemi Seçiniz");
                Console.WriteLine("1-Bakiye Görüntülemen \n2-Para Yatırma \n3-Para Çekme \n4-Çıkış");
                secim = Console.ReadLine();

                switch (secim)
                {

                    case "1":
                        Console.WriteLine("Bakiyeniz :" + bakiye);
                        break;
                    case "2":
                        Console.Write("Yatırılacak Tutarı Giriniz : ");
                        yatırılantutar = Convert.ToInt32(Console.ReadLine());
                        bakiye += yatırılantutar;
                        Console.WriteLine("Yeni Bakiyeniz : " + bakiye);
                        break;
                    case "3":

                        Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz");
                        Console.WriteLine("Bakiyeniz :" + bakiye);
                        cekilecektutar = Convert.ToInt32(Console.ReadLine());
                        if (cekilecektutar > bakiye)
                        {
                            Console.WriteLine("Bakiyenizden Fazla Miktar Çekemezsiniz");
                            break;
                        }
                        bakiye -= cekilecektutar;
                        Console.WriteLine("Yeni Bakiyeniz :" + bakiye);
                        break;

                }


            }
            while (secim != "4");
            Console.WriteLine("Çıkış Yapılıyor...");
            Console.ReadLine();


        }








    }




}
