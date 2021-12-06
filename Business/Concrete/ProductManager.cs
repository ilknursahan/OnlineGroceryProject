using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;

        public List<CardDto> products = new List<CardDto>();

        public List<CardDto> Products
        {
            get
            {
                return products;
            }
            set { products = value; }
        }

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public Product Get(int id)
        {
           return _productDal.Get(x => x.ProductId == id);
        }

        public List<Product> GetList()
        {
            return _productDal.GetList();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public void AddCard(CardDto cardDto)
        {
            if (Products.Any(x=>x.ProductId==cardDto.ProductId))
            {
                Products.FirstOrDefault(x => x.ProductId == cardDto.ProductId).Quantity++; 
   
            }
            else
            {
               
                Products.Add(cardDto);
            }
        }
        public decimal GetTotal()
        {
            return ((decimal)Products.Sum(x => x.TotalPrice));
        }


    

        public void DeleteCard(int id)
        {

            if (Products.FirstOrDefault(x => x.ProductId == id).Quantity>1)
            {
                Products.FirstOrDefault(x => x.ProductId == id).Quantity--;

            }
            else
            {
                CardDto card = Products.FirstOrDefault(x => x.product.ProductId == id);
                Products.Remove(card);
            }
        }

   
    }
}
