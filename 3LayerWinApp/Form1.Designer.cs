using System.Configuration;


namespace _3LayerWinApp
{
    partial class Form1
    {

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gvPhonesList = new System.Windows.Forms.DataGridView();
            this.ManufacturerId_M = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNewPhone = new System.Windows.Forms.Button();
            this.btnSavePhone = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnShowOrderItems = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListBoxPhonesInOrder = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.cbPhones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.gvOrders = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.report = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_SP = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExecSql = new System.Windows.Forms.Button();
            this.lblRawSql = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtMonthReport = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhonesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SP)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthReport)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPhonesList
            // 
            this.gvPhonesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhonesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManufacturerId_M});
            this.gvPhonesList.Location = new System.Drawing.Point(9, 31);
            this.gvPhonesList.Name = "gvPhonesList";
            this.gvPhonesList.Size = new System.Drawing.Size(761, 290);
            this.gvPhonesList.TabIndex = 0;
            // 
            // ManufacturerId_M
            // 
            this.ManufacturerId_M.DataPropertyName = "ManufacturerId";
            this.ManufacturerId_M.HeaderText = "ManufacturerId";
            this.ManufacturerId_M.Name = "ManufacturerId_M";
            this.ManufacturerId_M.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ManufacturerId_M.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 449);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnNewPhone);
            this.tabPage1.Controls.Add(this.btnSavePhone);
            this.tabPage1.Controls.Add(this.gvPhonesList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(299, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(218, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNewPhone
            // 
            this.btnNewPhone.Location = new System.Drawing.Point(137, 2);
            this.btnNewPhone.Name = "btnNewPhone";
            this.btnNewPhone.Size = new System.Drawing.Size(75, 23);
            this.btnNewPhone.TabIndex = 2;
            this.btnNewPhone.Text = "Добавить";
            this.btnNewPhone.UseVisualStyleBackColor = true;
            this.btnNewPhone.Click += new System.EventHandler(this.btnNewPhone_Click);
            // 
            // btnSavePhone
            // 
            this.btnSavePhone.Location = new System.Drawing.Point(9, 2);
            this.btnSavePhone.Name = "btnSavePhone";
            this.btnSavePhone.Size = new System.Drawing.Size(122, 23);
            this.btnSavePhone.TabIndex = 1;
            this.btnSavePhone.Text = "SaveChangesToDB";
            this.btnSavePhone.UseVisualStyleBackColor = true;
            this.btnSavePhone.Click += new System.EventHandler(this.btnSavePhone_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveOrder);
            this.tabPage2.Controls.Add(this.btnShowOrderItems);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.gvOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(128, 5);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(136, 23);
            this.btnSaveOrder.TabIndex = 4;
            this.btnSaveOrder.Text = "Сохранить изменения";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSavePhone_Click);
            // 
            // btnShowOrderItems
            // 
            this.btnShowOrderItems.Location = new System.Drawing.Point(6, 6);
            this.btnShowOrderItems.Name = "btnShowOrderItems";
            this.btnShowOrderItems.Size = new System.Drawing.Size(115, 23);
            this.btnShowOrderItems.TabIndex = 3;
            this.btnShowOrderItems.Text = "Товары в заказе";
            this.btnShowOrderItems.UseVisualStyleBackColor = true;
            this.btnShowOrderItems.Click += new System.EventHandler(this.btnShowOrderItems_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBoxPhonesInOrder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTelephone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnNewOrder);
            this.groupBox1.Controls.Add(this.cbPhones);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCustomer);
            this.groupBox1.Location = new System.Drawing.Point(8, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новый заказ";
            // 
            // ListBoxPhonesInOrder
            // 
            this.ListBoxPhonesInOrder.CheckOnClick = true;
            this.ListBoxPhonesInOrder.FormattingEnabled = true;
            this.ListBoxPhonesInOrder.Location = new System.Drawing.Point(196, 54);
            this.ListBoxPhonesInOrder.Name = "ListBoxPhonesInOrder";
            this.ListBoxPhonesInOrder.Size = new System.Drawing.Size(172, 94);
            this.ListBoxPhonesInOrder.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tel.";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(22, 135);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(150, 20);
            this.tbTelephone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Товар";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(282, 154);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(112, 23);
            this.btnNewOrder.TabIndex = 1;
            this.btnNewOrder.Text = "Добавить заказ";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // cbPhones
            // 
            this.cbPhones.FormattingEnabled = true;
            this.cbPhones.Location = new System.Drawing.Point(247, 25);
            this.cbPhones.Name = "cbPhones";
            this.cbPhones.Size = new System.Drawing.Size(121, 21);
            this.cbPhones.TabIndex = 4;
            this.cbPhones.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(20, 94);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(150, 20);
            this.tbAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Покупатель ФИО";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(20, 52);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(150, 20);
            this.tbCustomer.TabIndex = 0;
            // 
            // gvOrders
            // 
            this.gvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrders.Location = new System.Drawing.Point(3, 38);
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.Size = new System.Drawing.Size(780, 188);
            this.gvOrders.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.report);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridView_SP);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчет";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(249, 5);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 23);
            this.report.TabIndex = 3;
            this.report.Text = "выполнить";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Результат ХП:";
            // 
            // dataGridView_SP
            // 
            this.dataGridView_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SP.Location = new System.Drawing.Point(23, 54);
            this.dataGridView_SP.Name = "dataGridView_SP";
            this.dataGridView_SP.Size = new System.Drawing.Size(645, 150);
            this.dataGridView_SP.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtMonthReport);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.btnExecSql);
            this.tabPage4.Controls.Add(this.lblRawSql);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Отчет2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Введите месяц";
            // 
            // btnExecSql
            // 
            this.btnExecSql.Location = new System.Drawing.Point(236, 20);
            this.btnExecSql.Name = "btnExecSql";
            this.btnExecSql.Size = new System.Drawing.Size(75, 23);
            this.btnExecSql.TabIndex = 4;
            this.btnExecSql.Text = "Показать";
            this.btnExecSql.UseVisualStyleBackColor = true;
            this.btnExecSql.Click += new System.EventHandler(this.btnExecSql_Click);
            // 
            // lblRawSql
            // 
            this.lblRawSql.AutoSize = true;
            this.lblRawSql.Location = new System.Drawing.Point(8, 51);
            this.lblRawSql.Name = "lblRawSql";
            this.lblRawSql.Size = new System.Drawing.Size(210, 13);
            this.lblRawSql.TabIndex = 3;
            this.lblRawSql.Text = "Результат raw sql (количество заказов):";
            // 
            // txtMonthReport
            // 
            this.txtMonthReport.Location = new System.Drawing.Point(110, 20);
            this.txtMonthReport.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtMonthReport.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMonthReport.Name = "txtMonthReport";
            this.txtMonthReport.Size = new System.Drawing.Size(120, 20);
            this.txtMonthReport.TabIndex = 7;
            this.txtMonthReport.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ExampleDb";
            ((System.ComponentModel.ISupportInitialize)(this.gvPhonesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SP)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.DataGridView gvPhonesList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gvOrders;
        private System.Windows.Forms.Button btnSavePhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCol;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private System.Windows.Forms.Button btnNewPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShowOrderItems;
        private System.Windows.Forms.CheckedListBox ListBoxPhonesInOrder;
        private System.Windows.Forms.ComboBox cbPhones;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ManufacturerId_M;
        private System.Windows.Forms.DataGridView dataGridView_SP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblRawSql;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExecSql;
        private System.Windows.Forms.NumericUpDown txtMonthReport;
    }
}

