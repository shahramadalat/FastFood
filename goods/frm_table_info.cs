using System;
using System.Windows.Forms;

namespace FastFood
{
    public partial class frm_table_info : Form
    {
      
        classreader cr = new classreader();
        classcommand5 c5 = new classcommand5();
        public frm_table_info()
        {
            InitializeComponent();
        }

        void loadd()
        {

            classaddapter ca = new classaddapter();
            ca.addapter("select * from tbl_table_info");
            dataGridView1.DataSource = classaddapter.dt;
            rename();
            dataGridView1.Columns[0].DisplayIndex = 3;
            dataGridView1.Columns[1].Visible = false;

        }
        void renew()
        {
            txt_name.Text = "";
            txt_name.Focus();
        }
        void count()
        {
            c5.id("select isnull(max(table_id),0) from tbl_table_info");
            txt_id.Text = classcommand5.set;
        }
        void rename()
        {
            dataGridView1.Columns["table_id"].HeaderText = "کۆدی مێز";
            dataGridView1.Columns["name"].HeaderText = "ناوی مێز";
            dataGridView1.Columns["available"].HeaderText = "بەردەستی";
            dataGridView1.Columns["delete"].HeaderText = "";
            dataGridView1.Columns["delete"].Width = 75;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ch_available_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_available.Checked==true)
            {
                ch_available.Text = "True";
            }
            else{
                ch_available.Text = "False";
            }
        }

        private void frm_table_info_Load(object sender, EventArgs e)
        {
            classcontrol ccon = new classcontrol();
            ccon.image("delete",FastFood.Properties.Resources.Webp_net_resizeimage);
            dataGridView1.Columns.Add(classcontrol.i);
            loadd();
            count();
            txt_name.Focus();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            count();
            c5.command("insert into tbl_table_info values(@id,@name,@available)","@id",txt_id.Text,"@name",txt_name.Text,"@available",ch_available.Text,"","","","");
            loadd();
            count();
            renew();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("ئایا دڵنیای لە ڕەشکردنەوەی " + "\n" + "کۆدی" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "ئاگاداری", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    classcommand5 c5 = new classcommand5();
                    c5.command("delete from tbl_table_info where table_id=@id", "@id", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "", "", "", "", "", "", "", "");
                    loadd();
                    count();
                    renew();
                }
            }
            else
            {
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cr.read("","select * from tbl_table_info where table_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null, "table_id", "name", "available", "");
                txt_id.Text = classreader.o1;
                txt_name.Text = classreader.o2;
                if(classreader.o3=="True")
                {
                    ch_available.Checked = true;
                }
                else{

                    ch_available.Checked = false;
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            c5.command("update tbl_table_info set name=@name,available=@a where table_id=@id","@name",txt_name.Text,"@a",ch_available.Text,"@id",txt_id.Text,"","","","");
            loadd();

        }

        private void pictureBox_reload_Click(object sender, EventArgs e)
        {
            loadd();
            renew();
            count();
            ch_available.Checked = true;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                #region check if we have some tabe in form order 
                classreader.o1 = "";
                cr.read("", "select table_id from tbl_order where table_id=@id", "@id", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "", "", "", "", "", "", "", "", "table_id", "", "", "");
                MessageBox.Show(classreader.o1);
                if (classreader.o1 != "")
                {
                    MessageBox.Show("ببورە ناتوانی ئەم مێزە ڕەش بکیتەوە");
                    classreader.o1 = "";
                    return;
                }
                #endregion
              


                classreader.o1 = null;
                cr.read("", "select * from tbl_order where table_id=@id", "@id", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "", "", "", "", "", "", "", null, "table_id", "", "", "");
                if (classreader.o1 != null)
                { MessageBox.Show("ببورە تۆ ناتوانی ئەم مێزە ڕەش بکەیتەوە" + "\n" + "چونکە لەبەشی فرۆشتنا داخڵت کردوە" + "\n" , "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    if (MessageBox.Show("ئایا دڵنیای لە ڕەشکردنەوەی " + "\n" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), "ئاگاداری", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        classcommand5 c5 = new classcommand5();
                        c5.command("delete from tbl_table_info where table_id=@id", "@id", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "", "", "", "", "", "", "", "");
                        loadd();
                        count();
                        renew();
                    }
                }

            }
            else
            {
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cr.read("", "select * from tbl_table_info where table_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null, "table_id", "name", "available", "");
                txt_id.Text = classreader.o1;
                txt_name.Text = classreader.o2;
                ch_available.Text = classreader.o3;
                if (ch_available.Text == "True")
                {
                    ch_available.Checked = true;
                }
                else { ch_available.Checked = false; }




         
            }
        }

      
    }
}
