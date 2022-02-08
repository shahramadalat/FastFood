
using System.Data;
using System.Data.SqlClient;



namespace FastFood
{
   public class classcommand5
   {

        // take the below code with you to work with the class 
        /*classcommand5 c5 = new classcommand()5;
         c5.command("insert into tablename(fields_here) values(parameters_here)","parameter","value","","","","","","","image_para","image_value_here_if_not_write_null");*/

        public void command(string query, string p1, string p1v, string p2, string p2v, string p3, string p3v, string p4, string p4v, string p5, string p5v)
        {
            
            classconnection c = new classconnection();
            c.connect();
            SqlCommand command = new SqlCommand(query, classconnection.con);
            if(p1!="")
            {
                command.Parameters.AddWithValue(p1, p1v);
            }
            if (p2 != "")
            {
                command.Parameters.AddWithValue(p2,p2v);
            }
            if (p3 != "")
            {
                command.Parameters.AddWithValue(p3, p3v);
            }
            if (p4 != "")
            {
                command.Parameters.AddWithValue(p4, p4v);
            }
            if (p5 != "")
            {
                command.Parameters.AddWithValue(p5, p5v);
            }
            classconnection.con.Open();
            command.ExecuteNonQuery();
            classconnection.con.Close();
        }

        public static DataTable dt = null;
       public void command_sp(string what,string q, string p1, string p1v, string p2, string p2v, string p3, string p3v, string p4, string p4v, string p5, string p5v)
        {
            classconnection c = new classconnection();
            c.connect();
            SqlCommand command = new SqlCommand(q, classconnection.con);
            command.CommandType = CommandType.StoredProcedure;
            if (p1 != "")
            {
                command.Parameters.AddWithValue(p1, p1v);
            }
            if (p2 != "")
            {
                command.Parameters.AddWithValue(p2, p2v);
            }
            if (p3 != "")
            {
                command.Parameters.AddWithValue(p3, p3v);
            }
            if (p4 != "")
            {
                command.Parameters.AddWithValue(p4, p4v);
            }
            if (p5 != "")
            {
                command.Parameters.AddWithValue(p5, p5v);
            }
            classconnection.con.Open();
            if (what == "s")
            {
                dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            else { command.ExecuteNonQuery(); }
           
            classconnection.con.Close();
        }



        public static string set = null;
        public void id(string q)
        {
            classconnection c = new classconnection();
            c.connect();
            SqlCommand comm = new SqlCommand(q,classconnection.con);
            classconnection.con.Open();
           string txt = comm.ExecuteScalar().ToString();
           int ccc =int.Parse( txt )+ 1;
            classconnection.con.Close();
            set = ccc.ToString(); ;
        }

    }
}
