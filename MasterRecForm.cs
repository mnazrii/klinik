using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Hik.Communication.Scs.Communication.Messages;
using System.Text.RegularExpressions;

namespace Klinik3
{
    public partial class MasterRecForm : Form
    {
        ClientServer cs;
        public MasterRecForm()
        {
            InitializeComponent();

        }

        public void Client_MessageReceived(object sender, MessageEventArgs e)
        {
            Invoke(new Action(() =>
            { 
            //Client only accepts text messages
            var message = e.Message as ScsTextMessage;
            if (message == null)
            {
                return;
            }

            var log = message.Text.Split(';');

            var split = message.Text.Split(';');
        
            if (log[0].Equals("drug"))
                this.drugTableAdapter.Fill(this.klinikDataSet.drug);

            if (log[0].Equals("employerinfo"))
                this.employerinfoTableAdapter.Fill(this.klinikDataSet.employerinfo);

            if (log[0].Equals("treatment_type"))
                this.treatment_typeTableAdapter.Fill(this.klinikDataSet.treatment_type);
            }));
        }


        //private void q_drugBindingNavigatorSaveItem_Click(object sender, EventArgs e)


        private void DrugForm_Load(object sender, EventArgs e)
        {
            //eventLogMonitorQ.MachineName = Klinik3.Properties.Settings.Default.HostPCName;
            
            // TODO: This line of code loads data into the 'klinikDataSet.employerinfo' table. You can move, or remove it, as needed.
            this.employerinfoTableAdapter.Fill(this.klinikDataSet.employerinfo);
            // TODO: This line of code loads data into the 'klinikDataSet.metadata' table. You can move, or remove it, as needed.
            this.metadataTableAdapter.Fill(this.klinikDataSet.metadata);
            // TODO: This line of code loads data into the 'klinikDataSet.treatment_type' table. You can move, or remove it, as needed.
            this.treatment_typeTableAdapter.Fill(this.klinikDataSet.treatment_type);
            // TODO: This line of code loads data into the 'klinikDataSet.treatment_type' table. You can move, or remove it, as needed.
            this.treatment_typeTableAdapter.Fill(this.klinikDataSet.treatment_type);
            // TODO: This line of code loads data into the 'klinikDataSet.drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.klinikDataSet.drug);
            // TODO: This line of code loads data into the 'klinikDataSet.q_drug' table. You can move, or remove it, as needed.
            //this.q_drugTableAdapter.Fill(this.klinikDataSet.q_drug);

            cs = new ClientServer();
            cs.StartClient();
            cs.client.MessageReceived += Client_MessageReceived;
        }

        private void drugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);

        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "*.txt|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                value_TextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            metadataBindingSource.CancelEdit();
            metadataBindingSource.AddNew();
        }


        private void tabPage2_Enter(object sender, EventArgs e)
        {
            treatment_typeBindingSource.CancelEdit();
            treatment_typeBindingSource.AddNew();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            drugBindingSource.CancelEdit();
            drugBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPage1_Enter(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabPage2_Enter(null, null);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabPage3_Enter(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                    drg_sellingpriceperunitNumericUpDown.Value += 0.0001m;
                    drugBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(klinikDataSet);

                    cs.WriteEntry("master;added");
            }
            catch (ConstraintException csx)
            {

                drg_sellingpriceperunitNumericUpDown.Value += 0.0001m;
                drugBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(klinikDataSet);

                cs.WriteEntry("master;added");
            }
           
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(klinikDataSet);
            cs.WriteEntry("master;added");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tr_defaultchargeNumericUpDown.Value += 0.001m;
            treatment_typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(klinikDataSet);
            cs.WriteEntry("master;added");


        }

        private void drugDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void treatment_typeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void metadataDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            employerinfoBindingSource.CancelEdit();
            employerinfoBindingSource.AddNew();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {

                employerinfoBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(klinikDataSet);
                cs.WriteEntry("employerinfo;added");
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Code already exist");
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            employerinfoBindingSource.CancelEdit();

        }

        private void employerinfoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabPage4_Enter(null, null);
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if(drugBindingSource.Current!=null)
            drugBindingSource.Remove(drugBindingSource.Current);
            
            button2_Click(null, null);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (employerinfoBindingSource.Current != null)
            employerinfoBindingSource.Remove(employerinfoBindingSource.Current);
            
            button12_Click(null, null);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (treatment_typeBindingSource.Current != null)
            treatment_typeBindingSource.Remove(treatment_typeBindingSource.Current);
           
            button5_Click(null, null);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(metadataBindingSource.Current!=null)
            metadataBindingSource.Remove(metadataBindingSource.Current);            
            
            button9_Click(null, null);
        }

        private void eventLogMonitorQ_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void drg_codeTextBox_DoubleClick(object sender, EventArgs e)
        {
            string txt = drg_nameTextBox.Text;
            if (txt.Length == 0) return;
            drg_codeTextBox.Text = txt.Substring(0, Math.Min(txt.Length - 2, 3));


            var regex1 = "((?:[a-z][a-z]+))";
            var regex = "(\\d+)";
            Regex r = new Regex(regex1, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(txt);
            if (m.Success)
            {
                string w1 = m.Groups[1].ToString();                
                drg_codeTextBox.Text += w1[w1.Length-1];
            }

            Regex r2 = new Regex(regex, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m2 = r2.Match(txt);
            if (m2.Success)
            {
                string d1 = m2.Groups[1].ToString();
                drg_codeTextBox.Text +=  d1;
            }
            int srccode=drugBindingSource.Find("drg_code", drg_codeTextBox.Text);
            if(srccode>0)
            {
              var row= (DataRowView)drugBindingSource[srccode];
              int no;
              if (int.TryParse(row[0].ToString()[row[0].ToString().Length - 1].ToString(), out no))
              {
                  drg_codeTextBox.Text += (no + 1).ToString();
              }
              else
                  drg_codeTextBox.Text += "1";
            }
        }

        private void drg_codeTextBox_Enter(object sender, EventArgs e)
        {
        }

        private void drg_nameTextBox_Leave(object sender, EventArgs e)
        {
            drg_codeTextBox_DoubleClick(null, null);
        }

        private void checkBoxdrgcodeauto_CheckedChanged(object sender, EventArgs e)
        {
            drg_codeTextBox.ReadOnly = checkBoxdrgcodeauto.Checked;
        }   
    }
}
