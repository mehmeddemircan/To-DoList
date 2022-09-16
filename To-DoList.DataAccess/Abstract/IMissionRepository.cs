using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Core.DataAccess;
using To_DoList.Entities.Concrete;

namespace To_DoList.DataAccess.Abstract
{
    public interface IMissionRepository : IEntityRepository<Mission>
    {

        public Task<List<Mission>> GetByGroupIdAsync(int groupId); 

        public Task<List<Mission>> GetCompletedMissions(int groupId,bool isCompleted);


    }
}
