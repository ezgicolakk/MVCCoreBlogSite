using BlogSite.CORE.Entities;
using BlogSite.DAL.Abstract;
using BlogSite.DAL.Concrete;
using BlogSite.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DAL.Repositories.Concrete
{
    public class TopicRepository : GenericRepository<Topic>,ITopicRepostory
    {
        private readonly BlogSiteDbContext db;
        public TopicRepository(BlogSiteDbContext db) : base(db)
        {
            this.db = db;
        }

        public IEnumerable<Topic> GetAllIncludeAuthors()
        {
            return db.Topics.Include(s => s.Authors);
        }

        public IEnumerable<Topic> GetAllIncludeTopics()
        {
            return db.Topics.Include(s => s.Articles);
        }

        public Topic GetByIdIncludeArticle(int id)
        {
            return db.Topics.Include(s => s.Articles).FirstOrDefault(a => a.Id == id);
        }

       

    }
}
