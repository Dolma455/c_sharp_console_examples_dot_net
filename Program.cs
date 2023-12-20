// using System;
// using System.Collections.Generic;

// // Base class for common properties/methods
// class LibraryItem
// {
//     public string Title { get; set; }
//     public string Genre { get; set; }

//     // Add other common properties/methods
// }

// // Interface for borrowable items
// interface IBorrowable
// {
//     void Borrow();
//     void Return();
// }

// // Interface for displayable items
// interface IDisplayable
// {
//     void DisplayDetails();
// }

// // Book class
// class Book : LibraryItem, IBorrowable, IDisplayable
// {
//     public string Author { get; set; }
//     public string ISBN { get; set; }
//     public bool Availability { get; set; } = true;

//     // Implement IBorrowable interface
//     public void Borrow()
//     {
//         if (Availability)
//         {
//             Availability = false;
//             // Add logic to update member's borrowed books list
//         }
//         else
//         {
//             Console.WriteLine("Book is not available for borrowing.");
//         }
//     }

//     // Implement IBorrowable interface
//     public void Return()
//     {
//         Availability = true;
//         // Add logic to update member's borrowed books list
//     }

//     // Implement IDisplayable interface
//     public void DisplayDetails()
//     {
//         Console.WriteLine($"Book: {Title} by {Author}, ISBN: {ISBN}, Availability: {(Availability ? "Available" : "Not Available")}");
//     }

//     // Override ToString method
//     public override string ToString()
//     {
//         return $"{Title} by {Author}";
//     }
// }

// // Author class
// class Author : LibraryItem, IDisplayable

// {
//     public DateTime BirthDate { get; set; }
//     public List<Book> BooksWritten { get; set; } = new List<Book>();

//     // Implement IDisplayable interface
//     public void DisplayDetails()
//     {
//         Console.WriteLine($"Author: {Title} (Born on {BirthDate.ToShortDateString()})");
//     }
// }

// // LibraryMember class
// class LibraryMember : IDisplayable
// {
//     public int MemberID { get; set; }
//     public string Name { get; set; }
//     public List<Book> BorrowedBooks { get; set; } = new List<Book>();

//     // Implement IDisplayable interface
//     public void DisplayDetails()
//     {
//         Console.WriteLine($"Member ID: {MemberID}, Name: {Name}");
//     }
// }

// // Library class
// class Library
// {
//     private List<Book> books = new List<Book>();
//     private List<Author> authors = new List<Author>();
//     private List<LibraryMember> members = new List<LibraryMember>();

//     // Implement indexers
//     public Book this[int bookID] => books.Find(book => book.GetHashCode() == bookID);
//     public LibraryMember this[int memberID] => members.Find(member => member.MemberID == memberID);

//     // AddBook method overloading
//     public void AddBook(Book book)
//     {
//         books.Add(book);
//     }

//     // RemoveBook method
//     public void RemoveBook(Book book)
//     {
//         books.Remove(book);
//     }

//     // AddAuthor method
//     public void AddAuthor(Author author)
//     {
//         authors.Add(author);
//     }

//     // RemoveAuthor method
//     public void RemoveAuthor(Author author)
//     {
//         authors.Remove(author);
//     }

//     // AddMember method
//     public void AddMember(LibraryMember member)
//     {
//         members.Add(member);
//     }

//     // RemoveMember method
//     public void RemoveMember(LibraryMember member)
//     {
//         members.Remove(member);
//     }

//     // DisplayLibraryStatus method
//     public void DisplayLibraryStatus()
//     {
//         Console.WriteLine("Library Status:");
//         // Add logic to display the status of books, authors, and members
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create instances of classes and demonstrate functionality
//         // ...
//     }
// }
