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
    public class C102575814InterestController : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/C102575814Interest
        public IQueryable<C102575814Interest> GetC102575814Interest()
        {
            return db.C102575814Interest;
        }

        // GET: api/C102575814Interest/5
        [ResponseType(typeof(C102575814Interest))]
        public async Task<IHttpActionResult> GetC102575814Interest(string id)
        {
            C102575814Interest c102575814Interest = await db.C102575814Interest.FindAsync(id);
            if (c102575814Interest == null)
            {
                return NotFound();
            }

            return Ok(c102575814Interest);
        }

        // PUT: api/C102575814Interest/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutC102575814Interest(string id, C102575814Interest c102575814Interest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c102575814Interest.InterestCode)
            {
                return BadRequest();
            }

            db.Entry(c102575814Interest).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C102575814InterestExists(id))
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

        // POST: api/C102575814Interest
        [ResponseType(typeof(C102575814Interest))]
        public async Task<IHttpActionResult> PostC102575814Interest(C102575814Interest c102575814Interest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C102575814Interest.Add(c102575814Interest);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (C102575814InterestExists(c102575814Interest.InterestCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c102575814Interest.InterestCode }, c102575814Interest);
        }

        // DELETE: api/C102575814Interest/5
        [ResponseType(typeof(C102575814Interest))]
        public async Task<IHttpActionResult> DeleteC102575814Interest(string id)
        {
            C102575814Interest c102575814Interest = await db.C102575814Interest.FindAsync(id);
            if (c102575814Interest == null)
            {
                return NotFound();
            }

            db.C102575814Interest.Remove(c102575814Interest);
            await db.SaveChangesAsync();

            return Ok(c102575814Interest);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C102575814InterestExists(string id)
        {
            return db.C102575814Interest.Count(e => e.InterestCode == id) > 0;
        }
    }
}