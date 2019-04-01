using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace _3LayerWinApp
{
    public partial class AddPhoneForm : Form
    {
        DbDataOperation dal = new DbDataOperation();
        bool createMode = true;
        Phone ph;
        private void  init(List<Manufacturer> mData){
            InitializeComponent();
            comboBoxManuf.DataSource = mData;
            comboBoxManuf.DisplayMember = "Name";
            comboBoxManuf.ValueMember = "Id";
}

        public AddPhoneForm(List<Manufacturer> mData)
        {
            init(mData);
        }

        public AddPhoneForm(List<Manufacturer> mData, Phone item)
        {
            createMode = false;
            init(mData);
            numericUpDown1.Value = item.Cost;
            comboBoxManuf.SelectedValue = item.ManufacturerId;
            textBox1.Text = item.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (createMode)
            {
                Phone phone = new Phone();
                phone.ManufacturerId = (int)comboBoxManuf.SelectedValue;
                phone.Name = textBox1.Text;
                phone.Cost = numericUpDown1.Value;


                dal.CreatePhone(phone);
            }
            else
            {
                ph.Cost = numericUpDown1.Value;
                ph.Name =textBox1.Text;
                ph.ManufacturerId = (int)comboBoxManuf.SelectedValue;

                dal.UpdatePhone(ph);

            }

        }
    }
}
