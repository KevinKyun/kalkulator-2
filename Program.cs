using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Kalkulator Sederhana");
                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine("0. Keluar");

                Console.Write("Masukkan pilihan Anda (0-4) : ");
                string choice = Console.ReadLine();

                int selectedMenu;
                if (!int.TryParse(choice, out selectedMenu) || selectedMenu < 0 || selectedMenu > 4)
                {
                    Console.WriteLine("Pilihan yang Anda masukkan tidak valid. Silahkan coba lagi.");
                    Console.ReadLine();
                    continue;
                }

                if (selectedMenu == 0)
                {
                    break;
                }

                Console.Write("Masukkan angka pertama: ");
                string firstNumberInput = Console.ReadLine();

                Console.Write("Masukkan angka kedua: ");
                string secondNumberInput = Console.ReadLine();

                double firstNumber, secondNumber;

                if (!double.TryParse(firstNumberInput, out firstNumber) || !double.TryParse(secondNumberInput, out secondNumber))
                {
                    Console.WriteLine("Input yang Anda masukkan tidak valid. Silahkan coba lagi.");
                    Console.ReadLine();
                    continue;
                }

                double hasil = 0;

                switch (selectedMenu)
                {
                    case 1:
                        hasil = firstNumber + secondNumber;
                        break;
                    case 2:
                        hasil = firstNumber - secondNumber;
                        break;
                    case 3:
                        hasil = firstNumber * secondNumber;
                        break;
                    case 4:
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Tidak dapat melakukan pembagian dengan angka 0.");
                            Console.ReadLine();
                            continue;
                        }
                        hasil = firstNumber / secondNumber;
                        break;
                }

                Console.WriteLine("Hasil: " + hasil);
                Console.ReadLine();
            }
        }
    }
}
