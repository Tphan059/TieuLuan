using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Room
    {
        private int _idRoom;
        private string _nameRoom;
        private int _idRT;
        private int _idFloor;
        private int _idRStatus;
        public int IdRoom { get => _idRoom; set => _idRoom = value; }
        public string NameRoom { get => _nameRoom; set => _nameRoom = value; }
        public int IdRT { get => _idRT; set => _idRT = value; }
        public int IdFloor { get => _idFloor; set => _idFloor = value; }
        public int IdRStatus { get => _idRStatus; set => _idRStatus = value; }

        public Room (int idRoom, string nameRoom, int idRT, int idFloor, int idRStatus)
        {
            this.IdRoom = idRoom;
            this.NameRoom = nameRoom;
            this.IdRT = idRT;
            this.IdFloor = idFloor;
            this.IdRStatus = idRStatus;
        }

        public Room (DataRow row) 
        {
            this.IdRoom = (int)row["idRoom"];
            this.NameRoom = row["nameRoom"].ToString();
            this.IdRT = (int)row["idRT"];
            this.IdFloor = (int)row["idFloor"];
            this.IdRStatus = (int)row["idRStatus"];
        }
    }
}
