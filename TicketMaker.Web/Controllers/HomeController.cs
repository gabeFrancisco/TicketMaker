using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TicketMaker.Web.Models;

namespace TicketMaker.Web.Controllers
{
    public class HomeController : Controller
    {
        private static TicketIssuer _issuer;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Single([FromForm] TicketIssuer ticketIssuer)
        {
            _issuer = ticketIssuer;
            return RedirectToAction(nameof(SingleTickets));
        }

        public IActionResult Multiple([FromForm] TicketIssuer ticketIssuer)
        {
            _issuer = ticketIssuer;
            return RedirectToAction(nameof(MultipleTickets));
        }

        [HttpGet]
        public IActionResult SingleTickets()
        {
            try
            {
                if (_issuer.TicketQuantity <= 0)
                {
                    TempData["EmptyTickets"] = "Por favor insira um número!";
                    return RedirectToAction(nameof(Index));
                }

                for (int i = 0; i < _issuer.TicketQuantity; i++)
                {
                    _issuer.Tickets.Add(new Ticket());
                }

                var quantityList = new List<int>();

                if (_issuer.IsOrdered.Equals(true))
                    quantityList.AddRange(Enumerable.Range(1, _issuer.TicketQuantity));
                
                else
                    quantityList.AddRange(Enumerable.Range(1, _issuer.TicketQuantity)
                                .OrderBy(a => Guid.NewGuid()).ToList());
                
                foreach (var item in quantityList)
                {
                    _issuer.TotalTickets.Enqueue(item);
                }

                foreach (var ticket in _issuer.Tickets)
                {
                    ticket.NumberSet.Add(_issuer.TotalTickets.Dequeue());
                }
                return View(_issuer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult MultipleTickets()
        {
            try
            {
                if (_issuer.TicketQuantity <= 0 || _issuer.TicketNumbers <= 1)
                {
                    TempData["EmptyTickets"] = "Por favor preencha os campos abaixo!";
                    return RedirectToAction(nameof(Index));
                }

                for (int i = 0; i < _issuer.TicketQuantity; i++)
                {
                    _issuer.Tickets.Add(new Ticket());
                }

                var quantityList = new List<int>();

                quantityList.AddRange(Enumerable.Range(1, _issuer.TicketQuantity * _issuer.TicketNumbers)
                            .OrderBy(a => Guid.NewGuid()).ToList());

                foreach (var item in quantityList)
                {
                    _issuer.TotalTickets.Enqueue(item);
                }

                foreach (var ticket in _issuer.Tickets)
                {
                    for (int i = 0; i < _issuer.TicketNumbers; i++)
                    {
                        ticket.NumberSet.Add(_issuer.TotalTickets.Dequeue());
                    }
                }

                return View(_issuer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
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
