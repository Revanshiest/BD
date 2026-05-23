namespace LW5
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
            System.Windows.Forms.Label passengerNameLabel;
            System.Windows.Forms.Label departureDateLabel;
            System.Windows.Forms.Label subRouteIDLabel;
            System.Windows.Forms.Label trainIDLabel;
            System.Windows.Forms.Label tagIDLabel;
            System.Windows.Forms.Label ticketIDLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label subRouteIDLabel1;
            System.Windows.Forms.Label trainIDLabel1;
            System.Windows.Forms.Label ticketPriceLabel;
            System.Windows.Forms.Label ticketIDLabel1;
            this.railwayDBDataSet = new LW5.RailwayDBDataSet();
            this.baggageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baggageTableAdapter = new LW5.RailwayDBDataSetTableAdapters.BaggageTableAdapter();
            this.tableAdapterManager = new LW5.RailwayDBDataSetTableAdapters.TableAdapterManager();
            this.tariffTableAdapter = new LW5.RailwayDBDataSetTableAdapters.TariffTableAdapter();
            this.ticketTableAdapter = new LW5.RailwayDBDataSetTableAdapters.TicketTableAdapter();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baggageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ticketIDTextBox1 = new System.Windows.Forms.TextBox();
            this.trainIDTextBox = new System.Windows.Forms.TextBox();
            this.subRouteIDTextBox = new System.Windows.Forms.TextBox();
            this.departureDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passengerNameTextBox = new System.Windows.Forms.TextBox();
            this.ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.ticketIDTextBox = new System.Windows.Forms.TextBox();
            this.tagIDTextBox = new System.Windows.Forms.TextBox();
            this.baggageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ticketPriceTextBox = new System.Windows.Forms.TextBox();
            this.trainIDTextBox1 = new System.Windows.Forms.TextBox();
            this.subRouteIDTextBox1 = new System.Windows.Forms.TextBox();
            this.tariffDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            passengerNameLabel = new System.Windows.Forms.Label();
            departureDateLabel = new System.Windows.Forms.Label();
            subRouteIDLabel = new System.Windows.Forms.Label();
            trainIDLabel = new System.Windows.Forms.Label();
            tagIDLabel = new System.Windows.Forms.Label();
            ticketIDLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            subRouteIDLabel1 = new System.Windows.Forms.Label();
            trainIDLabel1 = new System.Windows.Forms.Label();
            ticketPriceLabel = new System.Windows.Forms.Label();
            ticketIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.railwayDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baggageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baggageBindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baggageDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tariffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // passengerNameLabel
            // 
            passengerNameLabel.AutoSize = true;
            passengerNameLabel.Location = new System.Drawing.Point(148, 325);
            passengerNameLabel.Name = "passengerNameLabel";
            passengerNameLabel.Size = new System.Drawing.Size(91, 13);
            passengerNameLabel.TabIndex = 1;
            passengerNameLabel.Text = "Passenger Name:";
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.Location = new System.Drawing.Point(367, 329);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new System.Drawing.Size(83, 13);
            departureDateLabel.TabIndex = 3;
            departureDateLabel.Text = "Departure Date:";
            departureDateLabel.Click += new System.EventHandler(this.departureDateLabel_Click);
            // 
            // subRouteIDLabel
            // 
            subRouteIDLabel.AutoSize = true;
            subRouteIDLabel.Location = new System.Drawing.Point(149, 351);
            subRouteIDLabel.Name = "subRouteIDLabel";
            subRouteIDLabel.Size = new System.Drawing.Size(75, 13);
            subRouteIDLabel.TabIndex = 5;
            subRouteIDLabel.Text = "Sub Route ID:";
            // 
            // trainIDLabel
            // 
            trainIDLabel.AutoSize = true;
            trainIDLabel.Location = new System.Drawing.Point(367, 354);
            trainIDLabel.Name = "trainIDLabel";
            trainIDLabel.Size = new System.Drawing.Size(48, 13);
            trainIDLabel.TabIndex = 7;
            trainIDLabel.Text = "Train ID:";
            trainIDLabel.Click += new System.EventHandler(this.trainIDLabel_Click);
            // 
            // tagIDLabel
            // 
            tagIDLabel.AutoSize = true;
            tagIDLabel.Location = new System.Drawing.Point(282, 270);
            tagIDLabel.Name = "tagIDLabel";
            tagIDLabel.Size = new System.Drawing.Size(43, 13);
            tagIDLabel.TabIndex = 1;
            tagIDLabel.Text = "Tag ID:";
            tagIDLabel.Click += new System.EventHandler(this.tagIDLabel_Click);
            // 
            // ticketIDLabel
            // 
            ticketIDLabel.AutoSize = true;
            ticketIDLabel.Location = new System.Drawing.Point(216, 322);
            ticketIDLabel.Name = "ticketIDLabel";
            ticketIDLabel.Size = new System.Drawing.Size(54, 13);
            ticketIDLabel.TabIndex = 3;
            ticketIDLabel.Text = "Ticket ID:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(403, 326);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 5;
            weightLabel.Text = "Weight:";
            // 
            // subRouteIDLabel1
            // 
            subRouteIDLabel1.AutoSize = true;
            subRouteIDLabel1.Location = new System.Drawing.Point(290, 243);
            subRouteIDLabel1.Name = "subRouteIDLabel1";
            subRouteIDLabel1.Size = new System.Drawing.Size(75, 13);
            subRouteIDLabel1.TabIndex = 1;
            subRouteIDLabel1.Text = "Sub Route ID:";
            // 
            // trainIDLabel1
            // 
            trainIDLabel1.AutoSize = true;
            trainIDLabel1.Location = new System.Drawing.Point(227, 294);
            trainIDLabel1.Name = "trainIDLabel1";
            trainIDLabel1.Size = new System.Drawing.Size(48, 13);
            trainIDLabel1.TabIndex = 3;
            trainIDLabel1.Text = "Train ID:";
            // 
            // ticketPriceLabel
            // 
            ticketPriceLabel.AutoSize = true;
            ticketPriceLabel.Location = new System.Drawing.Point(404, 294);
            ticketPriceLabel.Name = "ticketPriceLabel";
            ticketPriceLabel.Size = new System.Drawing.Size(67, 13);
            ticketPriceLabel.TabIndex = 5;
            ticketPriceLabel.Text = "Ticket Price:";
            // 
            // ticketIDLabel1
            // 
            ticketIDLabel1.AutoSize = true;
            ticketIDLabel1.Location = new System.Drawing.Point(291, 264);
            ticketIDLabel1.Name = "ticketIDLabel1";
            ticketIDLabel1.Size = new System.Drawing.Size(54, 13);
            ticketIDLabel1.TabIndex = 9;
            ticketIDLabel1.Text = "Ticket ID:";
            // 
            // railwayDBDataSet
            // 
            this.railwayDBDataSet.DataSetName = "RailwayDBDataSet";
            this.railwayDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baggageBindingSource
            // 
            this.baggageBindingSource.DataMember = "Baggage";
            this.baggageBindingSource.DataSource = this.railwayDBDataSet;
            // 
            // baggageTableAdapter
            // 
            this.baggageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaggageTableAdapter = this.baggageTableAdapter;
            this.tableAdapterManager.TariffTableAdapter = this.tariffTableAdapter;
            this.tableAdapterManager.TicketTableAdapter = this.ticketTableAdapter;
            this.tableAdapterManager.UpdateOrder = LW5.RailwayDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tariffTableAdapter
            // 
            this.tariffTableAdapter.ClearBeforeFill = true;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.railwayDBDataSet;
            // 
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataMember = "Tariff";
            this.tariffBindingSource.DataSource = this.railwayDBDataSet;
            // 
            // baggageBindingSource1
            // 
            this.baggageBindingSource1.DataMember = "Baggage";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(274, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 471);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(ticketIDLabel1);
            this.tabPage1.Controls.Add(this.ticketIDTextBox1);
            this.tabPage1.Controls.Add(trainIDLabel);
            this.tabPage1.Controls.Add(this.trainIDTextBox);
            this.tabPage1.Controls.Add(subRouteIDLabel);
            this.tabPage1.Controls.Add(this.subRouteIDTextBox);
            this.tabPage1.Controls.Add(departureDateLabel);
            this.tabPage1.Controls.Add(this.departureDateDateTimePicker);
            this.tabPage1.Controls.Add(passengerNameLabel);
            this.tabPage1.Controls.Add(this.passengerNameTextBox);
            this.tabPage1.Controls.Add(this.ticketDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Билеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ticketIDTextBox1
            // 
            this.ticketIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "TicketID", true));
            this.ticketIDTextBox1.Location = new System.Drawing.Point(351, 261);
            this.ticketIDTextBox1.Name = "ticketIDTextBox1";
            this.ticketIDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.ticketIDTextBox1.TabIndex = 10;
            // 
            // trainIDTextBox
            // 
            this.trainIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "TrainID", true));
            this.trainIDTextBox.Location = new System.Drawing.Point(456, 351);
            this.trainIDTextBox.Name = "trainIDTextBox";
            this.trainIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.trainIDTextBox.TabIndex = 8;
            this.trainIDTextBox.TextChanged += new System.EventHandler(this.trainIDTextBox_TextChanged);
            // 
            // subRouteIDTextBox
            // 
            this.subRouteIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "SubRouteID", true));
            this.subRouteIDTextBox.Location = new System.Drawing.Point(245, 348);
            this.subRouteIDTextBox.Name = "subRouteIDTextBox";
            this.subRouteIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.subRouteIDTextBox.TabIndex = 6;
            // 
            // departureDateDateTimePicker
            // 
            this.departureDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketBindingSource, "DepartureDate", true));
            this.departureDateDateTimePicker.Location = new System.Drawing.Point(456, 325);
            this.departureDateDateTimePicker.Name = "departureDateDateTimePicker";
            this.departureDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.departureDateDateTimePicker.TabIndex = 4;
            this.departureDateDateTimePicker.ValueChanged += new System.EventHandler(this.departureDateDateTimePicker_ValueChanged);
            // 
            // passengerNameTextBox
            // 
            this.passengerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "PassengerName", true));
            this.passengerNameTextBox.Location = new System.Drawing.Point(245, 322);
            this.passengerNameTextBox.Name = "passengerNameTextBox";
            this.passengerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.passengerNameTextBox.TabIndex = 2;
            this.passengerNameTextBox.TextChanged += new System.EventHandler(this.passengerNameTextBox_TextChanged);
            // 
            // ticketDataGridView
            // 
            this.ticketDataGridView.AutoGenerateColumns = false;
            this.ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.ticketDataGridView.DataSource = this.ticketBindingSource;
            this.ticketDataGridView.Location = new System.Drawing.Point(245, 6);
            this.ticketDataGridView.Name = "ticketDataGridView";
            this.ticketDataGridView.Size = new System.Drawing.Size(300, 220);
            this.ticketDataGridView.TabIndex = 0;
            this.ticketDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TicketID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TicketID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PassengerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PassengerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubRouteID";
            this.dataGridViewTextBoxColumn3.HeaderText = "SubRouteID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TrainID";
            this.dataGridViewTextBoxColumn4.HeaderText = "TrainID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DepartureDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "DepartureDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(weightLabel);
            this.tabPage2.Controls.Add(this.weightTextBox);
            this.tabPage2.Controls.Add(ticketIDLabel);
            this.tabPage2.Controls.Add(this.ticketIDTextBox);
            this.tabPage2.Controls.Add(tagIDLabel);
            this.tabPage2.Controls.Add(this.tagIDTextBox);
            this.tabPage2.Controls.Add(this.baggageDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Багаж";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baggageBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(453, 323);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 6;
            // 
            // ticketIDTextBox
            // 
            this.ticketIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baggageBindingSource, "TicketID", true));
            this.ticketIDTextBox.Location = new System.Drawing.Point(276, 319);
            this.ticketIDTextBox.Name = "ticketIDTextBox";
            this.ticketIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketIDTextBox.TabIndex = 4;
            // 
            // tagIDTextBox
            // 
            this.tagIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baggageBindingSource, "TagID", true));
            this.tagIDTextBox.Location = new System.Drawing.Point(331, 267);
            this.tagIDTextBox.Name = "tagIDTextBox";
            this.tagIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.tagIDTextBox.TabIndex = 2;
            // 
            // baggageDataGridView
            // 
            this.baggageDataGridView.AutoGenerateColumns = false;
            this.baggageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baggageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.baggageDataGridView.DataSource = this.baggageBindingSource;
            this.baggageDataGridView.Location = new System.Drawing.Point(230, 6);
            this.baggageDataGridView.Name = "baggageDataGridView";
            this.baggageDataGridView.Size = new System.Drawing.Size(300, 220);
            this.baggageDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TagID";
            this.dataGridViewTextBoxColumn6.HeaderText = "TagID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TicketID";
            this.dataGridViewTextBoxColumn7.HeaderText = "TicketID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn8.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(ticketPriceLabel);
            this.tabPage3.Controls.Add(this.ticketPriceTextBox);
            this.tabPage3.Controls.Add(trainIDLabel1);
            this.tabPage3.Controls.Add(this.trainIDTextBox1);
            this.tabPage3.Controls.Add(subRouteIDLabel1);
            this.tabPage3.Controls.Add(this.subRouteIDTextBox1);
            this.tabPage3.Controls.Add(this.tariffDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(755, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Тарифы";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click_1);
            // 
            // ticketPriceTextBox
            // 
            this.ticketPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "TicketPrice", true));
            this.ticketPriceTextBox.Location = new System.Drawing.Point(477, 291);
            this.ticketPriceTextBox.Name = "ticketPriceTextBox";
            this.ticketPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketPriceTextBox.TabIndex = 6;
            // 
            // trainIDTextBox1
            // 
            this.trainIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "TrainID", true));
            this.trainIDTextBox1.Location = new System.Drawing.Point(281, 291);
            this.trainIDTextBox1.Name = "trainIDTextBox1";
            this.trainIDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.trainIDTextBox1.TabIndex = 4;
            // 
            // subRouteIDTextBox1
            // 
            this.subRouteIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "SubRouteID", true));
            this.subRouteIDTextBox1.Location = new System.Drawing.Point(371, 240);
            this.subRouteIDTextBox1.Name = "subRouteIDTextBox1";
            this.subRouteIDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.subRouteIDTextBox1.TabIndex = 2;
            // 
            // tariffDataGridView
            // 
            this.tariffDataGridView.AutoGenerateColumns = false;
            this.tariffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tariffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.tariffDataGridView.DataSource = this.tariffBindingSource;
            this.tariffDataGridView.Location = new System.Drawing.Point(230, 6);
            this.tariffDataGridView.Name = "tariffDataGridView";
            this.tariffDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tariffDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SubRouteID";
            this.dataGridViewTextBoxColumn9.HeaderText = "SubRouteID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TrainID";
            this.dataGridViewTextBoxColumn10.HeaderText = "TrainID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TicketPrice";
            this.dataGridViewTextBoxColumn11.HeaderText = "TicketPrice";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(734, 477);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(618, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(508, 477);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Добавить";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1126, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.railwayDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baggageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baggageBindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baggageDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tariffDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RailwayDBDataSet railwayDBDataSet;
        private System.Windows.Forms.BindingSource baggageBindingSource;
        private RailwayDBDataSetTableAdapters.BaggageTableAdapter baggageTableAdapter;
        private RailwayDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RailwayDBDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private RailwayDBDataSetTableAdapters.TariffTableAdapter tariffTableAdapter;
        private System.Windows.Forms.BindingSource tariffBindingSource;
        private System.Windows.Forms.BindingSource baggageBindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ticketDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox trainIDTextBox;
        private System.Windows.Forms.TextBox subRouteIDTextBox;
        private System.Windows.Forms.DateTimePicker departureDateDateTimePicker;
        private System.Windows.Forms.TextBox passengerNameTextBox;
        private System.Windows.Forms.TextBox tagIDTextBox;
        private System.Windows.Forms.DataGridView baggageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox ticketIDTextBox;
        private System.Windows.Forms.TextBox trainIDTextBox1;
        private System.Windows.Forms.TextBox subRouteIDTextBox1;
        private System.Windows.Forms.DataGridView tariffDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox ticketPriceTextBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox ticketIDTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

