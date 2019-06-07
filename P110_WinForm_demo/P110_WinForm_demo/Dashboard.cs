using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P110_WinForm_demo
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            #region Update Maximum Date of birthdate
            var today = DateTime.Now.AddDays(1);
            dtBirthdate.MaxDate = today;
            #endregion

            #region Filling listBoxControl with Students
            //foreach (var stu in P110.GetStudents())
            //{
            //    lbStudent2.Items.Add(stu);
            //}
            //lbStudent2.DataSource = P110.GetStudents();
            //lbStudent2.DisplayMember = "Email";
            #endregion

            dgwStudents.DataSource = P110.GetStudents();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstname.Text.Trim();
            string lastname = txtLastname.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime birthdate = dtBirthdate.Value;

            //Firstname and lastname validation
            if (firstname == string.Empty)
            {
                MessageBox.Show("Firstname is empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lastname == string.Empty)
            {
                MessageBox.Show("Lastname is empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Email validation
            try
            {
                MailAddress mail = new MailAddress(email);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Email is not valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validation is OK, Create Student and Add student
            Student student = new Student
            {
                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                Birthdate = birthdate
            };

            P110.AddStudent(student);
            ResetAddStudentControls();

            //update DataGridView to show new Student
            dgwStudents.DataSource = null;
            dgwStudents.DataSource = P110.GetStudents();
        }

        private void ResetAddStudentControls()
        {
            txtFirstname.Text = txtLastname.Text = txtEmail.Text = "";
            dtBirthdate.Value = DateTime.Now;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.FormClosed += UpdateDatagridWhenFormClosed;
            deleteStudent.ShowDialog();
        }

        private void UpdateDatagridWhenFormClosed(object sender, EventArgs e)
        {
            dgwStudents.DataSource = null;
            dgwStudents.DataSource = P110.GetStudents();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudent updateStudent = new UpdateStudent();
            updateStudent.FormClosed += UpdateDatagridWhenFormClosed;
            updateStudent.ShowDialog();
        }
    }
}
