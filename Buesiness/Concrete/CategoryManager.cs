﻿using Buesiness.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buesiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        GenerikRepository<Category> repo = new GenerikRepository<Category>();
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
