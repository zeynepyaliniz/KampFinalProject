using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  // attribute ---- javada annotation
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;

        }
        //[HttpGet]
        //public List<Product> _Get()
        //{

        //    var result = _productService.GetAll();
        //    return result.Data;

        //}
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {

            var result = _productService.Add(product);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int Id)
        {
            var res = _productService.GetById(Id);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);



        }
    }
}
