using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Yasm.Dao.Model;
using Yasm.Dao.Repos;

namespace Yasm.Ui.Controllers
{
    public class UserController : Controller
    {
        private UserRepository _userRepository = new UserRepository();

        // GET: /<controller>/
        public IActionResult Index()
        {
            var users = _userRepository.FindAll();

            return View(users);
        }

        public ActionResult Edit(int? id)
        {
            User user = null;
            if (id == null)
            {
                user = new User();
            }
            else
            {
                user = _userRepository.FindById(id.Value);
                if (user == null)
                {
                    ViewData["ErrorMessage"] = "Bad request";
                    return View();
                }
            }
            return View(user);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(User userToSave)
        {
            if (userToSave == null)
            {
                ViewData["ErrorMessage"] = "Bad request";
                return View();
            }
            try
            {
                if (userToSave.Id == 0){
                    _userRepository.Add(userToSave);
                }
                else
                {
                    _userRepository.Edit(userToSave);
                }
                return RedirectToAction("Index");
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(userToSave);
        }

        public IActionResult Form(int userId)
        {
            var user = _userRepository.FindById(userId);

            return View();
        }
    }
}
