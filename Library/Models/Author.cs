using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author
    {
        /// <summary>
        /// Unique ID of author.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { get; private set; }
        /// <summary>
        /// First name of author.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of author.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// List of books written by author.
        /// </summary>
        public virtual ICollection<Book> Books { get; set; }

        // Constructors. -->
        public Author() { }

        public Author(string _FirstName, string _LastName)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            Books = new List<Book>();
        }
        // <-- Constructors.



        // Class methods. -->
        /// <summary>
        /// Overriding ToString methord to easy add author items to listboxes etc.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"{FirstName} {LastName}");
        }
        // <-- Class methods.
    }
}
