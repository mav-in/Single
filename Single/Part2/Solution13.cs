using System;

namespace Single.Part2
{
    public class Solution13
    {
        public static void Execute()
        {
            // СТРУКТУРЫ

            Book book;
            book.name = "Война и мир";
            book.author = "Л. Н. Толстой";
            book.year = 1869;

            //Выведем информацию о книге book на экран
            book.Info();

            //Использование массива
            Book[] books = new Book[3];
            books[0].name = "Война и мир";
            books[0].author = "Л. Н. Толстой";
            books[0].year = 1869;

            books[1].name = "Преступление и наказание";
            books[1].author = "Ф. М. Достоевский";
            books[1].year = 1866;

            books[2].name = "Отцы и дети";
            books[2].author = "И. С. Тургенев";
            books[2].year = 1862;

            foreach (Book b in books)
            {
                b.Info();
            }

            //Конструкторы в структурах
            Book book3 = new Book("Война и мир", "Л. Н. Толстой", 1869);
            book3.Info();

            Console.ReadLine();
        }
    }

    struct Book
    {
        public string name;
        public string author;
        public int year;

        // конструкор
        public Book(string n, string a, int y)
        {
            name = n;
            author = a;
            year = y;
        }

        public void Info() {
            Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name, author, year);
        }
    }
}
