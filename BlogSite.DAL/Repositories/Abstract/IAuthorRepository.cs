using BlogSite.CORE.Entities;
using BlogSite.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DAL.Repositories.Abstract
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAllIncludeArticles();
        IEnumerable<Author> GetAllIncludeTopics();
        Author GetByIdIncludeArticle(int id);
        Author GetByEmailAndPassword(string email, string password);
    }
}
