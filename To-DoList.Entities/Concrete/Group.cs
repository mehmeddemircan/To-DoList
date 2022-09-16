using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Entities.Common;

namespace To_DoList.Entities.Concrete
{
    public class Group : BaseEntity
    {

      

        public string Title { get; set; }

        //[ForeignKey("Mission")]
        //public int? MissionId { get; set; }

        public  ICollection<Mission>? Missions { get; set; }



        public int ColorId { get; set; } = 1;

        public virtual Color? Color { get; set; }
     
        public int? ThemeId { get; set; }

        public virtual Theme? Theme { get; set; }



    }
}
