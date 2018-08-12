namespace Klinik3
{
    partial class Sales_Report
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
            System.Windows.Forms.Label pay_idLabel;
            System.Windows.Forms.Label pay_staffidLabel;
            System.Windows.Forms.Label pay_typeLabel;
            System.Windows.Forms.Label pay_amtLabel;
            System.Windows.Forms.Label q_idLabel;
            System.Windows.Forms.Label pat_nameLabel;
            System.Windows.Forms.Label doc_idLabel;
            System.Windows.Forms.Label recieptLabel;
            System.Windows.Forms.Label dATELabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxpaymentty = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonmonth = new System.Windows.Forms.RadioButton();
            this.radioButtondate = new System.Windows.Forms.RadioButton();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.radioButtondaterange = new System.Windows.Forms.RadioButton();
            this.radioButtonthisyear = new System.Windows.Forms.RadioButton();
            this.radioButtonthismonth = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonbydoc = new System.Windows.Forms.RadioButton();
            this.radioButtonsumm = new System.Windows.Forms.RadioButton();
            this.radioButtonbypanel = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pAYMENTDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_klinikDataSet = new Klinik3.database_klinikDataSet();
            this.pay_idLabel1 = new System.Windows.Forms.Label();
            this.pay_staffidLabel1 = new System.Windows.Forms.Label();
            this.pay_typeLabel1 = new System.Windows.Forms.Label();
            this.pay_amtLabel1 = new System.Windows.Forms.Label();
            this.q_idLabel1 = new System.Windows.Forms.Label();
            this.pat_nameLabel1 = new System.Windows.Forms.Label();
            this.doc_idLabel1 = new System.Windows.Forms.Label();
            this.recieptTextBox = new System.Windows.Forms.TextBox();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.payidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paystaffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTableAdapter = new Klinik3.klinikDataSetTableAdapters.paymentTableAdapter();
            this.pAYMENTDETAILSTableAdapter = new Klinik3.database_klinikDataSetTableAdapters.PAYMENTDETAILSTableAdapter();
            this.tableAdapterManager = new Klinik3.database_klinikDataSetTableAdapters.TableAdapterManager();
            pay_idLabel = new System.Windows.Forms.Label();
            pay_staffidLabel = new System.Windows.Forms.Label();
            pay_typeLabel = new System.Windows.Forms.Label();
            pay_amtLabel = new System.Windows.Forms.Label();
            q_idLabel = new System.Windows.Forms.Label();
            pat_nameLabel = new System.Windows.Forms.Label();
            doc_idLabel = new System.Windows.Forms.Label();
            recieptLabel = new System.Windows.Forms.Label();
            dATELabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxpaymentty.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_klinikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pay_idLabel
            // 
            pay_idLabel.AutoSize = true;
            pay_idLabel.Location = new System.Drawing.Point(8, 343);
            pay_idLabel.Name = "pay_idLabel";
            pay_idLabel.Size = new System.Drawing.Size(38, 13);
            pay_idLabel.TabIndex = 23;
            pay_idLabel.Text = "pay id:";
            // 
            // pay_staffidLabel
            // 
            pay_staffidLabel.AutoSize = true;
            pay_staffidLabel.Location = new System.Drawing.Point(8, 373);
            pay_staffidLabel.Name = "pay_staffidLabel";
            pay_staffidLabel.Size = new System.Drawing.Size(58, 13);
            pay_staffidLabel.TabIndex = 25;
            pay_staffidLabel.Text = "pay staffid:";
            // 
            // pay_typeLabel
            // 
            pay_typeLabel.AutoSize = true;
            pay_typeLabel.Location = new System.Drawing.Point(409, 358);
            pay_typeLabel.Name = "pay_typeLabel";
            pay_typeLabel.Size = new System.Drawing.Size(50, 13);
            pay_typeLabel.TabIndex = 27;
            pay_typeLabel.Text = "pay type:";
            // 
            // pay_amtLabel
            // 
            pay_amtLabel.AutoSize = true;
            pay_amtLabel.Location = new System.Drawing.Point(409, 381);
            pay_amtLabel.Name = "pay_amtLabel";
            pay_amtLabel.Size = new System.Drawing.Size(47, 13);
            pay_amtLabel.TabIndex = 29;
            pay_amtLabel.Text = "pay amt:";
            // 
            // q_idLabel
            // 
            q_idLabel.AutoSize = true;
            q_idLabel.Location = new System.Drawing.Point(8, 318);
            q_idLabel.Name = "q_idLabel";
            q_idLabel.Size = new System.Drawing.Size(27, 13);
            q_idLabel.TabIndex = 31;
            q_idLabel.Text = "q id:";
            // 
            // pat_nameLabel
            // 
            pat_nameLabel.AutoSize = true;
            pat_nameLabel.Location = new System.Drawing.Point(409, 295);
            pat_nameLabel.Name = "pat_nameLabel";
            pat_nameLabel.Size = new System.Drawing.Size(54, 13);
            pat_nameLabel.TabIndex = 33;
            pat_nameLabel.Text = "pat name:";
            // 
            // doc_idLabel
            // 
            doc_idLabel.AutoSize = true;
            doc_idLabel.Location = new System.Drawing.Point(409, 320);
            doc_idLabel.Name = "doc_idLabel";
            doc_idLabel.Size = new System.Drawing.Size(39, 13);
            doc_idLabel.TabIndex = 35;
            doc_idLabel.Text = "doc id:";
            // 
            // recieptLabel
            // 
            recieptLabel.AutoSize = true;
            recieptLabel.Location = new System.Drawing.Point(755, 275);
            recieptLabel.Name = "recieptLabel";
            recieptLabel.Size = new System.Drawing.Size(42, 13);
            recieptLabel.TabIndex = 37;
            recieptLabel.Text = "reciept:";
            // 
            // dATELabel
            // 
            dATELabel.AutoSize = true;
            dATELabel.Location = new System.Drawing.Point(181, 317);
            dATELabel.Name = "dATELabel";
            dATELabel.Size = new System.Drawing.Size(39, 13);
            dATELabel.TabIndex = 38;
            dATELabel.Text = "DATE:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 656);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxpaymentty);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "General";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxpaymentty
            // 
            this.groupBoxpaymentty.Controls.Add(this.radioButton3);
            this.groupBoxpaymentty.Controls.Add(this.radioButton2);
            this.groupBoxpaymentty.Controls.Add(this.radioButton1);
            this.groupBoxpaymentty.Location = new System.Drawing.Point(135, 15);
            this.groupBoxpaymentty.Name = "groupBoxpaymentty";
            this.groupBoxpaymentty.Size = new System.Drawing.Size(200, 100);
            this.groupBoxpaymentty.TabIndex = 7;
            this.groupBoxpaymentty.TabStop = false;
            this.groupBoxpaymentty.Text = "Payment Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(76, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Tag = "and [PAYMENT TYPE] <> \'CASH\'";
            this.radioButton3.Text = "Panel Only";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Tag = "and [PAYMENT TYPE] = \'CASH\'";
            this.radioButton2.Text = "Cash Only";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimePicker4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.dateTimePicker3);
            this.groupBox3.Controls.Add(this.radioButtondaterange);
            this.groupBox3.Controls.Add(this.radioButtonthisyear);
            this.groupBox3.Controls.Add(this.radioButtonthismonth);
            this.groupBox3.Location = new System.Drawing.Point(349, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 186);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visitation Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To: ";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(104, 104);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker4.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonmonth);
            this.groupBox1.Controls.Add(this.radioButtondate);
            this.groupBox1.Location = new System.Drawing.Point(0, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group By";
            // 
            // radioButtonmonth
            // 
            this.radioButtonmonth.AutoSize = true;
            this.radioButtonmonth.Location = new System.Drawing.Point(63, 19);
            this.radioButtonmonth.Name = "radioButtonmonth";
            this.radioButtonmonth.Size = new System.Drawing.Size(55, 17);
            this.radioButtonmonth.TabIndex = 0;
            this.radioButtonmonth.Tag = "right(convert(varchar,DATEADD(MONTH, DATEDIFF(MONTH, 0, [date]), 0),103 ),7)";
            this.radioButtonmonth.Text = "Month";
            this.radioButtonmonth.UseVisualStyleBackColor = true;
            // 
            // radioButtondate
            // 
            this.radioButtondate.AutoSize = true;
            this.radioButtondate.Checked = true;
            this.radioButtondate.Location = new System.Drawing.Point(6, 19);
            this.radioButtondate.Name = "radioButtondate";
            this.radioButtondate.Size = new System.Drawing.Size(48, 17);
            this.radioButtondate.TabIndex = 1;
            this.radioButtondate.TabStop = true;
            this.radioButtondate.Tag = "[date]";
            this.radioButtondate.Text = "Date";
            this.radioButtondate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(104, 78);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker3.TabIndex = 3;
            // 
            // radioButtondaterange
            // 
            this.radioButtondaterange.AutoSize = true;
            this.radioButtondaterange.Location = new System.Drawing.Point(6, 78);
            this.radioButtondaterange.Name = "radioButtondaterange";
            this.radioButtondaterange.Size = new System.Drawing.Size(86, 17);
            this.radioButtondaterange.TabIndex = 2;
            this.radioButtondaterange.Text = "Date Range:";
            this.radioButtondaterange.UseVisualStyleBackColor = true;
            this.radioButtondaterange.CheckedChanged += new System.EventHandler(this.radioButtondaterange_CheckedChanged);
            // 
            // radioButtonthisyear
            // 
            this.radioButtonthisyear.AutoSize = true;
            this.radioButtonthisyear.Location = new System.Drawing.Point(6, 53);
            this.radioButtonthisyear.Name = "radioButtonthisyear";
            this.radioButtonthisyear.Size = new System.Drawing.Size(70, 17);
            this.radioButtonthisyear.TabIndex = 1;
            this.radioButtonthisyear.Tag = "datepart(year,[date])=datepart(year,getdate())";
            this.radioButtonthisyear.Text = "This Year";
            this.radioButtonthisyear.UseVisualStyleBackColor = true;
            // 
            // radioButtonthismonth
            // 
            this.radioButtonthismonth.AutoSize = true;
            this.radioButtonthismonth.Checked = true;
            this.radioButtonthismonth.Location = new System.Drawing.Point(6, 28);
            this.radioButtonthismonth.Name = "radioButtonthismonth";
            this.radioButtonthismonth.Size = new System.Drawing.Size(78, 17);
            this.radioButtonthismonth.TabIndex = 0;
            this.radioButtonthismonth.TabStop = true;
            this.radioButtonthismonth.Tag = "DATEADD(MONTH, DATEDIFF(MONTH, 0, [date]), 0) = DATEADD(MONTH, DATEDIFF(MONTH, 0," +
    " getdate()), 0)";
            this.radioButtonthismonth.Text = "This Month";
            this.radioButtonthismonth.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonbydoc);
            this.groupBox2.Controls.Add(this.radioButtonsumm);
            this.groupBox2.Controls.Add(this.radioButtonbypanel);
            this.groupBox2.Location = new System.Drawing.Point(8, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group Summary";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButtonbydoc
            // 
            this.radioButtonbydoc.AutoSize = true;
            this.radioButtonbydoc.Location = new System.Drawing.Point(6, 56);
            this.radioButtonbydoc.Name = "radioButtonbydoc";
            this.radioButtonbydoc.Size = new System.Drawing.Size(57, 17);
            this.radioButtonbydoc.TabIndex = 2;
            this.radioButtonbydoc.Tag = "DR";
            this.radioButtonbydoc.Text = "Doctor";
            this.radioButtonbydoc.UseVisualStyleBackColor = true;
            // 
            // radioButtonsumm
            // 
            this.radioButtonsumm.AutoSize = true;
            this.radioButtonsumm.Location = new System.Drawing.Point(6, 81);
            this.radioButtonsumm.Name = "radioButtonsumm";
            this.radioButtonsumm.Size = new System.Drawing.Size(82, 17);
            this.radioButtonsumm.TabIndex = 1;
            this.radioButtonsumm.Text = "Summary All";
            this.radioButtonsumm.UseVisualStyleBackColor = true;
            // 
            // radioButtonbypanel
            // 
            this.radioButtonbypanel.AutoSize = true;
            this.radioButtonbypanel.Checked = true;
            this.radioButtonbypanel.Location = new System.Drawing.Point(6, 28);
            this.radioButtonbypanel.Name = "radioButtonbypanel";
            this.radioButtonbypanel.Size = new System.Drawing.Size(84, 17);
            this.radioButtonbypanel.TabIndex = 0;
            this.radioButtonbypanel.TabStop = true;
            this.radioButtonbypanel.Tag = "[PAYMENT TYPE]";
            this.radioButtonbypanel.Text = "Paymt. Type";
            this.radioButtonbypanel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(818, 399);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(dATELabel);
            this.tabPage1.Controls.Add(this.dATEDateTimePicker);
            this.tabPage1.Controls.Add(pay_idLabel);
            this.tabPage1.Controls.Add(this.pay_idLabel1);
            this.tabPage1.Controls.Add(pay_staffidLabel);
            this.tabPage1.Controls.Add(this.pay_staffidLabel1);
            this.tabPage1.Controls.Add(pay_typeLabel);
            this.tabPage1.Controls.Add(this.pay_typeLabel1);
            this.tabPage1.Controls.Add(pay_amtLabel);
            this.tabPage1.Controls.Add(this.pay_amtLabel1);
            this.tabPage1.Controls.Add(q_idLabel);
            this.tabPage1.Controls.Add(this.q_idLabel1);
            this.tabPage1.Controls.Add(pat_nameLabel);
            this.tabPage1.Controls.Add(this.pat_nameLabel1);
            this.tabPage1.Controls.Add(doc_idLabel);
            this.tabPage1.Controls.Add(this.doc_idLabel1);
            this.tabPage1.Controls.Add(recieptLabel);
            this.tabPage1.Controls.Add(this.recieptTextBox);
            this.tabPage1.Controls.Add(this.paymentDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dATEDateTimePicker
            // 
            this.dATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pAYMENTDETAILSBindingSource, "DATE", true));
            this.dATEDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATEDateTimePicker.Location = new System.Drawing.Point(184, 338);
            this.dATEDateTimePicker.Name = "dATEDateTimePicker";
            this.dATEDateTimePicker.Size = new System.Drawing.Size(87, 20);
            this.dATEDateTimePicker.TabIndex = 39;
            // 
            // pAYMENTDETAILSBindingSource
            // 
            this.pAYMENTDETAILSBindingSource.DataMember = "PAYMENTDETAILS";
            this.pAYMENTDETAILSBindingSource.DataSource = this.database_klinikDataSet;
            // 
            // database_klinikDataSet
            // 
            this.database_klinikDataSet.DataSetName = "database_klinikDataSet";
            this.database_klinikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pay_idLabel1
            // 
            this.pay_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pAYMENTDETAILSBindingSource, "pay_id", true));
            this.pay_idLabel1.Location = new System.Drawing.Point(78, 343);
            this.pay_idLabel1.Name = "pay_idLabel1";
            this.pay_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.pay_idLabel1.TabIndex = 24;
            this.pay_idLabel1.Text = "label1";
            // 
            // pay_staffidLabel1
            // 
            this.pay_staffidLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pAYMENTDETAILSBindingSource, "pay_staffid", true));
            this.pay_staffidLabel1.Location = new System.Drawing.Point(78, 373);
            this.pay_staffidLabel1.Name = "pay_staffidLabel1";
            this.pay_staffidLabel1.Size = new System.Drawing.Size(100, 23);
            this.pay_staffidLabel1.TabIndex = 26;
            this.pay_staffidLabel1.Text = "label1";
            // 
            // pay_typeLabel1
            // 
            this.pay_typeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pAYMENTDETAILSBindingSource, "PAYMENT TYPE", true));
            this.pay_typeLabel1.Location = new System.Drawing.Point(479, 358);
            this.pay_typeLabel1.Name = "pay_typeLabel1";
            this.pay_typeLabel1.Size = new System.Drawing.Size(100, 23);
            this.pay_typeLabel1.TabIndex = 28;
            this.pay_typeLabel1.Text = "label1";
            // 
            // pay_amtLabel1
            // 
            this.pay_amtLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pAYMENTDETAILSBindingSource, "pay_amt", true));
            this.pay_amtLabel1.Location = new System.Drawing.Point(479, 381);
            this.pay_amtLabel1.Name = "pay_amtLabel1";
            this.pay_amtLabel1.Size = new System.Drawing.Size(100, 23);
            this.pay_amtLabel1.TabIndex = 30;
            this.pay_amtLabel1.Text = "label1";
            // 
            // q_idLabel1
            // 
            this.q_idLabel1.Location = new System.Drawing.Point(78, 318);
            this.q_idLabel1.Name = "q_idLabel1";
            this.q_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.q_idLabel1.TabIndex = 32;
            this.q_idLabel1.Text = "label1";
            // 
            // pat_nameLabel1
            // 
            this.pat_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pAYMENTDETAILSBindingSource, "pat_name", true));
            this.pat_nameLabel1.Location = new System.Drawing.Point(479, 295);
            this.pat_nameLabel1.Name = "pat_nameLabel1";
            this.pat_nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.pat_nameLabel1.TabIndex = 34;
            this.pat_nameLabel1.Text = "label1";
            // 
            // doc_idLabel1
            // 
            this.doc_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pAYMENTDETAILSBindingSource, "doc_id", true));
            this.doc_idLabel1.Location = new System.Drawing.Point(479, 320);
            this.doc_idLabel1.Name = "doc_idLabel1";
            this.doc_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.doc_idLabel1.TabIndex = 36;
            this.doc_idLabel1.Text = "label1";
            // 
            // recieptTextBox
            // 
            this.recieptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pAYMENTDETAILSBindingSource, "reciept", true));
            this.recieptTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.recieptTextBox.Font = new System.Drawing.Font("Consolas", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptTextBox.Location = new System.Drawing.Point(3, 3);
            this.recieptTextBox.Multiline = true;
            this.recieptTextBox.Name = "recieptTextBox";
            this.recieptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recieptTextBox.Size = new System.Drawing.Size(818, 269);
            this.recieptTextBox.TabIndex = 38;
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AllowUserToAddRows = false;
            this.paymentDataGridView.AllowUserToDeleteRows = false;
            this.paymentDataGridView.AutoGenerateColumns = false;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payidDataGridViewTextBoxColumn,
            this.paystaffidDataGridViewTextBoxColumn,
            this.payamtDataGridViewTextBoxColumn,
            this.qidDataGridViewTextBoxColumn,
            this.patnameDataGridViewTextBoxColumn,
            this.docidDataGridViewTextBoxColumn,
            this.recieptDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.pAYMENTTYPEDataGridViewTextBoxColumn});
            this.paymentDataGridView.DataSource = this.pAYMENTDETAILSBindingSource;
            this.paymentDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paymentDataGridView.Location = new System.Drawing.Point(3, 407);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.ReadOnly = true;
            this.paymentDataGridView.Size = new System.Drawing.Size(818, 220);
            this.paymentDataGridView.TabIndex = 23;
            // 
            // payidDataGridViewTextBoxColumn
            // 
            this.payidDataGridViewTextBoxColumn.DataPropertyName = "pay_id";
            this.payidDataGridViewTextBoxColumn.HeaderText = "pay_id";
            this.payidDataGridViewTextBoxColumn.Name = "payidDataGridViewTextBoxColumn";
            this.payidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paystaffidDataGridViewTextBoxColumn
            // 
            this.paystaffidDataGridViewTextBoxColumn.DataPropertyName = "pay_staffid";
            this.paystaffidDataGridViewTextBoxColumn.HeaderText = "pay_staffid";
            this.paystaffidDataGridViewTextBoxColumn.Name = "paystaffidDataGridViewTextBoxColumn";
            this.paystaffidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payamtDataGridViewTextBoxColumn
            // 
            this.payamtDataGridViewTextBoxColumn.DataPropertyName = "pay_amt";
            this.payamtDataGridViewTextBoxColumn.HeaderText = "pay_amt";
            this.payamtDataGridViewTextBoxColumn.Name = "payamtDataGridViewTextBoxColumn";
            this.payamtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qidDataGridViewTextBoxColumn
            // 
            this.qidDataGridViewTextBoxColumn.DataPropertyName = "q_id";
            this.qidDataGridViewTextBoxColumn.HeaderText = "q_id";
            this.qidDataGridViewTextBoxColumn.Name = "qidDataGridViewTextBoxColumn";
            this.qidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patnameDataGridViewTextBoxColumn
            // 
            this.patnameDataGridViewTextBoxColumn.DataPropertyName = "pat_name";
            this.patnameDataGridViewTextBoxColumn.HeaderText = "pat_name";
            this.patnameDataGridViewTextBoxColumn.Name = "patnameDataGridViewTextBoxColumn";
            this.patnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docidDataGridViewTextBoxColumn
            // 
            this.docidDataGridViewTextBoxColumn.DataPropertyName = "doc_id";
            this.docidDataGridViewTextBoxColumn.HeaderText = "doc_id";
            this.docidDataGridViewTextBoxColumn.Name = "docidDataGridViewTextBoxColumn";
            this.docidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recieptDataGridViewTextBoxColumn
            // 
            this.recieptDataGridViewTextBoxColumn.DataPropertyName = "reciept";
            this.recieptDataGridViewTextBoxColumn.HeaderText = "reciept";
            this.recieptDataGridViewTextBoxColumn.Name = "recieptDataGridViewTextBoxColumn";
            this.recieptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            this.dATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAYMENTTYPEDataGridViewTextBoxColumn
            // 
            this.pAYMENTTYPEDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT TYPE";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.HeaderText = "PAYMENT TYPE";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.Name = "pAYMENTTYPEDataGridViewTextBoxColumn";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // pAYMENTDETAILSTableAdapter
            // 
            this.pAYMENTDETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Klinik3.database_klinikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 656);
            this.Controls.Add(this.tabControl1);
            this.Name = "Sales_Report";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.Sales_Report_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBoxpaymentty.ResumeLayout(false);
            this.groupBoxpaymentty.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_klinikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView paymentDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private klinikDataSetTableAdapters.paymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonmonth;
        private System.Windows.Forms.RadioButton radioButtondate;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.RadioButton radioButtondaterange;
        private System.Windows.Forms.RadioButton radioButtonthisyear;
        private System.Windows.Forms.RadioButton radioButtonthismonth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonbydoc;
        private System.Windows.Forms.RadioButton radioButtonsumm;
        private System.Windows.Forms.RadioButton radioButtonbypanel;
        private database_klinikDataSet database_klinikDataSet;
        private System.Windows.Forms.BindingSource pAYMENTDETAILSBindingSource;
        private database_klinikDataSetTableAdapters.PAYMENTDETAILSTableAdapter pAYMENTDETAILSTableAdapter;
        private database_klinikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label pay_idLabel1;
        private System.Windows.Forms.Label pay_staffidLabel1;
        private System.Windows.Forms.Label pay_typeLabel1;
        private System.Windows.Forms.Label pay_amtLabel1;
        private System.Windows.Forms.Label q_idLabel1;
        private System.Windows.Forms.Label pat_nameLabel1;
        private System.Windows.Forms.Label doc_idLabel1;
        private System.Windows.Forms.TextBox recieptTextBox;
        private System.Windows.Forms.DateTimePicker dATEDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn payidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paystaffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxpaymentty;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;

    }
}