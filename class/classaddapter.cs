using System;
using System.Data.SqlClient;
using System.Data;

namespace FastFood
{
   public class classaddapter
    {

       public static DataTable dt = null;
       classconnection c = new classconnection();
       public void addapter(string q)
       {  c.connect();
           SqlDataAdapter da = new SqlDataAdapter(q,classconnection.con);
           dt = new DataTable();
           da.Fill(dt);
       }

    }
}
