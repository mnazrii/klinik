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
using System.Configuration;
using Hik.Communication.Scs.Communication.Messages;
namespace Klinik3
{
    public partial class TreatmentForm : Form
    {
        ClientServer cs;
        public TreatmentForm()
        {

            //eventLogMonitorQ.MachineName = Klinik3.Properties.Settings.Default.HostPCName;

            //if (Klinik3.Properties.Settings.Default.Server)
            //    cs.StartServer();

            InitializeComponent();


        }

        public void Client_MessageReceived(object sender, MessageEventArgs e)
        {


            try
            {
                if (this.InvokeRequired)
                    Invoke(new Action(() =>
                    {
                        Client_MessageReceived(sender, e);
                    }));

            }
            catch (System.ObjectDisposedException ex)
            {
                Console.WriteLine(ex.ToString());
            }




            //Client only accepts text messages
            var message = e.Message as ScsTextMessage;
            if (message == null)
            {
                return;
            }

            var log = message.Text.Split(';');

            var split = message.Text.Split(';');

            if (split[0].Equals("master"))
            {
                this.treatment_typeTableAdapter.Fill(this.klinikDataSet.treatment_type);
                this.metadataTableAdapter.Fill(this.klinikDataSet.metadata);
                this.drugTableAdapter.Fill(this.klinikDataSet.drug);
            }
            if (split[0].Equals("diagnosis"))
            {     //refresh queue
                this.diagnosisTableAdapter.Fill(this.klinikDataSet.diagnosis);
                diagnosisBindingSource1.CancelEdit();
                diagnosisBindingSource1.AddNew();
            }

            if (split[0].Equals("q_treatment"))
            {     //refresh queue
                this.q_treatmentTableAdapter.Fill(this.klinikDataSet.q_treatment);
                q_treatmentBindingSource.CancelEdit();
                q_treatmentBindingSource.AddNew();
            }
        }


        private void q_treatmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void queueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.queueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);

        }

        private void TreatmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikDataSet.q_documents' table. You can move, or remove it, as needed.
            this.q_documentsTableAdapter.Fill(this.klinikDataSet.q_documents);

            // TODO: This line of code loads data into the 'klinikDataSet.metadata' table. You can move, or remove it, as needed.

            this.metadataTableAdapter.Fill(this.klinikDataSet.metadata);

            //todo:uncomment
            tabControl1.TabPages.Remove(tabPagechg);
            tabControl1.TabPages.Remove(tabPagetreat);


            this.diagnosisTableAdapter.Fill(klinikDataSet.diagnosis);
            // TODO: This line of code loads data into the 'klinikDataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.klinikDataSet.patient);

            // TODO: This line of code loads data into the 'klinikDataSet.template' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'klinikDataSet.q_treatment' table. You can move, or remove it, as needed.
            this.q_treatmentTableAdapter.Fill(this.klinikDataSet.q_treatment);


            // TODO: This line of code loads data into the 'klinikDataSet.drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.klinikDataSet.drug);
            // TODO: This line of code loads data into the 'klinikDataSet.q_drug' table. You can move, or remove it, as needed.
            this.q_drugTableAdapter.Fill(this.klinikDataSet.q_drug);
            // TODO: This line of code loads data into the 'klinikDataSet.queue' table. You can move, or remove it, as needed.
            this.queueTableAdapter.Fill(this.klinikDataSet.queue);

            this.treatment_typeTableAdapter.Fill(this.klinikDataSet.treatment_type);

            //TODO:remove dummy qid
            //Session.Current_QID = "2";
            q_drugBindingSource.Filter = "q_id=" + Session.Current_QID + "";
            q_treatmentBindingSource.Filter = "q_id='" + Session.Current_QID + "'";
            diagnosisBindingSource1.Filter = "q_id='" + Session.Current_QID + "'";

            queueBindingSource.Filter = "q_id='" + Session.Current_QID + "'";
            patientBindingSource.Filter = "pat_id='" + ((DataRowView)queueBindingSource.Current)["pat_id"] + "'";
            queueBindingSrcHistry.Filter = "pat_id='" + ((DataRowView)queueBindingSource.Current)["pat_id"] + "' and q_status = '" + QStatus.QueueEnded + "'";
            try
            {

                int days = (int)(DateTime.Now - (DateTime)((DataRowView)patientBindingSource.Current)["pat_dob"]).TotalDays;
                labelage.Text = (days / 365) + " Years " + ((days % 365) / 30 == 0 ? "" : ((days % 365) / 30) + " Months ");
            }
            catch (Exception fexp)
            {
                Console.WriteLine(fexp.ToString());
            }

            var currentq = ((DataRowView)queueBindingSource.Current);
            q_drugBindingSource.AddNew();
            diagnosisBindingSource1.AddNew();

            cs = new ClientServer();
            cs.StartClient();
            cs.client.MessageReceived += Client_MessageReceived;

            //load queue documents
            qdocumentsBindingSource.Filter = "q_id='"+Session.Current_QID+"'";
        }



        private void drug_codeTextBox_Enter(object sender, EventArgs e)
        {
            this.treatment_typeTableAdapter.Fill(klinikDataSet.treatment_type);
            this.drugTableAdapter.Fill(this.klinikDataSet.drug);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            q_drugBindingSource.CancelEdit();
            q_drugBindingSource.AddNew();
        }

        private void button1savedrug_Click(object sender, EventArgs e)
        {
            q_idTextBox1.Text = Session.Current_QID;
            qtyNumericUpDown.Text = "0" + qtyNumericUpDown.Text;
            this.Validate();
            q_drugBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
            q_drugBindingSource.CancelEdit();
            q_drugBindingSource.AddNew();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drug_codeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void drug_codeComboBox_TextUpdate(object sender, EventArgs e)
        {
        }

        private void textBox1searchdrug_KeyUp(object sender, KeyEventArgs e)
        {
            drugBindingSource.Filter = "drg_name like '%" + textBox1.Text + "%'";
        }


        private void drugListBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void q_drugBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void q_drugDataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void drugBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {

        }

        private void q_drugBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {

        }

        private void q_drugDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void q_drugDataGridView_setsearchpostCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            drugBindingSource.Position = drugBindingSource.Find("drg_code", q_drugDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            //drugBindingSource.Filter = "drg_code = '" +  + "'";
            //MessageBox.Show(q_drugDataGridView.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void drugListBoxAddnewdruglist_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {

        }

        private void buttonsave_Qtreat_Click(object sender, EventArgs e)
        {
            q_idTextBox2.Text = Session.Current_QID;
            tr_additionalchgNumericUpDown.Value += 0.00001m;
            this.Validate();
            q_treatmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);

            cs.WriteEntry("q_treatment");
        }

        private void button2updatediag_Click(object sender, EventArgs e)
        {
            q_idTextBox.Text = Session.Current_QID;
            diag_addchrgNumericUpDown.Value += 0.00001m;

            this.Validate();
            diagnosisBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
            this.diagnosisTableAdapter.Fill(this.klinikDataSet.diagnosis);
            diagnosisBindingSource1.AddNew();
            //refresh queue
            //cs.WriteEntry("diagnosis");
        }

        private void button4updatequeue_Click(object sender, EventArgs e)
        {
            this.Validate();
            queueBindingSource.EndEdit();
            //klinikDataSet.AcceptChanges();

            klinikDataSet source = (klinikDataSet)queueBindingSource.DataSource;
            var chg = this.klinikDataSet.GetChanges();
            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
        }

        private void textBox2_src_qtrtmt_KeyUp(object sender, KeyEventArgs e)
        {
            treatment_typeBindingSource.Filter = "tr_name like'%" + textBox2.Text.Replace("'", "") +
                "%' or tr_type like '%" + textBox2.Text.Replace("'", "") + "%'";


        }


        private void treatment_typeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
            {
                //HostPCName

                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("calcCharge", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@qid", Session.Current_QID);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dataset);
                dataGridViewqueue.DataSource = dataset.Tables[0];

                dataGridViewqueue.Columns[0].Width = 100;
                dataGridViewqueue.Columns[1].Width = 300;

                dataGridView2drug.DataSource = dataset.Tables[1];
                dataGridView3trmnt.DataSource = dataset.Tables[2];
                dataGridView4diag.DataSource = dataset.Tables[3];
                dataGridView5total.DataSource = dataset.Tables[4];
            }
        }

        private void buttonTreat_Click(object sender, EventArgs e)
        {
            //new TreatmentTyForm().ShowDialog();
            this.treatment_typeTableAdapter.Fill(this.klinikDataSet.treatment_type);
        }

        private void button6cancel_Click(object sender, EventArgs e)
        {
            queueBindingSource.CancelEdit();
        }

        private void button7cancel_Click(object sender, EventArgs e)
        {
            q_drugBindingSource.CancelEdit();
        }

        private void qtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button8_cancelqtreat_Click(object sender, EventArgs e)
        {
            q_treatmentBindingSource.CancelEdit();
        }

        private void diag_addchrgTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            diagnosisBindingSource1.CancelEdit();
        }

        private void queueBindingSrcHistry_CurrentChanged(object sender, EventArgs e)
        {
            if (queueBindingSrcHistry.Current != null)
            {
                qdrugBindingSrcHstry.Filter = "q_id='" + ((DataRowView)queueBindingSrcHistry.Current)["q_id"] + "'";
                qtreatmentBdgSrcHstry.Filter = "q_id='" + ((DataRowView)queueBindingSrcHistry.Current)["q_id"] + "'";
                diagnosisBindingSrcHSTry.Filter = "q_id='" + ((DataRowView)queueBindingSrcHistry.Current)["q_id"] + "'";
            }
        }

        private void button10new_qtreat_Click(object sender, EventArgs e)
        {
            q_treatmentBindingSource.CancelEdit();
            q_treatmentBindingSource.AddNew();
        }

        private void tabPage4newdiag_Enter(object sender, EventArgs e)
        {
            diagnosisBindingSource1.CancelEdit();
            diagnosisBindingSource1.AddNew();
        }

        private void dataGridView_ResizeHeight_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridview = (DataGridView)sender;
            if (gridview.Rows.Count == 0)
                gridview.Visible = false;

            gridview.Height = 40 + gridview.RowCount * gridview.RowTemplate.Height;
            gridview.ClearSelection();
        }

        private void textBox2showtreatment_Enter(object sender, EventArgs e)
        {
            treatment_typeDataGridView.Visible = true;
            buttonnewTrTY.Visible = true;
        }

        private void textBox2_src_trtype_Leave(object sender, EventArgs e)
        {
            if (treatment_typeBindingSource.Current != null)
            {
                var row = (DataRowView)treatment_typeBindingSource.Current;
                textBox2.Text = row["tr_name"].ToString();
                //tr_typeLabel.Text = row["tr_type"].ToString();
                tr_typeTextBox.Text = row["tr_type"].ToString();
                label5deftrchg.Text = row["tr_defaultcharge"].ToString();
            }
            treatment_typeDataGridView.Visible = false;
            label5deftrchg.Visible = true;
            buttonnewTrTY.Visible = false;


        }

        private void dataGridView3_Leave(object sender, EventArgs e)
        {
            var gridview = (DataGridView)sender;
            gridview.ClearSelection();
        }

        private void TreatmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            diagnosisBindingSource1.CancelEdit();
            diagnosisBindingSource1.AddNew();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            q_treatmentBindingSource.CancelEdit();
            q_treatmentBindingSource.AddNew();

        }

        private void flowLayoutPanel2_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanel2.Controls.Count % 10 == 0)
                flowLayoutPanel2.SetFlowBreak(e.Control as Control, true);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void templateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button16SaveTemplate.Enabled = true;
            button16updatedoc.Enabled = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
            {
                conn.Open();
                var command = new SqlCommand("Update Queue set q_status='" + QStatus.QueuePayment + "',DOC_ID='" + Session.Username + "' where q_id='" + Session.Current_QID + "' ", conn);
                command.ExecuteScalar();
            }
            this.Close();
            //refresh queue
            cs.WriteEntry("queue;updated");

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to clear record and return?", "Exit without saving",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;

            using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("DeleteQinfo", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@qid", Session.Current_QID);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dataset);

            }
            //refresh queue
            cs.WriteEntry("queue;updated");

            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            drugListBox.Visible = true;
            buttonnewdrug.Visible = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (drugBindingSource.Current != null)
            {
                var row = (DataRowView)drugBindingSource.Current;
                drug_codeTextBox.Text = row["drg_code"].ToString();
                textBox1.Text = row["drg_name"].ToString();
                drugListBox.Visible = false;
                buttonnewdrug.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            q_treatmentBindingSource.CancelEdit();
            q_treatmentBindingSource.AddNew();
        }

        private void buttonnewTrTY_Click(object sender, EventArgs e)
        {
            masterRecForm.ShowDialog();
        }

        private void buttonnewdrug_Click(object sender, EventArgs e)
        {
            q_drugBindingSource.CancelEdit();
            q_drugBindingSource.AddNew();
        }


        MasterRecForm masterRecForm = new MasterRecForm();
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            masterRecForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var row = (DataRowView)patientBindingSource.Current;
            var qrow = (DataRowView)queueBindingSource.Current;

            RTFHelper.Replace(rtfRichTextBox, "--clinic.name--", Klinik3.Properties.Resources.klinikname);
            RTFHelper.Replace(rtfRichTextBox, "--clinik.address--", Klinik3.Properties.Resources.klinikaddress.Replace("\\r\\n", "\r\n"));
            RTFHelper.Replace(rtfRichTextBox, "--mc.no--", row["pat_id"] + "/" + DateTime.Now.ToString("ddMMyyyy"));//update mc no
            RTFHelper.Replace(rtfRichTextBox, "--patient.ic--", row["pat_ic"].ToString());
            RTFHelper.Replace(rtfRichTextBox, "--patient.name--", row["pat_name"].ToString());
            RTFHelper.Replace(rtfRichTextBox, "--treatment.date--", DateTime.Parse(qrow["time_enter"].ToString()).ToString("dd/MM/yyyy"));
            RTFHelper.Replace(rtfRichTextBox, "--treatment.date--", DateTime.Parse(qrow["time_enter"].ToString()).ToString("dd/MM/yyyy"));
            RTFHelper.Replace(rtfRichTextBox, "--treatment.date--", DateTime.Parse(qrow["time_enter"].ToString()).ToString("dd/MM/yyyy"));
            RTFHelper.Replace(rtfRichTextBox, "--current.date--", DateTime.Now.ToString("dd/MM/yyyy"));

            RTFHelper.Replace(rtfRichTextBox, "--doctor.name--", Session.Fullname);
            RTFHelper.Replace(rtfRichTextBox, "--treatment.starttime--", DateTime.Parse(qrow["time_enter"].ToString()).ToString("hh:mm tt"));
            RTFHelper.Replace(rtfRichTextBox, "--treatment.endtime--", (DateTime.Now).ToString("hh:mm tt"));


            var symtomps = "";
            var diagnosis = "";
            var signs = "";
            //TODO:

            for (int i = 0; i < diagnosisBindingSource1.Count; i++)
            {
                var drow = (DataRowView)diagnosisBindingSource1.List[i];
                diagnosis += drow["diag_name"] + Environment.NewLine;
                Console.WriteLine(diagnosisBindingSource1.Count);
                var drow2 = (DataRowView)diagnosisBindingSource1.List[i];
                symtomps += drow["diag_note"] + Environment.NewLine;

                var drow3 = (DataRowView)diagnosisBindingSource1.List[i];
                signs += drow["diag_type"] + Environment.NewLine;

            }
            RTFHelper.Replace(rtfRichTextBox, "--diagnosis.list--", diagnosis);
            RTFHelper.Replace(rtfRichTextBox, "--signs.list--", diagnosis);
            RTFHelper.Replace(rtfRichTextBox, "--symtomps.list--", diagnosis);
            button16SaveTemplate.Enabled = false;
            button16updatedoc.Enabled = true;
            comboBox1docList.Text = "";

        }


        private void buttonremove_q_drug_Click(object sender, EventArgs e)
        {
            if (q_drugBindingSource.Current != null)
                q_drugBindingSource.Remove(q_drugBindingSource.Current);

            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
        }

        private void buttonRem_qtreat_Click(object sender, EventArgs e)
        {
            if (q_treatmentBindingSource.Current != null)
                q_treatmentBindingSource.Remove(q_treatmentBindingSource.Current);

            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (diagnosisBindingSource1.Current != null)
                diagnosisBindingSource1.Remove(diagnosisBindingSource1.Current);

            this.tableAdapterManager.UpdateAll(this.klinikDataSet);
        }

        private void diagnosisDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void q_treatmentDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("B5", 690, 980);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }


        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print the content of RichTextBox. Store the last character printed.
            var checkPrint = rtfRichTextBox.Print(0, rtfRichTextBox.TextLength, e);

            // Check for more pages
            if (checkPrint < rtfRichTextBox.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void buttonToggleHistory_Click(object sender, EventArgs e)
        {

        }



        private void buttonvisitationhitry_Click(object sender, EventArgs e)
        {
            VisitationHistoryForm vf = new VisitationHistoryForm(pat_idLabel1.Text);
            vf.ShowDialog();

        }

        private void buttonchgsummary_Click(object sender, EventArgs e)
        {
            //splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            ChargeForm cf = new ChargeForm();
            cf.qid = Session.Current_QID;
            cf.panel2.Enabled = false;
            cf.ShowDialog();
        }

        private void button16SaveTemplate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
            {

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Update [metadata] set value_= @rtfvalue where name_='" + templateComboBox.Text + "'";
                cmd.Parameters.AddWithValue("@rtfvalue", rtfRichTextBox.Rtf);


                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                conn.Open();

                int no = cmd.ExecuteNonQuery();
                Console.Write("Executed query:" + no);
                this.metadataTableAdapter.Fill(this.klinikDataSet.metadata);
            }
        }

        private void button18print_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1docList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button16updatedoc_Click(object sender, EventArgs e)
        {
            string mc_name = templateComboBox.Text;

            if (comboBox1docList.Text.Length > 0)
                mc_name = comboBox1docList.Text;



            using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
            {

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "delete from q_documents where mc_name='"+ mc_name + "'";
                cmd.Connection = conn;

                conn.Open();

                int no = cmd.ExecuteNonQuery();
                Console.Write("Deleted q_documents:" + no);

                cmd.CommandText = "insert into q_documents (q_id,mc_name,value_) values('"+Session.Current_QID+"','"+mc_name+ "',@rtfvalue)";
                cmd.Parameters.AddWithValue("@rtfvalue", rtfRichTextBox.Rtf);

                no = cmd.ExecuteNonQuery();
                Console.Write("insert into q_documents:" + no);

                this.q_documentsTableAdapter.Fill(this.klinikDataSet.q_documents);
            }
        }

        private void comboBox1docList_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void comboBox1docList_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void comboBox1docList_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void qdocumentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (qdocumentsBindingSource.Count > 0 && comboBox1docList.Text.Length > 0)
            {
                var qdocumentsrow = (DataRowView)qdocumentsBindingSource.Current;
                rtfRichTextBox.Rtf = qdocumentsrow["value_"].ToString();
                button16updatedoc.Enabled = true;
            }
            button16updatedoc.Enabled = false;
        }
    }
}
