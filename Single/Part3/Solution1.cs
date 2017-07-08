using System;

//Классы и объекты
namespace Single.Part3
{
    public class Solution1
    {
        public static void Execute()
        {
            // КЛАССЫ И ОБЪЕКТЫ

            Book b1 = new Book("Война и мир", "Л. Н. Толстой", 1869);
            b1.GetInformation();

            Book b2 = new Book();
            b2.GetInformation();

            Book b3 = new Book();
            b3.name = "Война и мир";
            b3.author = "Л. Н. Толстой";
            b3.year = 1869;
            b3.GetInformation();

            Book b4 = new Book();
            // присваивание значения без явного вызова конструктора
            b4 = new Book { name = "Отцы и дети", author = "И. С. Тургенев", year = 1862 };
            b4.GetInformation();

            Console.ReadLine();
        }
    }

    class Book
    {
        public string name;
        public string author;
        public int year;

        public Book()
        {
            name = "неизвестно";
            author = "неизвестно";
            year = 0;
        }

        public Book(string name = "неизвестно", string author = "неизвестно", int year = 0)
        {
            this.name = name;
            this.author = author;
            this.year = year;
        }

        public void GetInformation()
        {
            Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name, author, year);
        }
    }

    // частичные классы
    partial class BookPartitial
    {
        public string name;
        public string author;
        public int year;
    }

    partial class BookPartitial
    {
        public void Info()
        {
          Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name, author, year);
        }
    }

    partial class BookPartitial
    {
        public BookPartitial(string name, string author, int year)
        {
            this.name = name;
            this.author = author;
            this.year = year;
        }

        public void GetInformation()
        {
            Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name, author, year);
        }
    }
}
