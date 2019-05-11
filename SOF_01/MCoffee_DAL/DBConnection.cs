using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MCoffee_DAL
{
    public class DBConnection
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GAF2823;Initial Catalog=DB_SOF_01;Integrated Security=True");
    }
}
