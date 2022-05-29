using BlogSite.CORE.Entities;
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
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        private readonly BlogSiteDbContext db;
        public ArticleRepository(BlogSiteDbContext db) : base(db)
        {
            this.db = db;
        }
        public IEnumerable<Article> GetAllIncludeTopics()
        {
            return db.Articles.Include(s => s.Topic);
        }

        public Article GetByIdIncludeAuthor(int id)
        {
            return db.Articles.Include(s => s.Author).FirstOrDefault(a => a.Id == id);
        }
    }
}
