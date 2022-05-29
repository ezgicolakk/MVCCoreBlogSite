using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.CORE.Entities
{
    public class Article:BaseEntity
    {
        public string ArticleDate { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int ReadingCount { get; set; }
        public string Content { get; set; }
        public string ArticleUrl { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
