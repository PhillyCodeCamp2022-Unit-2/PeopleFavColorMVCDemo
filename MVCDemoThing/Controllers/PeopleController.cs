using Microsoft.AspNetCore.Mvc;
using MVCDemoThing.Data;
using MVCDemoThing.Models;
using MVCDemoThing.ViewModels;

namespace MVCDemoThing.Controllers
{
    public class PeopleController : Controller
    {
        // [Route("/people/index")]
        public IActionResult Index()
        {
            // We need to drop the people list into the ViewBag here as well, so that all the people in our application
            // get displayed even when we aren't navigating to this page through submitting the form
            ViewBag.people = PersonData.people;

            return View();
        }

        // [Route("/people/form")]
        public IActionResult Form()
        {
            return View();
        }

        // handle this post request that is getting sent to /lmao by the form
        // display list of people after having added a person
        // render the people/index view!
        [HttpPost]
        [Route("/people/form")]
        public IActionResult AddPerson(AddPersonViewModel viewModel)
        {
            //if (viewModel.Name == null) { etc...} 
            //if (viewModel.Color1 == null) { etc... }
            // if the model state is not valid, ie viewModel.Name and viewModel.Color1 are null, then 
            // re-render the form page
            if (!ModelState.IsValid)
            {
                return View("Form");
            }

            // if model state IS valid, then we can move past that if statement and execute the rest of our code as normal
            // Which means creating a new instance of Person (a new Person object) and adding it into our PersonData data layer etc....

            // let's create a new instance of Person using the 3 pieces of information from the form
            // Person newPerson = new Person(name, color1, color2);
            Person newPerson = new Person(viewModel.Name, viewModel.Color1, viewModel.Color2);

            // now we want to be able to store our newPerson object somewhere to be used later in our application
            // instead of just being dropped into the ViewBag and then being forgotten since ViewBag is kind of this one way transaction
            PersonData.Add(newPerson);

            // Now we can drop the people list into the ViewBag, and then loop through the list to display all of the people in the list
            ViewBag.people = PersonData.people;
            

            // let's take the name, color1, and color2 data and make it accessible by the Index view
            // we are rendering with View("Index")
            //ViewBag.name = name;
            //ViewBag.color1 = color1;
            //ViewBag.color2 = color2;

            return View("Index");
        }
    }
}
