using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomType
    {
        private int _idRT;
        private string _nameRT;
        private string _descRT;
        private int _limitPerson;
        private int _acreage;
        private bool _statusRT;

        public int IdRT { get => _idRT; set => _idRT = value; }
        public string NameRT { get => _nameRT; set => _nameRT = value; }
        public string DescRT { get => _descRT; set => _descRT = value; }
        public int LimitPerson { get => _limitPerson; set => _limitPerson = value;}
        public int Acreage { get => _acreage; set => _acreage = value; }
        public bool StatusRT { get => _statusRT; set => _statusRT = value; }

        public RoomType (int idRT, string nameRT, string descRT, int limitPerson, int acreage, bool statusRT)
        {
            this.IdRT = idRT;
            this.NameRT = nameRT;
            this.DescRT = descRT;
            this.LimitPerson = limitPerson;
            this.Acreage = acreage;
            this.StatusRT = statusRT;
        }

        public RoomType(DataRow row)
        {
            this.IdRT = (int)row["idRT"];
            this.NameRT = row["nameRT"].ToString();
            this.DescRT = row["descRT"].ToString();
            this.LimitPerson = (int)row["limitPerson"];
            this.Acreage = (int)row["acreage"];
            this.StatusRT = (bool)row["stastusRT"];
        }
    }
}
