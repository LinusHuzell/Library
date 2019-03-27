using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class MemberRepository : IRepository<Member, int>
    {
        LibraryContext context;

        public MemberRepository (LibraryContext c)
        {
            this.context = c;
        }


        /// <summary>
        /// Gets all member objects from database.
        /// </summary>
        /// <param name="member"></param>
        public void Add(Member member)
        {
            context.Members.Add(member);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all member objects from database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Member> All()
        {
            return context.Members;
        }

        /// <summary>
        /// Edits the member object in database.
        /// </summary>
        /// <param name="member">Member object to be edited.</param>
        public void Edit(Member member)
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Finds the member searched for in database, by id.
        /// </summary>
        /// <param name="id">ID of member object to search for in database.</param>
        /// <returns></returns>
        public Member Find(int id)
        {
            return context.Members.Find(id);
        }

        /// <summary>
        /// Removes member object from database.
        /// </summary>
        /// <param name="member">Member object to be removed from database.</param>
        public void Remove(Member member)
        {
            context.Members.Remove(member);
            context.SaveChanges();
        }
    }
}