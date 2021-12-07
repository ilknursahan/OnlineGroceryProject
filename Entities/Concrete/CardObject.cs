using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
   public  class CardObject:IEntity
    {
        public Product product { get; set; }
        public int CardId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; } 

    }
}
