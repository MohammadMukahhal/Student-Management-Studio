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
    public partial class Grades : Form
    {
        string path = @"Data Source=MUKAHHAL\SQLEXPRESS; Initial Catalog=student_management_studio;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dataTable;

        int currStudentID; //Used for update and delete functions
        public Grades()
        {
            InitializeComponent();
            connection = new SqlConnection(path);
            display();
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }



        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (courseBox.Text == "" || idBox.Text == "" || idBox.Text == "")
            {
                MessageBox.Show("Please make sure all data is entered");
            }
            else
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand("insert into Course(student_id,course_name,course_grade) values('" + idBox.Text + "','" + courseBox.Text + "','" + gradeBox.Text + "')");
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
            courseBox.Text = "";
            idBox.Text = "";
            gradeBox.Text = "";
        }

        public void display()
        {
            try
            {
                dataTable = new DataTable();
                connection.Open();
                String courseName = searchBox.Text;
                adapter = new SqlDataAdapter("select StudentTable.id,StudentTable.name,StudentTable.dob," +
                    "Course.course_name,Course.course_grade FROM StudentTable " +
                    "INNER JOIN Course ON Course.student_id = StudentTable.id " +
                    "WHERE Course.course_name like'%" + searchBox.Text + "%'", connection);
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displatBtn_Click(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                updateBtn.Enabled = true;
                deleteBtn.Enabled = true;

                currStudentID = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                idBox.Text = currStudentID.ToString();
                courseBox.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                gradeBox.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

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
                command = new SqlCommand("UPDATE Course SET course_name='" + courseBox.Text + "', course_grade='" + gradeBox.Text + "' WHERE student_id='" + currStudentID + "' AND course_name='" + courseBox.Text + "'", connection);

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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                command = new SqlCommand("DELETE FROM Course SET course_name='" + courseBox.Text + "', course_grade='" + gradeBox.Text + "' WHERE student_id='" + currStudentID + "' AND course_name='" + courseBox.Text + "'", connection);
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

        private void displayBtn_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
