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
    public class InspectionDepartmentsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET api/InspectionDepartments
        public IQueryable<InspectionDepartments> GetInspectionDepartments()
        {
            return db.InspectionDepartments;
        }

        // GET api/InspectionDepartments/5
        [ResponseType(typeof(InspectionDepartments))]
        public IHttpActionResult GetInspectionDepartments(int id)
        {
            InspectionDepartments inspectiondepartments = db.InspectionDepartments.Find(id);
            if (inspectiondepartments == null)
            {
                return NotFound();
            }

            return Ok(inspectiondepartments);
        }

        // PUT api/InspectionDepartments/5
        public IHttpActionResult PutInspectionDepartments(int id, InspectionDepartments inspectiondepartments)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inspectiondepartments.ID)
            {
                return BadRequest();
            }

            db.Entry(inspectiondepartments).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspectionDepartmentsExists(id))
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

        // POST api/InspectionDepartments
        [ResponseType(typeof(InspectionDepartments))]
        public IHttpActionResult PostInspectionDepartments(InspectionDepartments inspectiondepartments)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InspectionDepartments.Add(inspectiondepartments);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = inspectiondepartments.ID }, inspectiondepartments);
        }

        // DELETE api/InspectionDepartments/5
        [ResponseType(typeof(InspectionDepartments))]
        public IHttpActionResult DeleteInspectionDepartments(int id)
        {
            InspectionDepartments inspectiondepartments = db.InspectionDepartments.Find(id);
            if (inspectiondepartments == null)
            {
                return NotFound();
            }

            db.InspectionDepartments.Remove(inspectiondepartments);
            db.SaveChanges();

            return Ok(inspectiondepartments);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InspectionDepartmentsExists(int id)
        {
            return db.InspectionDepartments.Count(e => e.ID == id) > 0;
        }
    }
}