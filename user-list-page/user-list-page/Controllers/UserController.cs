using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using user_list_page.Context;
using user_list_page.Models;

namespace user_list_page.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly UserContext _context;

        public UserController(ILogger<UserController> logger, UserContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.Select(x => new User()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                PhoneNumber = x.PhoneNumber,
                DateOfBirth = x.DateOfBirth,
                Address = x.Address,
            }).ToList() ?? new List<User>();

            return View(users);
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}