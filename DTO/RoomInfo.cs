using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomInfo
    {
        private int _idRoom;
        private string _nameRoom;
        private string _nameRT;
        private string _nameFloor;
        private string _nameRStatus;
        public int IdRoom { get => _idRoom; set => _idRoom = value; }
        public string NameRoom { get => _nameRoom; set => _nameRoom = value; }
        public string NameRT { get => _nameRT; set => _nameRT = value; }
        public string NameFloor { get => _nameFloor; set => _nameFloor = value; }
        public string NameRStatus { get => _nameRStatus; set => _nameRStatus = value; }

        public RoomInfo(int idRoom, string nameRoom, string nameRT, string nameFloor, string nameRStatus)
        {
            this.IdRoom = idRoom;
            this.NameRoom = nameRoom;
            this.NameRT = nameRT;
            this.NameFloor = nameFloor;
            this.NameRStatus = nameRStatus;
        }

        public RoomInfo(DataRow row)
        {
            //this.IdRoom = (int)row["idRoom"];
            this.NameRoom = row["nameRoom"].ToString();
            this.NameRT = row["nameRT"].ToString();
            this.NameFloor = row["nameFloor"].ToString();
            this.NameRStatus = row["nameRStatus"].ToString();
        }
    }
}
