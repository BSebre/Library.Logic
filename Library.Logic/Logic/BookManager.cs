using Library.Logic.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Library.Logic
{
    public class BookManager
    {
        public BookManager()
        {

        }

        //public Book AddNewBook(string title, string author, int year, int copies)
        //{
        //    //TODO: implement
        //    throw new NotImplementedException();
        //}
        /// <summary>
        /// Returns list of all available books
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAvailableBooks()
        {
            // Book list - shows all the available books in the library (ordered by title). 
            // Corresponding message if there are no more books in the list.
            using (var db = new LibraryDB())
            {
                return db.Books.Where(b => b.Copies > 0).OrderBy(b => b.Title).ToList();
            }
        }

        /// <summary>
        /// User's books
        /// </summary>
        /// <returns></returns>
        public List<UserBook> GetUserBooks()
        {
            using (var db = new LibraryDB())
            {
                return db.UserBooks.OrderBy(b => b.Title).ToList();
            }
        }

        /// <summary>
        /// Take a book
        /// </summary>
        /// <param name="title">Book's title</param>
        /// <returns></returns>
        public Book TakeBook(string title)
        {
            // Take - user takes a book providing its title. Validation if book exists. Validation if book is
            // still available(check number of copies). Book is added to the user's list and available
            // book count is decreased.
            using (var db = new LibraryDB())
            {
                // 1. Look for book inside table 'Books' by Title
                var book = db.Books.FirstOrDefault(b => b.Title.ToLower() == title.ToLower());
                // 2. If book is found and is still available:
                if (book != null && book.Copies > 0)
                {
                    // 2.1. Decrease available copies
                    book.Copies--;
                    // 2.2. Insert new record in table 'UserBooks'
                    db.UserBooks.Add(new UserBook()
                    {
                        Author = book.Author,
                        Title = book.Title,
                        Year = book.Year,
                    });

                    db.SaveChanges();

                    return book;
                }
            }

            return null;
        }

        /// <summary>
        /// User returns a book
        /// </summary>
        /// <param name="title">Book's title</param>
        /// <returns>Book returned (if found)</returns>
        public UserBook ReturnBook(string title)
        {
            // Return - user returns a book providing its title. Validation if the book is in the user’s list.
            // Book is removed from the user’s list and the available count is increased.
            // 1. Use the DB
            // 2. Find the book in 'UserBooks' by title
            // 3. If book is found:
            // 3.1. Delete it from 'UserBooks'
            // 3.2. Increase Copies count for the same book inside the 'Books' table
            using (var db = new LibraryDB())
            {
                var userBook = db.UserBooks.FirstOrDefault(b => b.Title.ToLower() == title.ToLower());
                if (userBook != null)
                {
                    db.UserBooks.Remove(userBook);

                    // increase availabe count
                    var libraryBook = db.Books.FirstOrDefault(b => b.Title.ToLower() == title.ToLower());
                    libraryBook.Copies++;

                    db.SaveChanges();

                    return userBook;
                }
            }

            return null;
        }
    }
}
