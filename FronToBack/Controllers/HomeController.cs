﻿using FronToBack.DAL;
using FronToBack.Models;
using FronToBack.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FronToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            
        }

        public async Task<IActionResult> Index()
        {
            var cards = await _appDbContext.Cards.ToListAsync();
            

            HomeIndexViewModel model = new HomeIndexViewModel
            {
                Cards=cards
            };
            return View(model);
        }

    }
}
