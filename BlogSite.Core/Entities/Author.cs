using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.CORE.Entities
{
    
    public class Author:BaseEntity
    {
        public string Name { get; set; }       
        public string Surname { get; set; }        
        public string AuthorAbout { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public IFormFile Photo { get; set; }
        public string PhotoPath  { get; set; }

        public Author()
        {
            Articles = new HashSet<Article>();
            Topics = new HashSet<Topic>();
        }
        public ICollection<Article> Articles { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}
