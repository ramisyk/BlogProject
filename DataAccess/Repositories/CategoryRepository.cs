using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public void Add(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void Delete(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int categoryId)
        {
            return c.Categories.Find(categoryId);
        }

        public List<Category> GetAll()
        {
            return c.Categories.ToList();
        }

        public void Update(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
