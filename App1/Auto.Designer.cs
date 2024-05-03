namespace App1
{
    partial class Auto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.txtSearchAuto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwBrands = new System.Windows.Forms.DataGridView();
            this.brand_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditBrand = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteBrand = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddAuto = new System.Windows.Forms.Button();
            this.txtSearchAutoInform = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwAuto = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goss_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditAuto = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteAuto = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrands)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAuto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 27);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Парковочное место";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Владелец";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Госномер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.dgwBrands);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(959, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Бренды авто";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.btnAddBrand);
            this.panel2.Controls.Add(this.txtSearchAuto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 37);
            this.panel2.TabIndex = 4;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.FlatAppearance.BorderSize = 0;
            this.btnAddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBrand.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrand.ForeColor = System.Drawing.Color.White;
            this.btnAddBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBrand.Image")));
            this.btnAddBrand.Location = new System.Drawing.Point(904, 1);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(55, 35);
            this.btnAddBrand.TabIndex = 3;
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click_1);
            // 
            // txtSearchAuto
            // 
            this.txtSearchAuto.Location = new System.Drawing.Point(68, 5);
            this.txtSearchAuto.Name = "txtSearchAuto";
            this.txtSearchAuto.Size = new System.Drawing.Size(219, 26);
            this.txtSearchAuto.TabIndex = 1;
            this.txtSearchAuto.TextChanged += new System.EventHandler(this.txtSearchAuto_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти";
            // 
            // dgwBrands
            // 
            this.dgwBrands.AllowUserToAddRows = false;
            this.dgwBrands.AllowUserToDeleteRows = false;
            this.dgwBrands.AllowUserToResizeColumns = false;
            this.dgwBrands.AllowUserToResizeRows = false;
            this.dgwBrands.BackgroundColor = System.Drawing.Color.White;
            this.dgwBrands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwBrands.ColumnHeadersHeight = 35;
            this.dgwBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwBrands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brand_id,
            this.brand_name,
            this.EditBrand,
            this.DeleteBrand});
            this.dgwBrands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwBrands.EnableHeadersVisualStyles = false;
            this.dgwBrands.Location = new System.Drawing.Point(0, 0);
            this.dgwBrands.Name = "dgwBrands";
            this.dgwBrands.RowHeadersVisible = false;
            this.dgwBrands.RowTemplate.Height = 23;
            this.dgwBrands.Size = new System.Drawing.Size(959, 432);
            this.dgwBrands.TabIndex = 3;
            this.dgwBrands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBrands_CellContentClick);
            // 
            // brand_id
            // 
            this.brand_id.HeaderText = "id";
            this.brand_id.Name = "brand_id";
            // 
            // brand_name
            // 
            this.brand_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brand_name.HeaderText = "Автомобильный бренд";
            this.brand_name.Name = "brand_name";
            // 
            // EditBrand
            // 
            this.EditBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditBrand.HeaderText = "";
            this.EditBrand.Image = ((System.Drawing.Image)(resources.GetObject("EditBrand.Image")));
            this.EditBrand.Name = "EditBrand";
            this.EditBrand.Width = 5;
            // 
            // DeleteBrand
            // 
            this.DeleteBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteBrand.HeaderText = "";
            this.DeleteBrand.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBrand.Image")));
            this.DeleteBrand.Name = "DeleteBrand";
            this.DeleteBrand.Width = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.dgwAuto);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные по авто";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.btnAddAuto);
            this.panel3.Controls.Add(this.txtSearchAutoInform);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 37);
            this.panel3.TabIndex = 4;
            // 
            // btnAddAuto
            // 
            this.btnAddAuto.FlatAppearance.BorderSize = 0;
            this.btnAddAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAuto.Image")));
            this.btnAddAuto.Location = new System.Drawing.Point(908, 0);
            this.btnAddAuto.Name = "btnAddAuto";
            this.btnAddAuto.Size = new System.Drawing.Size(45, 37);
            this.btnAddAuto.TabIndex = 2;
            this.btnAddAuto.UseVisualStyleBackColor = true;
            this.btnAddAuto.Click += new System.EventHandler(this.btnAddAuto_Click);
            // 
            // txtSearchAutoInform
            // 
            this.txtSearchAutoInform.Location = new System.Drawing.Point(64, 5);
            this.txtSearchAutoInform.Name = "txtSearchAutoInform";
            this.txtSearchAutoInform.Size = new System.Drawing.Size(219, 26);
            this.txtSearchAutoInform.TabIndex = 1;
            this.txtSearchAutoInform.TextChanged += new System.EventHandler(this.txtSearchAutoInform_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Найти";
            // 
            // dgwAuto
            // 
            this.dgwAuto.AllowUserToAddRows = false;
            this.dgwAuto.AllowUserToDeleteRows = false;
            this.dgwAuto.AllowUserToResizeColumns = false;
            this.dgwAuto.AllowUserToResizeRows = false;
            this.dgwAuto.BackgroundColor = System.Drawing.Color.White;
            this.dgwAuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAuto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwAuto.ColumnHeadersHeight = 35;
            this.dgwAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.goss_number,
            this.Column3,
            this.Column4,
            this.EditAuto,
            this.DeleteAuto});
            this.dgwAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwAuto.EnableHeadersVisualStyles = false;
            this.dgwAuto.Location = new System.Drawing.Point(3, 3);
            this.dgwAuto.Name = "dgwAuto";
            this.dgwAuto.RowHeadersVisible = false;
            this.dgwAuto.RowTemplate.Height = 23;
            this.dgwAuto.Size = new System.Drawing.Size(953, 420);
            this.dgwAuto.TabIndex = 2;
            this.dgwAuto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAuto_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 458);
            this.tabControl1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 44;
            // 
            // goss_number
            // 
            this.goss_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goss_number.HeaderText = "Госномер";
            this.goss_number.Name = "goss_number";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Дата выпуска";
            this.Column3.Name = "Column3";
            this.Column3.Width = 136;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Бренд авто";
            this.Column4.Name = "Column4";
            this.Column4.Width = 121;
            // 
            // EditAuto
            // 
            this.EditAuto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditAuto.HeaderText = "";
            this.EditAuto.Image = ((System.Drawing.Image)(resources.GetObject("EditAuto.Image")));
            this.EditAuto.Name = "EditAuto";
            this.EditAuto.Width = 5;
            // 
            // DeleteAuto
            // 
            this.DeleteAuto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteAuto.HeaderText = "";
            this.DeleteAuto.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAuto.Image")));
            this.DeleteAuto.Name = "DeleteAuto";
            this.DeleteAuto.Width = 5;
            // 
            // Auto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(967, 485);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auto";
            this.Text = "Auto";
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrands)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAuto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgwBrands;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.TextBox txtSearchAuto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgwAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_name;
        private System.Windows.Forms.DataGridViewImageColumn EditBrand;
        private System.Windows.Forms.DataGridViewImageColumn DeleteBrand;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddAuto;
        private System.Windows.Forms.TextBox txtSearchAutoInform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goss_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn EditAuto;
        private System.Windows.Forms.DataGridViewImageColumn DeleteAuto;
    }
}