namespace FastFood
{
    partial class frm_goods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_kurdish_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_arabic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_english = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_sort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_printer = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_reload = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_types = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_width = new System.Windows.Forms.Timer(this.components);
            this.timer_height = new System.Windows.Forms.Timer(this.components);
            this.timer_width_reverse = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reload)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.txt_kurdish_name, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.txt_id, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(271, 64);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // txt_kurdish_name
            // 
            this.txt_kurdish_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_kurdish_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_kurdish_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_kurdish_name.Location = new System.Drawing.Point(9, 38);
            this.txt_kurdish_name.Name = "txt_kurdish_name";
            this.txt_kurdish_name.Size = new System.Drawing.Size(123, 20);
            this.txt_kurdish_name.TabIndex = 0;
            this.txt_kurdish_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_kurdish_name_KeyDown_1);
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_id.Location = new System.Drawing.Point(9, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(123, 20);
            this.txt_id.TabIndex = 0;
            this.txt_id.TabStop = false;
            this.txt_id.Visible = false;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_favcolor_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(138, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ناوی کوردی";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(138, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "کۆدی کاڵا";
            this.label9.Visible = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel7.Controls.Add(this.btn_update, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.btn_insert, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 213);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(271, 75);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_update.Image = global::FastFood.Properties.Resources.Webp2;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(138, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(130, 63);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "دەستکاری";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_insert.Image = global::FastFood.Properties.Resources.Webp_net_resizeimage__1_;
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.Location = new System.Drawing.Point(3, 3);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(129, 63);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "تۆمارکردن";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_arabic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_english, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 64);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txt_arabic
            // 
            this.txt_arabic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_arabic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_arabic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_arabic.Location = new System.Drawing.Point(9, 6);
            this.txt_arabic.Name = "txt_arabic";
            this.txt_arabic.Size = new System.Drawing.Size(123, 20);
            this.txt_arabic.TabIndex = 0;
            this.txt_arabic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_arabic_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(138, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ناوی عەرەبی";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(138, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "ناوی ئینگلیزی";
            // 
            // txt_english
            // 
            this.txt_english.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_english.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_english.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_english.Location = new System.Drawing.Point(9, 38);
            this.txt_english.Name = "txt_english";
            this.txt_english.Size = new System.Drawing.Size(123, 20);
            this.txt_english.TabIndex = 1;
            this.txt_english.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_english_KeyDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txt_sort, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_printer, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(271, 64);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txt_sort
            // 
            this.txt_sort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_sort.Location = new System.Drawing.Point(9, 6);
            this.txt_sort.Name = "txt_sort";
            this.txt_sort.Size = new System.Drawing.Size(123, 20);
            this.txt_sort.TabIndex = 0;
            this.txt_sort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sort_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(138, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "ڕیزبەندی";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(138, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "ناوی پرنتەر";
            // 
            // txt_printer
            // 
            this.txt_printer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_printer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_printer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_printer.Location = new System.Drawing.Point(9, 38);
            this.txt_printer.Name = "txt_printer";
            this.txt_printer.Size = new System.Drawing.Size(123, 20);
            this.txt_printer.TabIndex = 1;
            this.txt_printer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_printer_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox_reload);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1092, 38);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::FastFood.Properties.Resources.cc;
            this.pictureBox2.Location = new System.Drawing.Point(1059, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox_reload
            // 
            this.pictureBox_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_reload.Image = global::FastFood.Properties.Resources.sdaeaaw;
            this.pictureBox_reload.Location = new System.Drawing.Point(1023, 3);
            this.pictureBox_reload.Name = "pictureBox_reload";
            this.pictureBox_reload.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_reload.TabIndex = 8;
            this.pictureBox_reload.TabStop = false;
            this.pictureBox_reload.Click += new System.EventHandler(this.pictureBox_reload_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel7);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 38);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(289, 592);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 294);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(268, 78);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.81132F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.18868F));
            this.tableLayoutPanel3.Controls.Add(this.btn_types, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_delete, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(265, 70);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_types
            // 
            this.btn_types.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_types.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_types.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_types.Image = global::FastFood.Properties.Resources.types;
            this.btn_types.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_types.Location = new System.Drawing.Point(135, 3);
            this.btn_types.Name = "btn_types";
            this.btn_types.Size = new System.Drawing.Size(0, 63);
            this.btn_types.TabIndex = 1;
            this.btn_types.Text = "جۆرەکانی";
            this.btn_types.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_types.UseVisualStyleBackColor = false;
            this.btn_types.Click += new System.EventHandler(this.btn_types_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.Image = global::FastFood.Properties.Resources.Webp3;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(3, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(0, 63);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "ڕەشکردنەوە";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(289, 38);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(803, 592);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_width
            // 
            this.timer_width.Tick += new System.EventHandler(this.timer_size_Tick);
            // 
            // timer_height
            // 
            this.timer_height.Tick += new System.EventHandler(this.timer_height_Tick);
            // 
            // timer_width_reverse
            // 
            this.timer_width_reverse.Tick += new System.EventHandler(this.timer_width_reverse_Tick);
            // 
            // frm_goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1092, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_goods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_goods";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_goods_Load);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reload)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_arabic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_english;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_sort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_reload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_printer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_kurdish_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_types;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_width;
        private System.Windows.Forms.Timer timer_height;
        private System.Windows.Forms.Timer timer_width_reverse;
        private System.Windows.Forms.Button btn_delete;
    }
}