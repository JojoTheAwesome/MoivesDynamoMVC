using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MovieRank.Libs.Models;
using MoviesDynamoMVC.Models;
using MoviesDynamoMVC.Services;

namespace MoviesDynamoMVC.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        private IUserService _userService;
        private IDynamoUserService _dynamoUserService;
        private int rowCount = -1;
        public static UserDb current;

        public AuthController(IUserService userService, IDynamoUserService dynamoUserService) {
            _userService = userService;
            _dynamoUserService = dynamoUserService;
        }

        [Route("signin")]
        public IActionResult SignIn()
        {
            return View(new SignInModel());
        }

        [Route("signin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignInModel model) {
            if (ModelState.IsValid) {
                User user;
                // I can probably just upload the dynamo table here and pass it into an edited version of the validate method.
                IEnumerable<UserDb> _dynamoUsers = await GetAllItemsFromDatabase();
                IDictionary<string, string> dynamoUsers = new Dictionary<string, string>();
                foreach(UserDb duser in _dynamoUsers) {
                    dynamoUsers.Add(duser.Username, duser.Password);
                    if(duser.Username == model.Username && duser.Password == model.Password) {
                        current = duser;
                    }
                }
                if(await _userService.ValidateCredentials(model.Username, model.Password, dynamoUsers, out user)) {
                    await SignInUser(user.Username);
                    // Maybe I can add the user here by calling the search method?

                    return RedirectToAction("Index", "Movie");
                }
            }
            return View(model);
        }

        public async Task SignInUser(string username) {
            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, username),
                new Claim("name", username)
            };
            //THIS WILL PROBABLY BE WHERE I ASSIGN ROLES
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme, "name", null);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal);
        }

        [Route("signup")]
        public IActionResult SignUp() {
            return View(new SignUpModel());
        }
        
        [Route("signup")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpModel model) {
            // Need to check that the username hasn't already been taken
            IEnumerable<UserDb> _users = await GetAllItemsFromDatabase();
            foreach(UserDb user in _users) {
                if(user.Username == model.Username) {
                    return RedirectToAction("SignUp", "Auth");
                }
            }

            if (rowCount < 0) {
                rowCount = await _dynamoUserService.GetRowCount();
            }
            if (ModelState.IsValid) {
                if(await _userService.AddUser(model.Username, model.Password)) {
                    await SignInUser(model.Username);
                    // Need to create a new userDb model, with a new userId, username and password should be easy
                    UserDb udb = new UserDb {
                        UserId = (rowCount + 1),
                        Username = model.Username,
                        Password = model.Password,
                        IsAdmin = false
                    };
                    await _dynamoUserService.AddUser(udb.UserId, udb);
                    rowCount++;
                    current = udb;
                    return RedirectToAction("Index", "Movie");
                }
                ModelState.AddModelError("Error", "Could not add user. Username already in use...");
            }
            return View(model);
        }

        [Route("signout")]
        [HttpPost]
        public async Task<IActionResult> SignOut() {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            current = null;
            return RedirectToAction("Index", "Movie");
        }
        [HttpGet]
        [Route("getdynamo")]
        public async Task<IEnumerable<UserDb>> GetAllItemsFromDatabase() {
            var results = await _dynamoUserService.GetAllItemsFromDatabase();
            return results;
        }

        //FIRST I NEED AN ADD METHOD
        [HttpPost]
        public async Task<IActionResult> AddUser(UserDb userDb) {
            await _dynamoUserService.AddUser(userDb.UserId, userDb);
            return RedirectToAction("Index", "Movie");
        }
    }
}