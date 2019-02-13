using Comics.Models;
using Comics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comics.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicRepository;

        public ComicBooksController()
        {
            _comicRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicRepository.GetComicBook((int)(id));
            if (comicBook == null)
            {
                return HttpNotFound();
            }
            return View(comicBook);
        }

        public ActionResult Index()
        {
            return View(_comicRepository.GetComicBooks());
        }
    }
}
