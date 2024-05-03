namespace App1
{
    partial class AddPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btbClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbSearchAuto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSumm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearchClient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 27);
            this.panel1.TabIndex = 17;
            // 
            // btbClose
            // 
            this.btbClose.FlatAppearance.BorderSize = 0;
            this.btbClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbClose.Image = ((System.Drawing.Image)(resources.GetObject("btbClose.Image")));
            this.btbClose.Location = new System.Drawing.Point(676, 38);
            this.btbClose.Name = "btbClose";
            this.btbClose.Size = new System.Drawing.Size(20, 20);
            this.btbClose.TabIndex = 19;
            this.btbClose.UseVisualStyleBackColor = true;
            this.btbClose.Click += new System.EventHandler(this.btbClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Новая оплата";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(12, 261);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(41, 19);
            this.lblPay.TabIndex = 36;
            this.lblPay.Text = "Payid";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(537, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 48);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Очистить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(367, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 48);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbSearchAuto
            // 
            this.cbSearchAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSearchAuto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchAuto.FormattingEnabled = true;
            this.cbSearchAuto.Location = new System.Drawing.Point(458, 113);
            this.cbSearchAuto.Name = "cbSearchAuto";
            this.cbSearchAuto.Size = new System.Drawing.Size(230, 25);
            this.cbSearchAuto.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Авто : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Сумма : ";
            // 
            // txtSumm
            // 
            this.txtSumm.Location = new System.Drawing.Point(458, 159);
            this.txtSumm.Name = "txtSumm";
            this.txtSumm.Size = new System.Drawing.Size(230, 26);
            this.txtSumm.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Клиент :";
            // 
            // cbSearchClient
            // 
            this.cbSearchClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSearchClient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchClient.FormattingEnabled = true;
            this.cbSearchClient.Location = new System.Drawing.Point(100, 113);
            this.cbSearchClient.Name = "cbSearchClient";
            this.cbSearchClient.Size = new System.Drawing.Size(230, 25);
            this.cbSearchClient.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Поиск : ";
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(100, 159);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(230, 26);
            this.txtSearchClient.TabIndex = 43;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // AddPay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(708, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchClient);
            this.Controls.Add(this.cbSearchClient);
            this.Controls.Add(this.cbSearchAuto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSumm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btbClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btbClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblPay;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox cbSearchAuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSumm;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbSearchClient;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSearchClient;
    }
}