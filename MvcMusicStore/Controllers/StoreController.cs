using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        //public ActionResult Index()
        public string Index()
        {
            return "hello from the Store.Index";
        }

        // GET: Store/Browse?genre=disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, genre = " + genre);
            return message;
        }

        // GET: Store/Details/5
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}