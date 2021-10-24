using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buesiness.Abstract
{
    public interface INewsletterService
    {
        void AddNewsLetter(Newsletter newsletter);

    }
}
