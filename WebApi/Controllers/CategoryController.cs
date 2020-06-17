using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using UnitOfWork;
using WebApi.Models.Dao;
using WebApi.Models.ModelView;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/Category
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(new CategoryDao(_unitOfWork, _mapper).GetAllCate());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(new CategoryDao(_unitOfWork, _mapper).GetCateById(id));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        // POST: api/Category
        [HttpPost]
        public IActionResult Post([FromBody] CategoryMv category)
        {
            try
            {
                return Ok(new CategoryDao(_unitOfWork, _mapper).CreateNewCate(category));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] CategoryMv category)
        {
            try
            {
                if (new CategoryDao(_unitOfWork, _mapper).UpdateCate(id, category)) return Ok();
                return BadRequest();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                if (new CategoryDao(_unitOfWork, _mapper).DeleteCate(id)) return Ok();
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