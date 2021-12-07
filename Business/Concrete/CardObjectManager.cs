using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CardObjectManager : ICardObjectService
    {
        private ICardIObjectDal _cardItemDal;


        public CardObjectManager(ICardIObjectDal cardItemDal)
        {
            _cardItemDal = cardItemDal;
        }
        public void AddCard(CardObject cardItem)
        {
            var products = _cardItemDal.GetList();
           
            if (products.Any(x=>x.ProductId==cardItem.ProductId))

            {
             cardItem.Quantity =  products.FirstOrDefault(x => x.ProductId == cardItem.ProductId).Quantity++;
                _cardItemDal.Update(cardItem);

            }
            else
            {
                _cardItemDal.Add(cardItem);
            }
    
        }

        public void DeleteCard(CardObject cardItem)
        {
            var products = _cardItemDal.GetList();
            if (products.Any(x => x.ProductId == cardItem.ProductId))

            {
                var quantity = products.FirstOrDefault(x => x.ProductId == cardItem.ProductId).Quantity--;
                cardItem.Quantity = quantity;
                cardItem.TotalPrice = cardItem.product.Price * quantity;
                _cardItemDal.Update(cardItem);

            }
            else
            {
                _cardItemDal.Delete(cardItem);
            }
        }

    

        public List<CardObject> GetList()
        {
            return _cardItemDal.GetList();
        }

        public decimal GetTotal()
        {
            var products = _cardItemDal.GetList();
            var total =  products.Sum(x => x.TotalPrice);
        
            return total;
        }

        public CardObject GetById(int id)
        {
            return _cardItemDal.Get(x => x.CardId == id); 
        }

      
    }
}
