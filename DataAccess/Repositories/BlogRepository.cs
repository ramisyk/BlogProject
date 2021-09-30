using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void Add(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void AddCategory(Blog blog)
        {            

        }

        public void Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int blogId)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllCategories()
        {
            throw new NotImplementedException();
        }

        public void Update(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
