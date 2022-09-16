using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using To_DoList.Business.Abstract;
using To_DoList.Entities.Concrete;

namespace To_DoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionsController : ControllerBase
    {
        IMissionService _missionService;

        public MissionsController(IMissionService missionService)
        {
            _missionService = missionService;
        }

        [HttpGet("get-all")]

        public async Task<ActionResult<List<Mission>>> GetAllMission()
        {
            return await _missionService.GetAllAsync();
        }

        [HttpPost("add-new")]
         
        public async Task<ActionResult<Mission>> AddMission(Mission mission)
        {
            return await _missionService.AddAsync(mission); 
        }


        [HttpPost("add-new2")]

        public async Task<ActionResult> AddMission2(Mission mission)
        {
            var result = await _missionService.AddNewAsync2(mission);

            if (result.Success)
            {
                return Ok(result.Message); 
            }

            return BadRequest(result.Message); 
        }

        [HttpGet("get-by-group")]

        public async Task<ActionResult<List<Mission>>> GetMissionsByList(int groupId)
        {
            return await _missionService.GetByGroupIdAsync(groupId); 
        }

        [HttpPut("update-mission")]

        public async Task UpdateMission(int missionId,Mission mission)
        {   

            mission.Id = missionId;
            await _missionService.TUpdate(missionId,mission);
        }


        [HttpGet("get-completed-missions")]

        public async Task<ActionResult<List<Mission>>> GetCompletedMissions(int groupId,bool isCompleted)
        {
            return await _missionService.GetCompletedMissions(groupId,isCompleted);
        }

        [HttpGet("get-by-id")]

        public async Task<ActionResult<Mission>> GetSingleMission(int missionId)
        {
            return await _missionService.GetById(missionId); 
        }

        [HttpGet("get-starred-missions")]

        public async Task<ActionResult<List<Mission>>> GetStarredMissions(int groupId, bool isStarred)
        {
            return await _missionService.GetStarredMissions(groupId, isStarred); 
        }
        //httpdelete

        [HttpDelete("delete-mission")]

        public async Task DeleteMission(int id)
        {
            await _missionService.TDelete(id); 
        }



     }
}
