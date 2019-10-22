using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewPhoneBook.Core.Contracts.People;
using NewPhoneBook.EndPoints.MVC.Models;

namespace NewPhoneBook.EndPoints.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IPersonRepository PersonRepository { get; }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(IPersonRepository personRepository)
        {
            this.PersonRepository = personRepository;
        }

        public IActionResult Index()
        {
            PersonRepository.Add(new PhoneBook.Domain.Core.People.Person
            {
                FirstName = "javad",
                LastName = "mzf",
                Email = "javadir26@gmail.com",
                Address = "my add"
                

            });
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
