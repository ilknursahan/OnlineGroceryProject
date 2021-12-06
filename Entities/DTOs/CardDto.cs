using Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CardDto:IDto
    {

        public Product product { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get { return product.Price * Quantity; } }


    }
}
