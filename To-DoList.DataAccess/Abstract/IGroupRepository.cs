using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Core.DataAccess;
using To_DoList.Entities.Concrete;
using To_DoList.Entities.DTOs;

namespace To_DoList.DataAccess.Abstract
{
    public interface IGroupRepository : IEntityRepository<Group>
    {

        public Group GetDetails(int groupId); 
        public GroupDetailsDTO GetDetailsAsDto(int groupId); 
    }
}
