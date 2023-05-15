using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TimeLineDAO
    {
        private static TimeLineDAO instance;
        public static TimeLineDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TimeLineDAO();
                return instance;
            }
            private set
            {
                TimeLineDAO.instance = value;
            }
        }
        public TimeLineDAO() { }

        public List<Timeline> GetTimelines()
        {
            List<Timeline> list = new List<Timeline>();
            string query = "select * from dbo.timeLine";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                Timeline timeline = new Timeline(row);
                list.Add(timeline);
            }
            return list;
        }

        public List<Timeline> GetTimelineById(int idTL)
        {
            List<Timeline> list = new List<Timeline>();
            string query = "exec USP_GetTimeLineByID @idTL";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { idTL});
            foreach (DataRow row in dataTable.Rows)
            {
                Timeline timeline = new Timeline(row);
                list.Add(timeline);
            }
            return list;
        }

        public List<Timeline> GetTimelineByName(string nameTL)
        {
            List<Timeline> list = new List<Timeline>();
            string query = "exec USP_GetTimeLineByName @nameTl";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { nameTL});
            foreach (DataRow row in dataTable.Rows)
            {
                Timeline timeline = new Timeline(row);
                list.Add(timeline);
            }
            return list;
        }

        
    }
}
