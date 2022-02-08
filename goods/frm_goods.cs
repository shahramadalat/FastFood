using System;
using System.Windows.Forms;
using System.Drawing;

namespace FastFood
{
    public partial class frm_goods : Form
    {
        classcommand cc = new classcommand();
        classreader cr = new classreader();
        classcommand5 c5 = new classcommand5();
        public frm_goods()
        {
            InitializeComponent();
        }
        void loadd()
        {
            
            classaddapter ca = new classaddapter();
            ca.addapter("select * from tbl_goods");
            dataGridView1.DataSource = classaddapter.dt;
            dataGridView1.Columns[1].DisplayIndex = 7;
            dataGridView1.Columns[0].DisplayIndex = 6;
            rename();
            dataGridView1.Columns[2].Visible = false;

            search(txt_kurdish_name, "select kurdish_name from tbl_goods");
            search(txt_arabic, "select arabic_name from tbl_goods");
            search(txt_english, "select english_name from tbl_goods");
            search(txt_printer, "select print_name from tbl_goods");
        }
        void renew()
        {
            txt_arabic.Text = "";
            txt_english.Text = "";
            txt_kurdish_name.Text = "";
            txt_printer.Text = "";
            txt_sort.Text = "";
            txt_kurdish_name.Focus();
        }
        void count()
        {
            c5.id("select isnull(max(goods_id),0) from tbl_goods");
            txt_id.Text = classcommand5.set;
        }
        void rename()
        {
            dataGridView1.Columns["goods_id"].HeaderText = "کۆدی کاڵا";
            dataGridView1.Columns["kurdish_name"].HeaderText = "ناوی کوردی";
            dataGridView1.Columns["arabic_name"].HeaderText = "ناوی عەرەبی";
            dataGridView1.Columns["english_name"].HeaderText = "ناوی ئینگلیزی";
            dataGridView1.Columns["sort"].HeaderText = "ڕیزبەندی";
            dataGridView1.Columns["print_name"].HeaderText = "ناوی پرنت";
            dataGridView1.Columns["delete"].HeaderText = "ڕەشکردنەوە";
            dataGridView1.Columns["add"].HeaderText ="دەستکاریکردنی جۆرەکانی";
            dataGridView1.Columns["goods_id"].Width = 75;
            dataGridView1.Columns["delete"].Width = 75;
            dataGridView1.Columns["sort"].Width = 75;

        }


        private void txt_favcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ببورە ناتوانی لێرەدا وشە داخڵ بکەی ", "زانیاری", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void search(TextBox a,string q) 
        {
            cr.read("collection", q, "", "", "", "", "", "", "", "", "", null, "", "", "", "");
            a.AutoCompleteCustomSource = classreader.collection;
        }
        private void frm_goods_Load(object sender, EventArgs e)
        {

            //btn_types.Visible = false;
          
            classcontrol cc = new classcontrol();
            cc.image("delete",FastFood.Properties.Resources.Webp_net_resizeimage);
            classcontrol classcontrol = new classcontrol();
            classcontrol.button_control("add","جۆرەکانی");
            dataGridView1.Columns.Add(classcontrol.b);
            dataGridView1.Columns.Add(classcontrol.i);
            loadd();
            count();
            txt_kurdish_name.Focus();
          
           
         
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if(txt_arabic.Text==""||txt_english.Text==""||txt_kurdish_name.Text==""||txt_printer.Text==""||txt_sort.Text=="")
            {
                MessageBox.Show("تکایە زانیاریەکان بەتەواوەتی پڕ بکەرەوە","ئاگاداری",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (txt_id.Text == "")
            {
                count();
                cc.command("insert into tbl_goods values(@id,@kurdish,@arabic,@english,@sort,@print)",
                   "@id", txt_id.Text, "@kurdish", txt_kurdish_name.Text, "@english", txt_english.Text, "@sort", txt_sort.Text, "@print", txt_printer.Text, "@arabic", txt_arabic.Text, "", "", "", "", "", "", "", "");
               
            }
            else
            {
                cc.command("insert into tbl_goods values(@id,@kurdish,@arabic,@english,@sort,@print)",
                    "@id", txt_id.Text, "@kurdish", txt_kurdish_name.Text, "@english", txt_english.Text, "@sort", txt_sort.Text, "@print", txt_printer.Text, "@arabic", txt_arabic.Text, "", "", "", "", "", "", "", "");
             
            }
            loadd();
            count();
            renew();
        }

        private void pictureBox_reload_Click(object sender, EventArgs e)
        {
            loadd();
            count();
            renew();
            timer_width_reverse.Start();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_arabic.Text == "" || txt_english.Text == "" || txt_kurdish_name.Text == "" || txt_printer.Text == "" || txt_sort.Text == "")
            {
                MessageBox.Show("تکایە زانیاریەکان بەتەواوەتی پڕ بکەرەوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_id.Text == "")
            {
                MessageBox.Show("تکایە کۆدی ئەو کاڵایە دیاری بکە کە دەتەوێ دەستکاری بکەیت","زانیاری",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                cc.command("update tbl_goods set kurdish_name=@kurdish, arabic_name=@arabic, english_name=@english , sort=@sort, print_name=@print where goods_id=@id ",
                 "@id", txt_id.Text, "@kurdish", txt_kurdish_name.Text, "@arabic", txt_arabic.Text, "@english", txt_english.Text, "@sort", txt_sort.Text, "@print", txt_printer.Text, "", "", "", "", "", "", "", "");
             
            }
           
            loadd();

           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                classreader.o1 = null;
                cr.read("", "select * from tbl_goods_type where goods_id=@id", "@id", dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), "", "", "", "", "", "", "", null, "goods_id", "", "", "");
                if (classreader.o1 != null)
                { MessageBox.Show("ببورە تۆ ناتوانی ئەم کاڵآیە ڕەش بکەیتەوە" + "\n" + "چونکە چەند جۆرێکت داخڵ کردوە تایبەت بەم کاڵآیە" + "\n" + " سەرەتا دەبێ جۆرەکانی ڕەش بکەیتەوە ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {

                    if (MessageBox.Show("ئایا دڵنیای لە ڕەشکردنەوەی " + "\n" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), "ئاگاداری", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        classcommand5 c5 = new classcommand5();
                        c5.command("delete from tbl_goods where goods_id=@id", "@id", dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), "", "", "", "", "", "", "", "");
                        loadd();
                        count();
                        renew();
                    }
                }

            }
            else if(e.ColumnIndex==0)
            {
                frm_type ft = new frm_type() {goods_id=dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),good_name=dataGridView1.Rows[e.RowIndex].Cells["kurdish_name"].Value.ToString() };
                ft.ShowDialog();
            }
            else
            {
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cr.read("","select * from tbl_goods where goods_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null, "kurdish_name", "arabic_name", "english_name", "sort");
                txt_arabic.Text = classreader.o2;
                txt_english.Text = classreader.o3;
                txt_kurdish_name.Text = classreader.o1;
                txt_sort.Text = classreader.o4;
                classreader.o1 = null;
               cr.read("","select print_name from tbl_goods where goods_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null, "print_name", "", "", "");
                txt_printer.Text = classreader.o1;
                timer_height.Start();
                timer_width.Start();
                timer1.Start();
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



        void spsearch(string sp,string p,string txt)
        {

            cr.read10("sp",sp, "", "", p, txt, "", "", "goods_id", "kurdish_name", "arabic_name", "sort", "print_name", "english_name", "", "", "", "");
            txt_id.Text = classreader.o1; txt_kurdish_name.Text = classreader.o2; txt_arabic.Text = classreader.o3; txt_sort.Text = classreader.o4; txt_printer.Text = classreader.o5; txt_english.Text = classreader.o6;
        
        }
        private void txt_english_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spsearch("spGoods_get_by_english_name", "@english_name", txt_english.Text);
                timer_height.Start();
                timer_width.Start();
                timer1.Start();
            }
        }

        private void txt_arabic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spsearch("spGoods_get_by_arabic_name", "@arabic_name", txt_arabic.Text);
                timer_height.Start();
                timer_width.Start();
                timer1.Start();
            }
        }

        private void txt_printer_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                spsearch("spGoods_get_by_printer_name", "@print_name", txt_printer.Text);
                timer_height.Start();
                timer_width.Start();
                timer1.Start();
            }
        }



        private void txt_kurdish_name_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
        {
            spsearch("spGoods_get_by_kurdish_name", "@kurdish_name", txt_kurdish_name.Text);
            timer_height.Start();
            timer_width.Start();
            timer1.Start();
        }
        }

        private void btn_types_Click(object sender, EventArgs e)
        {
            using(frm_type ft=new frm_type())
            {
                ft.goods_id = txt_id.Text;
                ft.good_name = txt_kurdish_name.Text;
                ft.ShowDialog();
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
                btn_types.BackColor = Color.FromArgb(r, g, b);
                btn_delete.BackColor = Color.FromArgb(r,g,b);
                if (b > 170)
                {
                    timer1.Stop();
                    r = 1; g = 1; b = 1;
                }
            }
            catch { MessageBox.Show("کێشەیەک لە کارەکەدا هەیە تکایە دوبارە هەوڵ بدەوە"); }

        }

        int w = 0;
        private void timer_size_Tick(object sender, EventArgs e)
        {

            w += 14;
            btn_types.Width = w;
            btn_delete.Width = w;
            if(w>180)
            { timer_width.Stop(); w = 0; }

        }

        int h = 0;
        private void timer_height_Tick(object sender, EventArgs e)
        {
            h += 7;
            btn_types.Height = h;
            btn_delete.Height = h;
            if (h > 60)
            { timer_height.Stop();
            h = 0;
            }
        }

        int wr = 182;
        private void timer_width_reverse_Tick(object sender, EventArgs e)
        {
            wr -= 14;
            btn_types.Width = wr;
            btn_delete.Width = wr;
            if (wr < 15)
            {
                btn_delete.Width = 0;
                btn_types.Width = 0;
                wr = 182;
               timer_width_reverse.Stop();
                
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            classreader.o1 = null;
            cr.read("", "select * from tbl_goods_type where goods_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", null, "goods_id", "", "", "");
            if (classreader.o1 != null)
            { MessageBox.Show("ببورە تۆ ناتوانی ئەم کاڵآیە ڕەش بکەیتەوە"+"\n"+"چونکە چەند جۆرێکت داخڵ کردوە تایبەت بەم کاڵآیە"+"\n"+" سەرەتا دەبێ جۆرەکانی ڕەش بکەیتەوە ","ئاگاداری",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
            else {

                if (MessageBox.Show("ئایا دڵنیای لە ڕەشکردنەوەی " + "\n" + txt_kurdish_name.Text, "ئاگاداری", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    classcommand5 c5 = new classcommand5();
                    c5.command("delete from tbl_goods where goods_id=@id", "@id", txt_id.Text, "", "", "", "", "", "", "", "");
                    loadd();
                    count();
                    renew();
                }
             }





       
        }

        


    }
}
