using System;
using Library_Management_System;

class Program
{
    static void Main()
    {
        LibraryManager manager = new LibraryManager();

        manager.AddBook(new Book(1, "The Tale of Two Cities", "Charles Darwin"));
        manager.AddBook(new Book(2, "Huckelburry Fin", "Mark Twain"));
        manager.AddBook(new Book(3, "The Night train at Deoli", "Ruskin Bond"));

        Console.WriteLine("All Books:");
        manager.DisplayAllBooks();

        Console.WriteLine("\nSearching using Linear Search:");
        var linearResult = manager.LinearSearchByTitle("The Tale of Two Cities");
        Console.WriteLine(linearResult != null ? linearResult.ToString() : "Book not found");

        Console.WriteLine("\nSearching using Binary Search:");
        var binaryResult = manager.BinarySearchByTitle("Huckelburry Fin");
        Console.WriteLine(binaryResult != null ? binaryResult.ToString() : "Book not found");
    }
}
