using Bookshelf.App.Abstract;
using Bookshelf.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshelf.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Books { get; set; }

        public BaseService()
        {
            Books = new List<T>();
        }

        public int AddBook(T book)
        {
            Books.Add(book);
            return book.Id;
        }

        public List<T> GetAllBooks()
        {
            return Books;
        }

        public void RemoveBook(T book)
        {
            Books.Remove(book);
        }

        public int UpdateBook(T book)
        {
            var entity = Books.FirstOrDefault(p => p.Id == book.Id);
            if (entity != null)
            {
                entity = book;
            }
            return entity.Id;
        }
    }
}
