using BlogSite.CORE.Entities;
using BlogSite.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DAL.Repositories.Abstract
{
   public interface IArticleRepository:IRepository<Article>
    {
        IEnumerable<Article> GetAllIncludeTopics();
        Article GetByIdIncludeAuthor(int id);
       

    }
}
