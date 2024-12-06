﻿using System;

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

            Console.WriteLine($"Hasil penambahan dari {A} + {B} adalah: {Penambahan}");
            Console.WriteLine($"Hasil pengurangan dari {A} - {B} adalah: {Pengurangan}");
        }
    }
}