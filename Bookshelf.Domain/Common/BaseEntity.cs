using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshelf.Domain.Entity
{
    public class BaseEntity : AuditableModel
    {
        public int Id { get; set; }
    }
}
