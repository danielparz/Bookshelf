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
        public List<Genre> genres;
        public Status BookStatus { get; set; }
    }
}
