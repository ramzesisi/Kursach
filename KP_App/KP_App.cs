using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_App
{
    public partial class KP_App : Form
    {
        public KP_App()
        {
            InitializeComponent();
        }

        private void KP_App_Load(object sender, EventArgs e)
        {

        }

        private void deleteSelectedRowButton_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.Rows.Count > 1)
            {
                mainDataGridView.Rows.RemoveAt(mainDataGridView.CurrentRow.Index);
            }
        }

        private void calculateTotalPaymentByWorkspace_Click(object sender, EventArgs e)
        {
            if (workspaceComboBox.Text == "") return;
            string workspace = workspaceComboBox.Text;
            int totalMonthlyPayment = 0;
            double averageMonthlyPayment = 0;
            int counter = 0;
            for (int i = 0; i < mainDataGridView.Rows.Count; i++)
            {
                if (mainDataGridView[2, i].Value == null) break;
                if (mainDataGridView[2, i].Value.ToString() == workspace)
                {
                    counter++;
                    totalMonthlyPayment += Convert.ToInt32(mainDataGridView[3, i].Value);
                } 
            }
            averageMonthlyPayment = (double)totalMonthlyPayment / counter;
            totalPaymentTextBox.Text = totalMonthlyPayment.ToString();
            averageMonthPaymentTextBox.Text = averageMonthlyPayment.ToString();
        }
    }
}
