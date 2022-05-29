using BlogSite.CORE.Entities;
using BlogSite.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DAL.Repositories.Abstract
{
    public interface ITopicRepostory:IRepository<Topic>
    {
        IEnumerable<Topic> GetAllIncludeAuthors();
        Topic GetByIdIncludeArticle(int id);
        

    }
}
