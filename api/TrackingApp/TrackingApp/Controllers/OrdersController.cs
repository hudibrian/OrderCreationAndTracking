using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrackingApp.Models;

namespace TrackingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ShippingContext _context;

        public OrdersController(ShippingContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<List<Order>> GetAll(int id)
        {
            return _context.Orders.Where(x => id == x.User.ID).ToList();
        }

        [HttpGet("get/{id}", Name = "GetOrder")]
        public ActionResult<Order> GetById(int id)
        {
            var item = _context.Orders.Include(x => x.User).FirstOrDefault(x => x.TrackingID == id.ToString());
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public void Create(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        [HttpPut]
        public void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }
    }
}
