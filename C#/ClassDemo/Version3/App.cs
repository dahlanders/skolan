namespace ClassDemo.Version3
{
    using System;

    class Product
    {
        public int ProductId { get; set; }
    }

    class Book : Product
    {
        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Title { get; }

        public Book(string isbn, string title)
        {
            Isbn = isbn;
            Title = title;
        }

        int _nrOfPages;

        public int NrOfPages
        {
            get => _nrOfPages;

            set
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
        }

        public double WeightInGram => _nrOfPages * 3;

        public string Review
        {
            get
            {
                if (_nrOfPages < 100)
                    return "Bra bok!";

                if (_nrOfPages < 300)
                    return "Okej bok";

                return "Värdelös bok";
            }
        }

    }

    class ElectronicBook : Book
    {

        public void EmailBook(string emailAdress)
        {
            Console.WriteLine($"Send book '{Title}' to {emailAdress}");
        }

        public ElectronicBook(string isbn, string title) : base(isbn, title)
        {
        }
    }

    public class App
    {
        public void Run()
        {
            Console.WriteLine();

            var b1 = new Book("yyyy", "Min bok");

            b1.Isbn = "XXXX-XXXXX";
            b1.Author = "Kalle";
            b1.NrOfPages = 400;
            b1.ProductId = 1234;

            Console.WriteLine($"Info om boken:");
            Console.WriteLine($"* ISBN={b1.Isbn}");
            Console.WriteLine($"* Författare={b1.Author}");
            Console.WriteLine($"* Titel={b1.Title}");
            Console.WriteLine($"* Antal sidor={b1.NrOfPages}");
            Console.WriteLine($"* Vikt={b1.WeightInGram} gram");
            Console.WriteLine($"* Recension={b1.Review}");
            Console.WriteLine($"* Produktens id={b1.ProductId}");
            Console.WriteLine($"* Är b1 en bok? {b1 is Book}");
            Console.WriteLine($"* Är b1 en produkt? {b1 is Product}");

            var e1 = new ElectronicBook("zzzz", "Röda rummet");
            e1.EmailBook("oo@happybits.se");

            Console.WriteLine();
        }
    }

}
