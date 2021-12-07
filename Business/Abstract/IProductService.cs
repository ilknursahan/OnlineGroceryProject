using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IProductService
    {
        List<Product> GetList();
        Product Get(int id);

        //decimal GetTotal();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        //void AddCard(CardDto cardDto);
        
        //void DeleteCard(int id);
    }
}
