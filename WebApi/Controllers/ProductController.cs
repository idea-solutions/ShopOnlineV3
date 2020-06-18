using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork;
using WebApi.Models.Dao;
using WebApi.Models.ModelView;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       private readonly IContainer _container;

        public ProductController(IContainer container)
        {
            _container = container;
        }
        // GET: api/Product
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = _container.CategoryFactory.GetAll();
                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        //// GET: api/Product/5
        //[HttpGet("{id}")]
        //public IActionResult Get(Guid id)
        //{
        //    try
        //    {
        //        return Ok(new ProductDao(_unitOfWork, _mapper).GetProductById(id));
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return BadRequest();
        //    }
        //}

        //// POST: api/Product
        //[HttpPost]
        //public IActionResult Post([FromBody] ProductMv product)
        //{
        //    try
        //    {
        //        return Created(Url.Action("Get"), new ProductDao(_unitOfWork, _mapper).CreateNewProduct(product));
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return BadRequest();
        //    }
        //}

        //// PUT: api/Product/5
        //[HttpPut("{id}")]
        //public IActionResult Put(Guid id, [FromBody] ProductMv product)
        //{
        //    try
        //    {
        //        return Created(Url.Action("Get"), new ProductDao(_unitOfWork, _mapper).UpdateProduct(id, product));
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return BadRequest();
        //    }
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public IActionResult Delete(Guid id)
        //{
        //    try
        //    {
        //        if (new ProductDao(_unitOfWork, _mapper).DeleteProduct(id)) return Ok();
        //        return NoContent();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return BadRequest();
        //    }
        //}
    }
}
