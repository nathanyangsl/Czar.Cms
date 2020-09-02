using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample01.Controllers
{
    public class ContentController : Controller
    {
        // GET: /<controller>/
        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        //public IActionResult Index()
        //{
        //    //var contents = new List<Content>();
        //    //for (int i=1;i<11; i++)
        //    //{
        //    //    contents.Add(new Content { Id = i,title=$"{i}的标标题",content=$"{i}的内容",status=1,add_time = DateTime.Now.AddDays(-i) });

        //    //}
        //    //return View(new ContentViewModel { contents=contents});
        //    return View(new ContentViewModel { Contents = new List<Content> { contents } });
        //}
        private readonly Content contents;
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }
        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {

            return View(new ContentViewModel { contents = new List<Content> { contents } });
        }
    }
}
