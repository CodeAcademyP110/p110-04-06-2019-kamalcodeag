namespace WindowsFormsApp1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.nmrPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.nmrCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.nmrPercent = new System.Windows.Forms.NumericUpDown();
            this.chckDisc = new System.Windows.Forms.CheckBox();
            this.dtgridList = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.əsasSəhifəToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridList)).BeginInit();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Sofia Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(3, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(173, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Məhsulun adı";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(197, 0);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 30);
            this.txtName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.SystemColors.Info;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(642, 0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(158, 40);
            this.cmbCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Sofia Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCategory.Location = new System.Drawing.Point(484, 1);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(144, 29);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kateqoriya";
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.BackColor = System.Drawing.Color.Transparent;
            this.lblDisc.Font = new System.Drawing.Font("Sofia Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDisc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDisc.Location = new System.Drawing.Point(464, 6);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(105, 29);
            this.lblDisc.TabIndex = 5;
            this.lblDisc.Text = "Endirim";
            // 
            // nmrPrice
            // 
            this.nmrPrice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nmrPrice.Font = new System.Drawing.Font("Open Sans", 13.8F);
            this.nmrPrice.Location = new System.Drawing.Point(320, 5);
            this.nmrPrice.Name = "nmrPrice";
            this.nmrPrice.Size = new System.Drawing.Size(92, 39);
            this.nmrPrice.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Sofia Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrice.Location = new System.Drawing.Point(208, 6);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 29);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Qiymət";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Sofia Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCount.Location = new System.Drawing.Point(6, 6);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(57, 29);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "Say";
            // 
            // nmrCount
            // 
            this.nmrCount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nmrCount.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrCount.Location = new System.Drawing.Point(73, 5);
            this.nmrCount.Name = "nmrCount";
            this.nmrCount.Size = new System.Drawing.Size(92, 39);
            this.nmrCount.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.Font = new System.Drawing.Font("Sofia Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdd.Location = new System.Drawing.Point(384, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Əlavə et";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Sofia Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPercent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPercent.Location = new System.Drawing.Point(637, 6);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(62, 29);
            this.lblPercent.TabIndex = 12;
            this.lblPercent.Text = "Faiz";
            this.lblPercent.Visible = false;
            // 
            // nmrPercent
            // 
            this.nmrPercent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nmrPercent.Font = new System.Drawing.Font("Open Sans", 13.8F);
            this.nmrPercent.Location = new System.Drawing.Point(708, 3);
            this.nmrPercent.Name = "nmrPercent";
            this.nmrPercent.Size = new System.Drawing.Size(92, 39);
            this.nmrPercent.TabIndex = 6;
            this.nmrPercent.Visible = false;
            // 
            // chckDisc
            // 
            this.chckDisc.AutoSize = true;
            this.chckDisc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chckDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckDisc.Location = new System.Drawing.Point(574, 12);
            this.chckDisc.Name = "chckDisc";
            this.chckDisc.Size = new System.Drawing.Size(18, 17);
            this.chckDisc.TabIndex = 5;
            this.chckDisc.UseVisualStyleBackColor = false;
            this.chckDisc.CheckedChanged += new System.EventHandler(this.ChckDisc_CheckedChanged);
            // 
            // dtgridList
            // 
            this.dtgridList.AllowUserToAddRows = false;
            this.dtgridList.AllowUserToDeleteRows = false;
            this.dtgridList.AllowUserToResizeColumns = false;
            this.dtgridList.AllowUserToResizeRows = false;
            this.dtgridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridList.BackgroundColor = System.Drawing.Color.Bisque;
            this.dtgridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgridList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgridList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgridList.Location = new System.Drawing.Point(0, 403);
            this.dtgridList.Name = "dtgridList";
            this.dtgridList.ReadOnly = true;
            this.dtgridList.RowHeadersWidth = 51;
            this.dtgridList.RowTemplate.Height = 24;
            this.dtgridList.Size = new System.Drawing.Size(982, 150);
            this.dtgridList.TabIndex = 14;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Bisque;
            this.menu.Font = new System.Drawing.Font("Sofia Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.əsasSəhifəToolStripMenuItem,
            this.menuDelete});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5);
            this.menu.Size = new System.Drawing.Size(982, 37);
            this.menu.TabIndex = 15;
            // 
            // əsasSəhifəToolStripMenuItem
            // 
            this.əsasSəhifəToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.əsasSəhifəToolStripMenuItem.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.əsasSəhifəToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.əsasSəhifəToolStripMenuItem.Name = "əsasSəhifəToolStripMenuItem";
            this.əsasSəhifəToolStripMenuItem.Size = new System.Drawing.Size(114, 27);
            this.əsasSəhifəToolStripMenuItem.Text = "Əsas səhifə";
            // 
            // menuDelete
            // 
            this.menuDelete.BackColor = System.Drawing.Color.PaleGreen;
            this.menuDelete.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(101, 27);
            this.menuDelete.Text = "Məhsul sil";
            this.menuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Location = new System.Drawing.Point(89, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.nmrCount);
            this.panel2.Controls.Add(this.lblCount);
            this.panel2.Controls.Add(this.nmrPrice);
            this.panel2.Controls.Add(this.lblPercent);
            this.panel2.Controls.Add(this.chckDisc);
            this.panel2.Controls.Add(this.nmrPercent);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblDisc);
            this.panel2.Location = new System.Drawing.Point(89, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 70);
            this.panel2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgridList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"Tazılar\" marketinin məhsul əlavə etmə sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridList)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown nmrCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.NumericUpDown nmrPercent;
        private System.Windows.Forms.CheckBox chckDisc;
        private System.Windows.Forms.DataGridView dtgridList;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem əsasSəhifəToolStripMenuItem;
    }
}

