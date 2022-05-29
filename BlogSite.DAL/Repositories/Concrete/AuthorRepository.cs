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
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        private readonly BlogSiteDbContext db;
        public AuthorRepository(BlogSiteDbContext db):base(db)
        {
            this.db = db;   
        }
        public IEnumerable<Author> GetAllIncludeArticles()
        {
            return db.Authors.Include(s => s.Articles);
        }

        public Author GetByIdIncludeArticle(int id)
        {
            return db.Authors.Include(s=>s.Articles).FirstOrDefault(a => a.Id == id);
        }

        public Author GetByEmailAndPassword(string email, string password)
        {
            return db.Authors.FirstOrDefault(a => a.Email == email && a.Password == password);
        }

        public IEnumerable<Author> GetAllIncludeTopics()
        {
            return db.Authors.Include(s => s.Topics);
        }
    }
}
