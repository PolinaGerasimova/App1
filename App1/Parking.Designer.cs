namespace App1
{
    partial class Parking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parking));
            this.dgwParking = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddParking = new System.Windows.Forms.Button();
            this.txtSearchParking = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parking_namber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_to_month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goss_numberAuto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteAuto = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwParking)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwParking
            // 
            this.dgwParking.AllowUserToAddRows = false;
            this.dgwParking.AllowUserToDeleteRows = false;
            this.dgwParking.AllowUserToResizeColumns = false;
            this.dgwParking.AllowUserToResizeRows = false;
            this.dgwParking.BackgroundColor = System.Drawing.Color.White;
            this.dgwParking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwParking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwParking.ColumnHeadersHeight = 35;
            this.dgwParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwParking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.parking_namber,
            this.cost_to_month,
            this.goss_numberAuto,
            this.Edit,
            this.Delete,
            this.DeleteAuto});
            this.dgwParking.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwParking.EnableHeadersVisualStyles = false;
            this.dgwParking.Location = new System.Drawing.Point(0, 0);
            this.dgwParking.Name = "dgwParking";
            this.dgwParking.RowHeadersVisible = false;
            this.dgwParking.RowTemplate.Height = 23;
            this.dgwParking.Size = new System.Drawing.Size(967, 394);
            this.dgwParking.TabIndex = 2;
            this.dgwParking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwParking_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAddParking);
            this.panel1.Controls.Add(this.txtSearchParking);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 91);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(756, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddParking
            // 
            this.btnAddParking.FlatAppearance.BorderSize = 0;
            this.btnAddParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddParking.Image = ((System.Drawing.Image)(resources.GetObject("btnAddParking.Image")));
            this.btnAddParking.Location = new System.Drawing.Point(880, 20);
            this.btnAddParking.Name = "btnAddParking";
            this.btnAddParking.Size = new System.Drawing.Size(75, 50);
            this.btnAddParking.TabIndex = 2;
            this.btnAddParking.UseVisualStyleBackColor = true;
            this.btnAddParking.Click += new System.EventHandler(this.btnAddParking_Click);
            // 
            // txtSearchParking
            // 
            this.txtSearchParking.Location = new System.Drawing.Point(72, 33);
            this.txtSearchParking.Name = "txtSearchParking";
            this.txtSearchParking.Size = new System.Drawing.Size(219, 26);
            this.txtSearchParking.TabIndex = 1;
            this.txtSearchParking.TextChanged += new System.EventHandler(this.txtSearchParking_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер места";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 286;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата заезда";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // parking_namber
            // 
            this.parking_namber.HeaderText = "Номер места";
            this.parking_namber.Name = "parking_namber";
            this.parking_namber.Width = 286;
            // 
            // cost_to_month
            // 
            this.cost_to_month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cost_to_month.HeaderText = "Стоимость";
            this.cost_to_month.Name = "cost_to_month";
            // 
            // goss_numberAuto
            // 
            this.goss_numberAuto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goss_numberAuto.DefaultCellStyle = dataGridViewCellStyle2;
            this.goss_numberAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goss_numberAuto.HeaderText = "Номер машины";
            this.goss_numberAuto.Name = "goss_numberAuto";
            this.goss_numberAuto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.goss_numberAuto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.goss_numberAuto.Width = 148;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // DeleteAuto
            // 
            this.DeleteAuto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteAuto.HeaderText = "";
            this.DeleteAuto.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAuto.Image")));
            this.DeleteAuto.Name = "DeleteAuto";
            this.DeleteAuto.Width = 5;
            // 
            // Parking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(967, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwParking);
            this.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Parking";
            this.Text = "Parking";
            ((System.ComponentModel.ISupportInitialize)(this.dgwParking)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddParking;
        private System.Windows.Forms.TextBox txtSearchParking;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgwParking;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn parking_namber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_to_month;
        private System.Windows.Forms.DataGridViewComboBoxColumn goss_numberAuto;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn DeleteAuto;
    }
}