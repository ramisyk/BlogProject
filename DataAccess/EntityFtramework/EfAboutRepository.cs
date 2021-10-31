using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFtramework
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
        public List<About> GetAll2()
        {
            using (var context = new Context())
            {
                return context.Abouts.ToList();
            }
        }
    }
}
