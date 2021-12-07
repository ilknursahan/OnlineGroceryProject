using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetData.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CardObjectsController : ControllerBase
    {
        ICardObjectService _cardService;

        public CardObjectsController(ICardObjectService cardService)
        {
            _cardService = cardService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _cardService.GetList();

            return Ok(result);
        }

        [HttpPost("addtocard")]
        public IActionResult AddToCard(CardObject cardItem)
        {
            _cardService.AddCard(cardItem);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Remove(int id)
        {
            var carditem = _cardService.GetById(id);

            _cardService.DeleteCard(carditem);

            return Ok();
        }

        [HttpGet("gettocard")]
        public IActionResult GetToCard()
        {
           var result = _cardService.GetTotal();

            return Ok(result);
        }
    }
}
