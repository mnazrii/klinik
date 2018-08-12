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

namespace Klinik3
{
    public partial class Sales_Report : Form
    {
        public Sales_Report()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_klinikDataSet.PAYMENTDETAILS' table. You can move, or remove it, as needed.
            this.pAYMENTDETAILSTableAdapter.Fill(this.database_klinikDataSet.PAYMENTDETAILS);
            
        }

        
        ////private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var index = comboBox1.SelectedIndex;
        //    using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
        //    {
        //        DataSet dataset = new DataSet();
        //        SqlDataAdapter adapter = new SqlDataAdapter();
        //        adapter.SelectCommand = new SqlCommand(QStatus.sqllist[index], conn);
        //        adapter.Fill(dataset);
        //        dataGridView1.DataSource = dataset.Tables[0];
        //    }
        //}

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var panelrb = groupBox2.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            
            
            var rangerb = groupBox3.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);

            var daterb = groupBox1.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);

            var pamntty = groupBoxpaymentty.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            var sqlcol = "";


            //summarize amount
            if (panelrb == radioButtonsumm)
                sqlcol = string.Format("SELECT COUNT(1) [NO OF VISIT],SUM([AMNT.]) TOTAL,{0} [VST.DATE] ", daterb.Tag);
            
            if(panelrb==radioButtonbypanel)
                sqlcol = string.Format("SELECT COUNT(1) [NO OF VISIT],{0} [VST.DATE],[PAYMENT TYPE] ,SUM([AMNT.]) TOTAL ", daterb.Tag);

            if (panelrb == radioButtonbydoc)
                sqlcol = string.Format("SELECT COUNT(1) [NO OF VISIT],{0} [VST.DATE],[DR]           ,SUM([AMNT.]) TOTAL ", daterb.Tag);

            var sql = string.Format(
                 sqlcol+
                "FROM [dbo].[PAYMENTREPORT] " +
                "WHERE {1} {3}" +
                "GROUP BY {2} ,{0}"
                , panelrb.Tag, rangerb.Tag, daterb.Tag, pamntty.Tag).TrimEnd(',');

            Console.Write(sql);

            using (SqlConnection conn = new SqlConnection(Klinik3.Properties.Settings.Default.klinikConnectionString))
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(sql, conn);
                adapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
                
            }

            //string filter = string.Format("{0} {1}", rangerb.Tag, checkBox1.Checked ? "and [PAYMENT TYPE] <> 'CASH' " : "");
            //pAYMENTDETAILSBindingSource.Filter = filter;
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void radioButtondaterange_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Enabled = dateTimePicker4.Enabled = radioButtondaterange.Checked;
            radioButtondaterange.Tag = "date between '"+ dateTimePicker3.Value.Date.ToString("yyyy-MM-dd ") +"' and '"+dateTimePicker4.Value.Date.AddDays(1).ToString("yyyy-MM-dd")+"'";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
