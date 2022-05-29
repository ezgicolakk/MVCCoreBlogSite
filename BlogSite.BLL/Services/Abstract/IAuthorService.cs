using BlogSite.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BLL.Services.Abstract
{
    public interface IAuthorService:IService<Author>
    {
       
        IEnumerable<IAuthorService> GetAllIncludeArticles();
        IEnumerable<IAuthorService> GetAllIncludeTopics();
        Author GetByIdIncludeArticle(int id);
        Author GetByEmailAndPassword(string email, string password);
    }
}
