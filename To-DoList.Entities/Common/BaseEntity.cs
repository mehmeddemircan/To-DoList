using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_DoList.Entities.Common
{
    public class BaseEntity
    {

        public int Id { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public int UpdatedBy { get; set; }

        public DateTime UpdatedTime { get; set; }
    }
}
