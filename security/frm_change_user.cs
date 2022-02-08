using System;
using System.Windows.Forms;

namespace FastFood
{
    public partial class frm_change_user : Form
    {
        classencrypt ce = new classencrypt();
        public frm_change_user()
        {
            InitializeComponent();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            classreader r = new classreader();

            #region encrypt
            ce.encrypt(txt_pass.Text);
            string pass = classencrypt.endresult;
            #endregion


            r.read("",@"select username from tbl_user where password=@pass and user_id=@id", "@pass", pass, "@id", txt_id.Text, "", "", "", "", "", null, "username", "", "", "");
            if (classreader.o1 !=null)
            {
                panel1.Visible = true;
            }
            else { MessageBox.Show(classreader.message); }
            
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("تکایە پاسۆردو تیراژ داخڵ بکە سەرەتا");
            }
            else
            {
                if (txt_again.Text != txt_new_user.Text)
                {
                    MessageBox.Show("ئەو ناوە تازەی داخڵت کردوە لەگەڵ دوبارەکەیدا وەک یەک نین");
                }
                else
                {
                    #region encrypt
                    ce.encrypt(txt_new_user.Text);
                    string username = classencrypt.endresult;
                    ce.encrypt(txt_pass.Text);
                    string pass = classencrypt.endresult;
                    #endregion

                    classcommand5 c5 = new classcommand5();
                    c5.command(@"update tbl_user set username=@user where password=@pass and user_id=@id   ",
                        "@user", username, "@pass", pass, "@id", txt_id.Text, "", "", "", null);
                    MessageBox.Show("سەرکەوتوو بوو"+"\nبریتیە لە ناوە تازەکە"+" "+txt_new_user.Text+" ");
                    this.Close();

                }
            }
        }

        private void frm_change_user_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
