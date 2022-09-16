using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Core.Utilities.Results;
using To_DoList.Business.Abstract;
using To_DoList.DataAccess.Abstract;
using To_DoList.Entities.Concrete;
using To_DoList.Entities.DTOs;

namespace To_DoList.Business.Concrete
{
    public class GroupManager : IGroupService
    {

        IGroupRepository _groupRepository;

        public GroupManager(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task<Group> AddAsync(Group entity)
        {
           return await _groupRepository.AddNewAsync(entity);
        }

        public Task<IResult> AddNewAsync2(Group entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Group>> GetAllAsync()
        {
            return await _groupRepository.GetAllAsync();
        }

        public Task<Group> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Group GetDetails(int groupId)
        {
            return  _groupRepository.GetDetails(groupId); 
        }

        public GroupDetailsDTO GetDetailsAsDto(int groupId)
        {
            return _groupRepository.GetDetailsAsDto(groupId); 
        }

        public async Task TDelete(int id)
        {
            await _groupRepository.TDelete(id); 
        }

        public async Task TUpdate(int id, Group entity)
        {
            await _groupRepository.TUpdate(id, entity);
        }
    }
}
