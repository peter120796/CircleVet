using JamVET.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamVET
{
    public partial class Form1 : Form
    {
        private bool isCollapsed;
        private bool isCollapsed2;
        private bool isCollapsed3;
        private bool isCollapsed4;


        public Form1()
        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button8.Image = Resources.iconfinder_arrow_up_01_186407;
                
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button8.Image = Resources.drop_down_arrow; 
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void openchild6(Form childform6)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform6;
            childform6.TopLevel = false;
            childform6.Location = panel5.Location;
            childform6.Size = panel5.Size;

            childform6.FormBorderStyle = FormBorderStyle.None;
            childform6.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform6);
            panel5.Tag = childform6;
            childform6.BringToFront();
            childform6.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ProductList productlist = new ProductList();
            openchild6(productlist);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                button3.Image = Resources.iconfinder_arrow_up_01_186407;

                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                button3.Image = Resources.drop_down_arrow;
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed3)
            {
                button9.Image = Resources.iconfinder_arrow_up_01_186407;

                panel3.Height += 10;
                if (panel3.Size == panel3.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed3 = false;
                }
            }
            else
            {
                button9.Image = Resources.drop_down_arrow;
                panel3.Height -= 10;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed3 = true;
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsed4)
            {
                button14.Image = Resources.iconfinder_arrow_up_01_186407;

                panel4.Height += 10;
                if (panel4.Size == panel4.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsed4 = false;
                }
            }
            else
            {
                button14.Image = Resources.drop_down_arrow;
                panel4.Height -= 10;
                if (panel4.Size == panel4.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsed4 = true;
                }
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private Form activeform = null;
        private void openchild(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform;
            childform.TopLevel = false;
            childform.Location = panel5.Location;
            childform.Size = panel5.Size;

            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform);
            panel5.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboared = new Dashboard();
            openchild(dashboared);
        }

        private void openchild2(Form childform2)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform2;
            childform2.TopLevel = false;
            childform2.Location = panel5.Location;
            childform2.Size = panel5.Size;

            childform2.FormBorderStyle = FormBorderStyle.None;
            childform2.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform2);
            panel5.Tag = childform2;
            childform2.BringToFront();
            childform2.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            HRMcs hrm = new HRMcs();
            openchild2(hrm);
        }

        private void openchild3(Form childform3)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform3;
            childform3.TopLevel = false;
            childform3.Location = panel5.Location;
            childform3.Size = panel5.Size;

            childform3.FormBorderStyle = FormBorderStyle.None;
            childform3.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform3);
            panel5.Tag = childform3;
            childform3.BringToFront();
            childform3.Show();

        }
        private void button11_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner();
            openchild3(owner);
        }

        private void openchild4(Form childform4)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform4;
            childform4.TopLevel = false;
            childform4.Location = panel5.Location;
            childform4.Size = panel5.Size;

            childform4.FormBorderStyle = FormBorderStyle.None;
            childform4.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform4);
            panel5.Tag = childform4;
            childform4.BringToFront();
            childform4.Show();

        }
        private void button10_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            openchild4(patient);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openchild5(Form childform5)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform5;
            childform5.TopLevel = false;
            childform5.Location = panel5.Location;
            childform5.Size = panel5.Size;

            childform5.FormBorderStyle = FormBorderStyle.None;
            childform5.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform5);
            panel5.Tag = childform5;
            childform5.BringToFront();
            childform5.Show();

        }
        private void button13_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            openchild5(report);
        }

        private void openchild7(Form childform7)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform7;
            childform7.TopLevel = false;
            childform7.Location = panel5.Location;
            childform7.Size = panel5.Size;

            childform7.FormBorderStyle = FormBorderStyle.None;
            childform7.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform7);
            panel5.Tag = childform7;
            childform7.BringToFront();
            childform7.Show();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            openchild7(suppliers);
        }

        private void openchild8(Form childform8)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform8;
            childform8.TopLevel = false;
            childform8.Location = panel5.Location;
            childform8.Size = panel5.Size;

            childform8.FormBorderStyle = FormBorderStyle.None;
            childform8.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform8);
            panel5.Tag = childform8;
            childform8.BringToFront();
            childform8.Show();

        }

        private void openchild9(Form childform9)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform9;
            childform9.TopLevel = false;
            childform9.Location = panel5.Location;
            childform9.Size = panel5.Size;

            childform9.FormBorderStyle = FormBorderStyle.None;
            childform9.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform9);
            panel5.Tag = childform9;
            childform9.BringToFront();
            childform9.Show();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            PurchaseOrder purchaseorder = new PurchaseOrder();
            openchild9(purchaseorder);
        }

        private void openchild10(Form childform10)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform10;
            childform10.TopLevel = false;
            childform10.Location = panel5.Location;
            childform10.Size = panel5.Size;

            childform10.FormBorderStyle = FormBorderStyle.None;
            childform10.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform10);
            panel5.Tag = childform10;
            childform10.BringToFront();
            childform10.Show();

        }
        private void button17_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            openchild10(services);
        }

        private void openchild11(Form childform11)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform11;
            childform11.TopLevel = false;
            childform11.Location = panel5.Location;
            childform11.Size = panel5.Size;

            childform11.FormBorderStyle = FormBorderStyle.None;
            childform11.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform11);
            panel5.Tag = childform11;
            childform11.BringToFront();
            childform11.Show();

        }
        private void button16_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            openchild11(product);
        }

        private void openchild12(Form childform12)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform12;
            childform12.TopLevel = false;
            childform12.Location = panel5.Location;
            childform12.Size = panel5.Size;

            childform12.FormBorderStyle = FormBorderStyle.None;
            childform12.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform12);
            panel5.Tag = childform12;
            childform12.BringToFront();
            childform12.Show();

        }
        private void button15_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            openchild12(invoice);
        }

        private void openchild13(Form childform13)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform13;
            childform13.TopLevel = false;
            childform13.Location = panel5.Location;
            childform13.Size = panel5.Size;

            childform13.FormBorderStyle = FormBorderStyle.None;
            childform13.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform13);
            panel5.Tag = childform13;
            childform13.BringToFront();
            childform13.Show();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            openchild13(calendar);
        }

        private void openchild14(Form childform14)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childform14;
            childform14.TopLevel = false;
            childform14.Location = panel5.Location;
            childform14.Size = panel5.Size;

            childform14.FormBorderStyle = FormBorderStyle.None;
            childform14.Dock = DockStyle.Fill;

            panel5.Controls.Add(childform14);
            panel5.Tag = childform14;
            childform14.BringToFront();
            childform14.Show();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            openchild14(appointment);
        }


    }
}
