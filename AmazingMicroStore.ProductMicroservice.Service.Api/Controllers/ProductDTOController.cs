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
using AmazingMicroStore.ProductMicroservice.Application.AppModel.DTO;
using AmazingMicroStore.ProductMicroservice.Service.Api.Contexts;

namespace AmazingMicroStore.ProductMicroservice.Service.Api.Controllers
{
    public class ProductDTOController : ApiController
    {
        private ProductContext db = new ProductContext();

        // GET: api/ProductDTO
        public IQueryable<ProductDTO> GetProducts()
        {
            return db.Products;
        }

        // GET: api/ProductDTO/5
        [ResponseType(typeof(ProductDTO))]
        public async Task<IHttpActionResult> GetProductDTO(Guid id)
        {
            ProductDTO productDTO = await db.Products.FindAsync(id);
            if (productDTO == null)
            {
                return NotFound();
            }

            return Ok(productDTO);
        }

        // PUT: api/ProductDTO/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProductDTO(Guid id, ProductDTO productDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productDTO.Id)
            {
                return BadRequest();
            }

            db.Entry(productDTO).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductDTOExists(id))
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

        // POST: api/ProductDTO
        [ResponseType(typeof(ProductDTO))]
        public async Task<IHttpActionResult> PostProductDTO(ProductDTO productDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Products.Add(productDTO);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductDTOExists(productDTO.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = productDTO.Id }, productDTO);
        }

        // DELETE: api/ProductDTO/5
        [ResponseType(typeof(ProductDTO))]
        public async Task<IHttpActionResult> DeleteProductDTO(Guid id)
        {
            ProductDTO productDTO = await db.Products.FindAsync(id);
            if (productDTO == null)
            {
                return NotFound();
            }

            db.Products.Remove(productDTO);
            await db.SaveChangesAsync();

            return Ok(productDTO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductDTOExists(Guid id)
        {
            return db.Products.Count(e => e.Id == id) > 0;
        }
    }
}