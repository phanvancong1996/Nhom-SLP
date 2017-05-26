using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qewewqewqe.DAO
{
    public class acountDAO
    {
        private static acountDAO instance;

        public static acountDAO Instance
        {
            get { if (instance == null) instance = new acountDAO(); return instance; }
            private set { instance = value; }
        }

        private acountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "' ";

            DataTable result = dataprovider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
