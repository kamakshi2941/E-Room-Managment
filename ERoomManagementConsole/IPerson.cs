using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERoomManagementConsole
{
    public interface IPerson
    {

        int Id { get; set; }
        string StudentId { get; set; }
        string StudentIdMask { get; set; }
        string StudentName { get; set; }
        string Hours { get; set; }
        int FloorNo { get; set; }
        string FloorText { get; set; }
        int RoomNo { get; set; }

        string RoomText { get; set; }



    }
}
