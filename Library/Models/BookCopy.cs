using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookCopy
    {
        /// <summary>
        /// Unique ID of book copy.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookCopyID { get; private set; }
        /// <summary>
        /// Book which the copy is a copy of.
        /// </summary>
        public virtual Book Book { get; private set; }

        // Constructors. -->
        public BookCopy() { }

        public BookCopy(Book _Book)
        {
            this.Book = _Book;
        }
        // <-- Constructors.



        // Class methods. -->
        /// <summary>
        /// Overriding ToString method to easy add book copy items to listboxes etc.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return BookCopyID.ToString();
        }
        // <-- Class methods.
    }
}
