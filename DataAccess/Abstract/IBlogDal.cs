using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    interface IBlogDal
    {
        List<Blog> ListAllCategories();
        void AddCategory(Blog blog);
        void DeleteCategory(Blog blog);
        void UpdateCategory(Blog blog);
        Blog GetById(int blogId);
    }
}
