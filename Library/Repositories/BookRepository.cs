using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookRepository : IRepository<Book, int>
    {
        LibraryContext context;

        public BookRepository(LibraryContext c)
        {
            this.context = c;
        }


        /// <summary>
        /// Adds book object to the database.
        /// </summary>
        /// <param name="book">Book object to be added to databse.</param>
        public void Add(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }


        /// <summary>
        /// Gets all book objects from database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> All()
        {
            return context.Books;
        }

        /// <summary>
        /// Edits the book object in database.
        /// </summary>
        /// <param name="book">This is the object to be edited.</param>
        public void Edit(Book book)
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Finds the book searched for in database, by id.
        /// </summary>
        /// <param name="id">ID of book object to search for in database.</param>
        /// <returns>The book searched for. Null if not found.</returns>
        public Book Find(int id)
        {
            return context.Books.Find(id);
        }

        /// <summary>
        /// Removes book object from database.
        /// </summary>
        /// <param name="book">Book object to be removed from database.</param>
        public void Remove(Book book)
        {
            context.Books.Remove(book);
            context.SaveChanges();   
        }
    }
}