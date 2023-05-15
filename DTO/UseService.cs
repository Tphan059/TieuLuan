using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UseService
    {
        private int _idForm;
        private int _idServ;
        private int _quantity;
        private int _id;
        
        public int IdForm { get { return _idForm; } set { _idForm = value; } }
        public int IdServ { get { return _idServ;} set { _idServ = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public int Id { get { return _id; } set { _id = value; } }

        public UseService(int idForm, int idServ, int quantity, int id) 
        {
            this.IdForm = idForm;
            this.IdServ = idServ;
            this.Quantity = quantity;
            this.Id = id;
        }

        public UseService(DataRow row) 
        {
            this.IdForm = (int)row["idForm"];
            this.IdServ = (int)row["idServ"];
            this.Quantity = (int)row["quantity"];
            this.Id = (int)row["id"];
        }
    }
}
