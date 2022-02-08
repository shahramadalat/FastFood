using System;
using System.Windows.Forms;

namespace FastFood
{
    public partial class frm_first_visit : Form
    {
        public string what { get; set; }
        public string who { get; set; }
        classencrypt ce=new classencrypt();
        public frm_first_visit()
        {
            InitializeComponent();
        }

        private void frm_first_visit_Load(object sender, EventArgs e)
        {
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                #region validate email
                if (!txt_email.Text.Contains("@") || txt_email.Text.Contains(".com"))
                {
                    MessageBox.Show("تکایە ئەمەیڵەکە بەجوانی پڕ بکەوە");
                    return;
                }
                #endregion
                if (txt_favanimal.Text == "" || txt_favcolor.Text == "" || txt_pass.Text == "" || txt_username.Text == "")
                {
                    MessageBox.Show("تکایە زانیاریەکان بەتەواوی پڕ بکەرەوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                         #region encrypt
                    ce.encrypt(txt_username.Text);
                    string username = classencrypt.endresult;
                    ce.encrypt(txt_pass.Text);
                    string pass = classencrypt.endresult;
                    ce.encrypt(txt_favcolor.Text);
                    string color = classencrypt.endresult;
                    ce.encrypt(txt_favanimal.Text);
                    string animal = classencrypt.endresult;
                    #endregion
                     
                    
                        classcommand5 classcommand5 = new classcommand5();
                        classcommand5.command(@"insert into tbl_user values(1,'" + username + "','" + pass + "','admin','" + color + "','" + animal + "',@name,1,1,1,@email)",
                            "", "", "", "", "@name", txt_full_name.Text, "@email", txt_email.Text, "", "");
                        this.Close();
                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
