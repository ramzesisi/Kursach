
namespace KP_App
{
    partial class KP_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KP_App));
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkspaceName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.decreaseSalaryButton = new System.Windows.Forms.Button();
            this.percentSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.increaseSalary = new System.Windows.Forms.Button();
            this.excelExportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculateTotalPaymentByWorkspace = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.workspaceComboBox = new System.Windows.Forms.ComboBox();
            this.averageMonthPaymentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPaymentTextBox = new System.Windows.Forms.TextBox();
            this.deleteSelectedRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Surname,
            this.WorkspaceName,
            this.Payment});
            this.mainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGridView.Location = new System.Drawing.Point(0, 0);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowHeadersWidth = 51;
            this.mainDataGridView.RowTemplate.Height = 24;
            this.mainDataGridView.Size = new System.Drawing.Size(1054, 401);
            this.mainDataGridView.TabIndex = 0;
            this.mainDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Табельный №";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            // 
            // WorkspaceName
            // 
            this.WorkspaceName.HeaderText = "Наименование цеха";
            this.WorkspaceName.Items.AddRange(new object[] {
            "Деревообработка",
            "Металлообработка",
            "Переработка отходов",
            "Сварочный",
            "Токарный"});
            this.WorkspaceName.MinimumWidth = 6;
            this.WorkspaceName.Name = "WorkspaceName";
            this.WorkspaceName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkspaceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Заработная плата";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.excelExportButton);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.deleteSelectedRowButton);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 640);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.decreaseSalaryButton);
            this.groupBox2.Controls.Add(this.percentSalaryTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.increaseSalary);
            this.groupBox2.Location = new System.Drawing.Point(382, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 131);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Увеличение/уменьшение ЗП";
            // 
            // decreaseSalaryButton
            // 
            this.decreaseSalaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.decreaseSalaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decreaseSalaryButton.Location = new System.Drawing.Point(119, 59);
            this.decreaseSalaryButton.Name = "decreaseSalaryButton";
            this.decreaseSalaryButton.Size = new System.Drawing.Size(101, 49);
            this.decreaseSalaryButton.TabIndex = 3;
            this.decreaseSalaryButton.Text = "Уменьшить зарплату";
            this.decreaseSalaryButton.UseVisualStyleBackColor = false;
            this.decreaseSalaryButton.Click += new System.EventHandler(this.decreaseSalaryButton_Click);
            // 
            // percentSalaryTextBox
            // 
            this.percentSalaryTextBox.Location = new System.Drawing.Point(96, 31);
            this.percentSalaryTextBox.Name = "percentSalaryTextBox";
            this.percentSalaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.percentSalaryTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Проценты";
            // 
            // increaseSalary
            // 
            this.increaseSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.increaseSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.increaseSalary.Location = new System.Drawing.Point(18, 59);
            this.increaseSalary.Name = "increaseSalary";
            this.increaseSalary.Size = new System.Drawing.Size(95, 49);
            this.increaseSalary.TabIndex = 0;
            this.increaseSalary.Text = "Увеличить зарплату";
            this.increaseSalary.UseVisualStyleBackColor = false;
            this.increaseSalary.Click += new System.EventHandler(this.increaseSalary_Click);
            // 
            // excelExportButton
            // 
            this.excelExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excelExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.excelExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excelExportButton.Location = new System.Drawing.Point(615, 61);
            this.excelExportButton.Name = "excelExportButton";
            this.excelExportButton.Size = new System.Drawing.Size(251, 36);
            this.excelExportButton.TabIndex = 9;
            this.excelExportButton.Text = "Экспорт в Excel";
            this.excelExportButton.UseVisualStyleBackColor = false;
            this.excelExportButton.Click += new System.EventHandler(this.excelExportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.calculateTotalPaymentByWorkspace);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.workspaceComboBox);
            this.groupBox1.Controls.Add(this.averageMonthPaymentTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.totalPaymentTextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выплаты заработной платы";
            // 
            // calculateTotalPaymentByWorkspace
            // 
            this.calculateTotalPaymentByWorkspace.BackColor = System.Drawing.Color.Fuchsia;
            this.calculateTotalPaymentByWorkspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateTotalPaymentByWorkspace.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateTotalPaymentByWorkspace.Location = new System.Drawing.Point(205, 15);
            this.calculateTotalPaymentByWorkspace.Name = "calculateTotalPaymentByWorkspace";
            this.calculateTotalPaymentByWorkspace.Size = new System.Drawing.Size(130, 49);
            this.calculateTotalPaymentByWorkspace.TabIndex = 1;
            this.calculateTotalPaymentByWorkspace.Text = "Вычислить выплаты по цеху";
            this.calculateTotalPaymentByWorkspace.UseVisualStyleBackColor = false;
            this.calculateTotalPaymentByWorkspace.Click += new System.EventHandler(this.calculateTotalPaymentByWorkspace_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Среднемесячный заработок";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // workspaceComboBox
            // 
            this.workspaceComboBox.FormattingEnabled = true;
            this.workspaceComboBox.Items.AddRange(new object[] {
            "Деревообработка",
            "Металлообработка",
            "Переработка отходов",
            "Сварочный",
            "Токарный"});
            this.workspaceComboBox.Location = new System.Drawing.Point(45, 28);
            this.workspaceComboBox.Name = "workspaceComboBox";
            this.workspaceComboBox.Size = new System.Drawing.Size(123, 24);
            this.workspaceComboBox.TabIndex = 2;
            // 
            // averageMonthPaymentTextBox
            // 
            this.averageMonthPaymentTextBox.Location = new System.Drawing.Point(208, 101);
            this.averageMonthPaymentTextBox.Name = "averageMonthPaymentTextBox";
            this.averageMonthPaymentTextBox.ReadOnly = true;
            this.averageMonthPaymentTextBox.Size = new System.Drawing.Size(127, 22);
            this.averageMonthPaymentTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цех";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Общая сумма выплат";
            // 
            // totalPaymentTextBox
            // 
            this.totalPaymentTextBox.Location = new System.Drawing.Point(208, 70);
            this.totalPaymentTextBox.Name = "totalPaymentTextBox";
            this.totalPaymentTextBox.ReadOnly = true;
            this.totalPaymentTextBox.Size = new System.Drawing.Size(127, 22);
            this.totalPaymentTextBox.TabIndex = 4;
            // 
            // deleteSelectedRowButton
            // 
            this.deleteSelectedRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSelectedRowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteSelectedRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSelectedRowButton.Location = new System.Drawing.Point(615, 19);
            this.deleteSelectedRowButton.Name = "deleteSelectedRowButton";
            this.deleteSelectedRowButton.Size = new System.Drawing.Size(251, 36);
            this.deleteSelectedRowButton.TabIndex = 0;
            this.deleteSelectedRowButton.Text = "Удалить выбранный ряд";
            this.deleteSelectedRowButton.UseVisualStyleBackColor = false;
            this.deleteSelectedRowButton.Click += new System.EventHandler(this.deleteSelectedRowButton_Click);
            // 
            // KP_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 640);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1072, 687);
            this.Name = "KP_App";
            this.Text = "Завод ";
            this.Load += new System.EventHandler(this.KP_App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button deleteSelectedRowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewComboBoxColumn WorkspaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.Button calculateTotalPaymentByWorkspace;
        private System.Windows.Forms.ComboBox workspaceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox averageMonthPaymentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalPaymentTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button excelExportButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button increaseSalary;
        private System.Windows.Forms.TextBox percentSalaryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button decreaseSalaryButton;
    }
}

