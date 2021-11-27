using DotNet5OctBatch_2021.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5OctBatch_2021.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly POSContext _dbcontext;
        public HomeController(ILogger<HomeController> logger, POSContext dbcontext)
        {
            _logger = logger;
            _dbcontext = dbcontext;
        }
        #region Manual Work
        public IActionResult Index()
        {
            try
            {
                Users oUser1 = new Users();
                oUser1.Id = 1;
                oUser1.Name = "ABC";
                oUser1.Password = "TEST";
                //  ViewBag.User1 = oUser1;

                Users oUser2 = new Users
                {
                    Id = 2,
                    Name = "XYZ",
                    Password = "123"
                };

                Users oUser3 = new Users
                {
                    Id = 3,
                    Name = "XYZ-ABC",
                    Password = "1234556"
                };
                // ViewBag.OUser2 = oUser2;
                IList<Users> oListUsers = new List<Users>();
                oListUsers.Add(oUser1);
                oListUsers.Add(oUser2);
                oListUsers.Add(oUser3);
                ViewBag.UsersList = oListUsers;
                try
                {

                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                // log in error
                ViewBag.ErroMesasge = "Some Error Occured. Please Try Again!";
            }

            return View();
        }

        public IActionResult UsersList()
        {
            Users oUser1 = new Users();
            oUser1.Id = 1;
            oUser1.Name = "ABC";
            oUser1.Password = "TEST";
            Users oUser2 = new Users
            {
                Id = 2,
                Name = "XYZ",
                Password = "123"
            };
            Users oUser3 = new Users
            {
                Id = 3,
                Name = "XYZ-ABC",
                Password = "1234556"
            };
            IList<Users> oListUsers = new List<Users>();
            oListUsers.Add(oUser3);
            oListUsers.Add(oUser1);
            oListUsers.Add(oUser2);

            ViewBag.UsersList = oListUsers;
            return View();
        }
        public IActionResult MyContact()
        {
            ViewBag.Name = "ASP Dot Net";
            return View();
        }
        public IActionResult MyFirstPage()
        {
            return View();
        }
        public IActionResult AddUser()
        {
            Users ObjUser = new Users();
            try
            {

                ObjUser.Id = 1;
                ObjUser.Name = "ASP COre Class";
                ObjUser.UserName = "theta";
                ObjUser.Password = "123";

            }
            catch (Exception ex)
            {

            }
            return View(ObjUser);
        }
        #endregion
        #region Categories Management
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(ItemCategory itemcat)
        {
            try
            {
                _dbcontext.ItemCategories.Add(itemcat);
                _dbcontext.SaveChanges();
                ViewBag.SMessage = "Data Saved Successfully";
            }
            catch (Exception ex)
            {
                ViewBag.EMessage = "Some Error Occured. Please try again";
            }

            return View();
        }
        public IActionResult AllCategories()
        {
            IList<ItemCategory> lCategories = _dbcontext.ItemCategories.ToList();
            return View(lCategories);
        }
        #endregion
    }
}
