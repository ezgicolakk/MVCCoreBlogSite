using BlogSite.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BLL.Services.Abstract
{
    public interface ITopicService:IService<Topic>
    {
        IEnumerable<Topic> GetAllIncludeAuthors();
        Topic GetByIdIncludeArticle(int id);
    }
}
