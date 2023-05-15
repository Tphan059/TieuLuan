using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomStatus
    {
        private int _idRStatus;
        private string _nameRStatus;
        public int IdRStatus { get => _idRStatus; set => _idRStatus = value; }
        public string NameRStatus { get => _nameRStatus; set => _nameRStatus = value; }

        public RoomStatus (int idRStatus, string nameRStatus)
        {
            this.IdRStatus = idRStatus;
            this.NameRStatus = nameRStatus;
        }

        public RoomStatus (DataRow row)
        {
            this.IdRStatus = (int)row["idRStatus"];
            this.NameRStatus = row["nameRStatus"].ToString();
        }
    }
}
