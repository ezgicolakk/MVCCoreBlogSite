using BlogSite.BLL.Services.Abstract;
using BlogSite.CORE.Entities;
using BlogSite.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BLL.Services.Concrete
{ 
    public class ArticleService:GenericService<Article>,IArticleService
    {
        private readonly IArticleRepository articleRepository;
        public ArticleService(IArticleRepository articleRepository):base(articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public IEnumerable<Article> GetAllIncludeTopics()
        {
            return articleRepository.GetAllIncludeTopics();
        }

        public Article GetByIdIncludeAuthor(int id)
        {
            return articleRepository.GetByIdIncludeAuthor(id);
        }
    }
}
