using Bookshelf.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshelf.Domain.Entity
{
    public class Author : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Book> Books;
    }
}
