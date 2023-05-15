using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nationality
    {
        private int _idNa;
        private string _nameNa;
        public int IdNa { get => _idNa; set => _idNa = value; }
        public string NameNa { get => _nameNa; set => _nameNa = value; }

        public Nationality (int idNa, string nameNa)
        {
            this.IdNa = idNa;
            this.NameNa = nameNa;
        }

        public Nationality(DataRow row)
        {
            this.IdNa = (int)row["idNa"];
            this.NameNa = row["nameNa"].ToString();
        }
    }
}
