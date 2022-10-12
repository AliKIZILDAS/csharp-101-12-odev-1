using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Lütfen pozitif bir sayi giriniz.");
            int sayi=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen "+ sayi+" adet pozitif sayı giriniz.");
            int[] sayiDizisi=new int[sayi];
            for (int i = 0; i < sayi; i++)
            {
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ekrana girdiğiniz çift sayılar:");
            foreach (var item in sayiDizisi)
            {
                if (item%2==0)
                {
                    Console.WriteLine(item);
                }                
            }            
            //2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("Lütfen pozitif iki sayı giriniz.");
            int[] sayiDizisi2=new int[2];
            for (int i = 0; i < 2; i++)
            {
                sayiDizisi2[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Lütfen "+sayiDizisi2[0]+" adet pozitif sayı giriniz.");
            int[] sayiDizisi3=new int[sayiDizisi2[0]];            
            for (int i = 0; i < sayiDizisi2[0]; i++)
            {
                sayiDizisi3[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sayiDizisi2[1] +"'e eşit yada tam bölünenler:");
            foreach (var item in sayiDizisi3)
            {
                if (item==sayiDizisi2[1] || item%sayiDizisi2[1]==0)
                    Console.WriteLine(item);                
            }
            //3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.WriteLine("Lütfen pozitif bir sayi giriniz.");
            int sayi1=int.Parse(Console.ReadLine());
            string[] sayiDizisi4=new string[sayi1]; 
            Console.WriteLine("Lütfen "+ sayi1+ " adet kelime giriniz.") ;        
            for (int i = 0; i < sayi1; i++)
            {
                sayiDizisi4[i]=Console.ReadLine();
            }
            Console.WriteLine("Girilen kelimeler:");
            foreach (var item in sayiDizisi4.Reverse())
            {
                Console.Write(item+" ");
            }
            //4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("Lütfen bir cümle giriniz.");
            string cümle=Console.ReadLine();
            string[] kelime=cümle.Split(" ");
            Console.WriteLine(kelime.Count());
            Console.WriteLine(cümle.Length);        
        }
    }
}
