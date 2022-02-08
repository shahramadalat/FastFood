using System;
using System.Data.SqlClient;

namespace FastFood
{
   public class classcommand
    {

        // take the below code with you to work with the class 
        /*classcommand com = new classcommand();
         com.command("insert into tablename(fields_here) values(parameters_here)","parameter","value","","","","","","","","","","","","","","","","","image here","image");*/

        public void command(string query, string p1, string p1v, string p2, string p2v, string p3, string p3v, string p4, string p4v, string p5, string p5v, string p6, string p6v, string p7, string p7v, string p8, string p8v, string p9, string p9v, string p10, string p10v)
        {
            classconnection c = new classconnection();
            c.connect();
            SqlCommand command = new SqlCommand(query, classconnection.con);
            command.Parameters.AddWithValue(p1, p1v);
            command.Parameters.AddWithValue(p2, p2v);
            command.Parameters.AddWithValue(p3, p3v);
            if (p4 != "") {  command.Parameters.AddWithValue(p4, p4v); }
            if (p5 != "") {  command.Parameters.AddWithValue(p5, p5v); }
            if (p6 != "") { command.Parameters.AddWithValue( p6, p6v); }
            if (p7 != "") {  command.Parameters.AddWithValue(p7, p7v); }
            if (p8 != "") { command.Parameters.AddWithValue( p8, p8v); }
            if (p9 != "") { command.Parameters.AddWithValue( p9, p9v); }
            if (p10!= "") { command.Parameters.AddWithValue( p10,p10v); }
            classconnection.con.Open();
            command.ExecuteNonQuery();
            classconnection.con.Close();
        }
    }
}
