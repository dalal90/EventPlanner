using Microsoft.AspNetCore.Mvc;
using EvantPlanner.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace EvantPlanner.Controllers
{
    public class UserController : Controller
    {
        private MyContext _context;
        public UserController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("processregister")]
        public IActionResult ProcessRegister(User newUser)
        {
            if (ModelState.IsValid)
            {
                //Confirm Email not already in use
                if (_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                    return View("Index");
                }
                else
                {
                    //Create new user
                    // Hash PW
                    PasswordHasher<User> hasher = new PasswordHasher<User>();
                    newUser.Password = hasher.HashPassword(newUser, newUser.Password);
                    _context.Add(newUser);
                    _context.SaveChanges();
                    //Log User In (add to session)
                    HttpContext.Session.SetInt32("uid", newUser.UserId);
                    //redirect to dashboard
                    return RedirectToAction("Dashboard", "Event");

                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("processlogin")]
        public IActionResult ProcessLogin(LoginUser logUser)
        {
            if (ModelState.IsValid)
            {
                // Find user in DB
                User userInDB = _context.Users.FirstOrDefault( u => u.Email == logUser.logEmail);
                if (userInDB == null)
                {
                    ModelState.AddModelError("logEmail", "Invalid Login Credentials");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();

                    var result = hasher.VerifyHashedPassword(logUser, userInDB.Password, logUser.logPassword);

                    if (result == 0)
                    {
                        ModelState.AddModelError("logEmail", "Invalid Login Credentials");
                        return View("Index");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("uid", userInDB.UserId);
                        //redirect to dashboard
                        return RedirectToAction("Dashboard", "Event");
                    }
                }
                
            }
            else 
            {
                return View("Index");
            }
        }
    }
}