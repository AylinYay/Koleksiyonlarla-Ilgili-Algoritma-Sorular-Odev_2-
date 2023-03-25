using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    class Program
    {
        //SORU 1
        //public static bool asalKontrol(int sayi)
        //{
        //    int sayac = 0;
        //    bool asal;
        //    int i;

        //    for (i = 1; i <= sayi; i++)
        //    {
        //        if (sayi % i == 0)
        //        {
        //            sayac++;
        //        }
        //    }
        //    if (sayac == 2)
        //    {
        //        asal = true;
        //    }
        //    else
        //    {
        //        asal = false;
        //    }
        //    return asal;
        //}
        //public static int toplamGetir(ArrayList list)
        //{
        //    int toplam = 0;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        toplam += Convert.ToInt32(list[i]);
        //    }

        //    return toplam;
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz");
        //    ArrayList tumSayilar = new ArrayList();
        //    ArrayList asalSayilar = new ArrayList();
        //    ArrayList asalOlmayanSayilar = new ArrayList();

        //    for (int i = 0; i < 20; i++)
        //    {
        //        var girilenDeger = Console.ReadLine();
        //        try
        //        {
        //            int sayi = Convert.ToInt32(girilenDeger);
        //            if (sayi > 0)
        //                tumSayilar.Add(sayi);
        //            else Console.WriteLine("Lütfen pozitif sayı giriniz");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Lütfen sayısal ve pozitif bir değer giriniz : " + girilenDeger);
        //        }
        //    }

        //    for (int i = 0; i < tumSayilar.Count; i++)
        //    {
        //        if (asalKontrol(Convert.ToInt32(tumSayilar[i])))
        //            asalSayilar.Add(tumSayilar[i]);
        //        else
        //            asalOlmayanSayilar.Add(tumSayilar[i]);
        //    }

        //    asalSayilar.Sort();
        //    asalSayilar.Reverse();


        //    asalOlmayanSayilar.Sort();
        //    asalOlmayanSayilar.Reverse();

        //    Console.WriteLine("Asal Sayılar eleman sayısı : " + asalSayilar.Count + " Ortalaması : " + toplamGetir(asalSayilar) / asalSayilar.Count);
        //    Console.WriteLine("Asal Olmayan Sayılar eleman sayısı : " + asalOlmayanSayilar.Count + " Ortalaması : " + toplamGetir(asalOlmayanSayilar) / asalOlmayanSayilar.Count);

        //    Console.ReadLine();
        //}


        static void Main(string[] args)
        {
            //SORU 2
            //int[] sayilar = new int[20];
            //int[] enKucukUcSayi = new int[3];
            //int[] enBuyukUcSayi = new int[3];
            //int enKucuklerOrt, enKucuklerToplam = 0;
            //int enBuyuklerOrt, enBuyuklerToplam = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    sayilar[i] = n;
            //}

            //Array.Sort(sayilar);
            //for (int j = 0; j < 3; j++)
            //{
            //    enKucukUcSayi[j] = sayilar[j];
            //    enKucuklerToplam += enKucukUcSayi[j];
            //}
            //Console.WriteLine("En küçük sayılar : " + enKucukUcSayi[0] + "," + enKucukUcSayi[1] + "," + enKucukUcSayi[2]);
            //enKucuklerOrt = enKucuklerToplam / 3;

            //Array.Reverse(sayilar);
            //for (int k = 0; k < 3; k++)
            //{
            //    enBuyukUcSayi[k] = sayilar[k];
            //    enBuyuklerToplam += enBuyukUcSayi[k];
            //}
            //Console.WriteLine("En büyük sayılar : " + enBuyukUcSayi[0] + "," + enBuyukUcSayi[1] + "," + enBuyukUcSayi[2]);
            //enBuyuklerOrt = enBuyuklerToplam / 3;

            //Console.WriteLine("En büyük 3 sayının ortalaması : " + enBuyuklerOrt);
            //Console.WriteLine("en küçük 3 sayının ortalaması : " + enKucuklerOrt);
            //Console.WriteLine("Ortalamaların Toplamı : " + (enKucuklerOrt + enBuyuklerOrt));

            //SORU 3
            //char[] sesli = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            //Console.WriteLine("Metin Giriniz : ");
            //List<string> liste = new List<string>();
            //string metin = Console.ReadLine();
            //for (int i = 0; i < sesli.Length; i++)
            //{
            //    for (int j = 0; j < metin.Length; j++)
            //    {
            //        if (metin[j] == sesli[i])
            //        {
            //            liste.Add(sesli[i].ToString());
            //            Console.Write(sesli[i].ToString() + " ");
            //        }
            //    }
                
            //}





        }

    }

}
