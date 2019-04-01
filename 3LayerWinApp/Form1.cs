using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BLL;
using BLL.Services;
using DAL;

namespace _3LayerWinApp
{
    public partial class Form1 : Form
    {
        DbDataOperation dal = new DbDataOperation();
        List<Phone> allPhones;
        List<Manufacturer> allManufacturers;
        BindingList<Phone> allPhones2;

        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        //загрузка данных в таблицы
        private void loadData()
        {

            loadPhones();

            loadOrders();
        }

        private void loadPhones()
        {
            //allPhones = ;
            allPhones2 = dal.GetAllPhones().ToBindingList();

            // Отображаем данные
            gvPhonesList.DataSource = allPhones2;

            ListBoxPhonesInOrder.DataSource = allPhones2;
            ListBoxPhonesInOrder.DisplayMember = "Name";
            ListBoxPhonesInOrder.ValueMember = "Id";

            allManufacturers = dal.GetManufacturers();

            ((DataGridViewComboBoxColumn)gvPhonesList.Columns["ManufacturerId_M"]).DataSource = allManufacturers;
            ((DataGridViewComboBoxColumn)gvPhonesList.Columns["ManufacturerId_M"]).DisplayMember ="Name";
            ((DataGridViewComboBoxColumn)gvPhonesList.Columns["ManufacturerId_M"]).ValueMember ="Id";
        }

        private void loadOrders()
        {
            gvOrders.DataSource = dal.GetAllOrders().ToBindingList(); ;

        }

        private void btnNewPhone_Click(object sender, EventArgs e)
        {
            AddPhoneForm f = new AddPhoneForm(allManufacturers);
            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Phone phone = new Phone();
            phone.ManufacturerId = (int)f.comboBoxManuf.SelectedValue;
            phone.Name = f.textBox1.Text;
            phone.Cost = f.numericUpDown1.Value;


            dal.CreatePhone(phone);

            this.gvPhonesList.Refresh();

            //MessageBox.Show("Новый объект добавлен");
        }





        //Добавить заказ
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (ListBoxPhonesInOrder.CheckedItems.Count == 0)
            {
                MessageBox.Show("Не выбран ни один товар в заказ!");
                return;
            }
            List<Phone> items = new List<Phone>();
            foreach (var i in ListBoxPhonesInOrder.CheckedItems)
                items.Add(i as Phone);

            Order order = new Order()
            {
                Address = tbAddress.Text,
                Customer = tbCustomer.Text,
                Phones = items,
                Date = DateTime.Now,
                Total = items.Select(i => i.Cost).Sum()
            };

            OrderService service = new OrderService(dal);
            bool result = service.MakeOrder(order);
            if (result)
            {
                MessageBox.Show("Success");
            }
            else MessageBox.Show("Failed");

        }

        private void btnSavePhone_Click(object sender, EventArgs e)
        {
            bool res = Validate();
            if (res)
            {
                dal.Save();
                this.gvPhonesList.Refresh();
            }
        }

        private void RefreshPhonesBtn_Click(object sender, EventArgs e)
        {
            loadPhones();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int index = getSelectedRow(gvPhonesList);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(gvPhonesList[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Phone ph = dal.GetPhone(id);
                if (ph != null)
                {
                    AddPhoneForm f = new AddPhoneForm(allManufacturers);

                    f.numericUpDown1.Value = ph.Cost;
                    f.comboBoxManuf.SelectedValue = ph.ManufacturerId;
                    f.textBox1.Text = ph.Name;

                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    ph.Cost = f.numericUpDown1.Value;
                    ph.Name = f.textBox1.Text;
                    ph.ManufacturerId = (int)f.comboBoxManuf.SelectedValue;

                    dal.Save();
                    gvPhonesList.Refresh();
                    //MessageBox.Show("Объект обновлен");
                }
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(gvPhonesList);
            if (index != -1)
            { 
                int id = 0;
                bool converted = Int32.TryParse(gvPhonesList[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                dal.DeletePhone(id);

                //MessageBox.Show("Объект удален");
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }

        private void btnShowOrderItems_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(gvOrders);
            if (index != -1)
            {
                var selectedId = Convert.ToInt32(gvOrders.Rows[index].Cells["Id"].Value);
                var orderedPhones =dal.GetAllOrders().Where(i => i.Id == selectedId).FirstOrDefault().Phones;

                string text = "";
                foreach (Phone p in orderedPhones)
                {
                    text += $"{ p.Manufacturer.Name.Trim()} { p.Name.Trim()}" + ",";
                }
                text = text.TrimEnd(',');
                string caption = $"Товары в заказе {selectedId} {gvOrders.Rows[index].Cells["Customer"].Value}";
                MessageBox.Show(text, caption);
            }
            else
                MessageBox.Show("Ни один объект не выбран!");

        }

        private int getSelectedRow(DataGridView dataGridView)
        {
            int index = -1;
            if (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                    index = dataGridView.SelectedRows[0].Index;
                else index = dataGridView.SelectedCells[0].RowIndex;
            }
            return index;
        }

 
        //выполнить ХП
        private void ExecuteSP()
        {
            ReportsService rs = new ReportsService();
            dataGridView_SP.DataSource = rs.ExecuteSP();
           
        }

        private void report_Click(object sender, EventArgs e)
        {

            ExecuteSP();

        }

        private void btnExecSql_Click(object sender, EventArgs e)
        {
            ReportsService rs = new ReportsService();
            lblRawSql.Text += rs.ReportOrdersByMonth((int)txtMonthReport.Value, DateTime.Now.Year).ToString();
        }


    }
}
