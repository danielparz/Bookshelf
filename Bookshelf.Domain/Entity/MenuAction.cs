using Bookshelf.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshelf.Domain.Entity
{
    public class MenuAction : BaseEntity
    {
        public string Name { get; set; }
        public string MenuName { get; set; }
    }
}
