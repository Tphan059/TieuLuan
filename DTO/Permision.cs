using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Permision
    {
        private int _idPer;
        private string _namePer;
        public int IdPer { get => _idPer; set => _idPer = value; }
        public string NamePer { get => _namePer; set => _namePer = value; }

        public Permision (int idPer, string namePer)
        {
            this.IdPer = idPer;
            this.NamePer = namePer;
        }

        public Permision (DataRow row) 
        {
            this.IdPer = (int)row["idPer"];
            this.NamePer = row["namePer"].ToString();
        }
    }
}
