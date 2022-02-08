using System;
using System.Data.SqlClient;

namespace FastFood
{
   public class classreader
    {
        classconnection c = new classconnection();
        public static string o1 { get; set; }
        public static string o2 { get; set; }
        public static string o3 { get; set; }
        public static string o4 { get; set; }
        public static string o5 { get; set; }
        public static string o6 { get; set; }
        public static string o7 { get; set; }
        public static string o8 { get; set; }
        public static string o9 { get; set; }
        public static string o10 { get; set; }
      

        public static string message;
        public static System.Windows.Forms.AutoCompleteStringCollection collection = null;
        public void read(string what,string q, string p1, string p1v, string p2, string p2v, string p3, string p3v, string p4, string p4v, string p5, string p5v, string r1, string r2, string r3, string r4)
        {
            c.connect();
            SqlCommand command = new SqlCommand(q, classconnection.con);
                 if(what=="sp") { command.CommandType = System.Data.CommandType.StoredProcedure;}
                 if (p1 != "") { command.Parameters.AddWithValue(p1, p1v); }
                 if (p2 != "") { command.Parameters.AddWithValue(p2, p2v); }
                 if (p3 != "") { command.Parameters.AddWithValue(p3, p3v); }
                 if (p4 != "") { command.Parameters.AddWithValue(p4, p4v); }
                 if (p5 != "") { command.Parameters.AddWithValue(p5, p5v); }
            classconnection.con.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (what == "collection")
            {
                collection = new System.Windows.Forms.AutoCompleteStringCollection();
                while (reader.Read()) { collection.Add(reader.GetString(0)); }
            }
            else
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (r1 != "") { o1 = reader[r1].ToString(); }
                        if (r2 != "") { o2 = reader[r2].ToString(); }
                        if (r3 != "") { o3 = reader[r3].ToString(); }
                        if (r4 != "") { o4 = reader[r4].ToString(); }
                    }
                }
                else { message = "هیچ نەدۆزرایەوە"; }
            }
            classconnection.con.Close();
        }

        public void read10(string what, string q, string p1, string p1v, string p2, string p2v, string p3, string p3v, string r1, string r2, string r3, string r4,string r5,string r6,string r7,string r8,string r9,string r10)
        {
            c.connect();
            SqlCommand command = new SqlCommand(q, classconnection.con);
            if (what == "sp") { command.CommandType = System.Data.CommandType.StoredProcedure; }
            if (p1 != "") { command.Parameters.AddWithValue(p1, p1v); }
            if (p2 != "") { command.Parameters.AddWithValue(p2, p2v); }
            if (p3 != "") { command.Parameters.AddWithValue(p3, p3v); }
            classconnection.con.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (what == "collection")
            {
                collection = new System.Windows.Forms.AutoCompleteStringCollection();
                while (reader.Read()) { collection.Add(reader.GetString(0)); }
            }
            else
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (r1 != "") { o1 = reader[r1].ToString(); }
                        if (r2 != "") { o2 = reader[r2].ToString(); }
                        if (r3 != "") { o3 = reader[r3].ToString(); }
                        if (r4 != "") { o4 = reader[r4].ToString(); }
                        if (r5 != "") { o5 = reader[r5].ToString(); }
                        if (r6 != "") { o6 = reader[r6].ToString(); }
                        if (r7 != "") { o7 = reader[r7].ToString(); }
                        if (r8 != "") { o8 = reader[r8].ToString(); }
                        if (r9 != "") { o9 = reader[r9].ToString(); }
                        if (r10 != "") { o10 = reader[r10].ToString(); }
                    }
                }
                else { message = "هیچ نەدۆزرایەوە"; }
            }
            classconnection.con.Close();
        }

      
        
        
        
        

    }
}
