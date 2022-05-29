using BlogSite.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BLL.Services.Abstract
{
    public interface IArticleService:IService<Article>
    {
        IEnumerable<Article> GetAllIncludeTopics();
        Article GetByIdIncludeAuthor(int id);
    }
}
