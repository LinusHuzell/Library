using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Member
    {
        /// <summary>
        /// Unique ID of member.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberID { get; private set; }
        /// <summary>
        /// Personal id of the member.
        /// </summary>
        [Column(TypeName = "VARCHAR")]
        [StringLength(13)]
        [Index(IsUnique = true)]
        public string PersonalID { get; private set; }
        /// <summary>
        /// The username of the member's account.
        /// </summary>
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string Username { get; set; }
        /// <summary>
        /// The first name of the member.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of the member.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The date and time of when the member was registrated to the service.
        /// </summary>
        public virtual DateTime? Registered { get; private set; }
        /// <summary>
        /// A list of loans made by member.
        /// </summary>
        public virtual ICollection<Loan> Loans { get; set; }

        // Constructors. -->
        public Member() { }

        public Member(string _PersonalID, string _Username, string _FirstName, string _LastName, DateTime? _Registered = null)
        {
            PersonalID = _PersonalID;
            Username = _Username;
            FirstName = _FirstName;
            LastName = _LastName;
            if (_Registered == null)
                Registered = DateTime.Now;
            else
                Registered = _Registered;
            
            Loans = new List<Loan>();
        }
        // <-- Constructors.



        // Class methods. --> 
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
        // <-- Class methods.
    }
}
