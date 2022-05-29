using BlogSite.CORE.Entities;
using BlogSite.DAL.Abstract;
using BlogSite.DAL.Concrete;
using BlogSite.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DAL.Repositories.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly BlogSiteDbContext db;
        private IAuthorRepository authorRepository;

        public GenericRepository(BlogSiteDbContext db)
        {
            this.db = db;
        }

        public GenericRepository(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public bool Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {

                return false;
            }
        }


        public bool Delete(T entity)
        {
            try
            {
                db.Set<T>().Remove(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {

                return false;
            }
        }


        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }


        public T GetById(int id)
        {
            return db.Set<T>().FirstOrDefault(a => a.Id == id);
        }


        public bool Update(T entity)
        {
            try
            {
                db.Set<T>().Update(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {

                return false;
            }
        }
    }
}
