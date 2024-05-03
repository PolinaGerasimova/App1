using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            openChildForm(new Dashboard());
        }
        
        private void btnMain_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnMain.Height;
            panelSlide.Top = btnMain.Top;
            openChildForm(new Dashboard());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnClients.Height;
            panelSlide.Top = btnClients.Top;
            openChildForm(new Clients());
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnAuto.Height;
            panelSlide.Top = btnAuto.Top;
            openChildForm(new Auto());
        }

        private void btnParking_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnParking.Height;
            panelSlide.Top = btnParking.Top;
            openChildForm(new Parking());
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnCash.Height;
            panelSlide.Top = btnCash.Top;
            openChildForm(new Cash());
        }

        
        private void btnCientsAuto_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnCientsAuto.Height;
            panelSlide.Top = btnCientsAuto.Top;
            openChildForm(new Clients_Auto());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnLogout.Height;
            panelSlide.Top = btnLogout.Top;
            Application.Exit();
        }
        
        #region method

        private Form activForm = null;
        public void openChildForm(Form childForm)
        { 
            if (activForm != null) 
                activForm.Close();
            activForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion method
    }
}
