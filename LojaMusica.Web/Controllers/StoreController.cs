using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaMusica.Web.Models;

namespace LojaMusica.Web.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            List<Genre> genres = new List<Genre>()
            {
                new Genre {Name = "Samba"},
                new Genre {Name = "Bossa nova"},
                new Genre {Name = "Rock"}
            };
            
            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre { Name = genre };

            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            Album album = new Album { Title = "Album " + id };

            return View(album);
        }

    }
}
