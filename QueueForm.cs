using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Hik.Communication.Scs.Communication.Messages;
using System.Threading;


namespace Klinik3
{
    public partial class QueueForm : Form
    {
        ClientServer cs;

        public QueueForm()
        {

            //if (Klinik3.Properties.Settings.Default.Server)
            //    new Thread(cs.StartServer).Start();

            InitializeComponent();
            cs = new ClientServer();
            cs.StartClient();
            cs.client.MessageReceived += Client_MessageReceived;
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


            if (log[0].Equals("patient"))
                this.patientTableAdapter.Fill(this.klinikDataSet.patient);

            if (log[0].Equals("employerinfo"))
                this.employerinfoTableAdapter.Fill(this.klinikDataSet.employerinfo);

            if (log[0].Equals("queue"))
            {
                using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
                {
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("AllQueue", conn);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dataset);


                    //queueDataGridViewtrmtdig.DataSource = dataset.Tables[0];
                    queueDataGridViewbill.DataSource = dataset.Tables[2];

                    string sql = "select q_id AS Q#, q.pat_id AS PatientID,pat_name [Name],pat_ic IC, doc_id AS DR,cast(time_enter as date) [Date], time_enter AS [TIME ENTER], q_status AS STATUS, q.note Remarks  from queue q " +
                            "join patient p on (p.pat_id=q.pat_id)  where q_status='" + QStatus.QueueDoctor + "'";

                    if (radioButton1.Checked)
                        sql += " AND DOC_ID='" + Session.Username + "'";

                    if (checkBoxfilterqtoday.Checked)
                        sql += " and cast(q.[time_enter] as date) = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'"; 

                    DataSet dataset2 = new DataSet();
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    adapter2.SelectCommand = new SqlCommand(sql, conn);
                    adapter2.SelectCommand.CommandType = CommandType.Text;
                    adapter2.Fill(dataset2);
                    queueDataGridViewtrmtdig.DataSource = dataset2.Tables[0];
                }
            }
            }));
        }


        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);

        }

        MasterRecForm masterRecForm = new MasterRecForm();
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            masterRecForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxfilterqtoday.Text = "Q for \r\n" +DateTime.Now.ToShortDateString();
            //if (!(Session.Level == "admin" || Session.Level == "dr"))
            //{
            //    tabControl1.TabPages.Remove(tabPageDocQ);
            //}
            tabControl1.TabPages.Remove(tabPageDocQ);

            radioButton1.Text = Session.Username;
            // TODO: This line of code loads data into the 'klinikDataSet.employerinfo' table. You can move, or remove it, as needed.
            this.employerinfoTableAdapter.Fill(this.klinikDataSet.employerinfo);
            // TODO: This line of code loads data into the 'klinikDataSet.GNDLST' table. You can move, or remove it, as needed.
            this.gNDLSTTableAdapter.Fill(this.klinikDataSet.GNDLST);
            // TODO: This line of code loads data into the 'klinikDataSet.RCLST' table. You can move, or remove it, as needed.
            this.rCLSTTableAdapter.Fill(this.klinikDataSet.RCLST);
            // TODO: This line of code loads data into the 'klinikDataSet.MRTLST' table. You can move, or remove it, as needed.
            this.mRTLSTTableAdapter.Fill(this.klinikDataSet.MRTLST);
            // TODO: This line of code loads data into the 'klinikDataSet.queue' table. You can move, or remove it, as needed.
            queueBindingSource.Filter = "q_status = '"+QStatus.QueueDoctor+"'";
            this.queueTableAdapter.Fill(this.klinikDataSet.queue);


            
            //patientTableAdapter.Adapter.RowUpdated += new SqlRowUpdatedEventHandler(row_updated) ;
            // TODO: This line of code loads data into the 'klinikDataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.klinikDataSet.patient);

            cs = new ClientServer();
            cs.StartClient();
            cs.client.MessageReceived += Client_MessageReceived;

            //update queue
            cs.WriteEntry("queue;updated");

            //timer1.Start();
            //TODO: change value
            //Session.Username = "DR1";


            //var autocompleterc = new AutoCompleteStringCollection();
            //for (int i = 0; i < rCLSTBindingSource.Count; i++)
            //{
            //    var value = ((DataRowView)rCLSTBindingSource[i])[0].ToString();
            //    autocompleterc.Add(value);
            //}
            //pat_raceTextBox.AutoCompleteCustomSource = autocompleterc;


            using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select * from DRView", conn);
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dataset);
                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    var tsmnuitem = new ToolStripMenuItem();
                    tsmnuitem.Text = dataset.Tables[0].Rows[i][0].ToString();
                    assignToolStripMenuItem.DropDownItems.Add(tsmnuitem);
                    tsmnuitem.Click += new EventHandler(tsmnuitem_Click);
                    comboBox1.Items.Add(tsmnuitem.Text);
                    comboBox1.SelectedIndex = i;
                    doc_idComboBox.Items.Add(tsmnuitem.Text);
                    doc_idComboBox.SelectedIndex = i;
                }
            }
        }

        void tsmnuitem_Click(object sender, EventArgs e)
        {
            var menuitem=(ToolStripMenuItem)sender;
            var datarow = (DataRowView)queueBindingSource.Current;
            datarow["doc_id"] = menuitem.Text;
            this.queueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
        }

        private void button1newpat_Click(object sender, EventArgs e)
        {
            patientBindingSource.CancelEdit();
            patientBindingSource.AddNew();
        }

        private void button2savepat_Click(object sender, EventArgs e)
        {
            patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
            
            //refresh patient
            cs.WriteEntry("patient;added");
            
            patientBindingSource.CancelEdit();
            patientBindingSource.AddNew();
        }

        private void button3cancelpat_Click(object sender, EventArgs e)
        {
            patientBindingSource.CancelEdit();
        }

        private void buttonqadd_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            noteTextBox.BackColor = textBox1serchpat.BackColor;

            time_enterDateTimePicker.Value = DateTime.Now;
            queueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
            
            //refresh queue
            cs.WriteEntry("queue;added");
            
        }

        private void button5newqueue_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            noteTextBox.BackColor = Color.LightYellow;
            queueBindingSource.CancelEdit();
            queueBindingSource.AddNew();
            if (doc_idComboBox.Items.Count>0)
                doc_idComboBox.Text = doc_idComboBox.Items[doc_idComboBox.Items.Count-1].ToString();

            q_idTextBox.Text = "-1";
            q_statusTextBox.Text = QStatus.QueueDoctor;
            time_enterDateTimePicker.Value = DateTime.Now;
            
        }

        private void tabPage2filterstatus_Enter(object sender, EventArgs e)
        {

            queueBindingSource.Filter = "q_status ='"+QStatus.QueueDoctor+"'";
            queueBindingSource.CancelEdit();
            queueBindingSource.AddNew();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            radioButton1clickfilter_CheckedChanged(radioButton1, null);
            
        }


        private void radioButton1clickfilter_CheckedChanged(object sender, EventArgs e)
        {
            //refresh queue
            cs.WriteEntry("queue;updated");
        }

        private void tabPage4qpaymntfilter_Enter(object sender, EventArgs e)
        {
            queueBindingSource.Filter = "q_status ='" +
                    QStatus.QueuePayment + "'";
        }

        private void textBox1patsearch_KeyUp(object sender, KeyEventArgs e)
        {
            patientBindingSource.Filter = "pat_name like '%" + textBox1serchpat.Text.Replace("'", "") +
                "%' or pat_ic like '%" + textBox1serchpat.Text.Replace("'", "") + "%'";
           
        }

        private void patientBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1doc_Opening(object sender, CancelEventArgs e)
        {
            if (queueDataGridViewdispnse.SelectedRows.Count == 0)
                e.Cancel = true;
        }

        private void contextMenuStripQ1_Opening(object sender, CancelEventArgs e)
        {
            if (queueDataGridViewtrmtdig.SelectedRows.Count == 0)
                e.Cancel = true;
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove record?", "Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;
            
            queueDataGridViewtrmtdig.Rows.Remove(queueDataGridViewtrmtdig.SelectedRows[0]);
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
        }

        private void button6AssignDoc_Click(object sender, EventArgs e)
        {
            if (queueDataGridViewtrmtdig.SelectedCells.Count == 0)
                return;

            queueBindingSource.Filter = "q_id='" + queueDataGridViewtrmtdig.SelectedCells[0].Value.ToString()+"'";
            if (queueBindingSource.Current == null || comboBox1.Text=="")
                return;

            var datarow = (DataRowView)queueBindingSource.Current;
            datarow["doc_id"] = comboBox1.Text;
            this.queueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
            
            //refresh queue
            cs.WriteEntry("queue;updated");
            
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((queueBindingSource.Current == null) || MessageBox.Show("Remove record?", "Delete", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;

            queueBindingSource.Remove(queueBindingSource.Current);
            this.queueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
        }

        TreatmentForm trf = new TreatmentForm();
        private void treatmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (queueDataGridViewdispnse.SelectedRows.Count > 0)
            {
                Session.Current_QID = queueDataGridViewdispnse.SelectedCells[0].Value.ToString();
                trf.ShowDialog();
            }
        }

        private void button7removeq_Click(object sender, EventArgs e)
        {
            if (queueDataGridViewdispnse.SelectedRows.Count==0|| MessageBox.Show("Remove record?", "Delete", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;

        }

        private void patientBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
           
        }

        private void textBox2searchpat_KeyUp(object sender, KeyEventArgs e)
        {
            var text=textBox2patsearch.Text.Replace("'","");
            patientBindingSource.Filter = "pat_name like '%" + text + "%' or pat_ic like '%" + text + "%'";
        }

        private void pat_employeerTextBox_Enter(object sender, EventArgs e)
        {
            dataGridView1employer.Visible = true;
        }

        private void pat_employeerTextBox_Leave(object sender, EventArgs e)
        {
            dataGridView1employer.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2searcemploy_Enter(object sender, EventArgs e)
        {
            dataGridView1employer.Visible = true;
        }

        private void textBox2searcemploy_Leave(object sender, EventArgs e)
        {
            dataGridView1employer.Visible = false;
            if (employerinfoBindingSource.Current != null)
            {
                string value = ((DataRowView)employerinfoBindingSource.Current)["employeer_code"].ToString();
                pat_employeerLabel2.Text = value;
            }
        }

        private void textBox2searcemploy_KeyUp(object sender, KeyEventArgs e)
        {
            var text = textBox2searcemploy.Text.Replace("'", "");
            employerinfoBindingSource.Filter = "employeer_code like '%" + text + "%' or name like '%" + text + "%'";
        }

        private void employerinfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            patientDataGridView1.Visible = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            patientDataGridView1.Visible = false;
            if (patientBindingSource.Current != null)
            {
                var datarw = (DataRowView)patientBindingSource.Current;
                textBox1serchpat.Text = datarw["pat_name"].ToString();
                pat_idTextBox1.Text = datarw["pat_id"].ToString();
            }
        }

        private void timer1refreshqd_Tick(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
          //salah
        }

        ChargeForm cf = new ChargeForm();
        private void button8_Click(object sender, EventArgs e)
        {
            if (queueDataGridViewbill.SelectedRows.Count > 0)
            {
                cf.qid = queueDataGridViewbill.SelectedCells[0].Value.ToString();
                cf.ShowDialog();
            }
            //refresh queue
            cs.WriteEntry("payment;updated");

        }

        private void QueueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonTreatment_Click(object sender, EventArgs e)
        {
             treatmentToolStripMenuItem_Click(sender, null);
        }

        private void timerrefreshdoc_Tick(object sender, EventArgs e)
        {

        }

        private void tabPage3_Leave(object sender, EventArgs e)
        {
            
        }


        private void Charge_FormClosing(object sender, FormClosingEventArgs e)
        {
 
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            new Sales_Report().ShowDialog();
        }

        private void queueDataGridViewdispnse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void queueDataGridViewdispnse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            treatmentToolStripMenuItem_Click(sender, null);
        }

        private void queueDataGridViewbill_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button8_Click(null, null);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            patientBindingSource.CancelEdit();
            patientBindingSource.AddNew();

        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            patientBindingSource.CancelEdit();
        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {
            queueBindingSource.CancelEdit();
        }

        private void pat_nameTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }



        private void button11_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
            {
                var qid = queueDataGridViewbill.SelectedCells[0].Value.ToString();

                conn.Open();
                var command = new SqlCommand("Update Queue set q_status='" + QStatus.QueueDoctor + "' where q_id='" + qid + "' ", conn);
                command.ExecuteScalar();
            }
            
            //refresh queue
            cs.WriteEntry("queue;updated");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (patientBindingSource.Current != null)
                patientBindingSource.Remove(patientBindingSource.Current);

            button2savepat_Click(null, null);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);

            //refresh patient
            cs.WriteEntry("patient;added");

            patientBindingSource.CancelEdit(); 
            
            tabControl1.SelectedTab = tabPageQlist;


            button5newqueue_Click(null, null);

            textBox1_Leave(null, null);
            buttonqadd_Click(null, null);
        }

        private void textBox2patsearch_Enter(object sender, EventArgs e)
        {
            
        }

        private void patientDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void patientDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button13_Click(null, null);
        }

        private void queueDataGridViewtrmtdig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (queueDataGridViewtrmtdig.SelectedRows.Count > 0)
            {
                Session.Current_QID = queueDataGridViewtrmtdig.SelectedCells[0].Value.ToString();
                trf.ShowDialog();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            queueDataGridViewtrmtdig_CellContentClick(null, null);
        }

        private void checkBoxfilterqtoday_CheckedChanged(object sender, EventArgs e)
        {
            //refresh queue
            cs.WriteEntry("queue;updated");
        }

 
    }
}
