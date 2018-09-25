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
    public class WellViolationsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/WellViolations
        public IQueryable<WellViolation> GetWellViolations()
        {
            return db.WellViolations;
        }

        // GET: api/WellViolations/5
        [ResponseType(typeof(WellViolation))]
        public IHttpActionResult GetWellViolation(int id)
        {
            WellViolation wellViolation = db.WellViolations.Find(id);
            if (wellViolation == null)
            {
                return NotFound();
            }

            return Ok(wellViolation);
        }

        // PUT: api/WellViolations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWellViolation(int id, WellViolation wellViolation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wellViolation.ID)
            {
                return BadRequest();
            }

            db.Entry(wellViolation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WellViolationExists(id))
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

        // POST: api/WellViolations
        [ResponseType(typeof(WellViolation))]
        public IHttpActionResult PostWellViolation(WellViolation wellViolation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WellViolations.Add(wellViolation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = wellViolation.ID }, wellViolation);
        }

        // DELETE: api/WellViolations/5
        [ResponseType(typeof(WellViolation))]
        public IHttpActionResult DeleteWellViolation(int id)
        {
            WellViolation wellViolation = db.WellViolations.Find(id);
            if (wellViolation == null)
            {
                return NotFound();
            }

            db.WellViolations.Remove(wellViolation);
            db.SaveChanges();

            return Ok(wellViolation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WellViolationExists(int id)
        {
            return db.WellViolations.Count(e => e.ID == id) > 0;
        }
    }
}