using System;
using System.Collections;
using System.IO;

namespace laba_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите количество библиотек: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            ArrayList arrayList = new ArrayList(N);

            for (int i = 0; i < N;)
            {
                try
                {
                    Console.Write("Название: ");
                    string name = Console.ReadLine();

                    Console.Write("Адрес: ");
                    string adress = Console.ReadLine();

                    Console.Write("Год открытия: ");
                    int year = Convert.ToInt32(Console.ReadLine());

                    Library Library = new Library(name, adress, year);
                    arrayList.Add(Library);

                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введенные данные были неверными");
                }
                Console.WriteLine();
            }

            string path = "ArrayList.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Library word in arrayList)
                {
                    writer.WriteLine(word.Name);
                    writer.WriteLine(word.Adress);
                    writer.WriteLine(word.Year);
                    writer.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}