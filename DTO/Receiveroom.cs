using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Receiveroom
    {
        private int _idRece;
        private int _idRoom;
        private int _idBook;
        private float _traTruoc;
        private DateTime _dateCheck;
        private DateTime? _dateOut;

        public int IdRece { get => _idRece; set => _idRece = value; }
        public int IdRoom { get => _idRoom; set => _idRoom = value; }
        public int IdBook { get => _idBook; set => _idBook = value; }
        public float TraTruoc { get => _traTruoc; set => _traTruoc = value; }
        public DateTime DateCheck { get => _dateCheck; set => _dateCheck = value; }
        public DateTime? DateOut { get => _dateOut; set => _dateOut = value; }

        public Receiveroom (int idRece, int idRoom, int idBook, DateTime dateCheck, DateTime? dateOut, float traTruoc)
        {
            this.IdRece = idRece;
            this.IdRoom = idRoom;
            this.IdBook = idBook;
            this.DateCheck = dateCheck;
            this.DateOut = dateOut;
            this.TraTruoc = traTruoc;
        }

        public Receiveroom (DataRow row)
        {
            this.IdRece = (int)row["idRece"];
            this.IdRoom = (int)row["idRoom"];
            this.IdBook = (int)row["idBook"];
            this.DateCheck = (DateTime)row["dateCheck"];
            this.DateOut = row["dateOut"].ToString() == string.Empty ? null : (DateTime?)row["dateOut"];
            this.TraTruoc = (float)Convert.ToDouble(row["datTruoc"].ToString());
        }
    }
}
