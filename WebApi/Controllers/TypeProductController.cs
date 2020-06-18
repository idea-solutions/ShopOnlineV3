using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork;
using WebApi.Models.Dao;
using WebApi.Models.ModelView;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TypeProductController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/TypeProduct
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(new TypeProductDao(_unitOfWork, _mapper).GetAllTypeProduct().Result);
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
                return Ok(new TypeProductDao(_unitOfWork, _mapper).GetTypeProductById(id));
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
                return Created(Url.Action("Get"), new TypeProductDao(_unitOfWork, _mapper).CreateNewTypeProduct(typeProduct));
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
                return Created(Url.Action("Get"), new TypeProductDao(_unitOfWork, _mapper).UpdateTypeProduct(id, typeProduct));
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
                if (new TypeProductDao(_unitOfWork, _mapper).DeleteTypeProduct(id)) return Ok();
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
