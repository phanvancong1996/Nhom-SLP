using qewewqewqe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qewewqewqe.DAO
{
    public class tableDAO
    {
        private static tableDAO instance;

        public static tableDAO Instance
        {
            get { if (instance == null) instance = new tableDAO(); return tableDAO.instance; }
            private set { tableDAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private tableDAO() { }

        public List<table> LoadTableList()
        {
            List<table> tableList = new List<table>();

            DataTable data = dataprovider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                table table = new table(item);
                tableList.Add(table);
            }

            return tableList;
        }
    }
}