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
        private readonly string excelSavePath = @"E:\лабы и курсач\2 курс\ТРПО\Курсовой проект\KP_App";
        //Проверка подключение гитхаба
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

        private void excelExportButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application appExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workBookExcel = appExcel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheetExcel = null;
            appExcel.Visible = true;
            worksheetExcel = workBookExcel.Sheets[1];
            worksheetExcel = workBookExcel.ActiveSheet;
            worksheetExcel.Name = "Таблица 1";
            //Копируем заголовки
            for (int i = 1; i < mainDataGridView.Columns.Count + 1; i++)
            {
                worksheetExcel.Cells[1, i] = mainDataGridView.Columns[i - 1].HeaderText;
            }
            //Заполняем таблицу
            for (int i = 0; i < mainDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < mainDataGridView.Columns.Count; j++)
                {
                    worksheetExcel.Cells[i + 2, j + 1] = mainDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            //Сохраняем
            workBookExcel.SaveAs(excelSavePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            appExcel.Quit();
        }

        private void increaseSalary_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.Rows.Count > 1)
            {
                if (mainDataGridView.CurrentCell.ColumnIndex == 1 && percentSalaryTextBox.Text != "")
                {
                    decimal salary_to_increase = Convert.ToDecimal(mainDataGridView.CurrentRow.Cells[3].Value);
                    salary_to_increase *= (Convert.ToDecimal(percentSalaryTextBox.Text)/100) + 1;
                    salary_to_increase = Math.Round(salary_to_increase, 2);
                    mainDataGridView.CurrentRow.Cells[3].Value = salary_to_increase;
                }
                else
                {
                    MessageBox.Show("Выберите фамилию рабочего и введите проценты");
                }
            }
        }

        private void decreaseSalaryButton_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.Rows.Count > 1)
            {
                if (mainDataGridView.CurrentCell.ColumnIndex == 1 && percentSalaryTextBox.Text != "")
                {
                    decimal salary_to_decrease = Convert.ToDecimal(mainDataGridView.CurrentRow.Cells[3].Value);
                    salary_to_decrease *= 1 - (Convert.ToDecimal(percentSalaryTextBox.Text) / 100);
                    salary_to_decrease = Math.Round(salary_to_decrease, 2);
                    if (Convert.ToInt32(salary_to_decrease) < 11114)
                    {
                        MessageBox.Show("Попытка уменьшить зарплату меньше прожиточного минимума (11114 рублей)");
                    }
                    else
                    {
                        mainDataGridView.CurrentRow.Cells[3].Value = salary_to_decrease;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите фамилию рабочего и введите проценты");
                }
            }
        }
    }
}
