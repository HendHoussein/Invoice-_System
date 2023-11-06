namespace Wel3a.IL
{
    partial class frmMoneyMovings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoneyMovings));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMiniMize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDataDetails = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPullsSum = new System.Windows.Forms.Label();
            this.dgvPull = new System.Windows.Forms.DataGridView();
            this.colPullMovementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPullValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPullDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPullHint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPushesSum = new System.Windows.Forms.Label();
            this.dgvPush = new System.Windows.Forms.DataGridView();
            this.colPushMovementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPushValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPushDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPushHint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRestOfDay = new System.Windows.Forms.Label();
            this.btnEndDay = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlDataDetails.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPull)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPush)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.pnlHeader.Controls.Add(this.btnMiniMize);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1064, 31);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnMiniMize
            // 
            this.btnMiniMize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniMize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMiniMize.FlatAppearance.BorderSize = 0;
            this.btnMiniMize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniMize.ForeColor = System.Drawing.Color.White;
            this.btnMiniMize.Location = new System.Drawing.Point(993, 2);
            this.btnMiniMize.Name = "btnMiniMize";
            this.btnMiniMize.Size = new System.Drawing.Size(27, 27);
            this.btnMiniMize.TabIndex = 37;
            this.btnMiniMize.Text = "_";
            this.btnMiniMize.UseVisualStyleBackColor = false;
            this.btnMiniMize.Click += new System.EventHandler(this.btnMiniMize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1027, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(102, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "الحركات المالية";
            // 
            // pnlDataDetails
            // 
            this.pnlDataDetails.Controls.Add(this.panel5);
            this.pnlDataDetails.Controls.Add(this.panel3);
            this.pnlDataDetails.Location = new System.Drawing.Point(0, 72);
            this.pnlDataDetails.Name = "pnlDataDetails";
            this.pnlDataDetails.Size = new System.Drawing.Size(511, 511);
            this.pnlDataDetails.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.dgvPull);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(511, 481);
            this.panel5.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.lblPullsSum);
            this.panel7.Location = new System.Drawing.Point(110, 448);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(398, 32);
            this.panel7.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 28);
            this.label2.TabIndex = 62;
            this.label2.Text = "إجمالي المصروفات";
            // 
            // lblPullsSum
            // 
            this.lblPullsSum.AutoSize = true;
            this.lblPullsSum.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPullsSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.lblPullsSum.Location = new System.Drawing.Point(47, 2);
            this.lblPullsSum.Name = "lblPullsSum";
            this.lblPullsSum.Size = new System.Drawing.Size(87, 28);
            this.lblPullsSum.TabIndex = 63;
            this.lblPullsSum.Text = "5000000";
            // 
            // dgvPull
            // 
            this.dgvPull.AllowUserToDeleteRows = false;
            this.dgvPull.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPull.BackgroundColor = System.Drawing.Color.White;
            this.dgvPull.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPull.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPull.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPullMovementID,
            this.colPullValue,
            this.colPullDirection,
            this.colPullHint});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPull.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPull.EnableHeadersVisualStyles = false;
            this.dgvPull.Location = new System.Drawing.Point(3, 4);
            this.dgvPull.MultiSelect = false;
            this.dgvPull.Name = "dgvPull";
            this.dgvPull.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPull.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPull.RowHeadersVisible = false;
            this.dgvPull.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPull.Size = new System.Drawing.Size(502, 443);
            this.dgvPull.TabIndex = 61;
            this.dgvPull.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPull_CellEndEdit);
            // 
            // colPullMovementID
            // 
            this.colPullMovementID.HeaderText = "Movement ID";
            this.colPullMovementID.Name = "colPullMovementID";
            this.colPullMovementID.Visible = false;
            // 
            // colPullValue
            // 
            this.colPullValue.HeaderText = "المبلغ";
            this.colPullValue.Name = "colPullValue";
            // 
            // colPullDirection
            // 
            this.colPullDirection.HeaderText = "الجهة";
            this.colPullDirection.Name = "colPullDirection";
            // 
            // colPullHint
            // 
            this.colPullHint.HeaderText = "البيان";
            this.colPullHint.Name = "colPullHint";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 30);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(176, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "الـــــمـــــصـــــروفـــــات";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(516, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 511);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.dgvPush);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 479);
            this.panel4.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.lblPushesSum);
            this.panel6.Location = new System.Drawing.Point(145, 448);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(398, 32);
            this.panel6.TabIndex = 65;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(172, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 28);
            this.label20.TabIndex = 62;
            this.label20.Text = "إجمالي المتحصلات";
            // 
            // lblPushesSum
            // 
            this.lblPushesSum.AutoSize = true;
            this.lblPushesSum.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPushesSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.lblPushesSum.Location = new System.Drawing.Point(47, 2);
            this.lblPushesSum.Name = "lblPushesSum";
            this.lblPushesSum.Size = new System.Drawing.Size(87, 28);
            this.lblPushesSum.TabIndex = 63;
            this.lblPushesSum.Text = "5000000";
            // 
            // dgvPush
            // 
            this.dgvPush.AllowUserToDeleteRows = false;
            this.dgvPush.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPush.BackgroundColor = System.Drawing.Color.White;
            this.dgvPush.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPush.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPush.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPush.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPushMovementID,
            this.colPushValue,
            this.colPushDirection,
            this.colPushHint});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPush.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPush.EnableHeadersVisualStyles = false;
            this.dgvPush.Location = new System.Drawing.Point(0, 3);
            this.dgvPush.MultiSelect = false;
            this.dgvPush.Name = "dgvPush";
            this.dgvPush.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPush.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPush.RowHeadersVisible = false;
            this.dgvPush.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPush.Size = new System.Drawing.Size(543, 444);
            this.dgvPush.TabIndex = 60;
            this.dgvPush.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPush_CellEndEdit);
            // 
            // colPushMovementID
            // 
            this.colPushMovementID.HeaderText = "Movement ID";
            this.colPushMovementID.Name = "colPushMovementID";
            this.colPushMovementID.Visible = false;
            // 
            // colPushValue
            // 
            this.colPushValue.HeaderText = "المبلغ";
            this.colPushValue.Name = "colPushValue";
            // 
            // colPushDirection
            // 
            this.colPushDirection.HeaderText = "الجهة";
            this.colPushDirection.Name = "colPushDirection";
            // 
            // colPushHint
            // 
            this.colPushHint.HeaderText = "البيان";
            this.colPushHint.Name = "colPushHint";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 30);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(204, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "الـــــمـــــتـــــحـــــصــــلات";
            // 
            // dtpDay
            // 
            this.dtpDay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDay.Location = new System.Drawing.Point(354, 37);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(152, 29);
            this.dtpDay.TabIndex = 63;
            this.dtpDay.ValueChanged += new System.EventHandler(this.dtpDay_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(512, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "حركة المتحصلات والمصروفات يوم";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(867, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 28);
            this.label3.TabIndex = 65;
            this.label3.Text = "الرصيد المتبقي";
            // 
            // lblRestOfDay
            // 
            this.lblRestOfDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRestOfDay.AutoSize = true;
            this.lblRestOfDay.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestOfDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.lblRestOfDay.Location = new System.Drawing.Point(709, 591);
            this.lblRestOfDay.Name = "lblRestOfDay";
            this.lblRestOfDay.Size = new System.Drawing.Size(87, 28);
            this.lblRestOfDay.TabIndex = 66;
            this.lblRestOfDay.Text = "5000000";
            // 
            // btnEndDay
            // 
            this.btnEndDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(2)))));
            this.btnEndDay.FlatAppearance.BorderSize = 0;
            this.btnEndDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndDay.ForeColor = System.Drawing.Color.White;
            this.btnEndDay.Image = ((System.Drawing.Image)(resources.GetObject("btnEndDay.Image")));
            this.btnEndDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndDay.Location = new System.Drawing.Point(437, 587);
            this.btnEndDay.Name = "btnEndDay";
            this.btnEndDay.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEndDay.Size = new System.Drawing.Size(191, 32);
            this.btnEndDay.TabIndex = 67;
            this.btnEndDay.Text = "تـــرحـــيـــل أمـــوال";
            this.btnEndDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEndDay.UseVisualStyleBackColor = false;
            this.btnEndDay.Click += new System.EventHandler(this.btnEndDay_Click);
            // 
            // frmMoneyMovings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 624);
            this.Controls.Add(this.btnEndDay);
            this.Controls.Add(this.lblRestOfDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.pnlDataDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmMoneyMovings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinics";
            this.Load += new System.EventHandler(this.frmSafeMoney_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDataDetails.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPull)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPush)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMiniMize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlDataDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvPull;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvPush;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPullsSum;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblPushesSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRestOfDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPullMovementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPullValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPullDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPullHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPushMovementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPushValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPushDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPushHint;
        private System.Windows.Forms.Button btnEndDay;
    }
}