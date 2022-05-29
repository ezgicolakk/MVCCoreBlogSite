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
    public class TopicService:GenericService<Topic>,ITopicService
    {
        private readonly ITopicRepostory topicRepository;
        public TopicService(ITopicRepostory topicRepository):base(topicRepository)
        {
            this.topicRepository = topicRepository;
        }

        public IEnumerable<Topic> GetAllIncludeAuthors()
        {
            return topicRepository.GetAllIncludeAuthors();
        }

        public Topic GetByIdIncludeArticle(int id)
        {
            return topicRepository.GetByIdIncludeArticle(id);
        }
    }

   
}
