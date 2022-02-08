using System;
using System.Windows.Forms;

namespace FastFood
{
    public partial class frm_home : Form
    {
        #region user id get&set
        private int user_id;

        public void SetUserId(int id)
        {
            this.user_id = id;
        }

        private int GetUserId()
        {
            return user_id;
        }
        #endregion
        public frm_home(string per,string user)
        {
            InitializeComponent();
            lbl_per.Text = per;
            lbl_user.Text = user;
        }

      

        private void frm_home_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(frm_user fu=new frm_user())
            {
                fu.ShowDialog();
            }
        }

        private void btn_goods_Click(object sender, EventArgs e)
        {
            using (frm_goods fg = new frm_goods())
            { fg.ShowDialog(); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using(frm_table_info ft=new frm_table_info())
            {
                ft.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(frm_order fo=new frm_order())
            {
                fo.SetUserId(GetUserId());
                fo.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_mobile_info fm = new frm_mobile_info();
            fm.set_what(false);
            fm.ShowDialog();
        }

     
    }
}
