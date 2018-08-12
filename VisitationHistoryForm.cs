using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Klinik3
{
    public partial class VisitationHistoryForm : Form
    {
        public VisitationHistoryForm(string pat_id)
        {
            InitializeComponent();
            queueBindingSrcHistry.Filter = "pat_id='" + pat_id + "'";
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

        private void FormVisitationHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikDataSet.diagnosis' table. You can move, or remove it, as needed.
            this.diagnosisTableAdapter.Fill(this.klinikDataSet.diagnosis);
            // TODO: This line of code loads data into the 'klinikDataSet.q_drug' table. You can move, or remove it, as needed.
            this.q_drugTableAdapter.Fill(this.klinikDataSet.q_drug);
            // TODO: This line of code loads data into the 'klinikDataSet.q_treatment' table. You can move, or remove it, as needed.
            this.q_treatmentTableAdapter.Fill(this.klinikDataSet.q_treatment);
            // TODO: This line of code loads data into the 'klinikDataSet.queue' table. You can move, or remove it, as needed.
            this.queueTableAdapter.Fill(this.klinikDataSet.queue);
            //queueBindingSrcHistry.Filter = "q_id='" + Session.Current_QID + "'";
        }
    }
}
