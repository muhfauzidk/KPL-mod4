using System;
using System.Collections;
using System.Collections.Generic;

public class Penjumlahan
{
    public void JumlahTigaAngka<T>(int x, int y, int z)
    {
        int result = x + y + z;
        Console.WriteLine("Hasil penjumlahan: " + result);
    }
}

public class Program
{
    public static void Main()
    {
        Penjumlahan hasil = new Penjumlahan();

        Console.Write("Masukkan angka pertama: ");
        int input1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        int input2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan angka ketiga: ");
        int input3 = Convert.ToInt32(Console.ReadLine());

        hasil.JumlahTigaAngka<int>(input1, input2, input3);
    }
}
