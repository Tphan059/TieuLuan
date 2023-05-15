using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Permision_detail
    {
        private int _idDetail;
        private int _idPer;
        private string _nameFun;
        private string _idFun;
        private bool _check_action;

        public int IdDetail { get => _idDetail; set => _idDetail = value; }
        public int IdPer { get => _idPer; set => _idPer = value; }
        public string NameFun { get => _nameFun; set => _nameFun = value; }
        public string IdFun { get => _idFun; set => _idFun = value; }
        public bool Check_action { get => _check_action; set => _check_action = value; }

        public Permision_detail (int idDerail, int idPer, string nameFun, string idFun, bool check_action)
        {
            this.IdDetail = idDerail;
            this.IdPer = idPer;
            this.NameFun = nameFun;
            this.IdFun = idFun;
            this.Check_action = check_action;
        }

        public Permision_detail (DataRow row) 
        {
            this.IdDetail = (int)row["idDetail"];
            this.IdPer = (int)row["idPer"]; 
            this.NameFun = row["nameFun"].ToString() ;
            this.IdFun = row["idFun"].ToString();
            this.Check_action = (bool)row["check_action"];
        }
    }
}
