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
    public class WellViolationsItemsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/WellViolationItems
        public IQueryable<WellViolationsItems> GetWellViolationItems()
        {
            return db.WellViolationItems.Include(a=>a.InfractionsWell);
        }

        // GET: api/WellViolationItems/5
        [ResponseType(typeof(WellViolationsItems))]
        public IHttpActionResult GetWellViolationItems(int id)
        {
            WellViolationsItems wellViolationItems = db.WellViolationItems.Find(id);
            if (wellViolationItems == null)
            {
                return NotFound();
            }

            return Ok(wellViolationItems);
        }

        // PUT: api/WellViolationItems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWellViolationItems(int id, WellViolationsItems wellViolationItems)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wellViolationItems.ID)
            {
                return BadRequest();
            }

            db.Entry(wellViolationItems).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WellViolationItemsExists(id))
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

        // POST: api/WellViolationItems
        [ResponseType(typeof(WellViolationsItems))]
        public IHttpActionResult PostWellViolationItems(WellViolationsItems wellViolationItems)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WellViolationItems.Add(wellViolationItems);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = wellViolationItems.ID }, wellViolationItems);
        }

        // DELETE: api/WellViolationItems/5
        [ResponseType(typeof(WellViolationsItems))]
        public IHttpActionResult DeleteWellViolationItems(int id)
        {
            WellViolationsItems wellViolationItems = db.WellViolationItems.Find(id);
            if (wellViolationItems == null)
            {
                return NotFound();
            }

            db.WellViolationItems.Remove(wellViolationItems);
            db.SaveChanges();

            return Ok(wellViolationItems);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WellViolationItemsExists(int id)
        {
            return db.WellViolationItems.Count(e => e.ID == id) > 0;
        }
    }
}