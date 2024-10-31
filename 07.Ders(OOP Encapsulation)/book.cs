using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace _07.Ders_OOP_Encapsulation_
{
    public class Book
    {
        public string id { get; set; }

        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                else
                {
                    bookName = value;
                }
            }
        }


        private string writername;
        public string writerName
        {
            get { return writerName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The writer name cannot be empty");
                }
                else
                {
                    writerName = value;
                }
            }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                if (value<0 || value >100)
                {
                    throw new ArgumentNullException("The price must not be less than 0 or greater than 100");
                }
                else
                {
                    price = value;
                }
            }
        }

        private bool bestSellere;

        public bool BestSeller
        {
            get { return Price > 20; }
        }


        public Book()
        {
            id = Guid.NewGuid().ToString();
        }

        public void GetInfo()
        {
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"Bookname: {BookName}");
            Console.WriteLine($"Writer name: {writerName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Bestseller: {BestSeller}");
        }


    }
}
