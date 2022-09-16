using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Entities.Concrete;

namespace To_DoList.Business.Abstract
{
    public interface IMissionService  : IGenericService<Mission>
    {
        public Task<List<Mission>> GetByGroupIdAsync(int groupId);
        public Task<List<Mission>> GetCompletedMissions(int groupId, bool isCompleted);

        public Task<List<Mission>> GetStarredMissions(int groupId, bool isStarred);

  
        
     }
}
