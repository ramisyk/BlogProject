using Buesiness.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buesiness.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetByWriter(int writerId)
        {
            return _blogDal.GetAll(x => x.WriterId == writerId);
        }

        public List<Blog> GetWithCategory()
        {
            return _blogDal.GetWithCategory();
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
