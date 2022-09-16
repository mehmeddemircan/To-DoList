using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Core.DataAccess.EntityFramework;
using To_DoList.DataAccess.Abstract;
using To_DoList.DataAccess.Concrete.Contexts;
using To_DoList.Entities.Concrete;
using To_DoList.Entities.DTOs;

namespace To_DoList.DataAccess.Concrete.EntityFramework
{
    public class GroupRepository : EfEntityRepositoryBase<Group, ApplicationDbContext>, IGroupRepository
    {
        public  Group GetDetails(int groupId)
        {
            using (var context = new ApplicationDbContext())
            {
                var result = context.Groups.Select(g => new Group()
                {
                    Id = g.Id,
                    Title = g.Title,
                    ColorId = g.ColorId,
                  
                   
                    CreatedTime = g.CreatedTime,
                    ThemeId = g.ThemeId,
                    UpdatedBy = g.UpdatedBy,
                    UpdatedTime = g.UpdatedTime,

                    Missions = g.Missions.Select(m => new Mission()
                    {
                        Id = m.Id,
                        Text = m.Text,
                        IsCompleted = m.IsCompleted,
                        IsStarred = m.IsStarred,
                        CreatedTime = m.CreatedTime,
                        GroupId = m.GroupId,
                        EndDate = m.EndDate,
                        NoteText = m.NoteText,
                        UpdatedBy = m.UpdatedBy,
                        UpdatedTime = m.UpdatedTime,
                    }).ToList(),
                }).Where((g) => g.Id == groupId).SingleOrDefault();

                return result; 
              
            }
        }

        public GroupDetailsDTO GetDetailsAsDto(int groupId)
        {
            using (var context = new ApplicationDbContext() )
            {
                var result = context.Groups.Select(g => new GroupDetailsDTO()
                {
                    Id = g.Id,
                    Title = g.Title,
                    Color = new Color()
                    {
                        Id = g.Color.Id , 
                        ColorText = g.Color.ColorText,
                       ColorHexaDecimal = g.Color.ColorHexaDecimal ,
                    },
                    //Theme = new Theme()
                    //{
                    //    Id=  g.Theme.Id,
                    //    Text = g.Theme.Text,
                    //    ThemeImage = g.Theme.ThemeImage
                    //},
                    Missions = g.Missions.Select(m => new Mission()
                    {
                        Id = m.Id,
                        Text = m.Text,
                        IsCompleted = m.IsCompleted,
                        IsStarred = m.IsStarred,
                        CreatedTime = m.CreatedTime,
                        GroupId = m.GroupId,
                        EndDate = m.EndDate,
                        NoteText = m.NoteText,
                        UpdatedBy = m.UpdatedBy,
                        UpdatedTime = m.UpdatedTime,
                    }).ToList(),
                }).Where((g) => g.Id == groupId).SingleOrDefault();

                return result;
            }
        }
    }
}
