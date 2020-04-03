using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pandemic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Security.Claims;

namespace Pandemic.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class StatusesController : ControllerBase
    {
        private PandemicContext _db;

        public StatusesController(PandemicContext db)
        {
            _db = db;
        }

        // GET values
        [HttpGet]
        public ActionResult<IEnumerable<Status>> Get(string country)
        {
            var query = _db.Statuses.Include(entry => entry.Country).AsQueryable();

            if (country != null)
            {
                query = query.Where(entry => entry.Country.CountryName == country);
            }
            return query.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Status> Get(int id)
        {
            return _db.Statuses.FirstOrDefault(entry => entry.StatusId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Status status)
        {
            _db.Statuses.Add(status);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Status status)
        {
            status.StatusId = id;
            _db.Entry(status).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var statusDelete = _db.Statuses.FirstOrDefault(entry => entry.StatusId == id);
            _db.Statuses.Remove(statusDelete);
            _db.SaveChanges();
        }
    }
}
