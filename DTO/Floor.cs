using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Floor
    {
        private int _idFloor;
        private string _nameFloor;
        public int IdFloor { get => _idFloor; set => _idFloor = value; }
        public string NameFloor { get => _nameFloor; set => _nameFloor = value; }

        public Floor (int idFloor, string nameFloor)
        {
            this.IdFloor = idFloor;
            this.NameFloor = nameFloor;
        }

        public Floor (DataRow row) 
        {
            this.IdFloor = (int)row["idFloor"];
            this.NameFloor = row["nameFloor"].ToString();
        }
    }
}
