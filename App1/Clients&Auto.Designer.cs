namespace App1
{
    partial class Clients_Auto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients_Auto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgwClientsAuto = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goss_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchMore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clbAuto = new System.Windows.Forms.CheckedListBox();
            this.clbClients = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchAuto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLink = new System.Windows.Forms.Button();
            this.txtSeachClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnClearChois = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientsAuto)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 27);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 458);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgwClientsAuto);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сводная таблица ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgwClientsAuto
            // 
            this.dgwClientsAuto.AllowUserToAddRows = false;
            this.dgwClientsAuto.AllowUserToDeleteRows = false;
            this.dgwClientsAuto.AllowUserToResizeColumns = false;
            this.dgwClientsAuto.AllowUserToResizeRows = false;
            this.dgwClientsAuto.BackgroundColor = System.Drawing.Color.White;
            this.dgwClientsAuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwClientsAuto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwClientsAuto.ColumnHeadersHeight = 35;
            this.dgwClientsAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.goss_number,
            this.brand,
            this.Delete});
            this.dgwClientsAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwClientsAuto.EnableHeadersVisualStyles = false;
            this.dgwClientsAuto.Location = new System.Drawing.Point(3, 3);
            this.dgwClientsAuto.Name = "dgwClientsAuto";
            this.dgwClientsAuto.RowHeadersVisible = false;
            this.dgwClientsAuto.RowTemplate.Height = 23;
            this.dgwClientsAuto.Size = new System.Drawing.Size(953, 383);
            this.dgwClientsAuto.TabIndex = 6;
            this.dgwClientsAuto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwClientsAuto_CellContentClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Клиент";
            this.name.Name = "name";
            // 
            // goss_number
            // 
            this.goss_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goss_number.HeaderText = "Номер машины";
            this.goss_number.Name = "goss_number";
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brand.HeaderText = "Марка машины";
            this.brand.Name = "brand";
            this.brand.Width = 146;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.btnClearChois);
            this.panel2.Controls.Add(this.lblCount);
            this.panel2.Controls.Add(this.btnSearchMore);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 37);
            this.panel2.TabIndex = 5;
            // 
            // btnSearchMore
            // 
            this.btnSearchMore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMore.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMore.Image")));
            this.btnSearchMore.Location = new System.Drawing.Point(828, 5);
            this.btnSearchMore.Name = "btnSearchMore";
            this.btnSearchMore.Size = new System.Drawing.Size(53, 27);
            this.btnSearchMore.TabIndex = 5;
            this.btnSearchMore.UseVisualStyleBackColor = true;
            this.btnSearchMore.Click += new System.EventHandler(this.btnSearchMore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(479, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Больше одного автомобиля имеют";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(68, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clbAuto);
            this.tabPage2.Controls.Add(this.clbClients);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Привязать авто к клиенту";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clbAuto
            // 
            this.clbAuto.FormattingEnabled = true;
            this.clbAuto.Location = new System.Drawing.Point(429, -2);
            this.clbAuto.Name = "clbAuto";
            this.clbAuto.Size = new System.Drawing.Size(403, 382);
            this.clbAuto.TabIndex = 9;
            // 
            // clbClients
            // 
            this.clbClients.FormattingEnabled = true;
            this.clbClients.Location = new System.Drawing.Point(1, -2);
            this.clbClients.Name = "clbClients";
            this.clbClients.Size = new System.Drawing.Size(403, 382);
            this.clbClients.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.txtSearchAuto);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnLink);
            this.panel3.Controls.Add(this.txtSeachClient);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 37);
            this.panel3.TabIndex = 5;
            // 
            // txtSearchAuto
            // 
            this.txtSearchAuto.Location = new System.Drawing.Point(563, 5);
            this.txtSearchAuto.Name = "txtSearchAuto";
            this.txtSearchAuto.Size = new System.Drawing.Size(266, 26);
            this.txtSearchAuto.TabIndex = 5;
            this.txtSearchAuto.TextChanged += new System.EventHandler(this.txtSearchAuto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(463, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Найти авто";
            // 
            // btnLink
            // 
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.ForeColor = System.Drawing.Color.White;
            this.btnLink.Image = ((System.Drawing.Image)(resources.GetObject("btnLink.Image")));
            this.btnLink.Location = new System.Drawing.Point(896, 1);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(55, 35);
            this.btnLink.TabIndex = 3;
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // txtSeachClient
            // 
            this.txtSeachClient.Location = new System.Drawing.Point(137, 5);
            this.txtSeachClient.Name = "txtSeachClient";
            this.txtSeachClient.Size = new System.Drawing.Size(266, 26);
            this.txtSeachClient.TabIndex = 1;
            this.txtSeachClient.TextChanged += new System.EventHandler(this.txtSeachClient_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Найти клиента";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(764, 7);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(60, 23);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "00000";
            // 
            // btnClearChois
            // 
            this.btnClearChois.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearChois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearChois.Image = ((System.Drawing.Image)(resources.GetObject("btnClearChois.Image")));
            this.btnClearChois.Location = new System.Drawing.Point(895, 5);
            this.btnClearChois.Name = "btnClearChois";
            this.btnClearChois.Size = new System.Drawing.Size(53, 27);
            this.btnClearChois.TabIndex = 8;
            this.btnClearChois.UseVisualStyleBackColor = true;
            this.btnClearChois.Click += new System.EventHandler(this.btnClearChois_Click);
            // 
            // Clients_Auto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(967, 485);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clients_Auto";
            this.Text = "Clients_Auto";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientsAuto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.TextBox txtSeachClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbClients;
        private System.Windows.Forms.CheckedListBox clbAuto;
        public System.Windows.Forms.DataGridView dgwClientsAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goss_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnSearchMore;
        public System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.Button btnClearChois;
    }
}