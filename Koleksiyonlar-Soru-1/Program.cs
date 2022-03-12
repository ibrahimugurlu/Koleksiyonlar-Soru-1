using System;
using System.Collections;
using System.Collections.Generic;
namespace Koleksiyonlar_Soru_1
{
    public static class Examples
     {
        public static bool PrimeControl(this int param,int assistant)
        {
            if (param == 1)
                return false;
            else if (assistant == 1)
                return true;
            else if (param % assistant == 0)
                return false;
            else return PrimeControl(param, assistant - 1);

        }
        public static int CalculateAverage(this ArrayList param)
        {
          int lenght = param.Count;
            int total=0;
           
            foreach (int number in param)
            {
                total = total + number;
            }
           int average = total / lenght;
            return average;
        }
        public static void WriteScreen(this ArrayList param)
        {
            param.Sort();
            foreach (var number in param)
            {
                Console.WriteLine(number);

            }

            Console.WriteLine("Eleman Sayısı :"+ param.Count);         
            Console.WriteLine("ortalama :"+ param.CalculateAverage());           
            Console.WriteLine("****************************************");
        }
       


     }
    class Program
    {
        static void Main(string[] args)
        {          
            ArrayList PrimeNumber = new ArrayList();
            ArrayList NoPrimeNumber = new ArrayList();
            int inputNumber;
            Console.WriteLine(" Hoşgeldiniz ");
            Console.WriteLine(" Klavyeden 10 Adet Sayi Giriniz.. ");

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    inputNumber = int.Parse(Console.ReadLine());
                    if (inputNumber < 0)
                    {
                        throw new Exception();
                    }
                        
                    else
                    {

                        if (inputNumber.PrimeControl(inputNumber / 2))
                            PrimeNumber.Add(inputNumber);
                        else
                            NoPrimeNumber.Add(inputNumber);
                    }
                       

                }
                catch (Exception)
                {
                    i--;
                    Console.WriteLine("Lütfen Sadece pozitif bir tam sayı girin");

                }                            
            }            
            Console.WriteLine(" Girdiğiniz Asal Sayilar : ... ");
            PrimeNumber.WriteScreen();
                      
            Console.WriteLine(" Girdiğiniz Asal Olmayan Sayilar : ... ");
            NoPrimeNumber.WriteScreen();




            Console.Read();
        }
    }
}
