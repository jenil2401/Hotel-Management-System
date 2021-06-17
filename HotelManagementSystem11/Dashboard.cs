using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem11
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left + 25;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();

            MovingPanel.Left = btnEmployee.Left + 25;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();

            MovingPanel.Left = btnCheckout.Left + 25;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerDetails.Left + 25;
            customerDetail1.Visible = true;
            customerDetail1.BringToFront();

        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerRegistration.Left+25;

            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
