using BogdanPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BogdanPieShop.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

    }
}
