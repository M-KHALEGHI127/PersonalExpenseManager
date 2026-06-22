namespace Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            recordexpenses = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            labeldate = new Label();
            dtpDate = new DateTimePicker();
            txtAmount = new TextBox();
            labelcategory = new Label();
            cmbCategory = new ComboBox();
            labelAmount = new Label();
            txtTitle = new TextBox();
            labelTitle = new Label();
            dgvExpenses = new DataGridView();
            comboBox1 = new ComboBox();
            filter = new Label();
            Statistics = new GroupBox();
            txtBudget = new TextBox();
            labelBudget = new Label();
            labelPercent = new Label();
            labelMax = new Label();
            labelTotal = new Label();
            groupBox1 = new GroupBox();
            btndeletrow = new Button();
            btnsave = new Button();
            btnload = new Button();
            statusStrip1 = new StatusStrip();
            toolStripUser = new ToolStripStatusLabel();
            toolStripTime = new ToolStripStatusLabel();
            recordexpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            Statistics.SuspendLayout();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // recordexpenses
            // 
            recordexpenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            recordexpenses.BackColor = Color.Transparent;
            recordexpenses.Controls.Add(btnClear);
            recordexpenses.Controls.Add(btnAdd);
            recordexpenses.Controls.Add(labeldate);
            recordexpenses.Controls.Add(dtpDate);
            recordexpenses.Controls.Add(txtAmount);
            recordexpenses.Controls.Add(labelcategory);
            recordexpenses.Controls.Add(cmbCategory);
            recordexpenses.Controls.Add(labelAmount);
            recordexpenses.Controls.Add(txtTitle);
            recordexpenses.Controls.Add(labelTitle);
            recordexpenses.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordexpenses.Location = new Point(661, 10);
            recordexpenses.Name = "recordexpenses";
            recordexpenses.RightToLeft = RightToLeft.Yes;
            recordexpenses.Size = new Size(278, 362);
            recordexpenses.TabIndex = 0;
            recordexpenses.TabStop = false;
            recordexpenses.Text = "ثبت هزینه جدید";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = Color.White;
            btnClear.Location = new Point(17, 314);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 32);
            btnClear.TabIndex = 9;
            btnClear.Text = "پاک کردن";
            btnClear.TextAlign = ContentAlignment.TopCenter;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.Location = new Point(167, 314);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 32);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ثبت";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // labeldate
            // 
            labeldate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labeldate.AutoSize = true;
            labeldate.Location = new Point(186, 247);
            labeldate.Name = "labeldate";
            labeldate.Size = new Size(67, 20);
            labeldate.TabIndex = 7;
            labeldate.Text = "تاریخ ثبت";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(17, 275);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(243, 23);
            dtpDate.TabIndex = 6;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAmount.Location = new Point(17, 140);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Name = "txtAmount";
            txtAmount.RightToLeft = RightToLeft.No;
            txtAmount.Size = new Size(243, 27);
            txtAmount.TabIndex = 2;
            txtAmount.Tag = "";
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // labelcategory
            // 
            labelcategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelcategory.AutoSize = true;
            labelcategory.Location = new Point(180, 176);
            labelcategory.Name = "labelcategory";
            labelcategory.Size = new Size(76, 20);
            labelcategory.TabIndex = 5;
            labelcategory.Text = "دسته بندی";
            labelcategory.Click += labelcategory_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "متفرقه", "مسکن", "خوراک", "آموزش", "حمل و نقل", "تفریح" });
            cmbCategory.Location = new Point(17, 205);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(243, 27);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(130, 108);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(121, 20);
            labelAmount.TabIndex = 3;
            labelAmount.Text = "مقدار هزینه(ریال)";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTitle.Location = new Point(17, 59);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(243, 27);
            txtTitle.TabIndex = 1;
            txtTitle.Tag = "";
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(186, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(75, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "شرح هزینه";
            labelTitle.Click += labelTitle_Click;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToOrderColumns = true;
            dgvExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.BackgroundColor = SystemColors.ControlLightLight;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(5, 30);
            dgvExpenses.Margin = new Padding(3, 2, 3, 2);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(624, 266);
            dgvExpenses.TabIndex = 1;
            dgvExpenses.CellContentClick += dgvExpenses_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "همه", "متفرقه", "مسکن", "خوراک", "آموزش", "حمل و نقل", "تفریح" });
            comboBox1.Location = new Point(143, 323);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 27);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // filter
            // 
            filter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            filter.AutoSize = true;
            filter.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filter.Location = new Point(336, 323);
            filter.Name = "filter";
            filter.Size = new Size(109, 20);
            filter.TabIndex = 3;
            filter.Text = "فیلتر دسته بندی";
            // 
            // Statistics
            // 
            Statistics.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Statistics.Controls.Add(txtBudget);
            Statistics.Controls.Add(labelBudget);
            Statistics.Controls.Add(labelPercent);
            Statistics.Controls.Add(labelMax);
            Statistics.Controls.Add(labelTotal);
            Statistics.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Statistics.Location = new Point(10, 380);
            Statistics.Margin = new Padding(3, 2, 3, 2);
            Statistics.Name = "Statistics";
            Statistics.Padding = new Padding(3, 2, 3, 2);
            Statistics.RightToLeft = RightToLeft.Yes;
            Statistics.Size = new Size(929, 60);
            Statistics.TabIndex = 5;
            Statistics.TabStop = false;
            Statistics.Text = "بودجه";
            // 
            // txtBudget
            // 
            txtBudget.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBudget.Location = new Point(26, 29);
            txtBudget.Margin = new Padding(3, 2, 3, 2);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(149, 27);
            txtBudget.TabIndex = 5;
            txtBudget.TextChanged += txtBudget_TextChanged;
            // 
            // labelBudget
            // 
            labelBudget.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelBudget.AutoSize = true;
            labelBudget.Location = new Point(180, 32);
            labelBudget.Name = "labelBudget";
            labelBudget.Size = new Size(95, 20);
            labelBudget.TabIndex = 4;
            labelBudget.Text = "بودجه ماهانه:";
            // 
            // labelPercent
            // 
            labelPercent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPercent.AutoSize = true;
            labelPercent.Location = new Point(298, 34);
            labelPercent.Name = "labelPercent";
            labelPercent.Size = new Size(119, 20);
            labelPercent.TabIndex = 3;
            labelPercent.Text = "درصد: 0%           ";
            labelPercent.Click += labelPercent_Click;
            // 
            // labelMax
            // 
            labelMax.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelMax.AutoSize = true;
            labelMax.Location = new Point(448, 34);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(188, 20);
            labelMax.TabIndex = 2;
            labelMax.Text = "بیشترین: 0                            ";
            labelMax.Click += labelMax_Click;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(678, 34);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(214, 20);
            labelTotal.TabIndex = 1;
            labelTotal.Text = "مجموع: 0                                    ";
            labelTotal.Click += labelTotal_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btndeletrow);
            groupBox1.Controls.Add(dgvExpenses);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(filter);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(634, 362);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "جدول";
            // 
            // btndeletrow
            // 
            btndeletrow.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btndeletrow.BackColor = Color.White;
            btndeletrow.Location = new Point(491, 314);
            btndeletrow.Margin = new Padding(3, 2, 3, 2);
            btndeletrow.Name = "btndeletrow";
            btndeletrow.Size = new Size(96, 32);
            btndeletrow.TabIndex = 10;
            btndeletrow.Text = "پاک کن";
            btndeletrow.TextAlign = ContentAlignment.TopCenter;
            btndeletrow.UseVisualStyleBackColor = false;
            btndeletrow.Click += btndeletrow_Click;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnsave.BackColor = Color.White;
            btnsave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(830, 441);
            btnsave.Margin = new Padding(3, 2, 3, 2);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(92, 32);
            btnsave.TabIndex = 10;
            btnsave.Text = "ذخیره ";
            btnsave.TextAlign = ContentAlignment.TopCenter;
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btnload
            // 
            btnload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnload.BackColor = Color.White;
            btnload.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnload.Location = new Point(682, 441);
            btnload.Margin = new Padding(3, 2, 3, 2);
            btnload.Name = "btnload";
            btnload.Size = new Size(92, 32);
            btnload.TabIndex = 11;
            btnload.Text = "دریافت";
            btnload.TextAlign = ContentAlignment.TopCenter;
            btnload.UseVisualStyleBackColor = false;
            btnload.Click += btnload_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripUser, toolStripTime });
            statusStrip1.Location = new Point(10, 452);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(93, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripUser
            // 
            toolStripUser.Name = "toolStripUser";
            toolStripUser.Size = new Size(39, 17);
            toolStripUser.Text = "نمایش";
            toolStripUser.Click += toolStripUser_Click;
            // 
            // toolStripTime
            // 
            toolStripTime.Name = "toolStripTime";
            toolStripTime.Size = new Size(39, 17);
            toolStripTime.Text = "نمایش";
            toolStripTime.Click += toolStripTime_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(949, 482);
            Controls.Add(statusStrip1);
            Controls.Add(btnload);
            Controls.Add(btnsave);
            Controls.Add(groupBox1);
            Controls.Add(Statistics);
            Controls.Add(recordexpenses);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            recordexpenses.ResumeLayout(false);
            recordexpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            Statistics.ResumeLayout(false);
            Statistics.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox recordexpenses;
        private Label labelTitle;
        private TextBox txtTitle;
        private Label labelAmount;
        private Label labelcategory;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private Label labeldate;
        private DateTimePicker dtpDate;
        private Button btnClear;
        private DataGridView dgvExpenses;
        private ComboBox comboBox1;
        private Label filter;
        private TextBox txtAmount;
        private GroupBox Statistics;
        private Label labelBudget;
        private Label labelPercent;
        private Label labelMax;
        private Label labelTotal;
        private TextBox txtBudget;
        private GroupBox groupBox1;
        private Button btndeletrow;
        private Button btnsave;
        private Button btnload;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripUser;
        private ToolStripStatusLabel toolStripTime;
    }
}