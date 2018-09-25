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
    public class WellProfilesController : ApiController
    {
        private WaterResourceContext db = new WaterResourceContext();

        // GET: api/WellProfiles
        public IQueryable<WellProfiles> GetWellProfiles()
        {
            return db.WellProfiles;
        }

        // GET: api/WellProfiles/5
        [ResponseType(typeof(WellProfiles))]
        public IHttpActionResult GetWellProfiles(int id)
        {
            WellProfiles wellProfiles = db.WellProfiles.Find(id);
            if (wellProfiles == null)
            {
                return NotFound();
            }

            return Ok(wellProfiles);
        }

        // PUT: api/WellProfiles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWellProfiles(int id, WellProfiles wellProfiles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wellProfiles.ID)
            {
                return BadRequest();
            }

            db.Entry(wellProfiles).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WellProfilesExists(id))
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

        // POST: api/WellProfiles
        [ResponseType(typeof(WellProfiles))]
        public IHttpActionResult PostWellProfiles(WellProfiles wellProfiles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WellProfiles.Add(wellProfiles);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = wellProfiles.ID }, wellProfiles);
        }

        // DELETE: api/WellProfiles/5
        [ResponseType(typeof(WellProfiles))]
        public IHttpActionResult DeleteWellProfiles(int id)
        {
            WellProfiles wellProfiles = db.WellProfiles.Find(id);
            if (wellProfiles == null)
            {
                return NotFound();
            }

            db.WellProfiles.Remove(wellProfiles);
            db.SaveChanges();

            return Ok(wellProfiles);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WellProfilesExists(int id)
        {
            return db.WellProfiles.Count(e => e.ID == id) > 0;
        }
    }
}