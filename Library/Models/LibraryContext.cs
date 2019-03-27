using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Models {
    /// <summary>
    /// Derived context.
    /// </summary>
    public class LibraryContext : DbContext
    {
        public LibraryContext(){
            // Database strategy.
            Database.SetInitializer<LibraryContext>(new LibraryDbInit());
        }
        // Lists that sets the database.
        /// <summary>
        /// Authors stored in database.
        /// </summary>
        public DbSet<Author> Authors { get; set; }
        /// <summary>
        /// Books stored in database.
        /// </summary>
        public DbSet<Book> Books { get; set; }
        /// <summary>
        /// Book copes stored in database.
        /// </summary>
        public DbSet<BookCopy> BookCopies { get; set; }
        /// <summary>
        /// Loans stored in database.
        /// </summary>
        public DbSet<Loan> Loans { get; set; }
        /// <summary>
        /// Members stored in database.
        /// </summary>
        public DbSet<Member> Members { get; set; }

        // If you want to try or need to (some use cases) use fluent API this is the place!
        // Reference: http://blogs.msdn.com/b/adonet/archive/2010/12/14/ef-feature-ctp5-fluent-api-samples.aspx
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}