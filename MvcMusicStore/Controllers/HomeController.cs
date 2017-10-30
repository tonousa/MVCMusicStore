using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private MusicStoreDB storeDB = new MusicStoreDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I like silence.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Search(string q)
        {
            var albums = storeDB.Albums
                .Include("Artist")
                .Where(a => a.Title.Contains(q))
                .Take(10);

            return View(albums);
        }

        [HttpGet]
        public PartialViewResult DailyDeal()
        {
            var album = GetDailyDeal();
            return PartialView("_DailyDeal", album);
        }

        // Select an album and discount it by 50%
        private Album GetDailyDeal()
        {
            var album = storeDB.Albums
                .OrderBy(a => System.Guid.NewGuid())
                .First();

            album.Price += 0.5m;
            return album;
        }

        public PartialViewResult ArtistSearch(string q)
        {
            var artists = GetArtists(q);
            return PartialView(artists);
        }

        private List<Artist> GetArtists(string searchString)
        {
            return storeDB.Artists
                .Where(a => a.Name.Contains(searchString))
                .ToList();
        }

        public ActionResult QuickSearch(string term)
        {
            var artists = GetArtists(term).Select(a => new {value = a.Name});
            return Json(artists, JsonRequestBehavior.AllowGet);
        }

    }
}