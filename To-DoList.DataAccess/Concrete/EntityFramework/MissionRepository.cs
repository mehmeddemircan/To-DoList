using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Core.DataAccess.EntityFramework;
using To_DoList.DataAccess.Abstract;
using To_DoList.DataAccess.Concrete.Contexts;
using To_DoList.Entities.Concrete;

namespace To_DoList.DataAccess.Concrete.EntityFramework
{
    public class MissionRepository : EfEntityRepositoryBase<Mission, ApplicationDbContext>, IMissionRepository
    {
       

        public  async Task<List<Mission>> GetByGroupIdAsync(int groupId)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Set<Mission>().Where(mission => mission.GroupId == groupId).ToListAsync(); 
            }
        }

        public async Task<List<Mission>> GetCompletedMissions(int groupId, bool isCompleted)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Set<Mission>().Where(mission => mission.GroupId == groupId && mission.IsCompleted == isCompleted).ToListAsync(); 
            }
        }

     
    }
}
