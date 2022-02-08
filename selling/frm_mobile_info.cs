using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FastFood
{
    public partial class frm_mobile_info : Form
    {
        classreader r = new classreader();
        classcommand5 c5 = new classcommand5();
        public string adress { get; set; }
        public string mobile { get; set; }
        public int mobile_id { get; set; }

        #region check if comed from order

        private bool _what;

        public void set_what(bool what)
        {
            this._what = what;
        }

        private bool get_what()
        {
            return _what;
        }

        #endregion
        public frm_mobile_info()
        {
            InitializeComponent();
        }
        void loadd()
        {
               
            classaddapter ca = new classaddapter();
            ca.addapter("select * from tbl_mobile_info");
            dataGridView1.DataSource = classaddapter.dt;
            rename();
            dataGridView1.Columns[1].Visible=false;

            search(txt_mobile, "select mobile_number from tbl_mobile_info");
            search(txt_address, "select address from tbl_mobile_info");

        }
        void renew()
        {
            txt_mobile.Text = "";
            txt_address.Text = "";
            txt_mobile.Focus();
        }
        void count()
        {
            c5.id("select isnull(max(mobile_info_id),0) from tbl_mobile_info");
            txt_id.Text = classcommand5.set;
        }
        void rename()
        {
            dataGridView1.Columns["mobile_info_id"].HeaderText = "کۆد";
            dataGridView1.Columns["mobile_number"].HeaderText = "ژ.مۆبایل";
            dataGridView1.Columns["address"].HeaderText = "ناونیشان";
            dataGridView1.Columns["delete"].HeaderText = "";
            dataGridView1.Columns["delete"].Width = 75;
        }
   

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox_reload_Click(object sender, EventArgs e)
        {
            loadd();
            renew();
            count();
            btn_delete.Visible = false;
        }

        private void frm_mobile_info_Load(object sender, EventArgs e)
        {
            if (get_what()==true)
            {
                btn_choose.Visible = true;
                _what = false;
            }

            classcontrol ccon = new classcontrol();
            ccon.image("delete", FastFood.Properties.Resources.Webp_net_resizeimage);
            dataGridView1.Columns.Add(classcontrol.i);
            loadd();
            count();
            txt_mobile.Focus();
            dataGridView1.Columns["delete"].DisplayIndex = 3;

           




        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_address.Text != null && txt_mobile.Text != null)
            {
                count();
                c5.command("insert into tbl_mobile_info values(@id,@phone,@add)", "@id", txt_id.Text, "@phone", txt_mobile.Text, "@add", txt_address.Text, "", "", "", "");
                loadd();
                count();
                renew();
            }
            else { MessageBox.Show("تکایە زانیاریەکان بەتەواوەتی پڕ بکەوە"); }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_address.Text != null && txt_mobile.Text != null)
            {
                c5.command("update tbl_mobile_info set mobile_number=@mobile,address=@a where mobile_info_id=@id", "@mobile", txt_mobile.Text, "@a", txt_address.Text, "@id", txt_id.Text, "", "", "", "");
                loadd();
            }
            else { MessageBox.Show("تکایە زانیاریەکان بەتەواوەتی پڕ بکەرەوە"); }
            }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("ئایا دڵنیای لە ڕەشکردنەوەی " +" \n"+dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), "ئاگاداری", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    classcommand5 c5 = new classcommand5();
                    c5.command("delete from tbl_mobile_info where mobile_info_id=@id", "@id", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "", "", "", "", "", "", "", "");
                    loadd();
                    count();
                    renew();
                }
            }
            else
            {
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                r.read("", "select * from tbl_mobile_info where mobile_info_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null, "mobile_info_id", "mobile_number", "address", "");
                txt_id.Text = classreader.o1;
                txt_mobile.Text = classreader.o2;
                txt_address.Text = classreader.o3;
                btn_delete.Visible = true;
            }
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ببورە ناتوانی لێرەدا وشە داخڵ بکەی ", "زانیاری", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

      

        #region search
        private void txt_mobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spsearch("spGet_mobile_number", "@mobile", txt_mobile.Text);
                btn_delete.Visible = true;
            }
        }
        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spsearch("spGet_address", "@address", txt_address.Text);
                btn_delete.Visible = true;
            }
        }

        void spsearch(string sp, string p, string txt)
        {
            r.read("sp", sp, p, txt, "", "", "", "", "", "", "", "", "mobile_info_id", "mobile_number", "address", "");
            txt_id.Text = classreader.o1;
            txt_mobile.Text = classreader.o2;
            txt_address.Text = classreader.o3;
        }

        void search(TextBox a, string q)
        {
            r.read("collection", q, "", "", "", "", "", "", "", "", "", null, "", "", "", "");
            a.AutoCompleteCustomSource = classreader.collection;
        }
        #endregion

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_id.Text=="")
            {
                MessageBox.Show("کردارەکە جێبەجێ نەکرا تکایە دوبارە هەوڵ بەرەوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("ئایا دڵنیای لە ڕەشکردنەوەی"+" \n"+txt_mobile.Text,"پرسیار",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                c5.command("delete from tbl_mobile_info where mobile_info_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", "");
                loadd();
                count();
                renew();
            }
        }

    
        private void btn_choose_Click(object sender, EventArgs e)
        {
            if (txt_id.Text=="")
            {
                MessageBox.Show("کردارەکە جێبەجێ نەکرا تکایە دوبارە هەوڵ بەرەوە","ئاگاداری",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

 
                frm_order fo=new frm_order();
                adress = txt_address.Text;
                mobile = txt_mobile.Text;
                mobile_id = int.Parse(txt_id.Text.Trim());
                this.Close();


        }

        
      
    }
}
