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
    public partial class Registration : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dataTable;

        int currStudentID; //Used for update and delete functions
        public Registration(String path)
        {
            InitializeComponent();
            connection = new SqlConnection(path);
            display();
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }
        public void display()
        {
            try
            {
                dataTable = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("select * from StudentTable", connection);
                adapter.Fill(dataTable);
                dataGridViewRegistration.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || addressBox.Text == "" || gpaBox.Text == "" || phoneBox.Text == "" || guardianNameBox.Text == "" ||
               guardianNumberBox.Text == "")
            {
                MessageBox.Show("Please make sure all data is entered");
            }
            else
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand("insert into StudentTable(name,dob,student_address,phone_num," +
                        "guardian_name,guardian_number,overallGPA) values('" + nameBox.Text + "','" + dateTimeBox.Value.Date + "','" + addressBox.Text + "'," +
                        "'" + phoneBox.Text + "','" + guardianNameBox.Text + "','" + guardianNumberBox.Text + "','" + gpaBox.Text + "')");
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                    clear();
                    display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void clear()
        {
            nameBox.Text = "";
            addressBox.Text = "";
            gpaBox.Text = "";
            phoneBox.Text = "";
            guardianNameBox.Text = "";
            guardianNumberBox.Text = "";
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataTable = new DataTable();
                connection.Open();
                if (dobBtn.Checked)
                {
                    adapter = new SqlDataAdapter("select * from StudentTable where dob like '%" + searchBox.Text + "%' ", connection);
                }
                else if (phoneNumberBtn.Checked)
                {
                    adapter = new SqlDataAdapter("select * from StudentTable where phone_num like '%" + searchBox.Text + "%' ", connection);
                }
                else if (addressBtn.Checked)
                {
                    adapter = new SqlDataAdapter("select * from StudentTable where student_addrsss like '%" + searchBox.Text + "%' ", connection);
                }
                else
                {
                    adapter = new SqlDataAdapter("select * from StudentTable where name like '%" + searchBox.Text + "%' ", connection);
                }
                adapter.Fill(dataTable);
                dataGridViewRegistration.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dataGridViewRegistration_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                updateBtn.Enabled = true;
                deleteBtn.Enabled = true;

                currStudentID = int.Parse(dataGridViewRegistration.Rows[e.RowIndex].Cells[0].Value.ToString());
                nameBox.Text = dataGridViewRegistration.Rows[e.RowIndex].Cells[1].Value.ToString();
                String date = dataGridViewRegistration.Rows[e.RowIndex].Cells[2].Value.ToString();
                phoneBox.Text = dataGridViewRegistration.Rows[e.RowIndex].Cells[3].Value.ToString();
                guardianNameBox.Text = dataGridViewRegistration.Rows[e.RowIndex].Cells[4].Value.ToString();
                guardianNumberBox.Text = dataGridViewRegistration.Rows[e.RowIndex].Cells[5].Value.ToString();
                gpaBox.Text = dataGridViewRegistration.Rows[e.RowIndex].Cells[6].Value.ToString();
                addressBox.Text = dataGridViewRegistration.Rows[e.RowIndex].Cells[7].Value.ToString();

                var dateSplit = date.Split('/');
                dateTimeBox.Value = new DateTime(int.Parse(dateSplit[2].Substring(0, 4)), int.Parse(dateSplit[0]), int.Parse(dateSplit[1]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("UPDATE StudentTable SET name='" + nameBox.Text + "', dob='" + dateTimeBox.Value.Date + "', student_address=" +
                    "'" + addressBox.Text + "', overallGPA='" + gpaBox.Text + "', phone_num='" + phoneBox.Text + "', guardian_name='" + guardianNameBox.Text + "', " +
                    "guardian_number='" + guardianNumberBox.Text + "' WHERE id='" + currStudentID + "'", connection);

                command.ExecuteNonQuery();
                connection.Close();
                display();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                //command = new SqlCommand("DELETE FROM Course WHERE id='" + currStudentID + " '", connection);
                //command.ExecuteNonQuery();
                command = new SqlCommand("DELETE FROM Course WHERE student_id='" + currStudentID.ToString() + "'", connection);
                command.ExecuteNonQuery();
                command = new SqlCommand("DELETE FROM StudentTable WHERE id='" + currStudentID.ToString() + "'", connection);
                command.ExecuteNonQuery();

                connection.Close();
                display();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
