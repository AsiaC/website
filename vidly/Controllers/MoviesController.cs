using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        /*public ActionResult Index()
        {
            return View();
        }*/

        // GET: Movies/Random
        public ActionResult Random()
        //public ViewResult Random()
        {
            //instancja MovieModel
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
            // return new ViewResult(); - inny sposób
            //return Content("Hello world!!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page=1,sortBy="name"}); //http://localhost:52701/?page=1&sortBy=name
        }
    }
}