using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork;
using WebApi.Models.Dao;
using WebApi.Models.FactoryModule;
using WebApi.Models.ModelView;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeProductController : ControllerBase
    {
        private readonly IContainer _container;

        public TypeProductController(IContainer container)
        {
            _container = container;
        }

        // GET: api/TypeProduct
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_container.TypeProductFactory.GetAll().Result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        // GET: api/TypeProduct/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(_container.TypeProductFactory.GetById(id));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        // GET: api/TypeProduct/GetByProductId/5
        [HttpGet("GetByProductId/{id}")]
        public IActionResult GetByProductId(Guid id)
        {
            try
            {
                var data = _container.ProductFactory.GetById(id);
                var typeProducts = _container.TypeProductFactory.GetAll().Result.Where(x => x.ProductId == id).ToList();
                foreach (var typeProduct in typeProducts) typeProduct.Product = null; 
                
                data.TypeProducts =  typeProducts;
                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        // POST: api/TypeProduct
        [HttpPost]
        public IActionResult Post([FromBody] TypeProductMv typeProduct)
        {
            try
            {
                return Created(Url.Action("Get"), _container.TypeProductFactory.CreateNew(typeProduct));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        // PUT: api/TypeProduct/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] TypeProductMv typeProduct)
        {
            try
            {
                return Ok(_container.TypeProductFactory.Update(id, typeProduct));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }

        }

        // DELETE: api/TypeProduct/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                if (_container.TypeProductFactory.Delete(id)) return Ok();
                return BadRequest();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }
    }
}
