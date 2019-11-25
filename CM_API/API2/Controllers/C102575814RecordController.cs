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
    public class C102575814RecordController : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/C102575814Record
        public IQueryable<C102575814Record> GetC102575814Record()
        {
            return db.C102575814Record;
        }

        // GET: api/C102575814Record/5
        [ResponseType(typeof(C102575814Record))]
        public async Task<IHttpActionResult> GetC102575814Record(string id)
        {
            C102575814Record c102575814Record = await db.C102575814Record.FindAsync(id);
            if (c102575814Record == null)
            {
                return NotFound();
            }

            return Ok(c102575814Record);
        }

        // PUT: api/C102575814Record/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutC102575814Record(string id, C102575814Record c102575814Record)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c102575814Record.RecordID)
            {
                return BadRequest();
            }

            db.Entry(c102575814Record).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C102575814RecordExists(id))
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

        // POST: api/C102575814Record
        [ResponseType(typeof(C102575814Record))]
        public async Task<IHttpActionResult> PostC102575814Record(C102575814Record c102575814Record)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C102575814Record.Add(c102575814Record);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (C102575814RecordExists(c102575814Record.RecordID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c102575814Record.RecordID }, c102575814Record);
        }

        // DELETE: api/C102575814Record/5
        [ResponseType(typeof(C102575814Record))]
        public async Task<IHttpActionResult> DeleteC102575814Record(string id)
        {
            C102575814Record c102575814Record = await db.C102575814Record.FindAsync(id);
            if (c102575814Record == null)
            {
                return NotFound();
            }

            db.C102575814Record.Remove(c102575814Record);
            await db.SaveChangesAsync();

            return Ok(c102575814Record);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C102575814RecordExists(string id)
        {
            return db.C102575814Record.Count(e => e.RecordID == id) > 0;
        }
    }
}