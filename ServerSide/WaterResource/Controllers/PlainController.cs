using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WaterResource.Models;

namespace WaterResource.Controllers
{
    public class PlainController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET api/Plain
         [Queryable()]
        public IQueryable<Plain> GetPlains()
        {
          
            return db.Plains.Include(a=>a.AreaStudy);
        }

        // GET api/Plain/5
        [ResponseType(typeof(Plain))]
        public IHttpActionResult GetPlain(int id)
        {
            Plain plain = db.Plains.Find(id);
            if (plain == null)
            {
                return NotFound();
            }

            return Ok(plain);
        }

        // PUT api/Plain/5
        public IHttpActionResult PutPlain(int id, Plain plain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != plain.ID)
            {
                return BadRequest();
            }

            db.Entry(plain).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlainExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Plain
        [ResponseType(typeof(Plain))]
        public IHttpActionResult PostPlain(Plain plain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Plains.Add(plain);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = plain.ID }, plain);
        }

        // DELETE api/Plain/5
        [ResponseType(typeof(Plain))]
        public IHttpActionResult DeletePlain(int id)
        {
            Plain plain = db.Plains.Find(id);
            if (plain == null)
            {
                return NotFound();
            }

            db.Plains.Remove(plain);
            db.SaveChanges();

            return Ok(plain);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PlainExists(int id)
        {
            return db.Plains.Count(e => e.ID == id) > 0;
        }
    }
}