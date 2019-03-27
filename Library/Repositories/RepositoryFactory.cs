using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class RepositoryFactory
    {
        private LibraryContext context;

        /// <param name="c">A Librarycontext that will be shared among repositories</param>
        public RepositoryFactory(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Creates a book repository from set context.
        /// </summary>
        /// <returns>Book repository with set context.</returns>
        public BookRepository CreateBookRepository()
        {
            return new BookRepository(context);
        }

        /// <summary>
        /// Creates a book copy repository from set context.
        /// </summary>
        /// <returns>Book copy repository with set context.</returns>
        public BookCopyRepository CreateBookCopyRepository()
        {
            return new BookCopyRepository(context);
        }

        /// <summary>
        /// Creates a author repository from set context.
        /// </summary>
        /// <returns>Author repository with set context.</returns>
        public AuthorRepository CreateAuthorRepository()
        {
            return new AuthorRepository(context);
        }

        /// <summary>
        /// Creates a member repository from set context.
        /// </summary>
        /// <returns>Member repository with set context.</returns>
        public MemberRepository CreateMemberRepository()
        {
            return new MemberRepository(context);
        }

        /// <summary>
        /// Creates a loan repository from set context.
        /// </summary>
        /// <returns>Loan repository with set context.</returns>
        public LoanRepository CreateLoanRepository()
        {
            return new LoanRepository(context);
        }
    }
}
