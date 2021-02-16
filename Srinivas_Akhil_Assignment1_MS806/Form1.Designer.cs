namespace Srinivas_Akhil_Assignment1_MS806
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.ServerNameTextBox = new System.Windows.Forms.TextBox();
            this.TableNoLabel = new System.Windows.Forms.Label();
            this.TableNoTextBox = new System.Windows.Forms.TextBox();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.SultLogo = new System.Windows.Forms.PictureBox();
            this.PizzaMenuLabel = new System.Windows.Forms.Label();
            this.OverallPizzaPanel = new System.Windows.Forms.Panel();
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.OverallSummaryPanel = new System.Windows.Forms.Panel();
            this.CompanySummaryDataLabel = new System.Windows.Forms.Label();
            this.SummaryPanel = new System.Windows.Forms.Panel();
            this.AvgTranscationValueDisplayLabel = new System.Windows.Forms.Label();
            this.TotalCompanyReceiptsDisplayLabel = new System.Windows.Forms.Label();
            this.TotalCompanyPizzaDisplayLabel = new System.Windows.Forms.Label();
            this.TotalCompanyTranscationsDisplayLabel = new System.Windows.Forms.Label();
            this.AverageTranscationValueLabel = new System.Windows.Forms.Label();
            this.TotalCompanyReceiptsLabel = new System.Windows.Forms.Label();
            this.TotalCompanyPizzaLabel = new System.Windows.Forms.Label();
            this.TotalCompanyTranscationsLabel = new System.Windows.Forms.Label();
            this.PanelOrder = new System.Windows.Forms.Panel();
            this.OrderServerNameLabel = new System.Windows.Forms.Label();
            this.OrderTotalTableReceiptsLabel = new System.Windows.Forms.Label();
            this.OrderTotalNumberOfPizza = new System.Windows.Forms.Label();
            this.OrderTotalNumberOfPizzaLabel = new System.Windows.Forms.Label();
            this.OrderTotalReceipts = new System.Windows.Forms.Label();
            this.OrderNameServerNameDisplayLabel = new System.Windows.Forms.Label();
            this.TableOrderSummaryDataLabel = new System.Windows.Forms.Label();
            this.OverallOrderPanel = new System.Windows.Forms.Panel();
            this.PepperoniRateLabel = new System.Windows.Forms.Label();
            this.HamRateLabel = new System.Windows.Forms.Label();
            this.MargheritaRateLabel = new System.Windows.Forms.Label();
            this.MargheritaPizzatextBox = new System.Windows.Forms.TextBox();
            this.HamPineappleLabel = new System.Windows.Forms.Label();
            this.PepperoniPizzaTextBox = new System.Windows.Forms.TextBox();
            this.MargheritaPizzaLabel = new System.Windows.Forms.Label();
            this.HamPineappleTextBox = new System.Windows.Forms.TextBox();
            this.PepperoniPizzaLabel = new System.Windows.Forms.Label();
            this.PizzaPanel = new System.Windows.Forms.Panel();
            this.StartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SultLogo)).BeginInit();
            this.OverallPizzaPanel.SuspendLayout();
            this.FunctionPanel.SuspendLayout();
            this.OverallSummaryPanel.SuspendLayout();
            this.SummaryPanel.SuspendLayout();
            this.PanelOrder.SuspendLayout();
            this.OverallOrderPanel.SuspendLayout();
            this.PizzaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.AutoSize = true;
            this.ServerNameLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerNameLabel.Location = new System.Drawing.Point(26, 25);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new System.Drawing.Size(130, 20);
            this.ServerNameLabel.TabIndex = 0;
            this.ServerNameLabel.Text = "Server\'s Name :";
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.Location = new System.Drawing.Point(162, 17);
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.Size = new System.Drawing.Size(223, 35);
            this.ServerNameTextBox.TabIndex = 1;
            this.ServerNameTextBox.TextChanged += new System.EventHandler(this.ServerNameTextBox_TextChanged);
            this.ServerNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerNameTextBox_KeyPress);
            // 
            // TableNoLabel
            // 
            this.TableNoLabel.AutoSize = true;
            this.TableNoLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNoLabel.Location = new System.Drawing.Point(431, 25);
            this.TableNoLabel.Name = "TableNoLabel";
            this.TableNoLabel.Size = new System.Drawing.Size(88, 20);
            this.TableNoLabel.TabIndex = 2;
            this.TableNoLabel.Text = "Table No :";
            // 
            // TableNoTextBox
            // 
            this.TableNoTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.TableNoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNoTextBox.Location = new System.Drawing.Point(525, 17);
            this.TableNoTextBox.Name = "TableNoTextBox";
            this.TableNoTextBox.Size = new System.Drawing.Size(80, 35);
            this.TableNoTextBox.TabIndex = 3;
            this.TableNoTextBox.TextChanged += new System.EventHandler(this.TableNoTextBox_TextChanged);
            this.TableNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TableNoTextBox_KeyPress);
            // 
            // ToolTips
            // 
            this.ToolTips.AutoPopDelay = 5000;
            this.ToolTips.InitialDelay = 100;
            this.ToolTips.IsBalloon = true;
            this.ToolTips.ReshowDelay = 100;
            this.ToolTips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.StartButton.Location = new System.Drawing.Point(669, 21);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(102, 28);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartPanel.Controls.Add(this.ServerNameLabel);
            this.StartPanel.Controls.Add(this.StartButton);
            this.StartPanel.Controls.Add(this.ServerNameTextBox);
            this.StartPanel.Controls.Add(this.TableNoTextBox);
            this.StartPanel.Controls.Add(this.TableNoLabel);
            this.StartPanel.Location = new System.Drawing.Point(75, 26);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(794, 64);
            this.StartPanel.TabIndex = 5;
            // 
            // SultLogo
            // 
            this.SultLogo.Image = ((System.Drawing.Image)(resources.GetObject("SultLogo.Image")));
            this.SultLogo.Location = new System.Drawing.Point(303, 582);
            this.SultLogo.Name = "SultLogo";
            this.SultLogo.Size = new System.Drawing.Size(255, 82);
            this.SultLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SultLogo.TabIndex = 6;
            this.SultLogo.TabStop = false;
            this.SultLogo.Visible = false;
            // 
            // PizzaMenuLabel
            // 
            this.PizzaMenuLabel.AutoSize = true;
            this.PizzaMenuLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PizzaMenuLabel.Location = new System.Drawing.Point(56, 13);
            this.PizzaMenuLabel.Name = "PizzaMenuLabel";
            this.PizzaMenuLabel.Size = new System.Drawing.Size(130, 26);
            this.PizzaMenuLabel.TabIndex = 15;
            this.PizzaMenuLabel.Text = "Pizza Menu";
            // 
            // OverallPizzaPanel
            // 
            this.OverallPizzaPanel.Controls.Add(this.PizzaMenuLabel);
            this.OverallPizzaPanel.Controls.Add(this.PizzaPanel);
            this.OverallPizzaPanel.Location = new System.Drawing.Point(79, 12);
            this.OverallPizzaPanel.Name = "OverallPizzaPanel";
            this.OverallPizzaPanel.Size = new System.Drawing.Size(714, 236);
            this.OverallPizzaPanel.TabIndex = 16;
            this.OverallPizzaPanel.Visible = false;
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FunctionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FunctionPanel.Controls.Add(this.ExitButton);
            this.FunctionPanel.Controls.Add(this.SummaryButton);
            this.FunctionPanel.Controls.Add(this.ClearButton);
            this.FunctionPanel.Controls.Add(this.OrderButton);
            this.FunctionPanel.Location = new System.Drawing.Point(165, 254);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(522, 57);
            this.FunctionPanel.TabIndex = 17;
            this.FunctionPanel.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ExitButton.Location = new System.Drawing.Point(397, 13);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(108, 30);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SummaryButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.SummaryButton.Location = new System.Drawing.Point(269, 13);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(122, 30);
            this.SummaryButton.TabIndex = 18;
            this.SummaryButton.Text = "&Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ClearButton.Location = new System.Drawing.Point(141, 13);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(122, 30);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.OrderButton.Location = new System.Drawing.Point(13, 13);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(122, 30);
            this.OrderButton.TabIndex = 0;
            this.OrderButton.Text = "&Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // OverallSummaryPanel
            // 
            this.OverallSummaryPanel.Controls.Add(this.CompanySummaryDataLabel);
            this.OverallSummaryPanel.Controls.Add(this.SummaryPanel);
            this.OverallSummaryPanel.Location = new System.Drawing.Point(95, 317);
            this.OverallSummaryPanel.Name = "OverallSummaryPanel";
            this.OverallSummaryPanel.Size = new System.Drawing.Size(698, 253);
            this.OverallSummaryPanel.TabIndex = 27;
            this.OverallSummaryPanel.Visible = false;
            // 
            // CompanySummaryDataLabel
            // 
            this.CompanySummaryDataLabel.AutoSize = true;
            this.CompanySummaryDataLabel.Location = new System.Drawing.Point(45, 17);
            this.CompanySummaryDataLabel.Name = "CompanySummaryDataLabel";
            this.CompanySummaryDataLabel.Size = new System.Drawing.Size(270, 26);
            this.CompanySummaryDataLabel.TabIndex = 0;
            this.CompanySummaryDataLabel.Text = "Company Summary Data";
            // 
            // SummaryPanel
            // 
            this.SummaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryPanel.Controls.Add(this.AvgTranscationValueDisplayLabel);
            this.SummaryPanel.Controls.Add(this.TotalCompanyReceiptsDisplayLabel);
            this.SummaryPanel.Controls.Add(this.TotalCompanyPizzaDisplayLabel);
            this.SummaryPanel.Controls.Add(this.TotalCompanyTranscationsDisplayLabel);
            this.SummaryPanel.Controls.Add(this.AverageTranscationValueLabel);
            this.SummaryPanel.Controls.Add(this.TotalCompanyReceiptsLabel);
            this.SummaryPanel.Controls.Add(this.TotalCompanyPizzaLabel);
            this.SummaryPanel.Controls.Add(this.TotalCompanyTranscationsLabel);
            this.SummaryPanel.Location = new System.Drawing.Point(24, 27);
            this.SummaryPanel.Name = "SummaryPanel";
            this.SummaryPanel.Size = new System.Drawing.Size(606, 213);
            this.SummaryPanel.TabIndex = 0;
            // 
            // AvgTranscationValueDisplayLabel
            // 
            this.AvgTranscationValueDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AvgTranscationValueDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvgTranscationValueDisplayLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.AvgTranscationValueDisplayLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.AvgTranscationValueDisplayLabel.Location = new System.Drawing.Point(330, 157);
            this.AvgTranscationValueDisplayLabel.Name = "AvgTranscationValueDisplayLabel";
            this.AvgTranscationValueDisplayLabel.Size = new System.Drawing.Size(250, 27);
            this.AvgTranscationValueDisplayLabel.TabIndex = 25;
            this.AvgTranscationValueDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCompanyReceiptsDisplayLabel
            // 
            this.TotalCompanyReceiptsDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalCompanyReceiptsDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCompanyReceiptsDisplayLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.TotalCompanyReceiptsDisplayLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.TotalCompanyReceiptsDisplayLabel.Location = new System.Drawing.Point(330, 111);
            this.TotalCompanyReceiptsDisplayLabel.Name = "TotalCompanyReceiptsDisplayLabel";
            this.TotalCompanyReceiptsDisplayLabel.Size = new System.Drawing.Size(250, 27);
            this.TotalCompanyReceiptsDisplayLabel.TabIndex = 24;
            this.TotalCompanyReceiptsDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCompanyPizzaDisplayLabel
            // 
            this.TotalCompanyPizzaDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalCompanyPizzaDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCompanyPizzaDisplayLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.TotalCompanyPizzaDisplayLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.TotalCompanyPizzaDisplayLabel.Location = new System.Drawing.Point(330, 71);
            this.TotalCompanyPizzaDisplayLabel.Name = "TotalCompanyPizzaDisplayLabel";
            this.TotalCompanyPizzaDisplayLabel.Size = new System.Drawing.Size(250, 27);
            this.TotalCompanyPizzaDisplayLabel.TabIndex = 23;
            this.TotalCompanyPizzaDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCompanyTranscationsDisplayLabel
            // 
            this.TotalCompanyTranscationsDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalCompanyTranscationsDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCompanyTranscationsDisplayLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.TotalCompanyTranscationsDisplayLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.TotalCompanyTranscationsDisplayLabel.Location = new System.Drawing.Point(330, 32);
            this.TotalCompanyTranscationsDisplayLabel.Name = "TotalCompanyTranscationsDisplayLabel";
            this.TotalCompanyTranscationsDisplayLabel.Size = new System.Drawing.Size(250, 27);
            this.TotalCompanyTranscationsDisplayLabel.TabIndex = 22;
            this.TotalCompanyTranscationsDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AverageTranscationValueLabel
            // 
            this.AverageTranscationValueLabel.AutoSize = true;
            this.AverageTranscationValueLabel.Location = new System.Drawing.Point(21, 157);
            this.AverageTranscationValueLabel.Name = "AverageTranscationValueLabel";
            this.AverageTranscationValueLabel.Size = new System.Drawing.Size(241, 26);
            this.AverageTranscationValueLabel.TabIndex = 4;
            this.AverageTranscationValueLabel.Text = "Avg Transcation Value";
            // 
            // TotalCompanyReceiptsLabel
            // 
            this.TotalCompanyReceiptsLabel.AutoSize = true;
            this.TotalCompanyReceiptsLabel.Location = new System.Drawing.Point(21, 111);
            this.TotalCompanyReceiptsLabel.Name = "TotalCompanyReceiptsLabel";
            this.TotalCompanyReceiptsLabel.Size = new System.Drawing.Size(261, 26);
            this.TotalCompanyReceiptsLabel.TabIndex = 3;
            this.TotalCompanyReceiptsLabel.Text = "Total Company Receipts";
            // 
            // TotalCompanyPizzaLabel
            // 
            this.TotalCompanyPizzaLabel.AutoSize = true;
            this.TotalCompanyPizzaLabel.Location = new System.Drawing.Point(21, 71);
            this.TotalCompanyPizzaLabel.Name = "TotalCompanyPizzaLabel";
            this.TotalCompanyPizzaLabel.Size = new System.Drawing.Size(242, 26);
            this.TotalCompanyPizzaLabel.TabIndex = 2;
            this.TotalCompanyPizzaLabel.Text = "Total Company Pizza\'s";
            // 
            // TotalCompanyTranscationsLabel
            // 
            this.TotalCompanyTranscationsLabel.AutoSize = true;
            this.TotalCompanyTranscationsLabel.Location = new System.Drawing.Point(21, 32);
            this.TotalCompanyTranscationsLabel.Name = "TotalCompanyTranscationsLabel";
            this.TotalCompanyTranscationsLabel.Size = new System.Drawing.Size(304, 26);
            this.TotalCompanyTranscationsLabel.TabIndex = 1;
            this.TotalCompanyTranscationsLabel.Text = "Total Company Transcations";
            // 
            // PanelOrder
            // 
            this.PanelOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOrder.Controls.Add(this.OrderServerNameLabel);
            this.PanelOrder.Controls.Add(this.OrderTotalTableReceiptsLabel);
            this.PanelOrder.Controls.Add(this.OrderTotalNumberOfPizza);
            this.PanelOrder.Controls.Add(this.OrderTotalNumberOfPizzaLabel);
            this.PanelOrder.Controls.Add(this.OrderTotalReceipts);
            this.PanelOrder.Controls.Add(this.OrderNameServerNameDisplayLabel);
            this.PanelOrder.Location = new System.Drawing.Point(13, 22);
            this.PanelOrder.Name = "PanelOrder";
            this.PanelOrder.Size = new System.Drawing.Size(631, 223);
            this.PanelOrder.TabIndex = 25;
            // 
            // OrderServerNameLabel
            // 
            this.OrderServerNameLabel.AutoSize = true;
            this.OrderServerNameLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.OrderServerNameLabel.Location = new System.Drawing.Point(26, 38);
            this.OrderServerNameLabel.Name = "OrderServerNameLabel";
            this.OrderServerNameLabel.Size = new System.Drawing.Size(135, 25);
            this.OrderServerNameLabel.TabIndex = 18;
            this.OrderServerNameLabel.Text = "Server Name";
            // 
            // OrderTotalTableReceiptsLabel
            // 
            this.OrderTotalTableReceiptsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderTotalTableReceiptsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderTotalTableReceiptsLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.OrderTotalTableReceiptsLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.OrderTotalTableReceiptsLabel.Location = new System.Drawing.Point(353, 156);
            this.OrderTotalTableReceiptsLabel.Name = "OrderTotalTableReceiptsLabel";
            this.OrderTotalTableReceiptsLabel.Size = new System.Drawing.Size(250, 27);
            this.OrderTotalTableReceiptsLabel.TabIndex = 23;
            this.OrderTotalTableReceiptsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderTotalNumberOfPizza
            // 
            this.OrderTotalNumberOfPizza.AutoSize = true;
            this.OrderTotalNumberOfPizza.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.OrderTotalNumberOfPizza.Location = new System.Drawing.Point(26, 95);
            this.OrderTotalNumberOfPizza.Name = "OrderTotalNumberOfPizza";
            this.OrderTotalNumberOfPizza.Size = new System.Drawing.Size(213, 25);
            this.OrderTotalNumberOfPizza.TabIndex = 19;
            this.OrderTotalNumberOfPizza.Text = "Total Number Pizza\'s";
            // 
            // OrderTotalNumberOfPizzaLabel
            // 
            this.OrderTotalNumberOfPizzaLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderTotalNumberOfPizzaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderTotalNumberOfPizzaLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.OrderTotalNumberOfPizzaLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.OrderTotalNumberOfPizzaLabel.Location = new System.Drawing.Point(353, 95);
            this.OrderTotalNumberOfPizzaLabel.Name = "OrderTotalNumberOfPizzaLabel";
            this.OrderTotalNumberOfPizzaLabel.Size = new System.Drawing.Size(250, 27);
            this.OrderTotalNumberOfPizzaLabel.TabIndex = 22;
            this.OrderTotalNumberOfPizzaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderTotalReceipts
            // 
            this.OrderTotalReceipts.AutoSize = true;
            this.OrderTotalReceipts.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.OrderTotalReceipts.Location = new System.Drawing.Point(26, 156);
            this.OrderTotalReceipts.Name = "OrderTotalReceipts";
            this.OrderTotalReceipts.Size = new System.Drawing.Size(203, 25);
            this.OrderTotalReceipts.TabIndex = 20;
            this.OrderTotalReceipts.Text = "Total Table Receipts";
            // 
            // OrderNameServerNameDisplayLabel
            // 
            this.OrderNameServerNameDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderNameServerNameDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderNameServerNameDisplayLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.OrderNameServerNameDisplayLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.OrderNameServerNameDisplayLabel.Location = new System.Drawing.Point(353, 38);
            this.OrderNameServerNameDisplayLabel.Name = "OrderNameServerNameDisplayLabel";
            this.OrderNameServerNameDisplayLabel.Size = new System.Drawing.Size(250, 27);
            this.OrderNameServerNameDisplayLabel.TabIndex = 21;
            this.OrderNameServerNameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableOrderSummaryDataLabel
            // 
            this.TableOrderSummaryDataLabel.AutoSize = true;
            this.TableOrderSummaryDataLabel.Location = new System.Drawing.Point(31, 11);
            this.TableOrderSummaryDataLabel.Name = "TableOrderSummaryDataLabel";
            this.TableOrderSummaryDataLabel.Size = new System.Drawing.Size(299, 26);
            this.TableOrderSummaryDataLabel.TabIndex = 24;
            this.TableOrderSummaryDataLabel.Text = "Table Order Summary Data";
            // 
            // OverallOrderPanel
            // 
            this.OverallOrderPanel.Controls.Add(this.TableOrderSummaryDataLabel);
            this.OverallOrderPanel.Controls.Add(this.PanelOrder);
            this.OverallOrderPanel.Location = new System.Drawing.Point(119, 318);
            this.OverallOrderPanel.Name = "OverallOrderPanel";
            this.OverallOrderPanel.Size = new System.Drawing.Size(655, 264);
            this.OverallOrderPanel.TabIndex = 28;
            this.OverallOrderPanel.Visible = false;
            // 
            // PepperoniRateLabel
            // 
            this.PepperoniRateLabel.AutoSize = true;
            this.PepperoniRateLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.PepperoniRateLabel.Location = new System.Drawing.Point(482, 85);
            this.PepperoniRateLabel.Name = "PepperoniRateLabel";
            this.PepperoniRateLabel.Size = new System.Drawing.Size(98, 25);
            this.PepperoniRateLabel.TabIndex = 11;
            this.PepperoniRateLabel.Text = "@ €11.50";
            // 
            // HamRateLabel
            // 
            this.HamRateLabel.AutoSize = true;
            this.HamRateLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.HamRateLabel.Location = new System.Drawing.Point(482, 134);
            this.HamRateLabel.Name = "HamRateLabel";
            this.HamRateLabel.Size = new System.Drawing.Size(99, 25);
            this.HamRateLabel.TabIndex = 12;
            this.HamRateLabel.Text = "@ €12.79";
            // 
            // MargheritaRateLabel
            // 
            this.MargheritaRateLabel.AutoSize = true;
            this.MargheritaRateLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.MargheritaRateLabel.Location = new System.Drawing.Point(482, 37);
            this.MargheritaRateLabel.Name = "MargheritaRateLabel";
            this.MargheritaRateLabel.Size = new System.Drawing.Size(60, 25);
            this.MargheritaRateLabel.TabIndex = 10;
            this.MargheritaRateLabel.Text = "@ €9";
            // 
            // MargheritaPizzatextBox
            // 
            this.MargheritaPizzatextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MargheritaPizzatextBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.MargheritaPizzatextBox.Location = new System.Drawing.Point(325, 37);
            this.MargheritaPizzatextBox.Name = "MargheritaPizzatextBox";
            this.MargheritaPizzatextBox.Size = new System.Drawing.Size(80, 33);
            this.MargheritaPizzatextBox.TabIndex = 5;
            this.MargheritaPizzatextBox.Text = "0";
            this.MargheritaPizzatextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HamPineappleLabel
            // 
            this.HamPineappleLabel.AutoSize = true;
            this.HamPineappleLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.HamPineappleLabel.Location = new System.Drawing.Point(29, 134);
            this.HamPineappleLabel.Name = "HamPineappleLabel";
            this.HamPineappleLabel.Size = new System.Drawing.Size(157, 25);
            this.HamPineappleLabel.TabIndex = 9;
            this.HamPineappleLabel.Text = "Ham Pineapple";
            // 
            // PepperoniPizzaTextBox
            // 
            this.PepperoniPizzaTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PepperoniPizzaTextBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.PepperoniPizzaTextBox.Location = new System.Drawing.Point(325, 85);
            this.PepperoniPizzaTextBox.Name = "PepperoniPizzaTextBox";
            this.PepperoniPizzaTextBox.Size = new System.Drawing.Size(80, 33);
            this.PepperoniPizzaTextBox.TabIndex = 13;
            this.PepperoniPizzaTextBox.Text = "0";
            this.PepperoniPizzaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MargheritaPizzaLabel
            // 
            this.MargheritaPizzaLabel.AutoSize = true;
            this.MargheritaPizzaLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.MargheritaPizzaLabel.Location = new System.Drawing.Point(29, 37);
            this.MargheritaPizzaLabel.Name = "MargheritaPizzaLabel";
            this.MargheritaPizzaLabel.Size = new System.Drawing.Size(173, 25);
            this.MargheritaPizzaLabel.TabIndex = 7;
            this.MargheritaPizzaLabel.Text = "Margherita Pizza";
            // 
            // HamPineappleTextBox
            // 
            this.HamPineappleTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.HamPineappleTextBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.HamPineappleTextBox.Location = new System.Drawing.Point(325, 130);
            this.HamPineappleTextBox.Name = "HamPineappleTextBox";
            this.HamPineappleTextBox.Size = new System.Drawing.Size(80, 33);
            this.HamPineappleTextBox.TabIndex = 14;
            this.HamPineappleTextBox.Text = "0";
            this.HamPineappleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PepperoniPizzaLabel
            // 
            this.PepperoniPizzaLabel.AutoSize = true;
            this.PepperoniPizzaLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.PepperoniPizzaLabel.Location = new System.Drawing.Point(29, 85);
            this.PepperoniPizzaLabel.Name = "PepperoniPizzaLabel";
            this.PepperoniPizzaLabel.Size = new System.Drawing.Size(163, 25);
            this.PepperoniPizzaLabel.TabIndex = 8;
            this.PepperoniPizzaLabel.Text = "Pepperoni Pizza";
            // 
            // PizzaPanel
            // 
            this.PizzaPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PizzaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PizzaPanel.Controls.Add(this.PepperoniPizzaLabel);
            this.PizzaPanel.Controls.Add(this.HamPineappleTextBox);
            this.PizzaPanel.Controls.Add(this.MargheritaPizzaLabel);
            this.PizzaPanel.Controls.Add(this.PepperoniPizzaTextBox);
            this.PizzaPanel.Controls.Add(this.HamPineappleLabel);
            this.PizzaPanel.Controls.Add(this.MargheritaPizzatextBox);
            this.PizzaPanel.Controls.Add(this.MargheritaRateLabel);
            this.PizzaPanel.Controls.Add(this.HamRateLabel);
            this.PizzaPanel.Controls.Add(this.PepperoniRateLabel);
            this.PizzaPanel.Location = new System.Drawing.Point(26, 27);
            this.PizzaPanel.Name = "PizzaPanel";
            this.PizzaPanel.Size = new System.Drawing.Size(641, 188);
            this.PizzaPanel.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 754);
            this.Controls.Add(this.OverallOrderPanel);
            this.Controls.Add(this.OverallSummaryPanel);
            this.Controls.Add(this.FunctionPanel);
            this.Controls.Add(this.OverallPizzaPanel);
            this.Controls.Add(this.SultLogo);
            this.Controls.Add(this.StartPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Sult";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SultLogo)).EndInit();
            this.OverallPizzaPanel.ResumeLayout(false);
            this.OverallPizzaPanel.PerformLayout();
            this.FunctionPanel.ResumeLayout(false);
            this.OverallSummaryPanel.ResumeLayout(false);
            this.OverallSummaryPanel.PerformLayout();
            this.SummaryPanel.ResumeLayout(false);
            this.SummaryPanel.PerformLayout();
            this.PanelOrder.ResumeLayout(false);
            this.PanelOrder.PerformLayout();
            this.OverallOrderPanel.ResumeLayout(false);
            this.OverallOrderPanel.PerformLayout();
            this.PizzaPanel.ResumeLayout(false);
            this.PizzaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ServerNameLabel;
        private System.Windows.Forms.TextBox ServerNameTextBox;
        private System.Windows.Forms.Label TableNoLabel;
        private System.Windows.Forms.TextBox TableNoTextBox;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.PictureBox SultLogo;
        private System.Windows.Forms.Label PizzaMenuLabel;
        private System.Windows.Forms.Panel OverallPizzaPanel;
        private System.Windows.Forms.Panel FunctionPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Panel OverallSummaryPanel;
        private System.Windows.Forms.Label CompanySummaryDataLabel;
        private System.Windows.Forms.Panel SummaryPanel;
        private System.Windows.Forms.Label TotalCompanyTranscationsLabel;
        private System.Windows.Forms.Label AvgTranscationValueDisplayLabel;
        private System.Windows.Forms.Label TotalCompanyReceiptsDisplayLabel;
        private System.Windows.Forms.Label TotalCompanyPizzaDisplayLabel;
        private System.Windows.Forms.Label TotalCompanyTranscationsDisplayLabel;
        private System.Windows.Forms.Label AverageTranscationValueLabel;
        private System.Windows.Forms.Label TotalCompanyReceiptsLabel;
        private System.Windows.Forms.Label TotalCompanyPizzaLabel;
        private System.Windows.Forms.Panel PanelOrder;
        private System.Windows.Forms.Label TableOrderSummaryDataLabel;
        private System.Windows.Forms.Label OrderServerNameLabel;
        private System.Windows.Forms.Label OrderTotalTableReceiptsLabel;
        private System.Windows.Forms.Label OrderTotalNumberOfPizza;
        private System.Windows.Forms.Label OrderTotalNumberOfPizzaLabel;
        private System.Windows.Forms.Label OrderTotalReceipts;
        private System.Windows.Forms.Label OrderNameServerNameDisplayLabel;
        private System.Windows.Forms.Panel OverallOrderPanel;
        private System.Windows.Forms.Panel PizzaPanel;
        private System.Windows.Forms.Label PepperoniPizzaLabel;
        private System.Windows.Forms.TextBox HamPineappleTextBox;
        private System.Windows.Forms.Label MargheritaPizzaLabel;
        private System.Windows.Forms.TextBox PepperoniPizzaTextBox;
        private System.Windows.Forms.Label HamPineappleLabel;
        private System.Windows.Forms.TextBox MargheritaPizzatextBox;
        private System.Windows.Forms.Label MargheritaRateLabel;
        private System.Windows.Forms.Label HamRateLabel;
        private System.Windows.Forms.Label PepperoniRateLabel;
    }
}

