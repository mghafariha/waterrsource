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
    public class WellViolationItemsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/WellViolationItems
        public IQueryable<WellViolationItems> GetWellViolationItems()
        {
            return db.WellViolationItems;
        }

        // GET: api/WellViolationItems/5
        [ResponseType(typeof(WellViolationItems))]
        public IHttpActionResult GetWellViolationItems(int id)
        {
            WellViolationItems wellViolationItems = db.WellViolationItems.Find(id);
            if (wellViolationItems == null)
            {
                return NotFound();
            }

            return Ok(wellViolationItems);
        }

        // PUT: api/WellViolationItems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWellViolationItems(int id, WellViolationItems wellViolationItems)
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
        [ResponseType(typeof(WellViolationItems))]
        public IHttpActionResult PostWellViolationItems(WellViolationItems wellViolationItems)
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
        [ResponseType(typeof(WellViolationItems))]
        public IHttpActionResult DeleteWellViolationItems(int id)
        {
            WellViolationItems wellViolationItems = db.WellViolationItems.Find(id);
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