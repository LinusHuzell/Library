using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        /// <summary>
        /// Unique ID of book.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; private set; }
        /// <summary>
        /// Year when book is published.
        /// </summary>
        public double Year { get; set; }
        /// <summary>
        /// ISBN of book.
        /// </summary>
        public string ISBN { get; private set; }
        /// <summary>
        /// Title of book.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Description of book (optional).
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Author(s) of book.
        /// </summary>
        public virtual ICollection<Author> Authors { get; set; }
        /// <summary>
        /// Copies of book.
        /// </summary>
        public virtual ICollection<BookCopy> BookCopies { get; set; }

        // Constructors. -->.
        public Book() { }

        public Book(string _ISBN, string _Title, ICollection<Author> _Authors, double _Year, string _Description = "" )
        {
            this.ISBN = _ISBN;
            this.Title = _Title;
            this.Authors = _Authors;
            this.BookCopies = new List<BookCopy>();
            this.Year = _Year;
            this.Description = _Description;
        }
        // <-- Constructors.



        //Class methods. -->
        /// <summary>
        /// Concatinating all authors of the book separated with a comma to string.
        /// </summary>
        /// <returns>String with all authors of the book concatinated and separated by commas.</returns>
        public string AuthorsToString()
        {
            string output = "";
            int i = 1;
            foreach (Author author in Authors)
            {
                if (i != Authors.Count)
                {
                    output += $"{author.FirstName} {author.LastName}, ";
                    i++;
                }
                else
                    output += $"{author.FirstName} {author.LastName}";
            }
            return output;
        }

        /// <summary>
        /// Overriding ToString method to easy add book items to listboxes etc.
        /// </summary>
        public override string ToString() {
            return String.Format($"{this.Title}");
        }
        // <-- Class methods.
    }
}