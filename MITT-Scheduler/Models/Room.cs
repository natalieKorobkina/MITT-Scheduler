using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MITT_Scheduler.Models
{
    public class Room
    {
        public int? RoomId { get; }
        public string RoomNumber { get; }

        public Room(int? id, string roomNumber)
        {
            RoomId = id;
            RoomNumber = roomNumber;
        }
    }
}