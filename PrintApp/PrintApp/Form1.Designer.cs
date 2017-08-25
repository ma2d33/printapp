namespace PrintApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.оплаченToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бракToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfPGS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDefectLable = new System.Windows.Forms.Label();
            this.colorDefectControl = new System.Windows.Forms.NumericUpDown();
            this.BWdefect = new System.Windows.Forms.Label();
            this.defectControl = new System.Windows.Forms.NumericUpDown();
            this.otherSummTextBox = new System.Windows.Forms.TextBox();
            this.totalSummLable = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.colourCheckBox = new System.Windows.Forms.CheckBox();
            this.brakCheckBox = new System.Windows.Forms.CheckBox();
            this.threRubCheckBox = new System.Windows.Forms.CheckBox();
            this.fourRubCheckBox = new System.Windows.Forms.CheckBox();
            this.sixRubCheckBox = new System.Windows.Forms.CheckBox();
            this.nineRubCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalShiftSummLBL = new System.Windows.Forms.Label();
            this.endShiftButton = new System.Windows.Forms.Button();
            this.timeNow = new System.Windows.Forms.Label();
            this.shiftLable = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.printViewGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.payedGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorDefectControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectControl)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printViewGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "testText";
            this.notifyIcon1.BalloonTipTitle = "Внимание!!!";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оплаченToolStripMenuItem,
            this.бракToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 48);
            // 
            // оплаченToolStripMenuItem
            // 
            this.оплаченToolStripMenuItem.Name = "оплаченToolStripMenuItem";
            this.оплаченToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.оплаченToolStripMenuItem.Text = "Оплачен";
            this.оплаченToolStripMenuItem.Click += new System.EventHandler(this.okButton_Click);
            // 
            // бракToolStripMenuItem
            // 
            this.бракToolStripMenuItem.Name = "бракToolStripMenuItem";
            this.бракToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.бракToolStripMenuItem.Text = "Брак";
            this.бракToolStripMenuItem.Click += new System.EventHandler(this.бракToolStripMenuItem_Click);
            // 
            // numberOfPGS
            // 
            this.numberOfPGS.AutoSize = true;
            this.numberOfPGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.numberOfPGS.Location = new System.Drawing.Point(627, 50);
            this.numberOfPGS.Name = "numberOfPGS";
            this.numberOfPGS.Size = new System.Drawing.Size(0, 53);
            this.numberOfPGS.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.colorDefectLable);
            this.panel1.Controls.Add(this.colorDefectControl);
            this.panel1.Controls.Add(this.BWdefect);
            this.panel1.Controls.Add(this.defectControl);
            this.panel1.Controls.Add(this.numberOfPGS);
            this.panel1.Controls.Add(this.otherSummTextBox);
            this.panel1.Controls.Add(this.totalSummLable);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.colourCheckBox);
            this.panel1.Controls.Add(this.brakCheckBox);
            this.panel1.Controls.Add(this.threRubCheckBox);
            this.panel1.Controls.Add(this.fourRubCheckBox);
            this.panel1.Controls.Add(this.sixRubCheckBox);
            this.panel1.Controls.Add(this.nineRubCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 201);
            this.panel1.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 42;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // colorDefectLable
            // 
            this.colorDefectLable.AutoSize = true;
            this.colorDefectLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorDefectLable.Location = new System.Drawing.Point(25, 13);
            this.colorDefectLable.Name = "colorDefectLable";
            this.colorDefectLable.Size = new System.Drawing.Size(185, 39);
            this.colorDefectLable.TabIndex = 41;
            this.colorDefectLable.Text = "Цвет Брак";
            // 
            // colorDefectControl
            // 
            this.colorDefectControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.colorDefectControl.Location = new System.Drawing.Point(32, 53);
            this.colorDefectControl.Name = "colorDefectControl";
            this.colorDefectControl.Size = new System.Drawing.Size(239, 53);
            this.colorDefectControl.TabIndex = 40;
            this.colorDefectControl.ValueChanged += new System.EventHandler(this.colorDefectControl_ValueChanged);
            // 
            // BWdefect
            // 
            this.BWdefect.AutoSize = true;
            this.BWdefect.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BWdefect.Location = new System.Drawing.Point(287, 10);
            this.BWdefect.Name = "BWdefect";
            this.BWdefect.Size = new System.Drawing.Size(152, 39);
            this.BWdefect.TabIndex = 39;
            this.BWdefect.Text = "ЧБ Брак";
            // 
            // defectControl
            // 
            this.defectControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.defectControl.Location = new System.Drawing.Point(294, 53);
            this.defectControl.Name = "defectControl";
            this.defectControl.Size = new System.Drawing.Size(239, 53);
            this.defectControl.TabIndex = 38;
            this.defectControl.ValueChanged += new System.EventHandler(this.defectControl_ValueChanged);
            // 
            // otherSummTextBox
            // 
            this.otherSummTextBox.Location = new System.Drawing.Point(133, 152);
            this.otherSummTextBox.Name = "otherSummTextBox";
            this.otherSummTextBox.Size = new System.Drawing.Size(40, 20);
            this.otherSummTextBox.TabIndex = 37;
            this.otherSummTextBox.TextChanged += new System.EventHandler(this.otherSummTextBox_TextChanged);
            // 
            // totalSummLable
            // 
            this.totalSummLable.AutoSize = true;
            this.totalSummLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSummLable.Location = new System.Drawing.Point(708, 53);
            this.totalSummLable.Name = "totalSummLable";
            this.totalSummLable.Size = new System.Drawing.Size(93, 29);
            this.totalSummLable.TabIndex = 36;
            this.totalSummLable.Text = "= 0 Руб";
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(713, 134);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(281, 55);
            this.okButton.TabIndex = 35;
            this.okButton.Text = "ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // colourCheckBox
            // 
            this.colourCheckBox.AutoSize = true;
            this.colourCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colourCheckBox.Location = new System.Drawing.Point(69, 155);
            this.colourCheckBox.Name = "colourCheckBox";
            this.colourCheckBox.Size = new System.Drawing.Size(49, 17);
            this.colourCheckBox.TabIndex = 34;
            this.colourCheckBox.Text = "цвет";
            this.colourCheckBox.UseVisualStyleBackColor = true;
            this.colourCheckBox.CheckedChanged += new System.EventHandler(this.colourCheckBox_CheckedChanged);
            // 
            // brakCheckBox
            // 
            this.brakCheckBox.AutoSize = true;
            this.brakCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brakCheckBox.Location = new System.Drawing.Point(14, 155);
            this.brakCheckBox.Name = "brakCheckBox";
            this.brakCheckBox.Size = new System.Drawing.Size(51, 17);
            this.brakCheckBox.TabIndex = 33;
            this.brakCheckBox.Text = "Брак";
            this.brakCheckBox.UseVisualStyleBackColor = true;
            this.brakCheckBox.CheckedChanged += new System.EventHandler(this.brakCheckBox_CheckedChanged);
            // 
            // threRubCheckBox
            // 
            this.threRubCheckBox.AutoSize = true;
            this.threRubCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threRubCheckBox.Location = new System.Drawing.Point(179, 113);
            this.threRubCheckBox.Name = "threRubCheckBox";
            this.threRubCheckBox.Size = new System.Drawing.Size(49, 17);
            this.threRubCheckBox.TabIndex = 32;
            this.threRubCheckBox.Text = "3руб";
            this.threRubCheckBox.UseVisualStyleBackColor = true;
            this.threRubCheckBox.CheckedChanged += new System.EventHandler(this.threRubCheckBox_CheckedChanged);
            // 
            // fourRubCheckBox
            // 
            this.fourRubCheckBox.AutoSize = true;
            this.fourRubCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourRubCheckBox.Location = new System.Drawing.Point(124, 113);
            this.fourRubCheckBox.Name = "fourRubCheckBox";
            this.fourRubCheckBox.Size = new System.Drawing.Size(49, 17);
            this.fourRubCheckBox.TabIndex = 31;
            this.fourRubCheckBox.Text = "4руб";
            this.fourRubCheckBox.UseVisualStyleBackColor = true;
            this.fourRubCheckBox.CheckedChanged += new System.EventHandler(this.fourRubCheckBox_CheckedChanged);
            // 
            // sixRubCheckBox
            // 
            this.sixRubCheckBox.AutoSize = true;
            this.sixRubCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixRubCheckBox.Location = new System.Drawing.Point(69, 113);
            this.sixRubCheckBox.Name = "sixRubCheckBox";
            this.sixRubCheckBox.Size = new System.Drawing.Size(49, 17);
            this.sixRubCheckBox.TabIndex = 30;
            this.sixRubCheckBox.Text = "6руб";
            this.sixRubCheckBox.UseVisualStyleBackColor = true;
            this.sixRubCheckBox.CheckedChanged += new System.EventHandler(this.sixRubCheckBox_CheckedChanged);
            // 
            // nineRubCheckBox
            // 
            this.nineRubCheckBox.AutoSize = true;
            this.nineRubCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineRubCheckBox.Location = new System.Drawing.Point(14, 113);
            this.nineRubCheckBox.Name = "nineRubCheckBox";
            this.nineRubCheckBox.Size = new System.Drawing.Size(49, 17);
            this.nineRubCheckBox.TabIndex = 29;
            this.nineRubCheckBox.Text = "9руб";
            this.nineRubCheckBox.UseVisualStyleBackColor = true;
            this.nineRubCheckBox.CheckedChanged += new System.EventHandler(this.nineRubCheckBox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalShiftSummLBL);
            this.panel2.Controls.Add(this.endShiftButton);
            this.panel2.Controls.Add(this.timeNow);
            this.panel2.Controls.Add(this.shiftLable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 78);
            this.panel2.TabIndex = 31;
            // 
            // totalShiftSummLBL
            // 
            this.totalShiftSummLBL.AutoSize = true;
            this.totalShiftSummLBL.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalShiftSummLBL.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.totalShiftSummLBL.Location = new System.Drawing.Point(650, 44);
            this.totalShiftSummLBL.Name = "totalShiftSummLBL";
            this.totalShiftSummLBL.Size = new System.Drawing.Size(58, 24);
            this.totalShiftSummLBL.TabIndex = 32;
            this.totalShiftSummLBL.Text = "time";
            this.totalShiftSummLBL.Click += new System.EventHandler(this.totalShiftSummLBL_Click);
            // 
            // endShiftButton
            // 
            this.endShiftButton.Location = new System.Drawing.Point(827, 19);
            this.endShiftButton.Name = "endShiftButton";
            this.endShiftButton.Size = new System.Drawing.Size(167, 49);
            this.endShiftButton.TabIndex = 30;
            this.endShiftButton.Text = "Смена";
            this.endShiftButton.UseVisualStyleBackColor = true;
            this.endShiftButton.Click += new System.EventHandler(this.endShiftButton_Click);
            // 
            // timeNow
            // 
            this.timeNow.AutoSize = true;
            this.timeNow.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNow.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.timeNow.Location = new System.Drawing.Point(152, 44);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(58, 24);
            this.timeNow.TabIndex = 26;
            this.timeNow.Text = "time";
            // 
            // shiftLable
            // 
            this.shiftLable.AutoSize = true;
            this.shiftLable.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shiftLable.Location = new System.Drawing.Point(9, 42);
            this.shiftLable.Name = "shiftLable";
            this.shiftLable.Size = new System.Drawing.Size(81, 25);
            this.shiftLable.TabIndex = 25;
            this.shiftLable.Text = "Смена";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 500);
            this.panel3.TabIndex = 32;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 500);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.printViewGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // printViewGrid
            // 
            this.printViewGrid.AllowUserToAddRows = false;
            this.printViewGrid.AllowUserToDeleteRows = false;
            this.printViewGrid.AllowUserToResizeColumns = false;
            this.printViewGrid.AllowUserToResizeRows = false;
            this.printViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.printViewGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.printViewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.printViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.printViewGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.printViewGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printViewGrid.Location = new System.Drawing.Point(3, 3);
            this.printViewGrid.Name = "printViewGrid";
            this.printViewGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.printViewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.printViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.printViewGrid.Size = new System.Drawing.Size(992, 468);
            this.printViewGrid.TabIndex = 22;
            this.printViewGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.printViewGrid_RowEnter);
            this.printViewGrid.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.printViewGrid_RowLeave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.payedGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // payedGridView
            // 
            this.payedGridView.AllowUserToAddRows = false;
            this.payedGridView.AllowUserToDeleteRows = false;
            this.payedGridView.AllowUserToResizeRows = false;
            this.payedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payedGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payedGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.payedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payedGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.payedGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payedGridView.Location = new System.Drawing.Point(3, 3);
            this.payedGridView.Name = "payedGridView";
            this.payedGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payedGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.payedGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.payedGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payedGridView.Size = new System.Drawing.Size(992, 468);
            this.payedGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1006, 779);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ARTUR45KLA";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorDefectControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectControl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printViewGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payedGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оплаченToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бракToolStripMenuItem;
        private System.Windows.Forms.Label numberOfPGS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label colorDefectLable;
        private System.Windows.Forms.NumericUpDown colorDefectControl;
        private System.Windows.Forms.Label BWdefect;
        private System.Windows.Forms.NumericUpDown defectControl;
        private System.Windows.Forms.TextBox otherSummTextBox;
        private System.Windows.Forms.Label totalSummLable;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox colourCheckBox;
        private System.Windows.Forms.CheckBox brakCheckBox;
        private System.Windows.Forms.CheckBox threRubCheckBox;
        private System.Windows.Forms.CheckBox fourRubCheckBox;
        private System.Windows.Forms.CheckBox sixRubCheckBox;
        private System.Windows.Forms.CheckBox nineRubCheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button endShiftButton;
        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Label shiftLable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView printViewGrid;
        private System.Windows.Forms.Label totalShiftSummLBL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView payedGridView;
    }
}

