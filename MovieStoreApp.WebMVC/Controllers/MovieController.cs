using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.WebMVC.Models;
namespace MovieStoreApp.WebMVC.Controllers
{
    public class MovieController : Controller
    {
        IMovieServiceAsync movieService;
        public MovieController(IMovieServiceAsync ser)
        {
            movieService = ser;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "All Movies";

            var result =await movieService.GetTop10RevenueMoviesAsync();

            return View(result);
        }

        public async Task<IActionResult> Detail(int movieId)
        { 
            var result =await movieService.GetByIdAsync(movieId);
            return View(result);
        }

    }
}
