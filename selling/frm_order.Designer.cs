namespace FastFood
{
    partial class frm_order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_table_id = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_invoice_id = new System.Windows.Forms.TextBox();
            this.btn_insert_invoice_id = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_final_price = new System.Windows.Forms.TextBox();
            this.layout_del = new System.Windows.Forms.TableLayoutPanel();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.panel_table = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_goods = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_type = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_hide = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DataSet1 = new FastFood.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spPrintTableAdapter = new FastFood.DataSet1TableAdapters.spPrintTableAdapter();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.layout_del.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel_goods.SuspendLayout();
            this.panel_type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.btn_insert_invoice_id);
            this.flowLayoutPanel2.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel7);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel8);
            this.flowLayoutPanel2.Controls.Add(this.layout_del);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(197, 820);
            this.flowLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_table_id, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(135, 65);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ناوی مێز";
            // 
            // cmb_table_id
            // 
            this.cmb_table_id.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_table_id.FormattingEnabled = true;
            this.cmb_table_id.Location = new System.Drawing.Point(4, 29);
            this.cmb_table_id.Name = "cmb_table_id";
            this.cmb_table_id.Size = new System.Drawing.Size(121, 26);
            this.cmb_table_id.TabIndex = 1;
            this.cmb_table_id.SelectedIndexChanged += new System.EventHandler(this.cmb_table_id_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_invoice_id, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(135, 65);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "کۆدی پسوڵە";
            // 
            // txt_invoice_id
            // 
            this.txt_invoice_id.Enabled = false;
            this.txt_invoice_id.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoice_id.Location = new System.Drawing.Point(4, 29);
            this.txt_invoice_id.Name = "txt_invoice_id";
            this.txt_invoice_id.Size = new System.Drawing.Size(127, 30);
            this.txt_invoice_id.TabIndex = 1;
            this.txt_invoice_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_invoice_id_KeyPress);
            // 
            // btn_insert_invoice_id
            // 
            this.btn_insert_invoice_id.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_insert_invoice_id.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_insert_invoice_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert_invoice_id.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_invoice_id.ForeColor = System.Drawing.Color.White;
            this.btn_insert_invoice_id.Image = global::FastFood.Properties.Resources.Webp_net_resizeimage__6_;
            this.btn_insert_invoice_id.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_insert_invoice_id.Location = new System.Drawing.Point(3, 145);
            this.btn_insert_invoice_id.Name = "btn_insert_invoice_id";
            this.btn_insert_invoice_id.Size = new System.Drawing.Size(135, 57);
            this.btn_insert_invoice_id.TabIndex = 0;
            this.btn_insert_invoice_id.Text = "پرنت";
            this.btn_insert_invoice_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert_invoice_id.UseVisualStyleBackColor = false;
            this.btn_insert_invoice_id.Click += new System.EventHandler(this.btn_insert_invoice_id_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 30);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txt_price, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 244);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(135, 65);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(54, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "نرخ";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(4, 29);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(127, 30);
            this.txt_price.TabIndex = 1;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_invoice_id_KeyPress);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.txt_total, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 315);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(135, 65);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "کۆی گشتی";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(4, 29);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(127, 30);
            this.txt_total.TabIndex = 1;
            this.txt_total.Text = "0";
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_discount, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 386);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(135, 65);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "داشکاندن";
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(4, 29);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(127, 30);
            this.txt_discount.TabIndex = 1;
            this.txt_discount.Text = " 0";
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            this.txt_discount.Enter += new System.EventHandler(this.txt_discount_Enter);
            this.txt_discount.Leave += new System.EventHandler(this.txt_discount_Leave);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txt_final_price, 0, 1);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 457);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(135, 65);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "نرخی کۆتایی";
            // 
            // txt_final_price
            // 
            this.txt_final_price.Enabled = false;
            this.txt_final_price.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_final_price.Location = new System.Drawing.Point(4, 29);
            this.txt_final_price.Name = "txt_final_price";
            this.txt_final_price.ReadOnly = true;
            this.txt_final_price.Size = new System.Drawing.Size(127, 30);
            this.txt_final_price.TabIndex = 1;
            this.txt_final_price.Text = " 0";
            // 
            // layout_del
            // 
            this.layout_del.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.layout_del.ColumnCount = 1;
            this.layout_del.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_del.Controls.Add(this.txt_address, 0, 3);
            this.layout_del.Controls.Add(this.label9, 0, 2);
            this.layout_del.Controls.Add(this.label4, 0, 0);
            this.layout_del.Controls.Add(this.txt_mobile, 0, 1);
            this.layout_del.Location = new System.Drawing.Point(3, 528);
            this.layout_del.Name = "layout_del";
            this.layout_del.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.layout_del.RowCount = 4;
            this.layout_del.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.layout_del.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.layout_del.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.layout_del.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.layout_del.Size = new System.Drawing.Size(135, 134);
            this.layout_del.TabIndex = 10;
            this.layout_del.Visible = false;
            // 
            // txt_address
            // 
            this.txt_address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_address.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(4, 92);
            this.txt_address.Name = "txt_address";
            this.txt_address.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_address.Size = new System.Drawing.Size(127, 30);
            this.txt_address.TabIndex = 3;
            this.txt_address.Text = "نیە";
            this.txt_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_address_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(39, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "ناونیشان";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "ژ.مۆبایل";
            // 
            // txt_mobile
            // 
            this.txt_mobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_mobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_mobile.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobile.Location = new System.Drawing.Point(4, 30);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(127, 30);
            this.txt_mobile.TabIndex = 2;
            this.txt_mobile.Text = "0";
            this.txt_mobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mobile_KeyDown);
            this.txt_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobile_KeyPress);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel6.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txt_user, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(751, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(238, 31);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(104, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "کۆدی کارمەند";
            // 
            // txt_user
            // 
            this.txt_user.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_user.Enabled = false;
            this.txt_user.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(10, 3);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(88, 25);
            this.txt_user.TabIndex = 1;
            this.txt_user.Text = "1";
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_table
            // 
            this.panel_table.AutoScroll = true;
            this.panel_table.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_table.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_table.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panel_table.Location = new System.Drawing.Point(197, 202);
            this.panel_table.Name = "panel_table";
            this.panel_table.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_table.Size = new System.Drawing.Size(114, 652);
            this.panel_table.TabIndex = 22;
            // 
            // panel_goods
            // 
            this.panel_goods.AutoScroll = true;
            this.panel_goods.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_goods.Controls.Add(this.reportViewer1);
            this.panel_goods.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_goods.Location = new System.Drawing.Point(197, 34);
            this.panel_goods.Name = "panel_goods";
            this.panel_goods.Size = new System.Drawing.Size(867, 86);
            this.panel_goods.TabIndex = 23;
            // 
            // panel_type
            // 
            this.panel_type.AutoScroll = true;
            this.panel_type.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_type.Controls.Add(this.btn_hide);
            this.panel_type.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_type.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_type.Location = new System.Drawing.Point(197, 120);
            this.panel_type.Name = "panel_type";
            this.panel_type.Size = new System.Drawing.Size(867, 82);
            this.panel_type.TabIndex = 26;
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.btn_hide.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_hide.Location = new System.Drawing.Point(3, 3);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(94, 33);
            this.btn_hide.TabIndex = 0;
            this.btn_hide.Text = "شاردنەوە";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(317, 208);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Peshang Des 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(708, 458);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1064, 34);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::FastFood.Properties.Resources.cc;
            this.pictureBox3.Location = new System.Drawing.Point(1031, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::FastFood.Properties.Resources.sdaeaaw;
            this.pictureBox4.Location = new System.Drawing.Point(995, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spPrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FastFood.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(722, 66);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // spPrintBindingSource
            // 
            this.spPrintBindingSource.DataMember = "spPrint";
            this.spPrintBindingSource.DataSource = this.DataSet1;
            // 
            // spPrintTableAdapter
            // 
            this.spPrintTableAdapter.ClearBeforeFill = true;
            // 
            // frm_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1064, 854);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.panel_type);
            this.Controls.Add(this.panel_goods);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_invoice_info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_invoice_info_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.layout_del.ResumeLayout(false);
            this.layout_del.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel_goods.ResumeLayout(false);
            this.panel_type.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel panel_table;
        private System.Windows.Forms.FlowLayoutPanel panel_goods;
        private System.Windows.Forms.FlowLayoutPanel panel_type;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_invoice_id;
        private System.Windows.Forms.Button btn_insert_invoice_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_final_price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_table_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TableLayoutPanel layout_del;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mobile;
        public System.Windows.Forms.TextBox txt_address;
        private DataSet1 DataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spPrintBindingSource;
        private DataSet1TableAdapters.spPrintTableAdapter spPrintTableAdapter;
    }
}