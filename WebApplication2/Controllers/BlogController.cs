using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Blogs()
        {
            var Blogs = new List<BlogModel>
                {
                 new BlogModel()
                {
                    AuthorName = "Atakan",
                    BlogName = ".NET Ögreniyorum",
                    BlogCategory = "Eğitim"
                },
                new BlogModel
                {
                    AuthorName = "Eylül",
                    BlogName = "Dapper ORM Nedir?",
                    BlogCategory = "Eğitim",
        },
                };
            var Readers = new List<ReaderModel>
            {
                new ReaderModel
                {
                    ReaderName = "Zehra",
                   CheckinTime =  new DateTime(2020, 07, 25),
                   FavouriteCategory = "Physics"
                },
                new ReaderModel
                {
                   ReaderName = "Bertan",
                   CheckinTime =  new DateTime(2021, 04, 06),
                   FavouriteCategory = "Video Games"
                },
               new ReaderModel
                {
                   ReaderName = "Serbülent",
                   CheckinTime =  new DateTime(2019, 04, 08),
                   FavouriteCategory = "Theatre"
                },
                new ReaderModel
                {
                    ReaderName = "Beyza",
                   CheckinTime =  new DateTime(2020, 11, 17),
                   FavouriteCategory = "Literature"
                },
            };
            BlogDetailsViewModel Model = new BlogDetailsViewModel();
            Model.Readers = Readers;
            Model.Blogs = Blogs;
            return View(Model);
        }
        public IActionResult Example()
        {
            return View();
        }
 
    }
}
