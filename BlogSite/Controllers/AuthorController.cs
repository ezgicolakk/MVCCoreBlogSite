using BlogSite.BLL.Services.Abstract;
using BlogSite.CORE.Entities;
using BlogSite.DAL.Abstract;
using BlogSite.DAL.Repositories.Abstract;
using BlogSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService authorService;
        private readonly IService<Article> articleService;

        public AuthorController(IAuthorService authorService, IService<Article> articleService)
        {
            this.authorService = authorService;
            this.articleService = articleService;

        }
        //GET:Authors
        public IActionResult Index()
        {
            var authors = authorService.GetAllIncludeArticles();
            return View(authors);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(LogInVM logInVm)
        {
            var author = authorService.GetByEmailAndPassword(logInVm.Email, logInVm.Password);
            if (author == null)
            {
                
                TempData["Message"] = "Giriş bilgileri hatalı";
                return View();
            }
            HttpContext.Session.SetString("authorname", author.Name);
            if (author.PhotoPath != null)
            {
                HttpContext.Session.SetString("picPath", author.PhotoPath);                   
            }
            TempData["Message"] = "Hoşgeldin";
            return RedirectToAction("Index", "Home");
        }
    }

}
