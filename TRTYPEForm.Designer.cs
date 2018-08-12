namespace Klinik3
{
    partial class TRTYPEForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRTYPEForm));
            System.Windows.Forms.Label tr_typeLabel;
            System.Windows.Forms.Label tr_nameLabel;
            System.Windows.Forms.Label tr_defaultchargeLabel;
            this.klinikDataSet = new Klinik3.klinikDataSet();
            this.treatment_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatment_typeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.treatment_typeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.treatment_typeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tr_typeTextBox = new System.Windows.Forms.TextBox();
            this.tr_nameTextBox = new System.Windows.Forms.TextBox();
            this.tr_defaultchargeTextBox = new System.Windows.Forms.TextBox();
            tr_typeLabel = new System.Windows.Forms.Label();
            tr_nameLabel = new System.Windows.Forms.Label();
            tr_defaultchargeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klinikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatment_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatment_typeBindingNavigator)).BeginInit();
            this.treatment_typeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatment_typeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // klinikDataSet
            // 
            this.klinikDataSet.DataSetName = "klinikDataSet";
            this.klinikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treatment_typeBindingSource
            // 
            this.treatment_typeBindingSource.DataMember = "treatment_type";
            this.treatment_typeBindingSource.DataSource = this.klinikDataSet;
            // 
            // treatment_typeBindingNavigator
            // 
            this.treatment_typeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.treatment_typeBindingNavigator.BindingSource = this.treatment_typeBindingSource;
            this.treatment_typeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.treatment_typeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.treatment_typeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.treatment_typeBindingNavigatorSaveItem});
            this.treatment_typeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.treatment_typeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.treatment_typeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.treatment_typeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.treatment_typeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.treatment_typeBindingNavigator.Name = "treatment_typeBindingNavigator";
            this.treatment_typeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.treatment_typeBindingNavigator.Size = new System.Drawing.Size(434, 25);
            this.treatment_typeBindingNavigator.TabIndex = 0;
            this.treatment_typeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(41, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // treatment_typeBindingNavigatorSaveItem
            // 
            this.treatment_typeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.treatment_typeBindingNavigatorSaveItem.Enabled = false;
            this.treatment_typeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("treatment_typeBindingNavigatorSaveItem.Image")));
            this.treatment_typeBindingNavigatorSaveItem.Name = "treatment_typeBindingNavigatorSaveItem";
            this.treatment_typeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.treatment_typeBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // treatment_typeDataGridView
            // 
            this.treatment_typeDataGridView.AutoGenerateColumns = false;
            this.treatment_typeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatment_typeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.treatment_typeDataGridView.DataSource = this.treatment_typeBindingSource;
            this.treatment_typeDataGridView.Location = new System.Drawing.Point(12, 148);
            this.treatment_typeDataGridView.Name = "treatment_typeDataGridView";
            this.treatment_typeDataGridView.Size = new System.Drawing.Size(410, 220);
            this.treatment_typeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tr_type";
            this.dataGridViewTextBoxColumn1.HeaderText = "Trmt Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tr_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tr_defaultcharge";
            this.dataGridViewTextBoxColumn3.HeaderText = "Default Charge";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tr_typeLabel
            // 
            tr_typeLabel.AutoSize = true;
            tr_typeLabel.Location = new System.Drawing.Point(12, 62);
            tr_typeLabel.Name = "tr_typeLabel";
            tr_typeLabel.Size = new System.Drawing.Size(42, 15);
            tr_typeLabel.TabIndex = 2;
            tr_typeLabel.Text = "Treatment Type:";
            // 
            // tr_typeTextBox
            // 
            this.tr_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatment_typeBindingSource, "tr_type", true));
            this.tr_typeTextBox.Location = new System.Drawing.Point(113, 59);
            this.tr_typeTextBox.Name = "tr_typeTextBox";
            this.tr_typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.tr_typeTextBox.TabIndex = 3;
            // 
            // tr_nameLabel
            // 
            tr_nameLabel.AutoSize = true;
            tr_nameLabel.Location = new System.Drawing.Point(12, 88);
            tr_nameLabel.Name = "tr_nameLabel";
            tr_nameLabel.Size = new System.Drawing.Size(52, 15);
            tr_nameLabel.TabIndex = 4;
            tr_nameLabel.Text = "Name:";
            // 
            // tr_nameTextBox
            // 
            this.tr_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatment_typeBindingSource, "tr_name", true));
            this.tr_nameTextBox.Location = new System.Drawing.Point(113, 85);
            this.tr_nameTextBox.Name = "tr_nameTextBox";
            this.tr_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.tr_nameTextBox.TabIndex = 5;
            // 
            // tr_defaultchargeLabel
            // 
            tr_defaultchargeLabel.AutoSize = true;
            tr_defaultchargeLabel.Location = new System.Drawing.Point(12, 114);
            tr_defaultchargeLabel.Name = "tr_defaultchargeLabel";
            tr_defaultchargeLabel.Size = new System.Drawing.Size(95, 15);
            tr_defaultchargeLabel.TabIndex = 6;
            tr_defaultchargeLabel.Text = "Default Charge:(RM)";
            // 
            // tr_defaultchargeTextBox
            // 
            this.tr_defaultchargeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatment_typeBindingSource, "tr_defaultcharge", true));
            this.tr_defaultchargeTextBox.Location = new System.Drawing.Point(113, 111);
            this.tr_defaultchargeTextBox.Name = "tr_defaultchargeTextBox";
            this.tr_defaultchargeTextBox.Size = new System.Drawing.Size(100, 20);
            this.tr_defaultchargeTextBox.TabIndex = 7;
            // 
            // TRTYPEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 425);
            this.Controls.Add(tr_typeLabel);
            this.Controls.Add(this.tr_typeTextBox);
            this.Controls.Add(tr_nameLabel);
            this.Controls.Add(this.tr_nameTextBox);
            this.Controls.Add(tr_defaultchargeLabel);
            this.Controls.Add(this.tr_defaultchargeTextBox);
            this.Controls.Add(this.treatment_typeDataGridView);
            this.Controls.Add(this.treatment_typeBindingNavigator);
            this.Name = "TRTYPEForm";
            this.Text = "TRTYPEForm";
            ((System.ComponentModel.ISupportInitialize)(this.klinikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatment_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatment_typeBindingNavigator)).EndInit();
            this.treatment_typeBindingNavigator.ResumeLayout(false);
            this.treatment_typeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatment_typeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private klinikDataSet klinikDataSet;
        private System.Windows.Forms.BindingSource treatment_typeBindingSource;
        private System.Windows.Forms.BindingNavigator treatment_typeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton treatment_typeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView treatment_typeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox tr_typeTextBox;
        private System.Windows.Forms.TextBox tr_nameTextBox;
        private System.Windows.Forms.TextBox tr_defaultchargeTextBox;
    }
}