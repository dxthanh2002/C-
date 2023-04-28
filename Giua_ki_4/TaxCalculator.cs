namespace Giua_ki_4
{
    internal class TaxCalculator
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            products[0] = new Book("1", "Book 1", 10.0);
            products[1] = new Book("2", "Book 2", 20.0);
            products[2] = new Book("3", "Book 3", 30.0);
            products[3] = new Phone("4", "Phone 1", 100.0);
            products[4] = new Phone("5", "Phone 2", 200.0);

            double totalBookTax = 0.0;
            double totalPhoneTax = 0.0;

            foreach (Product product in products)
            {
                if (product is Book)
                {
                    totalBookTax += product.computeTax();
                }
                else if (product is Phone)
                {
                    totalPhoneTax += product.computeTax();
                }
            }

            Console.WriteLine("Total tax of books: " + totalBookTax);
            Console.WriteLine("Total tax of phones: " + totalPhoneTax);
        }
    }
}