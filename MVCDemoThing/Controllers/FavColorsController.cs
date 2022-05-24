using Microsoft.AspNetCore.Mvc;
using MVCDemoThing.Data;
using MVCDemoThing.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCDemoThing.Controllers
{
    public class FavColorsController : Controller
    {
        private PersonDbContext context;

        public FavColorsController(PersonDbContext personDbContext)
        {
            context = personDbContext;
        }

        public IActionResult Index()
        {
            // We are going to start by doing a very similar thing to the Index method of PeopleController
            // but instead of getting all the people from the database, we are going get all of the sets of 
            // favorite colors

            List<FavoriteColors> favColors = context.FavoriteColorSets.ToList();
            return View(favColors);
        }

        public IActionResult Form()
        {
            // AddFavColorsViewModel
            return View();
        }
    }
}
