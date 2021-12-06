using Core.Entityframework;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
  public class EfProductDal : EfEntityRepositoryBase<Product, BasicProjectContext>, IProductDal
    {
      
    }
}
