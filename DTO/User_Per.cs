using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User_Per
    {
        private string _userName;
        private int _idPer;
        private bool _licensed;
        public string UserName { get => _userName; set => _userName = value;}
        public int IdPer { get => _idPer; set => _idPer = value;}
        public bool Licensed { get => _licensed; set => _licensed = value; }
        public User_Per (string userName, int idPer, bool licensed)
        {   
            this.UserName = userName;
            this.IdPer = idPer;
            this.Licensed = licensed;
        }

        public User_Per(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.IdPer = (int)row["idPer"];
            this.Licensed = (bool)row["licensed"];
        }
    }
}
