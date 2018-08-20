using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public ActionResult<List<Order>> GetAll()
        {
            return _context.Orders.ToList();
        }

        [HttpGet("{id}", Name = "GetOrder")]
        public ActionResult<Order> GetById(int id)
        {
            var item = _context.Orders.Find(id);
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

        [HttpPut("{id}", Name = "UpdateOrder")]
        public void Update(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
