using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_Studio
{
    public partial class Login : Form
    {
        string path = @"Data Source=MUKAHHAL\SQLEXPRESS; Initial Catalog=student_management_studio;Integrated Security=True";
        SqlConnection connection;

        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(path);
            WindowState = FormWindowState.Maximized;

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameBox.Text != "" && passwordBox.Text != "")
                {
                    SqlCommand command = new SqlCommand("SELECT * from Admin WHERE Admin_Username=@Name AND Admin_Password=@Pass", connection);
                    command.Parameters.Add("@Name", usernameBox.Text);
                    command.Parameters.Add("@Pass", passwordBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    //Filling an hidden dataset with the querry result
                    //If the sql querry found a match it will fill it in the dataset
                    int count = dataSet.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        Main main = new Main();
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username and Password");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the username and password");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
