using System;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.IO;


//1. Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.

//Разработать класс для моделирования объекта «Товар». Предусмотреть члены класса «Код товара» (целое число), «Название товара» (строка), «Цена товара» (вещественное число).
//Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
//Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json».

//2. Необходимо разработать программу для получения информации о товаре из json-файла.
// Десериализовать файл «Products.json» из задачи 1. Определить название самого дорогого товара.

namespace Lab_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите количество товара (целое число)");
            int z = 5;  //int z = Convert.ToInt32(Console.ReadLine());
            int[] kod = new int[z];
            string[] name = new string[z];
            double[] many = new double[z];
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine("Введите код товара (целое число)");
                kod[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите название товара (строка)");
                name[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите цену товара (вещественное число)");
                many[i] = Convert.ToDouble(Console.ReadLine());
            }
            Products products = new Products()
            {
                Kod = kod,
                Name = name,
                Many = many
            };
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
            };
            string JsonString = JsonSerializer.Serialize(products, options);
            Console.WriteLine(JsonString);
            using (StreamWriter sw = new StreamWriter("D:/111/Products.json"))
            {
                sw.WriteLine(JsonString);
            }
            Console.ReadKey();
        }
    }
    class Products
    {
        public int[] Kod { get; set; }
        public string[] Name { get; set; }
        public double[] Many { get; set; }
    }
}