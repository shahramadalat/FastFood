using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;

namespace FastFood
{
    public partial class frm_restore_by_email : Form
    {
        public frm_restore_by_email()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected void SendEmail(string host, string username, string password, string from, string to, string subject, string body)
        {
            SmtpClient client = new SmtpClient(host, 587);
            client.Credentials = new NetworkCredential(username, password);
            client.EnableSsl = true;
            MailMessage msg = new MailMessage(from, to, subject, body);
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Send(msg);
            MessageBox.Show("success");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                classreader cr = new classreader();

                cr.read("", "select user_id from tbl_user where email=@email", "@email", txt_email.Text, "", "", "", "", "", "", "", "", "user_id", "", "", "");
                string id = classreader.o1;
                cr.read10("", "select username ,password,favcolor,favanimal from tbl_user where user_id=" + id + " ", "", "", "", "", "", "", "username", "password", "favcolor", "favanimal", "", "", "", "", "", "");
                #region decrypt
                classencrypt ce=new classencrypt();
                ce.decrypt(classreader.o1);
                string username = classencrypt.endresult;
                ce.decrypt(classreader.o2);
                string password = classencrypt.endresult;
                ce.decrypt(classreader.o3);
                string color = classencrypt.endresult;
                ce.decrypt(classreader.o4);
                string animal = classencrypt.endresult;
                #endregion

                SendEmail("smtp.gmail.com", "shahramadalat@gmail.com", txt_email_pass.Text, txt_email.Text, txt_email.Text, @"هێنانەوەی ناوی بەکارهێنەرو وشەی تێپەڕ", string.Format("code: {0}  UserName: {1}  Password: {2}  color: {3}  animal: {4}",id,username,password,color,animal));
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
    }
}
