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
    public class C102575814CustomerController : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/C102575814Customer
        public IQueryable<C102575814Customer> GetC102575814Customer()
        {
            return db.C102575814Customer;
        }

        // GET: api/C102575814Customer/5
        [ResponseType(typeof(C102575814Customer))]
        public async Task<IHttpActionResult> GetC102575814Customer(int id)
        {
            C102575814Customer c102575814Customer = await db.C102575814Customer.FindAsync(id);
            if (c102575814Customer == null)
            {
                return NotFound();
            }

            return Ok(c102575814Customer);
        }

        // PUT: api/C102575814Customer/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutC102575814Customer(int id, C102575814Customer c102575814Customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c102575814Customer.CustNo_)
            {
                return BadRequest();
            }

            db.Entry(c102575814Customer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C102575814CustomerExists(id))
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

        // POST: api/C102575814Customer
        [ResponseType(typeof(C102575814Customer))]
        public async Task<IHttpActionResult> PostC102575814Customer(C102575814Customer c102575814Customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C102575814Customer.Add(c102575814Customer);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (C102575814CustomerExists(c102575814Customer.CustNo_))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c102575814Customer.CustNo_ }, c102575814Customer);
        }

        // DELETE: api/C102575814Customer/5
        [ResponseType(typeof(C102575814Customer))]
        public async Task<IHttpActionResult> DeleteC102575814Customer(int id)
        {
            C102575814Customer c102575814Customer = await db.C102575814Customer.FindAsync(id);
            if (c102575814Customer == null)
            {
                return NotFound();
            }

            db.C102575814Customer.Remove(c102575814Customer);
            await db.SaveChangesAsync();

            return Ok(c102575814Customer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C102575814CustomerExists(int id)
        {
            return db.C102575814Customer.Count(e => e.CustNo_ == id) > 0;
        }
    }
}