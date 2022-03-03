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
        String path;
        public Main(String path)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.path = path;
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
            loadForm(new Registration(path));

        }


        private void gradeBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Grades(path));
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
           loadForm(new ReportCardForm(path));
        }

    }
}
