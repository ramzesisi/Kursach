
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
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkspaceName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculateTotalPaymentByWorkspace = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.workspaceComboBox = new System.Windows.Forms.ComboBox();
            this.averageMonthPaymentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPaymentTextBox = new System.Windows.Forms.TextBox();
            this.deleteSelectedRowButton = new System.Windows.Forms.Button();
            this.excelExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
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
            this.mainDataGridView.Size = new System.Drawing.Size(707, 395);
            this.mainDataGridView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "Табельный №";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
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
            this.WorkspaceName.Width = 125;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Заработная плата";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            this.Payment.Width = 125;
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
            this.splitContainer1.Panel2.Controls.Add(this.excelExportButton);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.deleteSelectedRowButton);
            this.splitContainer1.Size = new System.Drawing.Size(707, 630);
            this.splitContainer1.SplitterDistance = 395;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calculateTotalPaymentByWorkspace);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.workspaceComboBox);
            this.groupBox1.Controls.Add(this.averageMonthPaymentTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.totalPaymentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выплаты заработной платы";
            // 
            // calculateTotalPaymentByWorkspace
            // 
            this.calculateTotalPaymentByWorkspace.Location = new System.Drawing.Point(6, 58);
            this.calculateTotalPaymentByWorkspace.Name = "calculateTotalPaymentByWorkspace";
            this.calculateTotalPaymentByWorkspace.Size = new System.Drawing.Size(302, 38);
            this.calculateTotalPaymentByWorkspace.TabIndex = 1;
            this.calculateTotalPaymentByWorkspace.Text = "Вычислиты выплаты по цеху";
            this.calculateTotalPaymentByWorkspace.UseVisualStyleBackColor = true;
            this.calculateTotalPaymentByWorkspace.Click += new System.EventHandler(this.calculateTotalPaymentByWorkspace_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Среднемесячный заработок";
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
            this.workspaceComboBox.Location = new System.Drawing.Point(187, 28);
            this.workspaceComboBox.Name = "workspaceComboBox";
            this.workspaceComboBox.Size = new System.Drawing.Size(121, 24);
            this.workspaceComboBox.TabIndex = 2;
            // 
            // averageMonthPaymentTextBox
            // 
            this.averageMonthPaymentTextBox.Location = new System.Drawing.Point(207, 132);
            this.averageMonthPaymentTextBox.Name = "averageMonthPaymentTextBox";
            this.averageMonthPaymentTextBox.ReadOnly = true;
            this.averageMonthPaymentTextBox.Size = new System.Drawing.Size(100, 22);
            this.averageMonthPaymentTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цех";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Общая сумма выплат";
            // 
            // totalPaymentTextBox
            // 
            this.totalPaymentTextBox.Location = new System.Drawing.Point(207, 107);
            this.totalPaymentTextBox.Name = "totalPaymentTextBox";
            this.totalPaymentTextBox.ReadOnly = true;
            this.totalPaymentTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalPaymentTextBox.TabIndex = 4;
            // 
            // deleteSelectedRowButton
            // 
            this.deleteSelectedRowButton.BackColor = System.Drawing.Color.Red;
            this.deleteSelectedRowButton.Location = new System.Drawing.Point(428, 19);
            this.deleteSelectedRowButton.Name = "deleteSelectedRowButton";
            this.deleteSelectedRowButton.Size = new System.Drawing.Size(251, 36);
            this.deleteSelectedRowButton.TabIndex = 0;
            this.deleteSelectedRowButton.Text = "Удалить выбранный ряд";
            this.deleteSelectedRowButton.UseVisualStyleBackColor = false;
            this.deleteSelectedRowButton.Click += new System.EventHandler(this.deleteSelectedRowButton_Click);
            // 
            // excelExportButton
            // 
            this.excelExportButton.Location = new System.Drawing.Point(428, 140);
            this.excelExportButton.Name = "excelExportButton";
            this.excelExportButton.Size = new System.Drawing.Size(251, 36);
            this.excelExportButton.TabIndex = 9;
            this.excelExportButton.Text = "Экспорт в Excel";
            this.excelExportButton.UseVisualStyleBackColor = true;
            this.excelExportButton.Click += new System.EventHandler(this.excelExportButton_Click);
            // 
            // KP_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 630);
            this.Controls.Add(this.splitContainer1);
            this.Name = "KP_App";
            this.Text = "Завод ";
            this.Load += new System.EventHandler(this.KP_App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}

