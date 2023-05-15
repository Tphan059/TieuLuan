using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Timeline
    {
        private int _idTL;
        private string _nameTL;
        private bool _statusTL;
        public int IdTL { get => _idTL; set => _idTL = value; }
        public string NameTL { get => _nameTL; set => _nameTL = value; }
        public bool StatusTL { get => _statusTL; set => _statusTL = value; }

        public Timeline (int idTL, string nameTL, bool statusTL)
        {
            this.IdTL = idTL;
            this.NameTL = nameTL;
            this.StatusTL = statusTL;
        }

        public Timeline(DataRow row)
        {
            this.IdTL = (int)row["idTL"];
            this.NameTL = row["nameTL"].ToString();
            this.StatusTL = (bool)row["statusTL"];
        }
    }
}
