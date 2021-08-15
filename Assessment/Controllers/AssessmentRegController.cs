using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Assessment.Data;
using Assessment.Models;

namespace Assessment.Controllers
{
    public class AssessmentRegController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AssessmentRegController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserList()
        {
            var list = _context.Users.ToList();
            return View(list);
        }
    }
}
