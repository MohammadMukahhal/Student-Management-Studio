using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_Studio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        public void loadForm(Object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.Show();
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Registration());

        }


        private void gradeBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Grades());
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
          //  loadForm(new InvoiceForm());
        }

    }
}
