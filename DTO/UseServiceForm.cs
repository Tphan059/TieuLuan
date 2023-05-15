using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UseServiceForm
    {
        private int _idForm;
        private int _idBook;
        public int IdForm { get => _idForm; set => _idForm = value; }
        public int IdBook { get => _idBook; set => _idBook = value; }
        public UseServiceForm (int idForm, int idBook)
        {
            this.IdForm = idForm;
            this.IdBook = idBook;
        }

        public UseServiceForm(DataRow row)
        {
            this.IdForm = (int)row["idForm"];
            this.IdBook = (int)row["idBook"];
        }
    }
}
