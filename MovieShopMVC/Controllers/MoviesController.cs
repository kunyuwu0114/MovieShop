using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Details(int id)
        {
            // go to movies table and get the movie details by ID
            // connect to SQL server and execute the SQL query
            // SELECT * FROM Movie WHERE id = 2
            // get the movies entity (object)
            // Repositories => Dta access Logic
            // Services => Business Logic
            // Controllers action methods => Services methods => Repository methods => SQL database
            // get the mode date from the services and send the data to the views()
            // Onion architecure or N-layer architetcure
            return View();
        }
    }
}
