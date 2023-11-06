namespace Wel3a.IL
{
    partial class InvoiceTabs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.btnShowAdd = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowSearch
            // 
            this.btnShowSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSearch.BackColor = System.Drawing.Color.Teal;
            this.btnShowSearch.FlatAppearance.BorderSize = 0;
            this.btnShowSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSearch.ForeColor = System.Drawing.Color.White;
            this.btnShowSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowSearch.Location = new System.Drawing.Point(940, 6);
            this.btnShowSearch.Name = "btnShowSearch";
            this.btnShowSearch.Size = new System.Drawing.Size(126, 33);
            this.btnShowSearch.TabIndex = 1;
            this.btnShowSearch.Text = "فاتورة بيع";
            this.btnShowSearch.UseVisualStyleBackColor = false;
            this.btnShowSearch.Click += new System.EventHandler(this.btnShowSearch_Click);
            // 
            // btnShowAdd
            // 
            this.btnShowAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(10)))));
            this.btnShowAdd.FlatAppearance.BorderSize = 0;
            this.btnShowAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdd.ForeColor = System.Drawing.Color.White;
            this.btnShowAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAdd.Location = new System.Drawing.Point(808, 6);
            this.btnShowAdd.Name = "btnShowAdd";
            this.btnShowAdd.Size = new System.Drawing.Size(126, 33);
            this.btnShowAdd.TabIndex = 2;
            this.btnShowAdd.Text = "الخزينة";
            this.btnShowAdd.UseVisualStyleBackColor = false;
            this.btnShowAdd.Click += new System.EventHandler(this.btnShowAdd_Click);
            // 
            // btnItems
            // 
            this.btnItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItems.Location = new System.Drawing.Point(676, 6);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(126, 33);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "الأصناف";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // InvoiceTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnShowSearch);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnShowAdd);
            this.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "InvoiceTabs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1072, 45);
            this.Load += new System.EventHandler(this.InvoiceTabs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.Button btnShowAdd;
        private System.Windows.Forms.Button btnItems;
    }
}
