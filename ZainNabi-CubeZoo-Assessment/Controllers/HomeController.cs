using Cubezoo_Interface.IUserDirectory;
using Cubezoo_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZainNabi_CubeZoo_Assessment.Models;

namespace ZainNabi_CubeZoo_Assessment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserDirectory _userDirectory;

        public HomeController(IUserDirectory userDirectory)
        {
            _userDirectory = userDirectory;
        }

        [HttpGet]
        public async Task<IActionResult> Index(bool showReport = false)
        {
            var model = new UserDirectoryModel();
            //Connection to Business Logic class library to get the data from the api
            var users = await _userDirectory.GetUserDirectoriesAsync();

            //Check if the api has returned data
            if (users != null)
            {
                if(showReport == true)
                {
                    model.ShowReport = true;
                    model.UserDirectoriesList = users;
                }
                return View(model);
            }
            else
            {
                //Return blank model if data is null from api and dont show data
                model.ShowReport = false;
                model.UserDirectoriesList = users;
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserDirectoryModel directoryModel)
        {
            var model = new UserDirectoryModel();
            //Connection to Business Logic class library to get the data from the api
            var users = await _userDirectory.GetUserDirectoriesAsync();

            //Check if the api has returned data
            if (users != null)
            {
                //check if the new record to be inserted has not already been inserted
                var duplicateEmail = users.Where(x => x.email == directoryModel.UserDirectory.email).Count();
                if (duplicateEmail >= 1)
                {
                    model.duplicateEmailAddress = true;
                    model.ShowReport = true;
                    model.UserDirectoriesList = users;
                    return View(model);
                }
                else
                {
                    //Append the new record to the current list of items from the api
                    model.ShowReport = true;
                    model.UserDirectoriesList = users;
                    model.UserDirectoriesList.Add(new Cubezoo_Models.DTO.UserDirectory()
                    {
                        name = directoryModel.UserDirectory.name,
                        email = directoryModel.UserDirectory.email
                    });
                    return View(model);
                }
            }
            else
            {
                //Return blank model if data is null from api and dont show data
                model.ShowReport = false;
                model.UserDirectoriesList = users;
                return View(model);
            }
        }
    }
}
