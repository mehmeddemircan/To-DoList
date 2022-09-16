using Business.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Core.Utilities.Results;
using To_DoList.Business.Abstract;
using To_DoList.DataAccess.Abstract;
using To_DoList.Entities.Concrete;

namespace To_DoList.Business.Concrete
{
    public class MissionManager : IMissionService 
    {

        IMissionRepository _missionRepository;

        public MissionManager(IMissionRepository missionRepository)
        {
            _missionRepository = missionRepository;
        }

        public async Task<Mission> AddAsync(Mission mission)
        {
            return await _missionRepository.AddNewAsync(mission);
        }

        public async Task<IResult> AddNewAsync2(Mission mission)
        {
            await _missionRepository.AddNewAsync2(mission);
                return new SuccessResult(Messages.ProductAdded); 
        }


       
        public async Task<List<Mission>> GetAllAsync()
        {
            return await _missionRepository.GetAllAsync(); 
        }

        public  async Task<List<Mission>> GetByGroupIdAsync(int groupId)
        {
            return await _missionRepository.GetByGroupIdAsync(groupId); 
        }

        public async Task<Mission> GetById(int id)
        {
            return await _missionRepository.GetSingle((mission) => mission.Id == id); 
        }

        public async Task<List<Mission>> GetCompletedMissions(int groupId , bool isCompleted)
        {
            return await _missionRepository.GetCompletedMissions(groupId,isCompleted); 
        }

 

        public async Task<List<Mission>> GetStarredMissions(int groupId, bool isStarred)
        {
           return await _missionRepository.GetList((mission) => mission.GroupId == groupId && mission.IsStarred == isStarred);
        }

        public async Task TDelete(int id)
        {
            await _missionRepository.TDelete(id); 
        }

        public async Task TUpdate(int id, Mission entity)
        {
            await _missionRepository.TUpdate(id,entity);
        }
    }
}
