namespace Wel3a.IL
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcoming = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPushes = new System.Windows.Forms.Label();
            this.lblPulles = new System.Windows.Forms.Label();
            this.pnlNotificationContainer = new System.Windows.Forms.Panel();
            this.lblNotiNo = new System.Windows.Forms.Label();
            this.btnNotification = new System.Windows.Forms.Button();
            this.pnlSideMinue = new System.Windows.Forms.Panel();
            this.btnAllSuppliers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAllMoneySafe = new System.Windows.Forms.Button();
            this.btnAllInvoices = new System.Windows.Forms.Button();
            this.btnAllItems = new System.Windows.Forms.Button();
            this.btnAllCustomers = new System.Windows.Forms.Button();
            this.pnlNotification = new System.Windows.Forms.Panel();
            this.timEndDay = new System.Windows.Forms.Timer(this.components);
            this.timOpenNotifications = new System.Windows.Forms.Timer(this.components);
            this.EndDayDocument = new System.Drawing.Printing.PrintDocument();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTabs.SuspendLayout();
            this.pnlNotificationContainer.SuspendLayout();
            this.pnlSideMinue.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.pnlHeader.Controls.Add(this.lblWelcoming);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1124, 31);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblWelcoming
            // 
            this.lblWelcoming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcoming.AutoSize = true;
            this.lblWelcoming.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcoming.ForeColor = System.Drawing.Color.White;
            this.lblWelcoming.Location = new System.Drawing.Point(472, 3);
            this.lblWelcoming.Name = "lblWelcoming";
            this.lblWelcoming.Size = new System.Drawing.Size(46, 24);
            this.lblWelcoming.TabIndex = 11;
            this.lblWelcoming.Text = "مرحبا";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(890, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "مطعم واعة";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1093, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(35, 7);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 16);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(11, 8);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTabs
            // 
            this.pnlTabs.AutoScroll = true;
            this.pnlTabs.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTabs.Controls.Add(this.lblDate);
            this.pnlTabs.Controls.Add(this.lblPushes);
            this.pnlTabs.Controls.Add(this.lblPulles);
            this.pnlTabs.Controls.Add(this.pnlNotificationContainer);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlTabs.Location = new System.Drawing.Point(0, 31);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1124, 45);
            this.pnlTabs.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(631, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 24);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "مرحبا";
            this.lblDate.Visible = false;
            // 
            // lblPushes
            // 
            this.lblPushes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPushes.AutoSize = true;
            this.lblPushes.BackColor = System.Drawing.Color.Transparent;
            this.lblPushes.ForeColor = System.Drawing.Color.White;
            this.lblPushes.Location = new System.Drawing.Point(565, 10);
            this.lblPushes.Name = "lblPushes";
            this.lblPushes.Size = new System.Drawing.Size(46, 24);
            this.lblPushes.TabIndex = 11;
            this.lblPushes.Text = "مرحبا";
            this.lblPushes.Visible = false;
            // 
            // lblPulles
            // 
            this.lblPulles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPulles.AutoSize = true;
            this.lblPulles.BackColor = System.Drawing.Color.Transparent;
            this.lblPulles.ForeColor = System.Drawing.Color.White;
            this.lblPulles.Location = new System.Drawing.Point(499, 6);
            this.lblPulles.Name = "lblPulles";
            this.lblPulles.Size = new System.Drawing.Size(46, 24);
            this.lblPulles.TabIndex = 11;
            this.lblPulles.Text = "مرحبا";
            this.lblPulles.Visible = false;
            // 
            // pnlNotificationContainer
            // 
            this.pnlNotificationContainer.Controls.Add(this.lblNotiNo);
            this.pnlNotificationContainer.Controls.Add(this.btnNotification);
            this.pnlNotificationContainer.Location = new System.Drawing.Point(35, 0);
            this.pnlNotificationContainer.Name = "pnlNotificationContainer";
            this.pnlNotificationContainer.Size = new System.Drawing.Size(65, 45);
            this.pnlNotificationContainer.TabIndex = 24;
            this.pnlNotificationContainer.Visible = false;
            // 
            // lblNotiNo
            // 
            this.lblNotiNo.AutoSize = true;
            this.lblNotiNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNotiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotiNo.ForeColor = System.Drawing.Color.White;
            this.lblNotiNo.Location = new System.Drawing.Point(38, 2);
            this.lblNotiNo.Name = "lblNotiNo";
            this.lblNotiNo.Size = new System.Drawing.Size(24, 20);
            this.lblNotiNo.TabIndex = 22;
            this.lblNotiNo.Text = "0 ";
            // 
            // btnNotification
            // 
            this.btnNotification.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotification.BackgroundImage")));
            this.btnNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.ForeColor = System.Drawing.Color.Yellow;
            this.btnNotification.Location = new System.Drawing.Point(5, 3);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(38, 39);
            this.btnNotification.TabIndex = 20;
            this.btnNotification.UseVisualStyleBackColor = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // pnlSideMinue
            // 
            this.pnlSideMinue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSideMinue.Controls.Add(this.btnAllSuppliers);
            this.pnlSideMinue.Controls.Add(this.button1);
            this.pnlSideMinue.Controls.Add(this.btnReports);
            this.pnlSideMinue.Controls.Add(this.btnAllMoneySafe);
            this.pnlSideMinue.Controls.Add(this.btnAllInvoices);
            this.pnlSideMinue.Controls.Add(this.btnAllItems);
            this.pnlSideMinue.Controls.Add(this.btnAllCustomers);
            this.pnlSideMinue.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSideMinue.Location = new System.Drawing.Point(944, 76);
            this.pnlSideMinue.Name = "pnlSideMinue";
            this.pnlSideMinue.Size = new System.Drawing.Size(180, 584);
            this.pnlSideMinue.TabIndex = 10;
            this.pnlSideMinue.Visible = false;
            // 
            // btnAllSuppliers
            // 
            this.btnAllSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.btnAllSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAllSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllSuppliers.FlatAppearance.BorderSize = 0;
            this.btnAllSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAllSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnAllSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.btnAllSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("btnAllSuppliers.Image")));
            this.btnAllSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllSuppliers.Location = new System.Drawing.Point(0, 102);
            this.btnAllSuppliers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAllSuppliers.Name = "btnAllSuppliers";
            this.btnAllSuppliers.Size = new System.Drawing.Size(180, 47);
            this.btnAllSuppliers.TabIndex = 8;
            this.btnAllSuppliers.Text = "الموردين   ";
            this.btnAllSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllSuppliers.UseVisualStyleBackColor = false;
            this.btnAllSuppliers.Click += new System.EventHandler(this.btnAllSuppliers_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(180, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "الاعدادات   ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(-1, 338);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(180, 47);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "الاستعلامات   ";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAllMoneySafe
            // 
            this.btnAllMoneySafe.BackColor = System.Drawing.Color.Transparent;
            this.btnAllMoneySafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAllMoneySafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllMoneySafe.FlatAppearance.BorderSize = 0;
            this.btnAllMoneySafe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAllMoneySafe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnAllMoneySafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllMoneySafe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.btnAllMoneySafe.Image = ((System.Drawing.Image)(resources.GetObject("btnAllMoneySafe.Image")));
            this.btnAllMoneySafe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllMoneySafe.Location = new System.Drawing.Point(0, 279);
            this.btnAllMoneySafe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAllMoneySafe.Name = "btnAllMoneySafe";
            this.btnAllMoneySafe.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnAllMoneySafe.Size = new System.Drawing.Size(180, 47);
            this.btnAllMoneySafe.TabIndex = 8;
            this.btnAllMoneySafe.Text = "الخزنة   ";
            this.btnAllMoneySafe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllMoneySafe.UseVisualStyleBackColor = false;
            this.btnAllMoneySafe.Click += new System.EventHandler(this.btnAllMoneySafe_Click);
            // 
            // btnAllInvoices
            // 
            this.btnAllInvoices.BackColor = System.Drawing.Color.Transparent;
            this.btnAllInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAllInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllInvoices.FlatAppearance.BorderSize = 0;
            this.btnAllInvoices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAllInvoices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnAllInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.btnAllInvoices.Image = ((System.Drawing.Image)(resources.GetObject("btnAllInvoices.Image")));
            this.btnAllInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllInvoices.Location = new System.Drawing.Point(0, 220);
            this.btnAllInvoices.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAllInvoices.Name = "btnAllInvoices";
            this.btnAllInvoices.Size = new System.Drawing.Size(180, 47);
            this.btnAllInvoices.TabIndex = 8;
            this.btnAllInvoices.Text = "الفواتير   ";
            this.btnAllInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllInvoices.UseVisualStyleBackColor = false;
            this.btnAllInvoices.Click += new System.EventHandler(this.btnAllInvoices_Click);
            // 
            // btnAllItems
            // 
            this.btnAllItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(183)))), ((int)(((byte)(245)))));
            this.btnAllItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAllItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllItems.FlatAppearance.BorderSize = 0;
            this.btnAllItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAllItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnAllItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.btnAllItems.Image = ((System.Drawing.Image)(resources.GetObject("btnAllItems.Image")));
            this.btnAllItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllItems.Location = new System.Drawing.Point(0, 43);
            this.btnAllItems.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAllItems.Name = "btnAllItems";
            this.btnAllItems.Size = new System.Drawing.Size(180, 47);
            this.btnAllItems.TabIndex = 8;
            this.btnAllItems.Text = "المنتجات   ";
            this.btnAllItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllItems.UseVisualStyleBackColor = false;
            this.btnAllItems.Click += new System.EventHandler(this.btnAllItems_Click);
            // 
            // btnAllCustomers
            // 
            this.btnAllCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnAllCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAllCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllCustomers.FlatAppearance.BorderSize = 0;
            this.btnAllCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAllCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnAllCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(207)))));
            this.btnAllCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnAllCustomers.Image")));
            this.btnAllCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllCustomers.Location = new System.Drawing.Point(0, 161);
            this.btnAllCustomers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAllCustomers.Name = "btnAllCustomers";
            this.btnAllCustomers.Size = new System.Drawing.Size(180, 47);
            this.btnAllCustomers.TabIndex = 8;
            this.btnAllCustomers.Text = "العملاء   ";
            this.btnAllCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllCustomers.UseVisualStyleBackColor = false;
            this.btnAllCustomers.Click += new System.EventHandler(this.btnAllCustomers_Click);
            // 
            // pnlNotification
            // 
            this.pnlNotification.AutoScroll = true;
            this.pnlNotification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotification.Location = new System.Drawing.Point(40, 82);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(284, 521);
            this.pnlNotification.TabIndex = 22;
            this.pnlNotification.Visible = false;
            // 
            // timEndDay
            // 
            this.timEndDay.Enabled = true;
            this.timEndDay.Interval = 1000;
            this.timEndDay.Tick += new System.EventHandler(this.timEndDay_Tick);
            // 
            // timOpenNotifications
            // 
            this.timOpenNotifications.Interval = 30;
            this.timOpenNotifications.Tick += new System.EventHandler(this.timOpenNotifications_Tick);
            // 
            // EndDayDocument
            // 
            this.EndDayDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.EndDayDocument_PrintPage);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 660);
            this.Controls.Add(this.pnlNotification);
            this.Controls.Add(this.pnlSideMinue);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drug store Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTabs.ResumeLayout(false);
            this.pnlTabs.PerformLayout();
            this.pnlNotificationContainer.ResumeLayout(false);
            this.pnlNotificationContainer.PerformLayout();
            this.pnlSideMinue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Button btnMinimize;
        public System.Windows.Forms.Panel pnlSideMinue;
        private System.Windows.Forms.Button btnAllSuppliers;
        private System.Windows.Forms.Button btnAllInvoices;
        private System.Windows.Forms.Button btnAllItems;
        private System.Windows.Forms.Button btnAllCustomers;
        private System.Windows.Forms.Panel pnlNotificationContainer;
        private System.Windows.Forms.Button btnAllMoneySafe;
        private System.Windows.Forms.Label lblWelcoming;
        public System.Windows.Forms.Label lblNotiNo;
        public System.Windows.Forms.Button btnNotification;
        public System.Windows.Forms.Panel pnlNotification;
        public System.Windows.Forms.Timer timEndDay;
        public System.Windows.Forms.Timer timOpenNotifications;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPushes;
        private System.Windows.Forms.Label lblPulles;
        private System.Drawing.Printing.PrintDocument EndDayDocument;
    }
}