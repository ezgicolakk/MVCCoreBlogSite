using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.CORE.Entities
{
    public class Topic:BaseEntity
    {
        public string Name { get; set; }
        public Topic()
        {
            Articles = new HashSet<Article>();
            Authors = new HashSet<Author>();
        }
        public ICollection<Article> Articles { get; set; }
       
        public ICollection<Author> Authors { get; set; }
    }
}
