using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERoomManagementConsole
{
    public class FloorSecond : AbstractPerson
    {
        public FloorSecond() { }


        public FloorSecond(int id, string studentId, string studentName, string hours, int floorNo, int roomNo)
            : base(id, studentId, studentName, hours, floorNo, roomNo)
        {

        }
    }
}
