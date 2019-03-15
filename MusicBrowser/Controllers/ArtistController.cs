using MusicBrowser.DAL;
using MusicBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicBrowser.Controllers
{
    public class ArtistController : Controller
    {
        private ArtistsContext db = new ArtistsContext();
        public ActionResult YourArtists()
        {
            return View(db.Artists);
        }

        [ChildActionOnly]
        public ActionResult ArtistList(int choice)
        {

            List<Artist> artists;

            switch(choice)
            {

                case 1: artists = db.Artists.OrderBy(a => a.Name).ToList(); break;
                case 2: artists = db.Artists.OrderByDescending(a => a.Name).ToList(); ; break;
                case 3: artists = db.Artists.OrderByDescending(a => a.Listeners).ToList(); break;




                default: artists = null; break;
            }

            return PartialView("_ArtistList", artists);
        }

        public ActionResult SearchArtist()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}