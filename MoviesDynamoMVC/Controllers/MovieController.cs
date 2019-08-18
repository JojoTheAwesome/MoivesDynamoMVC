using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRank.Contracts;
using MoviesDynamoMVC.Models;
using MoviesDynamoMVC.Services;
using System.Linq;
using MovieRank.Libs.Models;
using MovieRank.Libs.Methods;

namespace MoviesDynamoMVC.Controllers {

    public class MovieController : Controller {

        private readonly IMovieRankService _movieRankService;

        public MovieController(IMovieRankService movieRankService) {
            _movieRankService = movieRankService;
        }

        [HttpGet]
        [Route("allitems")]
        public async Task<IEnumerable<MovieDb>> GetAllItemsFromDatabase() {
            var results = await _movieRankService.GetAllItemsFromDatabase();
            return results;
        }

        public async Task<IActionResult> Index() {
            IEnumerable<MovieDb> items = await GetAllItemsFromDatabase();
            List<MovieDb> itemList = items.ToList();

            return View(itemList);
        }

        public async Task<IEnumerable<MovieResponse>> GetAllItemsForUser(int uid) {
            var results = await _movieRankService.GetAllItemsForUser(uid);
            return results;
        }

        [Route("/Movie/User/{uid}")]
        public async Task<IActionResult> User(int uid) {
            IEnumerable<MovieResponse> items = await GetAllItemsForUser(uid);
            List<MovieResponse> itemList = items.ToList();

            return View(itemList);
        }

        

        [Route("/Movie/Details/{uid}/{name}")]
        public async Task<IActionResult> Details(int uid, string name) {
            var result = await _movieRankService.GetMovie(uid, name);
            return View(result);
        }

        //[Route("/Movie/Edit/{uid}/{movieName}")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id, string movieName) {
            var result = await _movieRankService.GetMovie(id, movieName);
            return View(result);
        }

        //[Route("/Movie/Edit/{uid}/{movieName}")]
        [HttpPost]
        public async Task<IActionResult> Edit(MovieDb movie) {
            try {
                if (ModelState.IsValid) {
                    // Update.
                    await _movieRankService.UpdateMovie(movie.UserId, new MovieUpdateRequest { MovieName = movie.MovieName, Ranking = movie.Ranking });
                    return RedirectToAction("Index");
                }
                // Return the details of the updated movie.
                return View();
            } catch {
                return View();
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddMovie(MovieDb movieDb) {
            
            // Create a MovieRankRequest from the MovieDb
            MovieRankRequest request = new MovieRankRequest {
                MovieName = movieDb.MovieName,
                Description = movieDb.Description,
                MainActor = movieDb.MainActor,
                Ranking = movieDb.Ranking
            };

            await _movieRankService.AddMovie(MoviesDynamoMVC.Controllers.AuthController.current.UserId, request);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Delete(int id, string movieName) {
            var result = await _movieRankService.GetMovie(id, movieName);
            return View(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id, string movieName, int n) {
            try {
                string mn = movieName;
                
                if (ModelState.IsValid) {
                    var result = await _movieRankService.GetMovie(id, movieName);
                    if(result == null) {
                        return NotFound();
                    }

                    // Delete entry and save changes.
                    await _movieRankService.DeleteMovie(result);
                    return RedirectToAction("Index");
                }
                return View();
            } catch {
                return View();
            }
        }

        public IActionResult Create() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        /*public async Task<IActionResult> Test() {
            IEnumerable<MovieResponse> items = await GetAllItemsFromDatabase();
            List<MovieResponse> itemList = items.ToList();
            
            return View(itemList);
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
