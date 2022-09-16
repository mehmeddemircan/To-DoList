using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Core.DataAccess.EntityFramework;
using To_DoList.DataAccess.Abstract;
using To_DoList.DataAccess.Concrete.Contexts;
using To_DoList.Entities.Concrete;

namespace To_DoList.DataAccess.Concrete.EntityFramework
{
    public class ColorRepository : EfEntityRepositoryBase<Color,ApplicationDbContext>, IColorRepository
    {
        
    }
}
