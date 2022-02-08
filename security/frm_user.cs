using System;
using System.Windows.Forms;


namespace FastFood
{
    public partial class frm_user : Form
    {
        string per="user";
        classcommand classcommand = new classcommand();
        classcommand5 c5 = new classcommand5();
        classreader r = new classreader();
        classencrypt ce=new classencrypt();
        public frm_user()
        {
            InitializeComponent();
        }
       private void loadd()
        {
            classaddapter classaddapter = new classaddapter();
            classaddapter.addapter("select * from tbl_user order by user_id desc");
            dataGridView1.DataSource = classaddapter.dt;
            rename();
            changeindex();
       }
     
       void count()
       {
           
           c5.id("select isnull(max(user_id),0) from tbl_user");
           txt_id.Text = classcommand5.set;
       }
       void changeindex()
       {
           dataGridView1.Columns["full_name"].DisplayIndex = 1;
           dataGridView1.Columns["permission"].DisplayIndex = 3;
           dataGridView1.Columns["is_changed"].DisplayIndex = 4;
           dataGridView1.Columns["is_still_work"].DisplayIndex = 5;
           dataGridView1.Columns["active"].DisplayIndex = 6;
       }
       void rename()
       {
           dataGridView1.Columns["user_id"].HeaderText = "کۆد";
           dataGridView1.Columns["username"].HeaderText = "ناوی بەکارهێنەر";
           dataGridView1.Columns["password"].HeaderText = "وشەی تێپەڕ";
           dataGridView1.Columns["permission"].HeaderText = "مۆڵەت";
           dataGridView1.Columns["favcolor"].HeaderText = "ڕەنگ";
           dataGridView1.Columns["favanimal"].HeaderText = "ئاژەڵ";
           dataGridView1.Columns["full_name"].HeaderText = "ناو";
           dataGridView1.Columns["active"].HeaderText = "سەرهێڵ";
           dataGridView1.Columns["is_changed"].HeaderText = "وشەی تێپەڕ گۆڕاوە";
           dataGridView1.Columns["is_still_work"].HeaderText = "مانەوە لەسەر ئیش";

       }
       void renew()
       {
           txt_favanimal.Text = "";
           txt_favcolor.Text = "";
           txt_full_name.Text = "";
           txt_pass.Text = "";
           txt_username.Text = "";
           txt_full_name.Focus();
       }

        private void frm_user_Load(object sender, EventArgs e)
        {
           
            try
            {
                loadd();
                count();
                txt_full_name.Focus();
            }
            catch { MessageBox.Show("هەڵەیەک لە ئیشەکەدا هەیە تیاکە دووبارە هەوڵ بەرەوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadd();
            count();
            renew();
        }

        private void ch_is_still_work_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_is_still_work.Checked==true)
            {  ch_is_still_work.Text = "True"; }
            else{  ch_is_still_work.Text = "False"; }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            try
            {
                #region encryption
                ce.encrypt(txt_username.Text);
                string username = classencrypt.endresult;
                ce.encrypt(txt_pass.Text);
                string pass = classencrypt.endresult;
                ce.encrypt(txt_favanimal.Text);
                string animal = classencrypt.endresult;
                ce.encrypt(txt_favcolor.Text);
                string color = classencrypt.endresult;
                #endregion

                classcommand.command(@"update tbl_user set permission=@per,full_name=@name,is_still_work=@work where user_id=@id",
                    "", "", "", "", "@per", per, "@color", txt_favcolor.Text, "@animal", txt_favanimal.Text, "@name", txt_full_name.Text, "@work", ch_is_still_work.Text, "@id", txt_id.Text, "","", "", "");
                loadd();
                count();
                renew();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                if (txt_id.Text == "")
                {
                    MessageBox.Show("تکایە تیراژی ئەو بەکارهێنەرە داخڵ بکە کە دەتەوێ ڕەشی کەیتەوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_id.Focus();
                }
                else
                {
                    if (MessageBox.Show(" ئایا دڵنیای لە ڕەشکردنەوەکە؟" + "\n" + ":تێبینی" + "\n" + "بەڕەشکردنەوەی بەکارهێنەرەکە ئەگەری ئەوە هەیە کە" + "\n" + "لەداهاتودا هەندێ زانیاریمان لێ تێک بچێ" + "\n" + "کە پەیوەندی بە بەکارهێنەرەکەوە هەیە", "ئاگاداری", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        classcommand5 c = new classcommand5();
                        c.command("delete from tbl_user where user_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null);
                        loadd();
                        count();
                    }
                }
            }
            catch { MessageBox.Show("هەڵەیەک لە ئیشەکەدا هەیە تیاکە دووبارە هەوڵ بەرەوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            try
            {
                #region max id
                if (txt_id.Text == "")
                {
                    count();
                }
                #endregion
                #region validate email
                if (!txt_email.Text.Contains("@") || !txt_email.Text.Contains(".com"))
                {
                    MessageBox.Show("ئەمەیڵەکەت بە هەڵە داخڵ کردوە تکایە دوبارە هەوڵ بەرەوە");
                    return;
                }
                #endregion
                if (txt_favanimal.Text == "" || txt_favcolor.Text == "" || txt_full_name.Text == "" || txt_pass.Text == "" || txt_username.Text == "")
                { MessageBox.Show("تکایە زانیاریەکان بەتەواوی پڕ بکەرەوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    #region encryption
                    ce.encrypt(txt_username.Text);
                    string username = classencrypt.endresult;
                    ce.encrypt(txt_pass.Text);
                    string pass = classencrypt.endresult;
                    ce.encrypt(txt_favanimal.Text);
                    string animal = classencrypt.endresult;
                    ce.encrypt(txt_favcolor.Text);
                    string color = classencrypt.endresult;
                    #endregion
                    c5.command(@"insert into tbl_user values(@id, '" + username + "','" + pass + "',@per,'" + color + "','" + animal + "',@name,'False','False','True',@email)", "@id", txt_id.Text, "@name", txt_full_name.Text, "@email", txt_email.Text, "@per", per, "", ""); 
                    loadd();
                    count();
                    renew();
                }
            }
            catch { MessageBox.Show("هەڵەیەک لە ئیشەکەدا هەیە تیاکە دووبارە هەوڵ بەرەوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void rdb_admin_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rdb_admin.Checked == true)
            {
                per = "admin";
            }
            else { per = "user"; }
        }

        private void rdb_user_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_user.Checked)
            {
                per = "user";
            }
            else { per = "admin"; }
        }


        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if(txt_id.Text!="")
            {
            
            
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null )
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
          
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
            //if (e.ColumnIndex == 3 && e.Value != null)
            //{
            //    e.Value = new String('*', e.Value.ToString().Length);
            //}
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

   
    }
}
