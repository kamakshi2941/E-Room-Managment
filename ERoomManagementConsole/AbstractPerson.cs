using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERoomManagementConsole
{

    public enum Floors { First, Second, Third }
    public enum FirstFloor { A001, A002, A003, A004}
    public enum SecondFloor { B001, B002, B003, B004 }
    public enum ThirdFloor { C001, C002, C003, C004 }


    public class AbstractPerson : IPerson
    {
        private int id;
        private string studentId;
        private string studentIdMask;
        private string studentName;
        private string hours;
        private int floorNo;
        private string floorText;
        private int roomNo;
        private string roomText;

        public string StudentId { get => studentId; set 
            {
                studentId = value;
                MaskNumber(studentId);
            } 
        }
        public string StudentIdMask { get => studentIdMask; set => studentIdMask = value; }
        public string StudentName { get => studentName; set => studentName =value; }
        public string Hours { get => hours; set => hours = value; }
        public int FloorNo { get => floorNo; set 
            {
                floorNo = value;
                floorText = ((Floors)floorNo).ToString(); 
            }
        }
        public string FloorText { get => floorText; set => floorText = value; }
        public int RoomNo { get => roomNo; set { 
                roomNo = value;
                setRoomNo(roomNo);
            }
        }
        public string RoomText { get => roomText; set => roomText = value; }
        public int Id { get => id; set => id = value; }


        public AbstractPerson() { }

        public AbstractPerson (int id, string studentId, string studentName, string hours, int floorNo, int roomNo)
        {
            Id = id;
            StudentId = studentId;
            StudentName = studentName;
            Hours = hours;
            FloorNo = floorNo;
            RoomNo = roomNo;
        }

        public void setRoomNo(int roomNo)
        {
            switch((Floors)FloorNo) {
                case Floors.First:
                    roomText = ((FirstFloor)roomNo).ToString();
                    break; 
                case Floors.Second:
                    roomText = ((SecondFloor)roomNo).ToString();
                    break; 
                case Floors.Third:
                    roomText = ((ThirdFloor)roomNo).ToString();
                    break;

            }
        }

        private void MaskNumber(string studentId)
        {
            if (!string.IsNullOrEmpty(studentId))
            {
                int visibleDigits = 3;
                char maskCharacter = '*';

                if (studentId.Length <= visibleDigits)
                    return ;

                string visiblePart = studentId.Substring(studentId.Length - visibleDigits);
                string maskedPart = new string(maskCharacter, studentId.Length - visibleDigits);
                StudentIdMask = maskedPart + visiblePart;
            }
           
        }

    }

    
}
