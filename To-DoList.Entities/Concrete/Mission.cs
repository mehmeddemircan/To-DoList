using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Entities.Common;

namespace To_DoList.Entities.Concrete
{
    public class Mission : BaseEntity
    {
        public string Text { get; set; }

        public bool IsCompleted { get; set; } = false;

        public bool IsStarred { get; set; } = false; 

        public DateTime? EndDate { get; set; }

        public string?  NoteText { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }

      
    }
}
