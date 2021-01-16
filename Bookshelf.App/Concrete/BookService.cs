using Bookshelf.App.Common;
using Bookshelf.Domain.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bookshelf.App.Concrete
{
    public class BookService : BaseService<Book>
    {
        public BookService()
        {
            
        }
        
        public int AddBook(string title, Author author, PublishingHouse publisher, int pages, int publishedYear, List<Genre> genres, Status status)
        {
            var book = new Book()
            {
                Id = GetLastId() + 1,
                Title = title,
                BookAuthor = author,
                Publisher = publisher,
                Pages = pages,
                PublishedYear = publishedYear,
                Genres = genres,
                BookStatus = status
            };
            return AddItem(book);
        }
    }
}
