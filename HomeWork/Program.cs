using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ÜrümAdı = "Tablet";
            product1.Markası = "Samsung";
            product1.ÜrünAçıklaması = "64GB-10inç-Beyaz";
            product1.Fiyatı = 2400;

            Product product2 = new Product();
            product2.ÜrümAdı = "Çamaşır Makinası";
            product2.Markası = "Arçelik";
            product2.ÜrünAçıklaması = "Dokunmatik ekran - A plus tasarruf - 20 kg - Gri";
            product2.Fiyatı = 8900;

            Product product3 = new Product();
            product3.ÜrümAdı = "Laptop";
            product3.Markası = "Monster";
            product3.ÜrünAçıklaması = "Siyah renk - 32 gb Ram - RTX 3090 - İ7 Core intel işlemci";
            product3.Fiyatı = 30259;

            Product product4 = new Product();
            product4.ÜrümAdı = "Kulaklık";
            product4.Markası = "JBL";
            product4.ÜrünAçıklaması = "Siyah - Kulak üstü - Bluetooth - TYPE-C ";
            product4.Fiyatı = 1699;

            Product product5 = new Product();
            product5.ÜrümAdı = "Akıllı Saat";
            product5.Markası = "Xiomi";
            product5.ÜrünAçıklaması = "8 gb Hafıza - Pembe Kordon - 1.9 inç - SimKart uyumlu";
            product5.Fiyatı = 2559;


            Product[] products = new Product[] { product1, product2, product3, product4, product5 };

            foreach (var product in products)
            { Console.WriteLine(product.ÜrümAdı + ": " + product.Markası + ": " + product.ÜrünAçıklaması + ": " + product.Fiyatı); }

            Console.WriteLine("            --Foreach Bitti--          ");


            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ÜrümAdı + ": " + products[i].Markası + ":  " + products[i].ÜrünAçıklaması + ":  " + products[i].Fiyatı);
            }

            Console.WriteLine("            --For Bitti--           ");







        }
        class Product
        {
            public string ÜrümAdı { get; set; }
            public string Markası { get; set; }
            public string ÜrünAçıklaması { get; set; }
            public int Fiyatı { get; set; }


        }
    }
}
