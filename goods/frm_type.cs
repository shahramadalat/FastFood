using System;
using System.Windows.Forms;
using System.Drawing;

namespace FastFood
{
    public partial class frm_type : Form
    {
        classcommand cc = new classcommand();
        classreader cr = new classreader();
        classcommand5 c5 = new classcommand5();
        public string goods_id { get; set; }
        public string good_name { get; set; }
        public frm_type()
        {
            InitializeComponent();
        }
      
          void loadd()
        {
            classaddapter ca = new classaddapter();
            ca.addapter("select * from tbl_goods_type where goods_id='"+goods_id+"'");
            dataGridView1.DataSource = classaddapter.dt;
            lbl_name.Text = good_name;
            dataGridView1.Columns[0].DisplayIndex = 7;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            rename();
            search(txt_kurdish, "select kurdish_name from tbl_goods_type where goods_id="+goods_id+"");
            search(txt_arabic,  "select arabic_name from tbl_goods_type where goods_id="+goods_id+"" );
            search(txt_english, "select english_name from tbl_goods_type where goods_id="+goods_id+"");
        }
          void search(TextBox a, string q)
          {
              cr.read("collection", q, "", "", "", "", "", "", "", "", "", null, "", "", "", "");
              a.AutoCompleteCustomSource = classreader.collection;
          }
          void spsearch(string sp, string p, string txt)
          {
              cr.read10("sp", sp, "", "", p, txt, "", "", "goods_type_id", "kurdish_name", "arabic_name", "english_name", "price", "sort_no", "", "", "", "");
              txt_id.Text = classreader.o1; txt_kurdish.Text = classreader.o2; txt_arabic.Text = classreader.o3; txt_english.Text = classreader.o4; txt_price.Text = classreader.o5; txt_sort.Text = classreader.o6;
          }
          void rename()
          {
              dataGridView1.Columns["goods_type_id"].HeaderText = "تیراژی جۆر";
              dataGridView1.Columns["kurdish_name"].HeaderText = "ناوی کوردی";
              dataGridView1.Columns["arabic_name"].HeaderText = "ناوی عەرەبی";
              dataGridView1.Columns["english_name"].HeaderText = "ناوی ئینگلیزی";
              dataGridView1.Columns["sort_no"].HeaderText = "ڕیزبەندی";
              dataGridView1.Columns["price"].HeaderText = "نرخ";
              dataGridView1.Columns["goods_id"].HeaderText = "تیراژی کاڵا";
              dataGridView1.Columns["delete"].HeaderText = "";
                  }
          void count()
          {
              c5.id("select max(goods_type_id) from tbl_goods_type");
              txt_id.Text = classcommand5.set;
          }
          void renew()
          {
              txt_arabic.Text = "";
              txt_english.Text = "";
              txt_kurdish.Text = "";
              txt_price.Text = "";
              txt_sort.Text = "";
              txt_kurdish.Focus();
             
          }
        
        

        private void frm_type_Load(object sender, EventArgs e)
        {
            classcontrol cc = new classcontrol();
            cc.image("delete", FastFood.Properties.Resources.Webp_net_resizeimage);
            dataGridView1.Columns.Add(classcontrol.i);
            loadd();
            count();
            txt_kurdish.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cc.command("update tbl_goods_type set kurdish_name=@kurdish, arabic_name=@arabic, english_name=@english , sort_no=@sort, price=@price where goods_type_id=@id ",
               "@id", txt_id.Text, "@kurdish", txt_kurdish.Text, "@arabic", txt_arabic.Text, "@english", txt_english.Text, "@sort", txt_sort.Text, "@price", txt_price.Text, "@goods_id", goods_id, "", "", "", "", "", "");
            loadd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cc.command("insert into tbl_goods_type values(@id,@kurdish,@arabic,@english,@price,@sort,@g_id)","@id",txt_id.Text,"@kurdish",txt_kurdish.Text,"@arabic",txt_arabic.Text,"@english",txt_english.Text,"@price",txt_price.Text,"@sort",txt_sort.Text,"@g_id",goods_id,"","","","","","");
            loadd();
            count();
            renew();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("ئایا دڵنیای لە ڕەشکردنەوەی " + "\n" + "تیراژی" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "ئاگاداری", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    classcommand5 c5 = new classcommand5();
                    c5.command("delete from tbl_goods_type where goods_type_id=@id", "@id", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "", "", "", "", "", "", "", "");
                    loadd();
                    count();
                    renew();
                }
            }
            else
            {
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cr.read("","select * from tbl_goods_type where goods_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null, "kurdish_name", "arabic_name", "english_name", "sort_no");
                txt_arabic.Text = classreader.o2;
                txt_english.Text = classreader.o3;
                txt_kurdish.Text = classreader.o1;
                txt_sort.Text = classreader.o4;
                classreader.o1 = null;
                cr.read("","select price from tbl_goods_type where goods_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null, "price", "", "", "");
                txt_price.Text = classreader.o1;
            }
          
        }

        private void pictureBox_reload_Click(object sender, EventArgs e)
        {
            loadd();
            count();
            renew();
            timer_width_reverse.Start();
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ببورە ناتوانی لێرەدا وشە داخڵ بکەی ", "زانیاری", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;

            }
        }

        private void txt_sort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ببورە ناتوانی لێرەدا وشە داخڵ بکەی ", "زانیاری", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                cr.read("", "select goods_type_id from tbl_order where goods_type_id=@id", "@id", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "", "", "", "", "", "", "", "", "goods_type_id", "", "", "");
                if (classreader.o1 != "")
                {
                    MessageBox.Show("ببورە ناتوانی ئەم جۆری کاڵایە ڕەش بکەیتەوە چونکە لەم بابەتەت فرۆشتوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    classreader.o1 = "";
                    return;
                }

                if (MessageBox.Show("ئایا دڵنیای لە ڕەشکردنەوەی " + "\n"  + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), "ئاگاداری", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    classcommand5 c5 = new classcommand5();
                    c5.command("delete from tbl_goods_type where goods_type_id=@id", "@id", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "", "", "", "", "", "", "", "");
                    loadd();
                    count();
                    renew();
                }
            }
            else
            {
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cr.read("", "select * from tbl_goods_type where goods_type_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null, "kurdish_name", "arabic_name", "english_name", "price");
                txt_arabic.Text = classreader.o2;
                txt_english.Text = classreader.o3;
                txt_kurdish.Text = classreader.o1;
                txt_price.Text = classreader.o4;
                classreader.o1 = null;
                classreader.o2 = null;
                cr.read("", "select sort_no from tbl_goods_type where goods_type_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null, "sort_no", "", "", "");
                txt_sort.Text = classreader.o1;
                timer_height.Start();
                timer_width.Start();
                timer1.Start();
               
            }
        }

        int r = 1;
        int g = 1;
        int b = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                r += 2;
                g += 3;
                b += 4;
                btn_delete.BackColor = Color.FromArgb(r, g, b);
                if (b > 170)
                {
                    timer1.Stop();
                    r = 1; g = 1; b = 1;
                }
            }
            catch { MessageBox.Show("کێشەیەک لە کارەکەدا هەیە تکایە دوبارە هەوڵ بدەوە"); }
        }

        int w = 0;
        private void timer_width_Tick(object sender, EventArgs e)
        {

            w += 14;
            btn_delete.Width = w;
            if (w > 180)
            { timer_width.Stop(); w = 0; }
        }

        int h = 0;
        private void timer_height_Tick(object sender, EventArgs e)
        {
            h += 7;
            btn_delete.Height = h;
            if (h > 60)
            {
                timer_height.Stop();
                h = 0;
            }
        }

        int wr = 182;
        private void timer_width_reverse_Tick(object sender, EventArgs e)
        {
            wr -= 14;
            btn_delete.Width = wr;
            if (wr < 15)
            {
                btn_delete.Width = 0;
                wr = 182;
                timer_width_reverse.Stop();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cr.read("", "select goods_type_id from tbl_order where goods_type_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", "", "goods_type_id", "", "", "");
            if (classreader.o1!="")
            {
                MessageBox.Show("ببورە ناتوانی ئەم جۆری کاڵایە ڕەش بکەیتەوە چونکە لەم بابەتەت فرۆشتوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            if (MessageBox.Show("ئایا دڵنیای لە ڕەشکردنەوەی " + "\n" + txt_kurdish.Text, "ئاگاداری", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                classcommand5 c5 = new classcommand5();
                c5.command("delete from tbl_goods_type where goods_type_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", "");
                loadd();
                count();
                renew();
                timer_width_reverse.Start();
            }
        }

        private void txt_kurdish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spsearch("spGoods_type_get_by_kurdish", "@kurdish", txt_kurdish.Text);
                timer_height.Start();
                timer_width.Start();
                timer1.Start();
            }
        }

        private void txt_arabic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spsearch("spGoods_type_get_by_arabic", "@arabic", txt_arabic.Text);
                timer_height.Start();
                timer_width.Start();
                timer1.Start();
            }
        }

        private void txt_english_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spsearch("spGoods_type_get_by_english", "@english", txt_english.Text);
                timer_height.Start();
                timer_width.Start();
                timer1.Start();
            }
        }
    }
}
