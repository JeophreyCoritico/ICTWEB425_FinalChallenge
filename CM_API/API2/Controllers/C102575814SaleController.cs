using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using API2.Models;

namespace API2.Controllers
{
    public class C102575814SaleController : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/C102575814Sale
        public IQueryable<C102575814Sale> GetC102575814Sale()
        {
            return db.C102575814Sale;
        }

        // GET: api/C102575814Sale/5
        [ResponseType(typeof(C102575814Sale))]
        public async Task<IHttpActionResult> GetC102575814Sale(DateTime id)
        {
            C102575814Sale c102575814Sale = await db.C102575814Sale.FindAsync(id);
            if (c102575814Sale == null)
            {
                return NotFound();
            }

            return Ok(c102575814Sale);
        }

        // PUT: api/C102575814Sale/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutC102575814Sale(DateTime id, C102575814Sale c102575814Sale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c102575814Sale.DateRecorded)
            {
                return BadRequest();
            }

            db.Entry(c102575814Sale).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C102575814SaleExists(id))
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

        // POST: api/C102575814Sale
        [ResponseType(typeof(C102575814Sale))]
        public async Task<IHttpActionResult> PostC102575814Sale(C102575814Sale c102575814Sale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C102575814Sale.Add(c102575814Sale);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (C102575814SaleExists(c102575814Sale.DateRecorded))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c102575814Sale.DateRecorded }, c102575814Sale);
        }

        // DELETE: api/C102575814Sale/5
        [ResponseType(typeof(C102575814Sale))]
        public async Task<IHttpActionResult> DeleteC102575814Sale(DateTime id)
        {
            C102575814Sale c102575814Sale = await db.C102575814Sale.FindAsync(id);
            if (c102575814Sale == null)
            {
                return NotFound();
            }

            db.C102575814Sale.Remove(c102575814Sale);
            await db.SaveChangesAsync();

            return Ok(c102575814Sale);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C102575814SaleExists(DateTime id)
        {
            return db.C102575814Sale.Count(e => e.DateRecorded == id) > 0;
        }
    }
}