using BlogSite.BLL.Services.Abstract;
using BlogSite.CORE.Entities;
using BlogSite.DAL.Repositories.Abstract;
using BlogSite.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BLL.Services.Concrete
{
    public class AuthorService: GenericService<Author>, IAuthorService 
    {
        private readonly IAuthorRepository authorRepository;
        public AuthorService(IAuthorRepository authorRepository):base(authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public IEnumerable<IAuthorService> GetAllIncludeArticles()
        {
            return (IEnumerable<IAuthorService>)authorRepository.GetAllIncludeArticles();
        }

        public IEnumerable<IAuthorService> GetAllIncludeTopics()
        {
            return (IEnumerable<IAuthorService>)authorRepository.GetAllIncludeTopics();
        }

        public Author GetByEmailAndPassword(string email, string password)
        {
            return authorRepository.GetByEmailAndPassword(email, password);
        }

        public Author GetByIdIncludeArticle(int id)
        {
            return authorRepository.GetByIdIncludeArticle(id);
        }
    }
}
