using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buesiness.Abstract
{
    public interface IBlogService
    {
        void Add(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);

        List<Blog> GetAll();
        List<Blog> GetWithCategory();
        List<Blog> GetByWriter(int writerId);
        Blog GetById(int id);
    }
}
