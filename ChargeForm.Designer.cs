namespace Klinik3
{
    partial class ChargeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxpaymentty = new System.Windows.Forms.ComboBox();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.labeldate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelstaff = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownbal = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownpay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChg = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new RichTextBoxPrintCtrl.RichTextBoxPrintCtrl();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownbal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 610);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(866, 584);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Charge Summary";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.68493F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.31507F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(866, 584);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxpaymentty);
            this.panel2.Controls.Add(this.buttoncancel);
            this.panel2.Controls.Add(this.buttonsave);
            this.panel2.Controls.Add(this.labeldate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelstaff);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDownbal);
            this.panel2.Controls.Add(this.numericUpDownpay);
            this.panel2.Controls.Add(this.numericUpDownChg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 137);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Payment Type:";
            // 
            // comboBoxpaymentty
            // 
            this.comboBoxpaymentty.FormattingEnabled = true;
            this.comboBoxpaymentty.Location = new System.Drawing.Point(397, 63);
            this.comboBoxpaymentty.Name = "comboBoxpaymentty";
            this.comboBoxpaymentty.Size = new System.Drawing.Size(121, 21);
            this.comboBoxpaymentty.TabIndex = 12;
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(639, 103);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 11;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(558, 103);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 23);
            this.buttonsave.TabIndex = 10;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(394, 40);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(11, 15);
            this.labeldate.TabIndex = 9;
            this.labeldate.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date/Time:";
            // 
            // labelstaff
            // 
            this.labelstaff.AutoSize = true;
            this.labelstaff.Location = new System.Drawing.Point(394, 14);
            this.labelstaff.Name = "labelstaff";
            this.labelstaff.Size = new System.Drawing.Size(11, 15);
            this.labelstaff.TabIndex = 7;
            this.labelstaff.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Staff:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Charge";
            // 
            // numericUpDownbal
            // 
            this.numericUpDownbal.DecimalPlaces = 2;
            this.numericUpDownbal.Location = new System.Drawing.Point(709, 64);
            this.numericUpDownbal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownbal.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownbal.Name = "numericUpDownbal";
            this.numericUpDownbal.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownbal.TabIndex = 2;
            // 
            // numericUpDownpay
            // 
            this.numericUpDownpay.DecimalPlaces = 2;
            this.numericUpDownpay.Location = new System.Drawing.Point(709, 38);
            this.numericUpDownpay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownpay.Name = "numericUpDownpay";
            this.numericUpDownpay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownpay.TabIndex = 1;
            this.numericUpDownpay.Leave += new System.EventHandler(this.numericUpDownpay_Leave);
            // 
            // numericUpDownChg
            // 
            this.numericUpDownChg.DecimalPlaces = 2;
            this.numericUpDownChg.Location = new System.Drawing.Point(709, 12);
            this.numericUpDownChg.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownChg.Name = "numericUpDownChg";
            this.numericUpDownChg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownChg.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 435);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(860, 435);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Complete",
            "Simple"});
            this.comboBox1.Location = new System.Drawing.Point(24, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Complete";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Reciept type:";
            // 
            // ChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 610);
            this.Controls.Add(this.tabControl1);
            this.Name = "ChargeForm";
            this.Text = "Charges";
            this.Load += new System.EventHandler(this.ChargeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownbal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownbal;
        private System.Windows.Forms.NumericUpDown numericUpDownpay;
        private System.Windows.Forms.NumericUpDown numericUpDownChg;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelstaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxpaymentty;
        private System.Windows.Forms.Button button1;
        private RichTextBoxPrintCtrl.RichTextBoxPrintCtrl textBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}