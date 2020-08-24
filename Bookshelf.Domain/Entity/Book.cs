using Bookshelf.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshelf.Domain.Entity
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }       
        public Author BookAuthor { get; set; }
        public PublishingHouse Publisher { get; set; }
        public int Pages { get; set; }
        public int PublishedYear { get; set; }
        public List<Genre> Genres { get; set; }
        public Status BookStatus { get; set; }

        public Book()
        {
            Genres = new List<Genre>();
        }
    }
}
