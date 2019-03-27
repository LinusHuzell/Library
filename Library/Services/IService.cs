using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;

namespace Library.Services {
    /// <summary>
    /// Allows services to notify when their
    /// underlying data model changes.
    /// </summary>
    interface IService<T> {
        event EventHandler Updated;
        void OnUpdated(object sender, EventArgs e);

        void Add(T item);
        IEnumerable<T> All();
        T Find(int id);
        void Edit(T item);
        void Remove(T item);
    }
}
