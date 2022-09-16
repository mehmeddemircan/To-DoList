using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Entities.Concrete;

namespace To_DoList.Entities.DTOs
{
    public class GroupDetailsDTO
    {

        public int Id { get; set; }

        public string Title { get; set; }


        public ICollection<Mission> Missions { get; set; }

        public virtual Color  Color { get; set;  }

        public virtual Theme Theme { get; set; }






    }
}
