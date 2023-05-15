using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class UseServiceInfoBUS
    {
        private static UseServiceInfoBUS instance;
        public static UseServiceInfoBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UseServiceInfoBUS();
                }
                return instance;
            }
            private set
            {
                UseServiceInfoBUS.instance = value;
            }
        }

        public void ShowFormService(ListView lsv,TextBox text, int idBook)
        {
            lsv.Items.Clear();
            List<UseServiceInfo> List = UseServiceInfoDAO.Instance.GetUseServiceInfoByBook(idBook);
            float totalPrice = 0;
            foreach (UseServiceInfo info in List) 
            {
                ListViewItem lsvItem = new ListViewItem(info.NameServ.ToString());
                lsvItem.SubItems.Add(info.Count.ToString());
                lsvItem.SubItems.Add(info.Price.ToString());
                lsvItem.SubItems.Add(info.TotalPrice.ToString());
                totalPrice += info.TotalPrice;
                lsv.Items.Add(lsvItem);
            }

            text.Text =totalPrice.ToString();
        }

        public void ShowFormService2(ListView lsv, int idBook)
        {
            lsv.Items.Clear();
            List<UseServiceInfo> List = UseServiceInfoDAO.Instance.GetUseServiceInfoByBook1(idBook);
            foreach (UseServiceInfo info in List)
            {
                ListViewItem lsvItem = new ListViewItem(info.NameServ.ToString());
                lsvItem.SubItems.Add(info.Count.ToString());
                lsvItem.SubItems.Add(info.Price.ToString());
                lsvItem.SubItems.Add(info.TotalPrice.ToString());
                lsv.Items.Add(lsvItem);
            }
        }

        public void InsertUseServiceInfo(int idBook, int idServ, int quantity)
        {
            int idForm = UseServiceFormDAO.Instance.GetUnCheckUseServiceForm(idBook);
            if (idForm == -1)
            {
                UseServiceFormDAO.Instance.InserUseServiceForm(idBook, idServ, quantity);
            }
            else
            { 
                UseServiceDAO.Instance.InsertUseService(idForm, idServ, quantity);
            }
        }
    }
}
