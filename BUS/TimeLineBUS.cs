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
    public class TimeLineBUS
    {
        private static TimeLineBUS instance;
        public static TimeLineBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TimeLineBUS();
                return instance;
            }
            private set
            {
                TimeLineBUS.instance = value;
            }
        }
        public  TimeLineBUS() { }

        public void GetTimeLineToCB(ComboBox cb)
        {
            cb.DataSource = TimeLineDAO.Instance.GetTimelines();
            cb.DisplayMember = "nameTL";
            cb.SelectedIndex = 0;
            cb.ValueMember = "idTL";
        }
        
        public List<Timeline> GetTimelineById(int idTL)
        {
            return TimeLineDAO.Instance.GetTimelineById(idTL);
        }

        public List<Timeline> GetTimelineByName(string nameTL)
        {
            return TimeLineDAO.Instance.GetTimelineByName(nameTL);
        }
    }
}
