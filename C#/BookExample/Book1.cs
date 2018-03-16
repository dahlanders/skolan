using System;

namespace Exempel1
{
    class Product
    {
        private int _productId;

        public int GetProductId()
        {
            return _productId;
        }

        public void SetProductId(int value)
        {
            _productId = value;
        }
    }
    class Book
    {
        string _isbn;
        string _author;
        int _nrOfPages;

        public string GetIsbn()
        {
            return _isbn;
        }

        public void SetIsbn(string value)
        {
            _isbn = value;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string value)
        {
            _author = value;
        }

        public int GetNrOfPages()
        {
            return _nrOfPages;
        }

        public void SetNrOfPages(int value)
        {
            if (value > 0 && value < 1000)
            {
                _nrOfPages = value;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Felaktigt antal sidor, sätter antal sidor till 300!");
                _nrOfPages = 300;
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }

        public double WeightInGram()
        {
            return _nrOfPages * 3;
        }

        public string Review()
        {
            if (_nrOfPages < 100)
                return "Bra bok!";

            if (_nrOfPages < 300)
                return "Okej bok";

            return "Värdelös bok";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine();

            var b1 = new Book();

            b1.SetIsbn("XXXXX-XXXX");
            b1.SetAuthor("Kalle");
            b1.SetNrOfPages(400);

            Console.WriteLine($"Info om boken:");
            Console.WriteLine($"* ISBN={b1.GetIsbn()}");
            Console.WriteLine($"* Författare={b1.GetAuthor()}");
            Console.WriteLine($"* Antal sidor={b1.GetNrOfPages()}");
            Console.WriteLine($"* Vikt={b1.WeightInGram()} gram");
            Console.WriteLine($"* Recension={b1.Review()}");
            Console.WriteLine();
        }
    }
}
