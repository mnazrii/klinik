namespace Klinik3
{
    partial class LoginForm
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
            this.klinikDataSet = new Klinik3.klinikDataSet();
            this.userloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userloginTableAdapter = new Klinik3.klinikDataSetTableAdapters.userloginTableAdapter();
            this.tableAdapterManager = new Klinik3.klinikDataSetTableAdapters.TableAdapterManager();
            this.button1submit = new System.Windows.Forms.Button();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4versionno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klinikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // klinikDataSet
            // 
            this.klinikDataSet.DataSetName = "klinikDataSet";
            this.klinikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userloginBindingSource
            // 
            this.userloginBindingSource.DataMember = "userlogin";
            this.userloginBindingSource.DataSource = this.klinikDataSet;
            // 
            // userloginTableAdapter
            // 
            this.userloginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.diagnosisTableAdapter = null;
            this.tableAdapterManager.drugTableAdapter = null;
            this.tableAdapterManager.employerinfoTableAdapter = null;
            this.tableAdapterManager.metadataTableAdapter = null;
            this.tableAdapterManager.patientTableAdapter = null;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.q_drugTableAdapter = null;
            this.tableAdapterManager.q_treatmentTableAdapter = null;
            this.tableAdapterManager.queueTableAdapter = null;
            this.tableAdapterManager.treatment_typeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Klinik3.klinikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userloginTableAdapter = this.userloginTableAdapter;
            // 
            // button1submit
            // 
            this.button1submit.Location = new System.Drawing.Point(151, 135);
            this.button1submit.Name = "button1submit";
            this.button1submit.Size = new System.Drawing.Size(75, 23);
            this.button1submit.TabIndex = 0;
            this.button1submit.Text = "Submit";
            this.button1submit.UseVisualStyleBackColor = true;
            this.button1submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(126, 58);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(162, 20);
            this.textBoxusername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(126, 98);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '#';
            this.textBoxpassword.Size = new System.Drawing.Size(162, 20);
            this.textBoxpassword.TabIndex = 3;
            this.textBoxpassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxpassword_KeyUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(-2, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Check Update";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4versionno
            // 
            this.label4versionno.AutoSize = true;
            this.label4versionno.Location = new System.Drawing.Point(284, 171);
            this.label4versionno.Name = "label4versionno";
            this.label4versionno.Size = new System.Drawing.Size(22, 13);
            this.label4versionno.TabIndex = 7;
            this.label4versionno.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Version";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 189);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4versionno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.button1submit);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login Klinik";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klinikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private klinikDataSet klinikDataSet;
        private System.Windows.Forms.BindingSource userloginBindingSource;
        private klinikDataSetTableAdapters.userloginTableAdapter userloginTableAdapter;
        private klinikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1submit;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4versionno;
    }
}