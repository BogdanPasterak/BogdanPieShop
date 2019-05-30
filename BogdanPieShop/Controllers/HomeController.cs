using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BogdanPieShop.Models;

namespace BogdanPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            return View(_pieRepository.GetAllPise().OrderBy(p => p.Name));
        }

        public IActionResult Details(int id)
        {
            Debug.WriteLine("Id = " + id.ToString());
            IEnumerator<Pie> enumerator = _pieRepository.GetAllPise().GetEnumerator();
            enumerator.MoveNext();
            Pie pie;

            do
            {
                pie = enumerator.Current;
                //Debug.WriteLine("In loop pie.Id = " + pie.Id);
                if (pie.Id == id)
                {
                    return View(pie);
                }
            } while (enumerator.MoveNext()) ;
            return View(_pieRepository.GetAllPise().FirstOrDefault<Pie>());
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
