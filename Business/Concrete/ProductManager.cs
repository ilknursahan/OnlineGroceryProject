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

       

   
    }
}
