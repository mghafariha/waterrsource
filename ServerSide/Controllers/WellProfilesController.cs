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
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/WellProfiles
        public IQueryable<WellProfile> GetWellProfiles()
        {
            return db.WellProfiles;
        }

        // GET: api/WellProfiles/5
        [ResponseType(typeof(WellProfile))]
        public IHttpActionResult GetWellProfile(int id)
        {
            WellProfile wellProfile = db.WellProfiles.Find(id);
            if (wellProfile == null)
            {
                return NotFound();
            }

            return Ok(wellProfile);
        }

        // PUT: api/WellProfiles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWellProfile(int id, WellProfile wellProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wellProfile.ID)
            {
                return BadRequest();
            }

            db.Entry(wellProfile).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WellProfileExists(id))
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
        [ResponseType(typeof(WellProfile))]
        public IHttpActionResult PostWellProfile(WellProfile wellProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WellProfiles.Add(wellProfile);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = wellProfile.ID }, wellProfile);
        }

        // DELETE: api/WellProfiles/5
        [ResponseType(typeof(WellProfile))]
        public IHttpActionResult DeleteWellProfile(int id)
        {
            WellProfile wellProfile = db.WellProfiles.Find(id);
            if (wellProfile == null)
            {
                return NotFound();
            }

            db.WellProfiles.Remove(wellProfile);
            db.SaveChanges();

            return Ok(wellProfile);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WellProfileExists(int id)
        {
            return db.WellProfiles.Count(e => e.ID == id) > 0;
        }
    }
}