using System;
using System.Windows.Forms;


namespace FastFood
{
    public partial class frm_forget : Form
    {
        string user="";
        classreader r = new classreader();
        classcommand c = new classcommand();
        classencrypt ce=new classencrypt();
        public frm_forget()
        {
            InitializeComponent();
        }

        private void frm_forgett_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region encrypt
            ce.encrypt(txt_color.Text);
            string color = classencrypt.endresult;
            ce.encrypt(txt_animal.Text);
            string animal = classencrypt.endresult;
            #endregion


            r.read("","select user_id,username from tbl_user where favcolor=@color and favanimal=@animal","@color",color,"@animal",animal,"","","","","",null,"user_id","username","","");
            if (classreader.o1!=null)
            {
                timer2.Start();
                classreader.o1 = null;
                classreader.o2 = null;
            }
            else { MessageBox.Show(classreader.message); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            #region encrypt
            ce.encrypt(txt_user.Text);
            string username = classencrypt.endresult;
            #endregion


            r.read("","select username from tbl_user where username=@user","@user",username,"","","","","","","",null,"username","","","");
            if (classreader.o1 != null)
            {
                user = classreader.o1;
                classreader.o1 = null;
                timer1.Start();
            }
            else { MessageBox.Show(classreader.message); }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_fav.Width = panel_fav.Width + 20;
            if(panel_fav.Width>325)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            panel_renew.Width = panel_renew.Width + 20;
            if (panel_renew.Width > 350)
            {
                timer2.Stop();
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (txt_new_pass.Text == txt_new_pass_again.Text)
            {
                ce.encrypt(txt_new_pass.Text);
                string pass = classencrypt.endresult;
                ce.encrypt(txt_user.Text);
                string username = classencrypt.endresult;


                c.command(@"update tbl_user set password=@pass where username=@user",
                "@pass", pass, "@user", username, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                this.Close();
            }
            else { MessageBox.Show("dont match password"); }
         
        }

        private void btn_user_change_Click(object sender, EventArgs e)
        {
            using(frm_change_user fcu=new frm_change_user())
            {
                fcu.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    SendEmail("smtp.gmail.com", "shahramadalat@gmail.com", "Hawraman2018", @"shahramadalat@gmail.com", @"shahramadalat@gmail.com", @"هێنانەوەی ناوی بەکارهێنەرو وشەی تێپەڕ", string.Format("username={0}",name));
        }

       

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }










    }
}
