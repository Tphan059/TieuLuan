using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Equipment
    {
        private int _idTB;
        private int _idRT;
        private int _quantity;

        public int IdTB { get => _idTB; set => _idTB = value; }
        public int IdRT { get => _idRT; set => _idRT = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }

        public Equipment (int idTB, int idRT, int quantity)
        {
            this.IdTB = idTB;
            this.IdRT = idRT;
            this.Quantity = quantity;

        }

        public Equipment (DataRow row) 
        {
            this.IdTB = (int)row["idTB"];
            this.IdRT = (int)row["idRT"];
            this.Quantity = (int)row["quantity"];
        }
    }
}
