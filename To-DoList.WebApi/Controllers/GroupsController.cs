using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using To_DoList.Business.Abstract;
using To_DoList.Entities.Concrete;
using To_DoList.Entities.DTOs;

namespace To_DoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {


        IGroupService _groupService;

        public GroupsController(IGroupService groupService)
        {
            _groupService = groupService; 
        }

        [HttpPost("add-new-list")]

        public async Task<ActionResult<Group>> AddNewList(Group group)
        {
            return await _groupService.AddAsync(group);
        }

        [HttpGet("get-all-list")]

        public async Task<ActionResult<List<Group>>> GetAllList()
        {
            return await _groupService.GetAllAsync();   
        }

        [HttpGet("get-details")]

        public  ActionResult<Group> GetDetails(int groupId)
        {
            return  _groupService.GetDetails(groupId);
        }

        [HttpPut("update-list")]
        
        public async Task UpdateList(int groupId,Group group)
        {

            group.Id = groupId;

            await _groupService.TUpdate(groupId, group);
        }

        [HttpGet("get-details-as-dto")]

        public  ActionResult<GroupDetailsDTO> GetDetailsAsDto(int groupId)
        {
            return _groupService.GetDetailsAsDto(groupId);
        }

        [HttpDelete("delete-list")]

        public async Task DeleteList(int id)
        {

            await _groupService.TDelete(id); 


        }


    }
}
