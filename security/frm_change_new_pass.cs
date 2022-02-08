using System;
using System.Windows.Forms;

namespace FastFood
{
    public partial class frm_change_new_pass : Form
    {
        classcommand5 c = new classcommand5();
        classencrypt ce=new classencrypt();
        public string user { get; set; }
        public frm_change_new_pass()
        {
            InitializeComponent();
        }

        private void frm_change_new_pass_Load(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
      
                ce.encrypt(txt_pass.Text);
                string pass = classencrypt.endresult;
                ce.encrypt(user);
                string username = classencrypt.endresult;

                if (txt_pass.Text == txt_again.Text)
                {

                    c.command(@"update tbl_user set is_changed=@change, password=@pass where username=@user",
                    "@pass", pass, "@user", username, "@change", "True", "", "", "", null);
                    MessageBox.Show("سەرکەوتوبوو");
                    this.Close();
                }
                else { MessageBox.Show("تکایە هەردوو وشەی تێپەڕەکە وەک یەک بنوسە"); }
            }
            catch { MessageBox.Show("تکایە دوبارە هەوڵ بدەرەوە","ئاگاداری",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
