using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrackingApp.Models;

namespace TrackingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ShippingContext _context;

        public UsersController(ShippingContext context)
        {
            _context = context;

            //if (_context.Users.Count() == 0)
            //{
            //    _context.Users.Add(new User { FirstName = "Brian", LastName = "Hudi", ID = 1 });
            //    _context.SaveChanges();
            //}
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult<User> GetById(int id)
        {
            var item = _context.Users.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public void Create(User user) {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
