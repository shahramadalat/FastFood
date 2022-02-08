using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastFood.DataSet1TableAdapters;


namespace FastFood
{
    public partial class frm_order : Form
    {
        classcommand5 c5 = new classcommand5();
        classreader cr = new classreader();
        classaddapter ca = new classaddapter();
        classcommand c10 = new classcommand(); 


        #region table info's we need
        public string right_table_name { get; set; }
        public string table_id { get; set; }
        public string table_name { get; set; }
        #endregion

        #region user id get&set
        public int user_id;

        public void SetUserId(int id)
        {
            this.user_id = id;
        }

        private int GetUserId()
        {
            return user_id;
        }
        #endregion
        

        public frm_order()
        {
            InitializeComponent();
        }

        private void frm_invoice_info_Load(object sender, EventArgs e)
        {
            
            mobile_id = "";
            txt_user.Text = Convert.ToString(GetUserId());
            get_tables();
            get_goods();
            get_invoice_id();
            cmb_get_table();
            cm.MenuItems.Add("حجزکردن", new EventHandler(contecxt_reserve_click));
            cm.MenuItems.Add("گواستنەوە", new EventHandler(btn_transfer_click));
            cm.MenuItems.Add("فۆڕمی مێزەکان",new EventHandler(btn_frm_table_click));
            cm_del.MenuItems.Add("فۆڕمی مۆبایل-ناونیشان", new EventHandler(btn_frm_mobile_click));

        }

        #region mobile info
        private string mobile_id="1";
        private void txt_mobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                spsearch("spGet_mobile_number","@mobile",txt_mobile.Text);
            }
        }
        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                spsearch("spGet_address","@address",txt_address.Text);
            }
        }

        private void btn_frm_mobile_click(object sender, EventArgs e)
        {
            frm_mobile_info fm = new frm_mobile_info();
            fm.set_what(true);
            fm.ShowDialog();
            layout_del.Visible = true;
            txt_address.Text = fm.adress;
            txt_mobile.Text = fm.mobile;
            mobile_id = fm.mobile_id.ToString();
        }

        void spsearch(string sp,string p,string txt)
        {
            cr.read("sp", sp, p, txt, "", "", "", "", "", "", "", "", "mobile_info_id", "mobile_number", "address", "");
            mobile_id = classreader.o1;
            txt_mobile.Text = classreader.o2;
            txt_address.Text = classreader.o3;
        }

        void search(TextBox a,string q)
        {
            cr.read("collection", q, "", "", "", "", "", "", "", "", "", null, "", "", "", "");
            a.AutoCompleteCustomSource = classreader.collection;
        }

        #endregion



         #region tables info
        ContextMenu cm = new ContextMenu();
        ContextMenu cm_del = new ContextMenu();

        private void btn_frm_table_click(object sender,EventArgs e)
        {
            frm_table_info fti=new frm_table_info();
            fti.ShowDialog();
        }

        //گواستنەوە
        private void btn_transfer_click(object sender , EventArgs e)
        {
            frm_transfer ft=new frm_transfer(){first_table_name =right_table_name,table_id = table_id};
            if (ft.ShowDialog()==DialogResult.OK)
            {
               get_note(txt_invoice_id.Text,table_id);
               get_tables();
            }
        }

        //حجزکردن
        private void contecxt_reserve_click(object sender, EventArgs e)
        {
            cr.read("", "select available from tbl_table_info where name=@id", "@id", right_table_name, "", "", "", "", "", "", "", null, "available", "", "", "");
            if (classreader.o1 == "True")
            {
                c5.command("update tbl_table_info set available='False' where name=@id", "@id", right_table_name, "", "", "", "", "", "", "", "");
            }
            else { c5.command("update tbl_table_info set available='True' where name=@id", "@id", right_table_name, "", "", "", "", "", "", "", ""); }
            panel_table.Controls.Clear();
            cmb_table_id.Items.Clear();
            cmb_get_table();
            get_tables();
        }

        //get tables and add in combobox
        void cmb_get_table()
        {
            cmb_table_id.Items.Clear();
            ca.addapter("select * from tbl_table_info where available=1");
            for (int i = 0; i < classaddapter.dt.Rows.Count; i++)
            {
                cmb_table_id.Items.Add(classaddapter.dt.Rows[i]["name"].ToString());
            }
        }
        

        // show context menu by right click 
        private void btn_tables_menu_MouseDown(object sender, MouseEventArgs e)
        {
            right_table_name = (sender as Button).Text;
            table_id = (sender as Button).Name;

            switch (e.Button)
            {
                case MouseButtons.Right:
                {
                    if ((sender as Button).Text == "دیلیڤەری" || (sender as Button).Text == "دلیڤەری" || (sender as Button).Text == "delivery")
                    {
                        cm_del.Show(this, new Point(e.X + ((Control)sender).Left + 210, e.Y + ((Control)sender).Top + 150));
                        return;
                    }
                    cm.Show(this, new Point(e.X + ((Control)sender).Left + 210, e.Y + ((Control)sender).Top + 150));
                }
                    break;
            }
        }

        void get_tables()
        {
            panel_table.Controls.Clear();
            List<string> note_names=new List<string>();
            //List<string> table_info_names = new List<string>();
            ca.addapter("select distinct(name) from view_note");
            for (int i=0;i<classaddapter.dt.Rows.Count;i++) { note_names.Add(classaddapter.dt.Rows[i]["name"].ToString()); }

            ca.addapter("select * from tbl_table_info");
            for (int i = 0; i < classaddapter.dt.Rows.Count; i++)
            {
                //table_info_names.Add(classaddapter.dt.Rows[i]["name"].ToString());
                Button b = new Button();
                b.Name = classaddapter.dt.Rows[i]["table_id"].ToString();
                b.Text = classaddapter.dt.Rows[i]["name"].ToString();
                b.FlatStyle = FlatStyle.Flat;
                panel_table.Controls.Add(b);
                b.Click += new System.EventHandler(this.btn_add_table_click);
                b.MouseDown += new MouseEventHandler(this.btn_tables_menu_MouseDown);
                b.ForeColor = Color.GhostWhite;
                b.Width = 90;
                b.Font = new Font("Peshang Des 3", 11, FontStyle.Bold);
                b.Height = 30;
                if (classaddapter.dt.Rows[i]["available"].ToString() == "False")
                {
                    b.BackColor = Color.FromArgb(255, 166, 76);
                }
                else if (note_names.Contains(classaddapter.dt.Rows[i]["name"].ToString()))
                {
                    b.BackColor = Color.SlateGray;
                }
                else
                {
                    b.BackColor = Color.FromArgb(62, 70, 87);
                }
            }
    
            search(txt_mobile,"select mobile_number from tbl_mobile_info");
            search(txt_address, "select address from tbl_mobile_info");

            
        }

        public int trans;
        void btn_add_table_click(object sender, EventArgs e)
        {
           
            cr.read("", "select available from tbl_table_info where table_id=@id", "@id", (sender as Button).Name, "", "", "", "", "", "", "", "", "available", "", "", "");
            if (classreader.o1 == "True")
            {
                get_note(txt_invoice_id.Text, (sender as Button).Name);
                cmb_table_id.Text=(sender as Button).Text;
                if ((sender as Button).Text == "دیلیڤەری" || (sender as Button).Text == "دلیڤەری" || (sender as Button).Text == "delivery")
                {
                    layout_del.Visible = true;
                }
                else
                {
                    layout_del.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("ببورە ئەم مێزە حیجز کراوە");
            }
        }


        private void cmb_table_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            cr.read("", "select * from tbl_table_info where name=@name", "@name", cmb_table_id.Text, "", "", "", "", "", "", "", null, "table_id", "", "", "");
            table_id = classreader.o1;
            table_name = cmb_table_id.Text;
            get_note(txt_invoice_id.Text, table_id);
            //dataGridView1.DataSource = classaddapter.dt;
            get_check();
            if (cmb_table_id.Text == "دیلیڤەری" || cmb_table_id.Text == "دلیڤەری" || cmb_table_id.Text == "delivery")
            {
                layout_del.Visible = true;
            }
            else
            {
                layout_del.Visible = false;
            }
        }

         #endregion

         #region invoice info
 

         void get_invoice_id()
         {
             c5.id("select isnull(max(invoice_id),0) from tbl_invoice");
             txt_invoice_id.Text = (int.Parse(classcommand5.set)-1).ToString();
             if (txt_invoice_id.Text=="0")
             {
                 c5.command("insert into tbl_invoice values(1)","","","","","","","","","","");
                 get_invoice_id();
             }
          
         }



         #endregion

         #region datagridview

         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             //delete
             if (dataGridView1.Rows.Count > 0)
             {
                 string order_id = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                 if (e.ColumnIndex == 2)
                 {
                     if (MessageBox.Show("ئایا دڵنیای لە لابردنی ئەم کاڵایە؟", "ئاگاداری", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) == DialogResult.Yes)
                     {
                         string goods_type_id = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                         c5.command("delete from tbl_note where goods_type_id=@id", "@id", goods_type_id, "", "", "", "", "", "", "", "");
                     }
                 }

                 //add
                 if (e.ColumnIndex == 1)
                 {
                     c5.command("   insert into tbl_note(order_id,invoice_id,goods_type_id,price,quantity,table_id,note) select (select max(order_id)+1 from tbl_note) ,invoice_id,goods_type_id,price,quantity,table_id,note from tbl_note where tbl_note.order_id=@id", "@id", order_id, "", "", "", "", "", "", "", "");
                 }

                 //mines
                 if (e.ColumnIndex == 0)
                 {
                     c5.command("delete from tbl_note where order_id=@id", "@id", order_id, "", "", "", "", "", "", "", "");
                 }


                 get_note(txt_invoice_id.Text, table_id);
                 get_tables();
                 total_dgv();
             }
         }

         void get_check()
         {
             //ca.addapter("select * from view_check where [table]='"+cmb_table_id.Text+"' ");
             //dataGridView2.Columns.Clear();
             //    classcontrol cc = new classcontrol();
             //    cc.image("m", FastFood.Properties.Resources.minuss);
             //    dataGridView2.Columns.Add(classcontrol.i);
             //    cc.image("a", FastFood.Properties.Resources.add);
             //    dataGridView2.Columns.Add(classcontrol.i);
             //    dataGridView2.DataSource = classaddapter.dt;
             //    dataGridView2.Columns["invoice_id"].Visible = false;
             //    dataGridView2.Columns["table"].Visible = false;
             //    dataGridView2.Columns["goods_type_id"].Visible = false;


         }


         void get_note(string invoice_id, string t_id)
         {
             ca.addapter(@"select * from view_note where name=(select name from tbl_table_info where table_id=" + t_id + ") and invoice_id='" + invoice_id + "'");
             #region plus , minus and  for quantity

             dataGridView1.Columns.Clear();
             classcontrol cc = new classcontrol();

             cc.image("minus", FastFood.Properties.Resources.minuss);
             dataGridView1.Columns.Add(classcontrol.i);
             cc.image("add", FastFood.Properties.Resources.add);
             dataGridView1.Columns.Add(classcontrol.i);
             cc.image("delete", FastFood.Properties.Resources.Webp_net_resizeimage);
             dataGridView1.Columns.Add(classcontrol.i);
             dataGridView1.DataSource = classaddapter.dt;
             #endregion
             #region columns property
             dataGridView1.Columns["add"].DisplayIndex = 6;
             dataGridView1.Columns["minus"].DisplayIndex = 7;
             dataGridView1.Columns["delete"].DisplayIndex = 10;

             dataGridView1.Columns["goods_type_id"].Visible = false;
             dataGridView1.Columns["invoice_id"].Visible = false;
             dataGridView1.Columns["order_id"].Visible = false;
             dataGridView1.Columns["name"].Visible = false;

             dataGridView1.Columns["kurdish_name"].HeaderText = "ناوی کاڵا";
             dataGridView1.Columns["price"].HeaderText = "نرخ";
             dataGridView1.Columns["quantity"].HeaderText = "عدد";
             dataGridView1.Columns["total"].HeaderText = "سەرجەم";
             dataGridView1.Columns["add"].HeaderText = "";
             dataGridView1.Columns["minus"].HeaderText = "";
             #endregion
             total_dgv();

         }


         #endregion

         #region goods and goods type
         void get_goods()
         {
             ca.addapter("select * from tbl_goods order by sort");
             for (int i = 0; i < classaddapter.dt.Rows.Count; i++)
             {
                 Button b = new Button();
                 b.Name = classaddapter.dt.Rows[i]["goods_id"].ToString();
                 b.Text = classaddapter.dt.Rows[i]["kurdish_name"].ToString();
                 b.FlatStyle = FlatStyle.Flat;
                 b.Width = 94;
                 b.Height = 60;
                 b.Font = new Font("Peshang Des 3", 9, FontStyle.Bold);
                 b.BackColor = Color.SteelBlue;
                 b.ForeColor = Color.WhiteSmoke;
                 panel_goods.Controls.Add(b);
                 b.Click += new System.EventHandler(this.btn_add_goods_click);
             }
         }
         void get_types(string id)
         {
             ca.addapter("select goods_type_id,kurdish_name,price from tbl_goods_type where goods_id=" + id + " order by sort_no  ");
             for (int i = 0; i < classaddapter.dt.Rows.Count; i++)
             {
                 Button b = new Button();
                 b.Text = classaddapter.dt.Rows[i]["kurdish_name"].ToString() + "\n" + "نرخ" + classaddapter.dt.Rows[i]["price"].ToString();
                 b.Name = classaddapter.dt.Rows[i]["goods_type_id"].ToString();
                 b.Width = 120;
                 b.Height = 60;
                 b.BackColor = Color.SteelBlue;
                 b.ForeColor = Color.WhiteSmoke;
                 b.Font = new Font("Peshang Des 3", 8, FontStyle.Bold);
                 b.FlatStyle = FlatStyle.Flat;
                 panel_type.Controls.Add(b);
                 b.Click += new System.EventHandler(this.btn_add_goods_type_click);
             }



         }

         void btn_add_goods_type_click(object sender, EventArgs e)
         {
             string s = (sender as Button).Name;
             if (cmb_table_id.Text == "")
             {
                 MessageBox.Show("تکایە مێزەکە هەڵبژێرە");
             }
             else
             {
                 #region select goods price
                 string price;
                 if (txt_price.Text == "")
                 {
                     cr.read("", "select price from tbl_goods_type where goods_type_id=@id", "@id", s, "", "", "", "", "", "", "", null, "price", "", "", "");
                     price = classreader.o1;
                 }
                 else { price = txt_price.Text.Trim(); }
                 #endregion

                 c5.id("select isnull(max(order_id),0) from tbl_note");
                 string order_id = classcommand5.set;
                 c10.command("insert into tbl_note values(" + order_id + ",@inv_id,@good_id," + price + ",@quant,@t_id,@note)",
                     "@inv_id", txt_invoice_id.Text, "@good_id", s,
                     "@quant", "1", "@t_id", table_id, "@note", "0",
                     "", "", "", "", "", "", "", "",
                     "", "");
                 get_note(txt_invoice_id.Text, table_id);
                 get_tables();
                 #region insert into tbl_invoice_info
                 //if (txt_discount.Text == "0")
                 //{
                 //    c10.command("update tbl_invoice_info set date='" + DateTime.Now.ToShortDateString() + "',total_before_discount=@t_b,discount_amount=@d_a,discount_ratio=@d_r,total_after_discount=@t_a,user_id=@u_id where invoice_id=@inv_id",
                 //        "@t_b", txt_total.Text, "@d_a", "0", "@d_r", "0"
                 //        , "@t_a", txt_final_price.Text, "@u_id", txt_user.Text, "@inv_id", txt_invoice_id.Text
                 //        , "", "", "", "", "", "", "", "");
                 //}
                 //else if (double.Parse(txt_discount.Text.Trim()) > 0 && double.Parse(txt_discount.Text) <= 100)
                 //{
                 //    c10.command("update tbl_invoice_info set date='" + DateTime.Now.ToShortDateString() + "',total_before_discount=@t_b,discount_amount=@d_a,discount_ratio=@d_r,total_after_discount=@t_a,user_id=@u_id where invoice_id=@inv_id",
                 //       "@t_b", txt_total.Text, "@d_a", "0", "@d_r", txt_discount.Text
                 //       , "@t_a", txt_final_price.Text, "@u_id", txt_user.Text, "@inv_id", txt_invoice_id.Text
                 //       , "", "", "", "", "", "", "", "");
                 //}
                 //else
                 //{
                 //    c10.command("update tbl_invoice_info set date='" + DateTime.Now.ToShortDateString() + "',total_before_discount=@t_b,discount_amount=@d_a,discount_ratio=@d_r,total_after_discount=@t_a,user_id=@u_id where invoice_id=@inv_id",
                 //        "@t_b", txt_total.Text, "@d_a", txt_discount.Text, "@d_r", "0"
                 //        , "@t_a", txt_final_price.Text, "@u_id", txt_user.Text, "@inv_id", txt_invoice_id.Text
                 //        , "", "", "", "", "", "", "", "");
                 //}
                 //get_note(txt_invoice_id.Text, table_name);
                 //get_check();
                 //get_tables();
                 #endregion
             }



         }
         private void btn_add_goods_click(object sender, EventArgs e)
         {
             string b_name = (sender as Button).Name;
             edit_panel_type();
             get_types(b_name);

         }


         #endregion

         #region calculations

         void total_dgv()
         {
             if (dataGridView1.Rows.Count != 0)
             {
                 List<double> total = new List<double>();
                 for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                 {
                     total.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells["total"].Value));
                 }
                 txt_total.Text = total.Sum().ToString();
             }
         }

         #endregion

         #region validations
         private void txt_invoice_id_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
             {
                 MessageBox.Show("لێرەدا تەنها دەتوانی ژمارە داخڵ بکەی", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 e.Handled = true;
             }

         }
         private void txt_discount_TextChanged(object sender, EventArgs e)
         {
             
         }
         private void txt_total_TextChanged(object sender, EventArgs e)
         {
             if (txt_discount.Text != "" && txt_total.Text != "")
             {
                 if (double.Parse(txt_discount.Text) == 0) { txt_final_price.Text = txt_total.Text; }
                 else if (double.Parse(txt_discount.Text) > 0 && double.Parse(txt_discount.Text) <= 100)
                 {
                     txt_final_price.Text = Convert.ToString(double.Parse(txt_total.Text.Trim()) - ((double.Parse(txt_total.Text.Trim()) * double.Parse(txt_discount.Text.Trim())) / 100));
                 }
                 else { txt_final_price.Text = Convert.ToString(double.Parse(txt_total.Text.Trim()) - double.Parse(txt_discount.Text.Trim())); }
             }
         }
         private void txt_discount_Leave(object sender, EventArgs e)
         {
             try
             {
                 if (txt_discount.Text != "")
                 {
                     if (double.Parse(txt_discount.Text) == 0)
                     {
                         txt_final_price.Text = txt_total.Text;
                     }
                     else if (double.Parse(txt_discount.Text) > 0 && double.Parse(txt_discount.Text) <= 100)
                     {
                         txt_final_price.Text =
                             Convert.ToString(double.Parse(txt_total.Text.Trim()) -
                                              ((double.Parse(txt_total.Text.Trim()) *
                                                double.Parse(txt_discount.Text.Trim())) / 100));
                     }
                     else
                     {
                         txt_final_price.Text =
                             Convert.ToString(double.Parse(txt_total.Text.Trim()) -
                                              double.Parse(txt_discount.Text.Trim()));
                     }
                 }
             }
             catch
             { }
         }

         #endregion

         #region panels

         private void btn_hide_Click_1(object sender, EventArgs e)
         {
             panel_type.Visible = false;
         }
         void edit_panel_type()
         {

             if (panel_type.Visible == false)
             {
                 panel_type.Visible = true;
             }
             panel_type.Controls.Clear();
             panel_type.Controls.Add(btn_hide);

         }

         #endregion
         string discount_amount;
         string discount_ratio;
        string discount;

        private void AutoPrint()
        {
            ReportParameterCollection col = new ReportParameterCollection();
            col.Add(new ReportParameter("total", txt_total.Text));
            //col.Add(new ReportParameter("user_id", (user_id).ToString()));
            //col.Add(new ReportParameter("discount", discount));
          
            this.reportViewer1.LocalReport.SetParameters(col);

            this.spPrintTableAdapter.Fill(this.DataSet1.spPrint, table_name);
            AutoPrintCls autoprintme = new AutoPrintCls(reportViewer1.LocalReport);
            autoprintme.Print();
            this.reportViewer1.RefreshReport();
        }

        private void btn_insert_invoice_id_Click(object sender, EventArgs e)
        {

            AutoPrint();
            string inv_id = Convert.ToString(int.Parse(txt_invoice_id.Text.Trim()) + 1);
            c5.command(
                "insert into tbl_order(invoice_id,goods_type_id,price,quantity,table_id) select invoice_id,goods_type_id,price,quantity,table_id from tbl_note where tbl_note.invoice_id=@i_id and tbl_note.table_id=(select table_id from tbl_table_info where name=@name)",
                "@i_id", txt_invoice_id.Text, "@Name", cmb_table_id.Text, "", "", "", "", "", "");
            c5.command(
                "delete  from tbl_note where invoice_id=@i_id and table_id=(select table_id from tbl_table_info where name=@name)",
                "@i_id", txt_invoice_id.Text, "@name", cmb_table_id.Text, "", "", "", "", "", "");
            c5.command("insert into tbl_invoice values(@id)", "@id", inv_id, "", "", "", "", "", "", "", "");
            c5.command("update tbl_note set invoice_id=@id", "@id", inv_id, "", "", "", "", "", "", "", "");
            

        c10.command("insert into tbl_invoice_info values((select isnull(max(info_id),0)+1 from tbl_invoice_info),@i_id,@date,@t_b_d,@d_a,@d_r,@t_a_d,@user,@mobile_info_id)", "@i_id", txt_invoice_id.Text, "@date", dateTimePicker1.Text, "@t_b_d", txt_total.Text, "@d_a", discount_amount, "@d_r", discount_ratio, "@t_a_d", txt_final_price.Text, "@user", txt_user.Text, "@mobile_info_id", mobile_id, "", "", "", "");
            get_invoice_id();
            get_note(txt_invoice_id.Text, table_id);
            get_check();
            get_tables();
        }

      




         private void txt_discount_Enter(object sender, EventArgs e)
         {
             if (MessageBox.Show("پێویستە ئەکاونتی ئەدمینت هەبێ تاوەکو داشکاندن بکەی ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
             {
                 frm_login fg = new frm_login();
                 fg.is_discount = true;
                 if (fg.is_let == false)
                 {
                     fg.ShowDialog();

                 }
                 if (fg.is_let == false)
                 {
                     cmb_table_id.Focus();
                 }
             }
         }

         private void pictureBox3_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void pictureBox4_Click(object sender, EventArgs e)
         {
             get_note(txt_invoice_id.Text,table_id);
             get_invoice_id();
             get_tables();
             total_dgv();
             mobile_id = "";
             txt_address.Text = "";
             txt_mobile.Text = "";
         }

         private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar))
             {
                 MessageBox.Show("ببورە ناتوانی لێرەدا وشە داخڵ بکەی ", "زانیاری", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 e.Handled = true;
             }
         }


     

       

       

   
  

    }
}
