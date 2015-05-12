using makeup1.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using makeup1.Repositories;

namespace makeup1.Controllers
{
    public class SearchController : Controller
    {
      /*  public ActionResult search(string name)
        {
			Debug.WriteLine("query: " + name);
			
			var model = from u in 
                        where u.UserName.Contains(name)
                        select u;

            return View(model);
        }*/
        // GET: /Search/
        public ActionResult Index()
        {
            return View();
        }
	}
}