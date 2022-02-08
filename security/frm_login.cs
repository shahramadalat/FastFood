using System;
using System.Windows.Forms;

namespace FastFood
{
    public partial class frm_login : Form
    {
        classreader classreader = new classreader();
        classcommand5 c5 = new classcommand5();
        classencrypt ce=new classencrypt();
        public bool is_discount { get; set; }
        public bool is_let { get; set; }
       
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ce.encrypt(txt_user.Text);
            string username = classencrypt.endresult;
            ce.encrypt(txt_pass.Text);
            string pass = classencrypt.endresult;

            classreader.o1 = null;
            classreader.read("", @"select permission,full_name,is_still_work,is_changed from tbl_user where username=@user and password=@pass;",
                    "@user", username, "@pass", pass, "", "", "", "", "", null, "permission", "full_name", "is_still_work", "is_changed");
                //note: permission||classreader.o1 is just to know is admin or user. note2: full_name||classreader.o2 is to know the name of the user  
                #region to_know_if_have_account
                if (classreader.o1 != null)
                {
                    #region to_know_is_changed_his/her_pass
                    if (classreader.o4 == "False")
                    {
                        MessageBox.Show("تکایە وشەی تێپەڕی تازە دابنێ تایبەت بەخۆت", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        using (frm_change_new_pass fp = new frm_change_new_pass() { user = txt_user.Text }) { fp.ShowDialog(); }
                    }
                    else
                    {
                        #region to_know_is_still_work_or_not
                        if (classreader.o3 == "True")
                        {
                            c5.command(@"update tbl_user set active=@active where username=@user and password=@pass",
                                "@user", username, "@pass", pass, "@active", "True", "", "", "", null);
                            if (is_discount == true) { if (classreader.o1 == "admin") { this.Hide(); is_let = true; is_discount = true; } return; }
                            this.Hide();
                            frm_home fh = new frm_home(classreader.o1, classreader.o2);
                            classreader.read("", "select user_id from tbl_user where username=@user", "@user", username, "", "", "", "", "", "", "", "", "user_id", "", "", "");
                            fh.SetUserId(int.Parse(classreader.o1));
                            fh.ShowDialog();
                            this.Close();
                            classreader.o3 = null;
                        }
                        else { MessageBox.Show("ببورە تۆ لەسەر کار نەماوی"); }
                        #endregion
                    }
                    #endregion
                    classreader.o1 = null;
                }
                else { MessageBox.Show(classreader.message, "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                #endregion
            

        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
            classreader.read("","select sum(user_id) as high from tbl_user", "", "", "", "", "", "", "", "", "", null, "high", "", "", "");
            string sum = classreader.o1;
          if(classreader.o1=="")
          {
              MessageBox.Show("لەگەڵ بەرنامەکەمان کارەکانت بەرەو پێش بەرە "+"\n سەرەتا پێویستە ئەکاونتێک دابنێی بۆ ئاسایشی بەرنامەکە ");
              frm_first_visit fv = new frm_first_visit();
              fv.ShowDialog();
              classreader.o1 = null;
          }
          classreader.o1 = null;
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frm_forget fg=new frm_forget())
            {
                fg.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (is_discount==true)
            {
                this.Hide();
                is_discount = false;
                is_let = false;
            }
            else
            {
                Application.Exit();
            }
        }


        private void pictureBox_show_MouseDown(object sender, MouseEventArgs e)
        {
            txt_pass.UseSystemPasswordChar = false;
        }

        private void pictureBox_show_MouseUp(object sender, MouseEventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_restore_by_email fr=new frm_restore_by_email();
            fr.ShowDialog();
        }
    }
}
