using BlogSite.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Models
{
    public class AuthorVM
    {
        public IEnumerable<Author> Authors { get; set; }
    }
}
