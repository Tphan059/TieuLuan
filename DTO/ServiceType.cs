using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ServiceType
    {
        private int _idST;
        private string _nameST;
        private bool _statusST;
        public int IdST { get => _idST; set => _idST = value ;}
        public string NameST { get => _nameST; set => _nameST = value;}
        public bool StatusST { get => _statusST; set => _statusST = value; }

        public ServiceType (int idST, string nameST, bool statusST)
        {
            this.IdST = idST;
            this.NameST = nameST;
            this.StatusST = statusST;
        }

        public ServiceType(DataRow row)
        {
            this.IdST = (int)row["idST"];
            this.NameST = row["nameST"].ToString();
            this.StatusST = (bool)row["statusST"];
        }
    }
}
