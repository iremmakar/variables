
using System;

namespace degisken{

    class Program{
        
        static void Main(string[] args){
            int deger;
            deger =2;
            
            String Deger = null;

            Console.WriteLine(deger);
            
            String degisken = " ";
            byte b = 5; // 1 byte
            sbyte c = 5; //1 byte
            short s = 5; // 2 byte

            ushort us = 5; 

            Int16 i16 = 12; // 2byte
            int i = 2 ; // 4 byte
            Int32 i32= 2 ; // 4 byte;
            Int64 i64 = 2; // 8 byte

            uint ui = 2 ; // 4byte
            long l = 2;// 8 byte
            ulong ul=2; // 8 byte

            float f = 5;  // 4byte
            double d=5; // 8 byte
            decimal de = 5; // 16byte

            char ch = '2'; // 2 byte
            String str = "xdsds"; // sınırsız

            bool b1=true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1= "x1";
            object o2 = 2;
            object o3 = 3.4;

            String str2 = string.Empty;

            str2 = "ssss";

            String ad = "s";
            String soyad = "c";
            String tamisim = ad+ " " +soyad;

            int integer1 = 3;
            int integer2 = 4;
            int integer3= integer1*integer2;

            bool b3 = 10<3;

            // değişken dönüşümleri

            String str20= "20";
            int int20 = 20;

            String yeniDeger= str20 + int20.ToString();

            int int21 = int20 + Convert.ToInt32(str20);

            int int22 = int20 +int.Parse(str20);

            String dateTime = DateTime.Now.ToString("dd.MM.yyyy");

            String dateHour = DateTime.Now.ToString("HH:mm");
            




        }


    }


}