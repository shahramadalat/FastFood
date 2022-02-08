using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FastFood
{
    public partial class frm_transfer : Form
    {
        List<string> tables = new List<string>();
        public string first_table_name { get; set; }
        public string table_id { get; set; }
        
        public frm_transfer()
        {
            InitializeComponent();
        }

        private void btn_unsuccess_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void get_tables()
        {
            classaddapter ca=new classaddapter();
            cmb_second_table_id.Items.Clear();
            ca.addapter("select * from tbl_table_info where available=1");
            for (int i = 0; i < classaddapter.dt.Rows.Count; i++)
            {
                cmb_second_table_id.Items.Add(classaddapter.dt.Rows[i]["name"].ToString());
            }
        }
     
        private void frm_transfer_Load(object sender, EventArgs e)
        {
            lbl_id.Text = first_table_name;
            get_tables();
            #region get then set table names into a list
            classaddapter ca = new classaddapter();
            ca.addapter("select name from tbl_table_info");
            for (int i = 0; i < classaddapter.dt.Rows.Count; i++)
            {
                tables.Add(classaddapter.dt.Rows[i]["name"].ToString());

            }
            #endregion
        }

        private void cmb_second_table_id_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btn_success_Click(object sender, EventArgs e)
        {
           

            if (cmb_second_table_id.Text != null)
            {
                classcommand5 c5 = new classcommand5();
                c5.command("update tbl_note set table_id=(select table_id from tbl_table_info where name=@name) where table_id=@rid", "@name", cmb_second_table_id.Text, "@rid", table_id, "", "", "", "", "", "");
                this.Close();
            }
           
        }

        private void cmb_second_table_id_Leave(object sender, EventArgs e)
        {
         
        }

        private void btn_success_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
         
        }

        private void cmb_second_table_id_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lbl_id.Text == cmb_second_table_id.Text)
            {
                MessageBox.Show("ئەو مێزەی ئەتەوێ بیگۆڕی هەمان مێزە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            if (!tables.Contains(cmb_second_table_id.Text))
            {
                MessageBox.Show("ئەو تەیبڵەی داخڵت کردوە بونی نیە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
