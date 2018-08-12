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
using ConsoleTables.Core;

namespace Klinik3
{
    public partial class ChargeForm : Form
    {
        ClientServer cs;
        public ChargeForm()
        {
            InitializeComponent();
        }

        public string qid;
        private void ChargeForm_Load(object sender, EventArgs e)
        {
            showReciept();
            cs = new ClientServer();
            cs.StartClient();
        }

        enum RecieptType
        {
            SIMPLE,
            COMPLETE
        }
        private void showReciept(RecieptType receipttype=RecieptType.COMPLETE)
        {
                textBox1.Text = "";   
                labelstaff.Text = Session.Username;
                labeldate.Text = DateTime.Now.ToString("dd MMM yyyy / hh:mm tt");

                using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
                {
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("calcCharge", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@qid", qid);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dataset);

                    textBox1.AppendText("\t" + Klinik3.Properties.Resources.klinikname +
                   "\r\n" + "\t" + Klinik3.Properties.Resources.klinikaddress.Replace("\\r\\n", "\r\n\t") + "\r\n");

                    textBox1.AppendText(DataTableToString(dataset.Tables[0]));
                    comboBoxpaymentty.Text = dataset.Tables[0].Rows[5].ItemArray[1].ToString();

                    if (receipttype == RecieptType.COMPLETE)
                    {
                        textBox1.AppendText(DataTableToString(dataset.Tables[1]));
                        textBox1.AppendText(DataTableToString(dataset.Tables[2]));
                    
                    }
                    textBox1.AppendText(DataTableToString(dataset.Tables[3]));
                    textBox1.AppendText(DataTableToString(dataset.Tables[4]));

                    textBox1.AppendText(DataTableToString(dataset.Tables[5]));
                    textBox1.AppendText(DataTableToString(dataset.Tables[6]));


                    var ttl = dataset.Tables[6];
                    decimal val;
                    if (decimal.TryParse(ttl.Rows[0].ItemArray[1].ToString(), out val))
                    {
                        numericUpDownChg.Value = val;
                    }
                }
                
            


        }

        /// <summary>
        /// Display datatable as ascii table
        /// </summary>
        /// <param name="datatable">Input datatable</param>
        /// <returns>String ascii table</returns>
        string DataTableToString(DataTable datatable)
        {
            if (datatable.Rows.Count == 0)
                return "";

            
            var table = new ConsoleTable();
            table.saperator = "";
            table.showlinesrecord = false;
            table.devider = false;

            List<string> columns= new List<string>();
            foreach (DataColumn item in datatable.Columns)
            {
                columns.Add(item.ToString().Replace("\r\n"," ** "));
            }

            
            table.AddColumn(columns);
            
            foreach (DataRow row in datatable.Rows)
            {
                List<string> rw = new List<string>();
                foreach (var item in row.ItemArray)
	            {
                    rw.Add(item.ToString());
	            }
                table.AddRow(rw.ToArray());
            }
           
            return table.ToString();
        }

        /// <summary>
        /// Save sales transaction
        /// </summary>
        private void buttonsave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("insert into payment"+
                    "(pay_staffid,pay_amt,pay_bal,datetime,pay_type,q_id,reciept) values "+
                    "('" + labelstaff.Text.Replace("'", "") + "','" + numericUpDownChg.Value + "','" + numericUpDownbal.Value + "',GETDATE(),'" + comboBoxpaymentty.Text.Replace("'", "") + "','" + qid + "','"+textBox1.Text+"')", conn);
                adapter.Fill(dataset);

                adapter.SelectCommand = new SqlCommand("update queue set q_status='"+QStatus.QueueEnded+"',time_out=getdate() where q_id="+qid, conn);
                adapter.Fill(dataset);
                MessageBox.Show("Transaction saved");
                this.Close();
            }
            cs.WriteEntry("queue;updated");
        }

        /// <summary>
        /// Calculate payment balance
        /// </summary>
        private void numericUpDownpay_Leave(object sender, EventArgs e)
        {
            numericUpDownbal.Value = numericUpDownpay.Value - numericUpDownChg.Value; 
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            textBox1.Print(0, textBox1.Text.Length-1,e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rcttye = comboBox1.Text == "Complete" ? RecieptType.COMPLETE : RecieptType.SIMPLE;
            showReciept(rcttye);
        }

    }
}