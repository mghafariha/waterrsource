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
    public class OtherTypesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/OtherTypes
        public IQueryable<OtherType> GetOtherType()
        {
            return db.OtherType;
        }

        // GET: api/OtherTypes/5
        [ResponseType(typeof(OtherType))]
        public IHttpActionResult GetOtherType(int id)
        {
            OtherType otherType = db.OtherType.Find(id);
            if (otherType == null)
            {
                return NotFound();
            }

            return Ok(otherType);
        }

        // PUT: api/OtherTypes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOtherType(int id, OtherType otherType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != otherType.ID)
            {
                return BadRequest();
            }

            db.Entry(otherType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OtherTypeExists(id))
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

        // POST: api/OtherTypes
        [ResponseType(typeof(OtherType))]
        public IHttpActionResult PostOtherType(OtherType otherType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OtherType.Add(otherType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = otherType.ID }, otherType);
        }

        // DELETE: api/OtherTypes/5
        [ResponseType(typeof(OtherType))]
        public IHttpActionResult DeleteOtherType(int id)
        {
            OtherType otherType = db.OtherType.Find(id);
            if (otherType == null)
            {
                return NotFound();
            }

            db.OtherType.Remove(otherType);
            db.SaveChanges();

            return Ok(otherType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OtherTypeExists(int id)
        {
            return db.OtherType.Count(e => e.ID == id) > 0;
        }
    }
}