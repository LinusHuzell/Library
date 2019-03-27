using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext context;

        public AuthorRepository(LibraryContext c)
        {
            this.context = c;
        }


        /// <summary>
        /// Adds author object to databse.
        /// </summary>
        /// <param name="author">Author object to be added to databse.</param>
        public void Add(Author author)
        {
            context.Authors.Add(author);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all author objects from database.
        /// </summary>
        /// <returns>Returns all author objects from database.</returns>
        public IEnumerable<Author> All()
        {
            return context.Authors;
        }

        /// <summary>
        /// Edits the author object in database.
        /// </summary>
        /// <param name="author">Author object to be edited.</param>
        public void Edit(Author author)
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Finds the author searched for in database, by id.
        /// </summary>
        /// <param name="id">ID of author object to search for in database.</param>
        /// <returns>The author searched for. Null if not found.</returns>
        public Author Find(int id)
        {
            return context.Authors.Find(id);
        }

        /// <summary>
        /// Removes author object from database.
        /// </summary>
        /// <param name="author">Author object to be removed from database.</param>
        public void Remove(Author author)
        {
            context.Authors.Remove(author);
            context.SaveChanges();
        }
    }
}