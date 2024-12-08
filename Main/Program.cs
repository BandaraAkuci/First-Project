using System;

namespace Aritmatika
{

    /// <summary>
    /// Method aritmatika dari penambahan dan pengurangan.
    /// </summary>
    class Opsi
    {

        /// <summary>
        /// Penambahan antar dua bilangan bulat.
        /// </summary>
        /// <param name="a">Bilangan bulat pertama/</param>
        /// <param name="b">Bilangan bulat kedua.</param>
        /// <returns>Hasil penjumlahan dua bilangan bulat.</returns>
        public static int Tambah(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// Pengurangan antar dua bilangan bulat.
        /// </summary>
        /// <param name="a">Bilangan bulat pertama.</param>
        /// <param name="b">Bilangan bulat kedua.</param>
        /// <returns>Hasil pengurangan dua bilangan bulat.</returns>
        public static int Kurang(int a, int b)
        {
            return a - b;
        }


        /// <summary>
        /// Pembagian antar dua bilangan bulat.
        /// </summary>
        /// <param name="a">Bilangan bulat pertama.</param>
        /// <param name="b">Bilangan bulat kedua.</param>
        /// <returns>Hasil pembagian dua bilangan bulat.</returns>
        public static float Bagi(float a, float b)
        {
            return a / b;
        }


        /// <summary>
        /// Perkalian antar dua bilangan bulat.
        /// </summary>
        /// <param name="a">Bilangan bulat pertama.</param>
        /// <param name="b">Bilangan bulat kedua.</param>
        /// <returns>Hasil perkalian dua bilangan bulat.</returns>
        public static int Kali(int a, int b)
        {
            return a * b;
        }
    }


    /// <summary>
    /// Titik awal masuk program.
    /// </summary>
    class Program
    {
        static void Main()
        {
            int A = 10;
            int B = 15;
            int Penambahan = Opsi.Tambah(A,B);
            int Pengurangan = Opsi.Kurang(A,B);
            float Pembagian = Opsi.Bagi(A,B);
            int Perkalian = Opsi.Kali(A,B);

            Console.WriteLine($"Hasil penambahan dari {A} + {B} adalah: {Penambahan}");
            Console.WriteLine($"Hasil pengurangan dari {A} - {B} adalah: {Pengurangan}");
            Console.WriteLine($"Hasil pembagian dari {A} / {B} adalah: {Pembagian:F1}");
            Console.WriteLine($"Hasil perkalian dari {A} x {B} adalah: {Perkalian}");
        }
    }
}