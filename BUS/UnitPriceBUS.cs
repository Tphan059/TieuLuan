using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class UnitPriceBUS
    {
        private static UnitPriceBUS instance;
        public static UnitPriceBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new UnitPriceBUS();
                return instance;
            }
            private set
            {
                UnitPriceBUS.instance = value;
            }
        }
        private UnitPriceBUS() { }

        public List<unitPrice> GetPriceByRtTl(int idRT, int idTL)
        {
            return UnitPriceDAO.Instance.GetUnitPriceByIdRTIdTl(idRT, idTL);
        }

        public void GetUnitPrice(DataGridView dt)
        {
            dt.DataSource = UnitPriceDAO.Instance.GetUnitPrice();
        }

        public void GetUnitPriceById(int id, DataGridView dt)
        {
            int temp = id;
            dt.DataSource = UnitPriceDAO.Instance.GetUnitPriceInfoByIdRT(id);
        }

        public void Insert(int idrt, int idtl, float price)
        {
            if(UnitPriceDAO.Instance.InsertPrice(idrt, idtl, price))
            {
                MessageBox.Show("Thêm giá phòng thành công");
            }
            else
            {
                MessageBox.Show("Đã tồn tại giá của phòng! Không thể thêm");
            }
        }

        public void Update(int idrt, int idtl, float price)
        {
            if (UnitPriceDAO.Instance.UpdatePrice(idrt, idtl, price))
            {
                MessageBox.Show("Cập nhật giá phòng thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
