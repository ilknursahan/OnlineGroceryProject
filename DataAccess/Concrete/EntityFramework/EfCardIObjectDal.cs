using Core.Entityframework;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCardIObjectDal: EfEntityRepositoryBase<CardObject, BasicProjectContext>, ICardIObjectDal
    {
    }
}
