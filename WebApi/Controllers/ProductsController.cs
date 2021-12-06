using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public List<CardDto> products = new List<CardDto>();
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _productService.GetList();

            return Ok(result);

        }

        [HttpPost("addtocard")]
        public IActionResult AddToCard(CardDto cardDto)
        {
            _productService.AddCard(cardDto);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Remove(int id)
        {
            
            _productService.DeleteCard(id); 
           
            return Ok();
        }

        [HttpGet("gettocard")]
        public IActionResult GetToCard()
        {

            _productService.GetTotal();

            return Ok();
        }
    }
}
