namespace Klinik3
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.Update_bttn = new System.Windows.Forms.Button();
            this.checkForUpdate_bttn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labellatestversion = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.updateResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Update_bttn
            // 
            this.Update_bttn.BackColor = System.Drawing.Color.Gold;
            this.Update_bttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_bttn.Location = new System.Drawing.Point(290, 76);
            this.Update_bttn.Name = "Update_bttn";
            this.Update_bttn.Size = new System.Drawing.Size(196, 36);
            this.Update_bttn.TabIndex = 4;
            this.Update_bttn.Text = "Update Application";
            this.toolTip1.SetToolTip(this.Update_bttn, "This will close UpdateMe, install the update and\r\nrestart UpdateMe.");
            this.Update_bttn.UseVisualStyleBackColor = false;
            this.Update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            // 
            // checkForUpdate_bttn
            // 
            this.checkForUpdate_bttn.BackColor = System.Drawing.Color.Cornsilk;
            this.checkForUpdate_bttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkForUpdate_bttn.Location = new System.Drawing.Point(153, 76);
            this.checkForUpdate_bttn.Name = "checkForUpdate_bttn";
            this.checkForUpdate_bttn.Size = new System.Drawing.Size(134, 36);
            this.checkForUpdate_bttn.TabIndex = 3;
            this.checkForUpdate_bttn.Text = "Check for Update";
            this.toolTip1.SetToolTip(this.checkForUpdate_bttn, "Check online to see if there is an update available.");
            this.checkForUpdate_bttn.UseVisualStyleBackColor = false;
            this.checkForUpdate_bttn.Click += new System.EventHandler(this.checkForUpdate_bttn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Latest Version:";
            // 
            // labellatestversion
            // 
            this.labellatestversion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellatestversion.Location = new System.Drawing.Point(153, 47);
            this.labellatestversion.Name = "labellatestversion";
            this.labellatestversion.Size = new System.Drawing.Size(333, 23);
            this.labellatestversion.TabIndex = 2;
            this.toolTip1.SetToolTip(this.labellatestversion, resources.GetString("labellatestversion.ToolTip"));
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipTitle = "Tip:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(143, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Update Klinik";
            // 
            // updateResult
            // 
            this.updateResult.AutoSize = true;
            this.updateResult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateResult.ForeColor = System.Drawing.Color.Gold;
            this.updateResult.Location = new System.Drawing.Point(162, 126);
            this.updateResult.Name = "updateResult";
            this.updateResult.Size = new System.Drawing.Size(324, 18);
            this.updateResult.TabIndex = 11;
            this.updateResult.Text = "Klinik has been successfully updated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = " ";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(532, 158);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labellatestversion);
            this.Controls.Add(this.checkForUpdate_bttn);
            this.Controls.Add(this.Update_bttn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 326);
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateMe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update_bttn;
        private System.Windows.Forms.Button checkForUpdate_bttn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox labellatestversion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label updateResult;
        private System.Windows.Forms.Label label2;
    }
}

