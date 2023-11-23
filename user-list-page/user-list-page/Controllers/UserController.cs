using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Index(List<User> user)
        {
            /*userViewModel = (from u in _context.Users
                                 join a in _context.Address on u.Id equals a.UserId into ua
                                 from a in ua.DefaultIfEmpty()
                                 join p in _context.PhoneNumbers on u.Id equals p.UserId into upn
                                 from p in upn.DefaultIfEmpty()
                             select new UserViewModel { UsersViewModel = u, AddressViewModel = a, PhoneNumberViewModel = p })
                                .ToList();*/
            user = _context.Users.Include(u => u.Addresses)
                .Include(p => p.PhoneNumbers).ToList();
            
            return View(user);
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