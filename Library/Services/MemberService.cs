using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace Library.Services
{
    public class MemberService : IService<Member>
    {
        /// <summary>
        /// Member repository with set context.
        /// </summary>
        MemberRepository MemberRepository;

        /// <summary>
        /// Event that's triggered whenever a member is updated.
        /// </summary>
        public event EventHandler Updated;

        //Constructor. -->
        /// <summary>
        /// Member service that handles all members.
        /// </summary>
        /// <param name="rFactory">The Repositrory Factory useed.</param>
        public MemberService (RepositoryFactory rFactory)
        {
            this.MemberRepository = rFactory.CreateMemberRepository();
        }
        // <-- Constructor.

        /// <summary>
        /// Triggers all subscribers of the event.
        /// </summary>
        public void OnUpdated(object sender, EventArgs e)
        {
            Updated?.Invoke(sender, e);
        }

        // Standard query-methods implemented by the IService interface (CRUD functions). -->
        /// <summary>
        /// Validates and sends a member object to repository for adding to database and then raises the OnUpdated event.
        /// </summary>
        /// <param name="member">Member object to be added to database.</param>
        public void Add(Member member)
        { 
            ValidateInputs(member, true);
            MemberRepository.Add(member);
            OnUpdated(member, EventArgs.Empty);
        }

        /// <summary>
        /// Get all members from database.
        /// </summary>
        /// <returns>A list of all members in database.</returns>
        public IEnumerable<Member> All()
        {
            return MemberRepository.All().OrderBy(member => member.FirstName);
        }

        /// <summary>
        /// Finds a specific member in database from a specific ID.
        /// </summary>
        /// <param name="id">ID of member to find</param>
        /// <returns>The member object fround by ID.</returns>
        public Member Find(int id)
        {
            return MemberRepository.Find(id);
        }

        /// <summary>
        /// Validates and sends a specific member object to repository for editing in database and then raises the OnUpdated event.
        /// </summary>
        /// <param name="member">Member object to edit in database.</param>
        public void Edit(Member member)
        {
            ValidateInputs(member, false);
            try
            {
                MemberRepository.Edit(member);
                OnUpdated(member, EventArgs.Empty);
            }
            catch (DbUpdateException)
            {
                throw new OperationCanceledException("This username is currently in use by another member!");
            }
        }

        /// <summary>
        /// Removes a chosen member from database.
        /// </summary>
        /// <param name="member">Member object to be removed.</param>
        public void Remove(Member member)
        {
            MemberRepository.Remove(member);
            OnUpdated(member, EventArgs.Empty);
        }
        // <-- Standard query-methods implemented by the IService interface.

        // Specific query-methods for this service. -->
        /// <summary>
        /// Filters all members by name from an entered value. Works as a search method.
        /// </summary>
        /// <param name="name">Value to search member names with.</param>
        /// <returns>A list of all member searched for.</returns>
        public IEnumerable<Member> Filter(string name)
        {
            return All().Where(member => member.ToString().ToLower().Contains(name.ToLower()));
        }

        /// <summary>
        /// Checks if the personal-ID already exists in database.
        /// </summary>
        /// <param name="personalID">Personal-ID to check in database.</param>
        /// <returns></returns>
        public bool PersonalIDExists(string personalID)
        {
            if (All().Where(member => member.PersonalID == personalID).Count() == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Checks if the username already exists in database.
        /// </summary>
        /// <param name="username">Username to check in database.</param>
        /// <returns></returns>
        public bool UsernameExists(string username)
        {
            if (All().Where(member => member.Username == username).Count() == 0)
                return false;
            else
                return true;
        }
        // <-- Specific query-methods for this service. 

        // Local methods for this service. -->
        /// <summary>
        /// Validates inputs for a member that's going to be sent to database.
        /// </summary>
        /// <param name="member">Member that is going to be validated.</param>
        /// <param name="add">Checks if there is an add operation running.</param>
        private void ValidateInputs(Member member, bool add)
        {
            // Regex for checking inputs.
            Regex regexPersonalID = new Regex(@"^[0-9]{6}[-][0-9]{4}$");
            Regex regexUsername = new Regex(@"[a-zA-Z0-9_]$");
            Regex regexName = new Regex(@"[a-zåäöA-ZÅÄÖ]$");

            // Check personal id.
            if (add && !regexPersonalID.IsMatch(member.PersonalID))
                throw new OperationCanceledException("Please enter the personal ID in right format: YYMMDD-XXXX");
            if (add && PersonalIDExists(member.PersonalID))
                throw new OperationCanceledException("This member is already registered!");

            // Check username.
            if (UsernameExists(member.Username) && add)
                throw new OperationCanceledException("This username is already in use!");
            if (!regexUsername.IsMatch(member.Username))
                throw new OperationCanceledException("The username can only contain characters a-z and 0-9");

            // Check name.
            if (!regexName.IsMatch(member.FirstName) || !regexName.IsMatch(member.LastName))
                throw new OperationCanceledException("The name can only contain letters a-ö");
        }
        // <-- Local methods for this service.

        // Public methods for this service. -->
        /// <summary>
        /// Calculates the total debt of all loans made by member.
        /// </summary>
        /// <param name="member">Member to calculate debt for.</param>
        /// <returns></returns>
        public double CalculateTotalDebt(Member member)
        {
            return member.Loans.Sum(loan => loan.Debt);
        }
        // <-- Public methods for this service.
    }
}
