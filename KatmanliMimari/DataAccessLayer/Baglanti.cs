using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-23T2RIK\\SQLEXPRESS;Initial Catalog=KatmanlıPersonel;Integrated Security=True");

    }
}
