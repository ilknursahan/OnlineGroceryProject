using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICardObjectService
    {

        List<CardObject> GetList();

        CardObject GetById(int id);

        decimal GetTotal();
       
        void AddCard(CardObject cardItem);
    
        void DeleteCard(CardObject cardItem);
    }
}
