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
    public class AreaStudiesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/AreaStudies
         [Queryable()]
        public IQueryable<AreaStudy> GetAreaStudies()
        {
            return db.AreaStudies;
         }

        // GET: api/AreaStudies/5
        [ResponseType(typeof(AreaStudy))]
        public IHttpActionResult GetAreaStudy(int id)
        {
            AreaStudy areaStudy = db.AreaStudies.Find(id);
            if (areaStudy == null)
            {
                return NotFound();
            }

            return Ok(areaStudy);
        }

        // PUT: api/AreaStudies/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAreaStudy(int id, AreaStudy areaStudy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != areaStudy.ID)
            {
                return BadRequest();
            }

            db.Entry(areaStudy).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AreaStudyExists(id))
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

        // POST: api/AreaStudies
        [ResponseType(typeof(AreaStudy))]
        public IHttpActionResult PostAreaStudy(AreaStudy areaStudy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AreaStudies.Add(areaStudy);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = areaStudy.ID }, areaStudy);
        }

        // DELETE: api/AreaStudies/5
        [ResponseType(typeof(AreaStudy))]
        public IHttpActionResult DeleteAreaStudy(int id)
        {
            AreaStudy areaStudy = db.AreaStudies.Find(id);
            if (areaStudy == null)
            {
                return NotFound();
            }

            db.AreaStudies.Remove(areaStudy);
            db.SaveChanges();

            return Ok(areaStudy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AreaStudyExists(int id)
        {
            return db.AreaStudies.Count(e => e.ID == id) > 0;
        }
    }
}