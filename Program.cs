// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        //Array

        // Deklarasi dan inisialisasi array
        int[] angka = { 1, 2, 3, 4, 5 };

        // Akses elemen array
        Console.WriteLine("Elemen pertama: " + angka[0]);
        Console.WriteLine("Elemen terakhir: " + angka[angka.Length - 1]);

        // Mengubah nilai elemen array
        angka[2] = 10;
        Console.WriteLine("Elemen ketiga setelah diubah: " + angka[2]);

        //Menampilkan dengan foreach
        int i = 0;
        foreach (int ongko in angka)
        {
            
            Console.WriteLine(ongko);
            i++;
        }
        Console.WriteLine("I adalah =====> "+i);


        //List

        // Deklarasi dan inisialisasi List
        List<int> numberlist = new List<int>(){
                1,2,3,4,5
            };

        // Akses elemen List
        Console.WriteLine("Elemen Pertama List = " + numberlist[0]);
        Console.WriteLine("Elemen Terakhir List = " + numberlist[numberlist.Count - 1]);

        // Menambah elemen ke List
        numberlist.Add(6);
        Console.WriteLine("Elemen Baru Ditambahkan = " + numberlist[numberlist.Count - 1]);

        // Menghapus elemen dari List
        numberlist.Remove(2);
        Console.WriteLine("Elemen ke 2 dihapus = " + string.Join(", ", numberlist)); // "," untuk pemisah antar elemen
        
        //Menampilkan List dengan Loop For
        for (i = 0; i > numberlist.Count - 1; i++)
        {
            Console.WriteLine("Hasil For= "+numberlist[i]);
        }


        //Dictonary

        Dictionary<string, int> nilaiSiswa = new Dictionary<string, int>
                 {
                     {"Budi",87 },
                     {"Andi",90 },
                     {"Beni",79 },
                     {"Agung",95 }
                 };

        // Akses nilai berdasarkan kunci
        Console.WriteLine("Nilai Budi = " + nilaiSiswa["Budi"]);

        // Menambah pasangan kunci-nilai baru
        nilaiSiswa["Asep"] = 99;
        Console.WriteLine("Nilai Asep = " + nilaiSiswa["Beni"]);

        // Mengubah nilai berdasarkan kunci
        nilaiSiswa["Beni"] = 85;
        Console.WriteLine("Nilai Beni setelah diubah = " + nilaiSiswa["Beni"]);

        foreach (KeyValuePair<string, int> entry in nilaiSiswa)
        {
            Console.WriteLine($"{entry.Key} = {entry.Value}");
        }


    }
}
