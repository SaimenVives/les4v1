﻿using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Core;
using PeopleManager.Ui.Mvc.Models;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PeopleManagerDbContext _dbContext;

        public PeopleController(PeopleManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var people = _dbContext.People.ToList();
            return View(people);
        }
    }
}
