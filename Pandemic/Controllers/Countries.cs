using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pandemic.Models;

namespace Pandemic.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private PandemicContext _db;

        public CountriesController(PandemicContext db)
        {
            _db = db;
        }

        // GET values
        [HttpGet]
        public ActionResult<IEnumerable<Country>> Get(string country)
        {
            var query = _db.Countries.Include(entry => entry.Statuses).AsQueryable();

            if (country != null)
            {
                query = query.Where(entry => entry.CountryName.Equals(country));
            }

            return query.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Country> Get(int id)
        {
            return _db.Countries.FirstOrDefault(entry => entry.CountryId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Country country)
        {
            _db.Countries.Add(country);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Country country)
        {
            country.CountryId = id;
            _db.Entry(country).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var countryDelete = _db.Countries.FirstOrDefault(entry => entry.CountryId == id);
            _db.Countries.Remove(countryDelete);
            _db.SaveChanges();
        }
    }
}
