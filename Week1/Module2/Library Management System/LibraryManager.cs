using System;
using System.Collections.Generic;


namespace Library_Management_System
{
    public class LibraryManager
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

       
        public Book? LinearSearchByTitle(string title)
        {
            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return book;
                }
            }
            return null;
        }

        
        public Book? BinarySearchByTitle(string title)
        {
            books.Sort((b1, b2) => string.Compare(b1.Title, b2.Title, StringComparison.OrdinalIgnoreCase));

            int left = 0;
            int right = books.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(title, books[mid].Title, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return books[mid];
                else if (comparison < 0)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return null;
        }

        public void DisplayAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
