using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testCSharp.Controllers
{
    public class HomeController : Controller
    {
        private string FilePath
        {
            get { return Server.MapPath("~/App_Data/UserContent.txt"); }
        }

        public ActionResult Index()
        {
            var contentList = LoadContent();
            return View(contentList);
        }

        [HttpPost]
        public ActionResult AddContent(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                SaveContent(content);
            }
            return RedirectToAction("Index");
        }

        private void SaveContent(string content)
        {
            System.IO.File.AppendAllText(FilePath, content + "\n");
        }

        private List<string> LoadContent()
        {
            if (System.IO.File.Exists(FilePath))
            {
                return System.IO.File.ReadAllLines(FilePath).ToList();
            }
            return new List<string>();
        }
    }
}