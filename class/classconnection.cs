using System;
using System.Data.SqlClient;

namespace FastFood
{
   public class classconnection
    {
       public static SqlConnection con = null;
       private string con_str = $@"Data Source={System.Environment.MachineName};Database=FastFood;Integrated Security=True";
       public void connect()
       {
           con = new SqlConnection(con_str);
       }

    }
}
