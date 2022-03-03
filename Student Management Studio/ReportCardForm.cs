using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;
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
    public partial class ReportCardForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dataTable;
        public ReportCardForm(String path)
        {
            InitializeComponent();
            connection = new SqlConnection(path);
            display();
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
                idBox.Text = dataGridViewRegistration.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if(idBox.Text != "")
            {
                ArrayList data = new ArrayList();
                dataTable = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("select course_name, course_grade from Course WHERE student_Id like'%" + idBox.Text + "%'", connection);
                adapter.Fill(dataTable);
                dataGridViewRegistration.DataSource = dataTable;
                connection.Close();
                foreach (DataGridViewRow row in dataGridViewRegistration.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            data.Add(cell.Value.ToString());
                        }
                        else
                        {
                            break;
                        }

                    }
                }
                while(data.Count < 12)
                {
                    data.Add("");
                }

                double gpaVal = CalculateGPA(data);
                String gpaStr = gpaVal.ToString("0.##");
                //Section 2 Variables
                ReportCard rc = new ReportCard();
                TextObject nameBox = (TextObject)rc.ReportDefinition.Sections["Section2"].ReportObjects["nameBox"];
                TextObject dobBox = (TextObject)rc.ReportDefinition.Sections["Section2"].ReportObjects["dobBox"];
                TextObject addressBox = (TextObject)rc.ReportDefinition.Sections["Section2"].ReportObjects["addressBox"];
                //Section 2 Variables
                TextObject class1 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["class1"];
                TextObject class2 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["class2"];
                TextObject class3 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["class3"];
                TextObject class4 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["class4"];
                TextObject class5 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["class5"];
                TextObject class6 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["class6"];
                TextObject grade1 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["grade1"];
                TextObject grade2 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["grade2"];
                TextObject grade3 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["grade3"];
                TextObject grade4 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["grade4"];
                TextObject grade5 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["grade5"];
                TextObject grade6 = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["grade6"];
                TextObject gpa = (TextObject)rc.ReportDefinition.Sections["Section3"].ReportObjects["gpa"];

                //Getting section 2 from database
                var id = idBox.Text;
                connection.Open();

                command = new SqlCommand("select name from StudentTable WHERE id like'%" + id + "%'", connection);
                nameBox.Text = Convert.ToString(command.ExecuteScalar());

                command = new SqlCommand("select dob from StudentTable WHERE id like'%" + id + "%'", connection);
                dobBox.Text = Convert.ToString(command.ExecuteScalar()).Substring(0, 9);

                command = new SqlCommand("select student_address from StudentTable WHERE id like'%" + id + "%'", connection);
                addressBox.Text = Convert.ToString(command.ExecuteScalar());
                connection.Close();

                //Seting section 3


                class1.Text = data[0].ToString();
                grade1.Text = data[1].ToString();
                class2.Text = data[2].ToString();
                grade2.Text = data[3].ToString();
                class3.Text = data[4].ToString();
                grade3.Text = data[5].ToString();
                class4.Text = data[6].ToString();
                grade4.Text = data[7].ToString();
                class5.Text = data[8].ToString();
                grade5.Text = data[9].ToString();
                class6.Text = data[10].ToString();
                grade6.Text = data[11].ToString();

                gpa.Text = gpaStr;

                ReportViewer reportViewer = new ReportViewer();
                reportViewer.crystalReportViewer1.ReportSource = rc;
                reportViewer.Show();
            }
        }

        private double CalculateGPA(ArrayList data)
        {
            double points = 0;
            int count = 0;
            for(int x = 1; x < data.Count; x = x + 2)
            {
                switch (data[x])
                {
                    case "A+":
                        points += 4.0;
                        count++;
                        break;
                    case "A":
                        points += 4.0;
                        count++;
                        break;
                    case "A-":
                        points += 3.7;
                        count++;
                        break;
                    case "B+":
                        points += 3.3;
                        count++;
                        break;
                    case "B":
                        points += 3.0;
                        count++;
                        break;
                    case "B-":
                        points += 2.7;
                        count++;
                        break;
                    case "C+":
                        points += 2.3;
                        count++;
                        break;
                    case "C":
                        points += 2.0;
                        count++;
                        break;
                    case "C-":
                        points += 1.7;
                        count++;
                        break;
                    case "D+":
                        points += 1.3;
                        count++;
                        break;
                    case "D":
                        points += 1.0;
                        count++;
                        break;
                    case "D-":
                        points += 1.0;
                        count++;
                        break;
                    case "E":
                        points += 0.0;
                        count++;
                        break;
                    default:
                        points += 0.0;
                        break;
                }
            }
            return points / count;
        }
    }
}
