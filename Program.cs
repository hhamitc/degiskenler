using System;
using System.Runtime.Intrinsics.Arm;

namespace console_programlama
{
    class Program
    {
       static void Main(string[] args)
        {

        Console.WriteLine("Hello, World!");

        byte b = 5;         // 1 byte
        sbyte sb = 5;        // 1 byte

        short s = 5;        // 2 byte
        ushort us = 5;      // 2 byte

        Int16 i16= 5;       // 2 byte
        int i = 2;          // 4 byte   
        Int32 i32 = 2;      // 4 byte
        Int64 i64 = 2;      // 8 byte

        uint ui = 2;        // 4 byte
        long l = 4;         // 8 byte
        ulong ul = 4;       // 8 byte

        float f = 5;        // 4 byte
        double d = 5;       // 8 byte
        decimal de = 5;     // 16 byte

        char c = '2';       // 2 byte
        string str = "Hamit";  // Sınırsız

        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;
        System.Console.WriteLine(dt);

        object o1 = "x";
        object o2 = "y";
        object o3 = 4;
        object o4 = 4.3;

        // String İfadeler
        string str1 = "";
        string str2 = null;
        string str3 = string.Empty;

        str1 = "Hmait Canpolat";
        string ad = "Hamit";
        string soyad = "Canpolat";
        string tamIsim = ad + " " + soyad;

        //integer tanımlama şekilleri

        int integer1 = 5;
        int integer2 = 3;
        int integer3= integer1 + integer2;

        //boolean

        bool bool1 = 10<2;
        bool bool2 = 10>2;

        //Değişken Dönüşümleri
        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();
        System.Console.WriteLine(yeniDeger); //Çıktı 2020

        int int21 = int20 + Convert.ToInt32(str20);
        System.Console.WriteLine(int21); //Çıktı 40

        int int22 = int20 + int.Parse(str20); // Çıktı 40
        System.Console.WriteLine(int22);

        //datetime

        string datetime = DateTime.Now.ToString("dd.mm.yyyy");
        System.Console.WriteLine(datetime);

        string datetime2 = DateTime.Now.ToString("dd/mm/yyyy");
        System.Console.WriteLine(datetime2);

        string hour = DateTime.Now.ToString("HH:mm");
        System.Console.WriteLine(hour);


        }

    }
}

