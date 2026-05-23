using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void baggageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.baggageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.railwayDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railwayDBDataSet.Baggage". При необходимости она может быть перемещена или удалена.
            this.baggageTableAdapter.Fill(this.railwayDBDataSet.Baggage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railwayDBDataSet.Tariff". При необходимости она может быть перемещена или удалена.
            this.tariffTableAdapter.Fill(this.railwayDBDataSet.Tariff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railwayDBDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.railwayDBDataSet.Ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railwayDBDataSet.Baggage". При необходимости она может быть перемещена или удалена.
            this.baggageTableAdapter.Fill(this.railwayDBDataSet.Baggage);

        }

        private void baggageDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ticketDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void trainIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void trainIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void ticketDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    this.ticketBindingSource.AddNew();
                    this.ticketBindingSource.MoveLast();

                    passengerNameTextBox.Focus();
                    break;

                case 1:
                    this.baggageBindingSource.AddNew();
                    this.baggageBindingSource.MoveLast();

                    weightTextBox.Focus();
                    break;

                case 2:
                    this.tariffBindingSource.AddNew();
                    this.tariffBindingSource.MoveLast();

                    ticketPriceTextBox.Focus();
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                this.tariffBindingSource.EndEdit();
                this.ticketBindingSource.EndEdit();
                this.baggageBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.railwayDBDataSet);

                this.tariffTableAdapter.Fill(this.railwayDBDataSet.Tariff);
                this.ticketTableAdapter.Fill(this.railwayDBDataSet.Ticket);
                this.baggageTableAdapter.Fill(this.railwayDBDataSet.Baggage);

                MessageBox.Show("Данные успешно синхронизированы с SQL Server!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении или обновлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    if (ticketBindingSource.Current != null)
                    {
                        if (MessageBox.Show("Удалить билет? Связанный багаж удалится автоматически!", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ticketBindingSource.RemoveCurrent();
                            btnSave_Click(sender, e);
                        }
                    }
                    break;

                case 1:
                    if (baggageBindingSource.Current != null)
                    {
                        baggageBindingSource.RemoveCurrent();
                        btnSave_Click(sender, e);
                    }
                    break;

                case 2:
                    if (tariffBindingSource.Current != null)
                    {
                        if (MessageBox.Show("ВНИМАНИЕ! Удаление тарифа приведет к АВТОМАТИЧЕСКОМУ аннулированию ВСЕХ билетов на этот рейс и удалению их багажа! Продолжить?", "Критическое удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            tariffBindingSource.RemoveCurrent();
                            btnSave_Click(sender, e);
                        }
                    }
                    break;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }

        private void passengerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tagIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void departureDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void departureDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 reportForm = new Form2();
            reportForm.ShowDialog(); // Откроет отчет в красивом отдельном окне
        }
    }
}
