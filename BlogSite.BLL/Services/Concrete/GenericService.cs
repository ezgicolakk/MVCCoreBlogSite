using BlogSite.BLL.Services.Abstract;
using BlogSite.CORE.Entities;
using BlogSite.DAL.Abstract;
using BlogSite.DAL.Concrete;
using BlogSite.DAL.Repositories.Abstract;
using BlogSite.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BLL.Services.Concrete
{
    public class GenericService<T> : IService<T> where T : BaseEntity
    {
        private IRepository<T> genericRepository;
       
        public GenericService(IRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public bool Add(T entity)
        {
            try
            {
                bool result = genericRepository.Add(entity);
                return result;
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
                bool result = genericRepository.Delete(entity);
                return result;
            }
            catch
            {

                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return genericRepository.GetAll();
        }

        public T GetById(int id)
        {
            return genericRepository.GetById(id);
        }

        public bool Update(T entity)
        {
            try
            {
                bool result = genericRepository.Update(entity);
                return result;

            }
            catch 
            {

                return false;
            }
        }
    }
}
