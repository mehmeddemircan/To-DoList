using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Entities.Common;

namespace To_DoList.Entities.Concrete
{
    public class Color : BaseEntity
    {

        public string ColorText { get; set; }

        public string ColorHexaDecimal { get; set; }
    }
}
