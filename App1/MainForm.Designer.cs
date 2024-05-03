namespace App1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCientsAuto = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnParking = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 781);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelSlide.Location = new System.Drawing.Point(0, 150);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 50);
            this.panelSlide.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnCientsAuto);
            this.panel2.Controls.Add(this.btnCash);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnParking);
            this.panel2.Controls.Add(this.btnAuto);
            this.panel2.Controls.Add(this.btnClients);
            this.panel2.Controls.Add(this.btnMain);
            this.panel2.Controls.Add(this.panel_logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 781);
            this.panel2.TabIndex = 1;
            // 
            // btnCientsAuto
            // 
            this.btnCientsAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCientsAuto.FlatAppearance.BorderSize = 0;
            this.btnCientsAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCientsAuto.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCientsAuto.Image = ((System.Drawing.Image)(resources.GetObject("btnCientsAuto.Image")));
            this.btnCientsAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCientsAuto.Location = new System.Drawing.Point(0, 400);
            this.btnCientsAuto.Name = "btnCientsAuto";
            this.btnCientsAuto.Size = new System.Drawing.Size(190, 50);
            this.btnCientsAuto.TabIndex = 10;
            this.btnCientsAuto.Text = "Клиенты/машины";
            this.btnCientsAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCientsAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCientsAuto.UseVisualStyleBackColor = true;
            this.btnCientsAuto.Click += new System.EventHandler(this.btnCientsAuto_Click);
            // 
            // btnCash
            // 
            this.btnCash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCash.Location = new System.Drawing.Point(0, 350);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(190, 50);
            this.btnCash.TabIndex = 9;
            this.btnCash.Text = " Оплаты";
            this.btnCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 731);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 50);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = " Выход";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnParking
            // 
            this.btnParking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParking.FlatAppearance.BorderSize = 0;
            this.btnParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParking.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParking.Image = ((System.Drawing.Image)(resources.GetObject("btnParking.Image")));
            this.btnParking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParking.Location = new System.Drawing.Point(0, 300);
            this.btnParking.Name = "btnParking";
            this.btnParking.Size = new System.Drawing.Size(190, 50);
            this.btnParking.TabIndex = 7;
            this.btnParking.Text = "  Парковка";
            this.btnParking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParking.UseVisualStyleBackColor = true;
            this.btnParking.Click += new System.EventHandler(this.btnParking_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuto.FlatAppearance.BorderSize = 0;
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuto.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Image = ((System.Drawing.Image)(resources.GetObject("btnAuto.Image")));
            this.btnAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuto.Location = new System.Drawing.Point(0, 250);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(190, 50);
            this.btnAuto.TabIndex = 6;
            this.btnAuto.Text = " Машины";
            this.btnAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnClients
            // 
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(0, 200);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(190, 50);
            this.btnClients.TabIndex = 5;
            this.btnClients.Text = " Клиенты";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnMain
            // 
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(0, 150);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(190, 50);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = " Главная";
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(190, 150);
            this.panel_logo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "AutoCar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panelChild);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 781);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 687);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1064, 94);
            this.panel5.TabIndex = 5;
            // 
            // panelChild
            // 
            this.panelChild.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelChild.BackColor = System.Drawing.Color.White;
            this.panelChild.Location = new System.Drawing.Point(50, 176);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(967, 485);
            this.panelChild.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1064, 150);
            this.panel4.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnParking;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button btnCientsAuto;
        public System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

