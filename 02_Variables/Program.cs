using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //UTF-8 Kodlaması

            #region Double Değişkenler

            //double number;

            //number = 12.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine("");

            //double elmaPrice, armutPrice, portakalPrice, muzPrice, çilekPrice;

            //elmaPrice = 15.49;
            //armutPrice = 26.13;
            //portakalPrice = 11.86;
            //muzPrice = 32.99;
            //çilekPrice = 41.75;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + elmaPrice + " TL");
            //Console.WriteLine("---- Armut Birim Fiyatı: " + armutPrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + portakalPrice + " TL");
            //Console.WriteLine("---- Muz Birim Fiyatı: " + muzPrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + çilekPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double elmaGram, armutGram, portakalGram, muzGram, çilekGram;

            //elmaGram = 1.365;
            //armutGram = 0.585;
            //portakalGram = 2.870;
            //muzGram = 1.595;
            //çilekGram = 0.375;

            //double elmaToplam = elmaPrice * elmaGram;
            //double armutToplam = armutPrice * armutGram;
            //double portakalToplam = portakalPrice * portakalGram;
            //double muzToplam = muzPrice * muzGram;
            //double çilekToplam = çilekPrice * çilekGram;

            //Console.WriteLine("Alınan Ürün: Elma -     " + "Birim Fiyat: " + elmaPrice + " - Gramaj: " + elmaGram + " gr - Toplam Tutar: " + elmaToplam + " TL");
            //Console.WriteLine("Alınan Ürün: Armut -    " + "Birim Fiyat: " + armutPrice + " - Gramaj: " + armutGram + " gr - Toplam Tutar: " + armutToplam + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + portakalPrice + " - Gramaj: " + portakalGram + " gr - Toplam Tutar: " + portakalToplam + " TL");
            //Console.WriteLine("Alınan Ürün: Muz -      " + "Birim Fiyat: " + muzPrice + " - Gramaj: " + muzGram + " gr - Toplam Tutar: " + muzToplam + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek -    " + "Birim Fiyat: " + çilekPrice + " - Gramaj: " + çilekGram + " gr - Toplam Tutar: " + çilekToplam + " TL");

            //double toplamPrice = elmaToplam + armutToplam + portakalToplam + muzToplam + çilekToplam;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Toplam Fiyat: " + toplamPrice + " TL");

            #endregion

            #region Char Değişkenler

            //char sembol;
            //sembol = 'A';

            //Console.WriteLine(sembol);


            #endregion

            #region Veri String Girişleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerID;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu ID: ");
            //passengerID = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " - Yolcu Adres: " + passengerDistrict + "/" + 
            //    passengerCity + " - Yolcu Yaş: " + passengerAge + " - Yolcu Kimlik: " + passengerID);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı İşlemler

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.Write("Sınavların Ortalaması: " + result);

            #endregion

            #region Klavyeden Char Girişleri

            //char gender;
            //Console.Write("Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
