using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class TicketClass
    {
        public TicketClass()
        {
        }

        public int ClassId { get; set; }
        public string ClassType { get; set; }

        public TicketClass(int classId, string classType)
        {
            ClassId = classId;
            ClassType = classType;
        }
    }
}
