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
    public class WellVisitedsController : ApiController
    {
        private WaterResourceContext db = new WaterResourceContext();

        // GET: api/WellVisiteds
        public IQueryable<WellVisited> GetWellVisiteds()
        {
            return db.WellVisiteds;
        }

        // GET: api/WellVisiteds/5
        [ResponseType(typeof(WellVisited))]
        public IHttpActionResult GetWellVisited(int id)
        {
            WellVisited wellVisited = db.WellVisiteds.Find(id);
            if (wellVisited == null)
            {
                return NotFound();
            }

            return Ok(wellVisited);
        }

        // PUT: api/WellVisiteds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWellVisited(int id, WellVisited wellVisited)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wellVisited.ID)
            {
                return BadRequest();
            }

            db.Entry(wellVisited).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WellVisitedExists(id))
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

        // POST: api/WellVisiteds
        [ResponseType(typeof(WellVisited))]
        public IHttpActionResult PostWellVisited(WellVisited wellVisited)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WellVisiteds.Add(wellVisited);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = wellVisited.ID }, wellVisited);
        }

        // DELETE: api/WellVisiteds/5
        [ResponseType(typeof(WellVisited))]
        public IHttpActionResult DeleteWellVisited(int id)
        {
            WellVisited wellVisited = db.WellVisiteds.Find(id);
            if (wellVisited == null)
            {
                return NotFound();
            }

            db.WellVisiteds.Remove(wellVisited);
            db.SaveChanges();

            return Ok(wellVisited);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WellVisitedExists(int id)
        {
            return db.WellVisiteds.Count(e => e.ID == id) > 0;
        }
    }
}