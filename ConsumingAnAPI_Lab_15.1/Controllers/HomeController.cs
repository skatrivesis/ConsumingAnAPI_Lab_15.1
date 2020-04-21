using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsumingAnAPI_Lab_15._1.Models;
using System.Net.Http;

namespace ConsumingAnAPI_Lab_15._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CreateDeck()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");

            var response = await client.GetAsync("api/deck/new/shuffle/?deck_count=1");

            var deck = await response.Content.ReadAsAsync<Deck>();

            return View(deck);
        }

        public async Task<IActionResult> DrawFive()
        {
            string deckId = (string)ViewData["Deck_Id"];

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");

            var response = await client.GetAsync($"api/deck/{deckId}/draw/?count=5");

            var deck = await response.Content.ReadAsAsync<DeckOfCards>();

            return View(deck);
        }

        public IActionResult Privacy()
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
