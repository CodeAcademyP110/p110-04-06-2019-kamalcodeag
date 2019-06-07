using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace P110_WinForm_demo
{
    public partial class UpdateStudent : Form
    {
        private Student StudentToUpdate = null;

        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            UpdateStudentDropdown();
        }

        private void UpdateStudentDropdown()
        {
            cmbStudents.Items.Clear();
            foreach (var stu in P110.GetStudents())
            {
                cmbStudents.Items.Add(stu.Id + " - " + stu.Fullname);
            }
        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStudentId = cmbStudents.Text.Substring(0, 4);

            StudentToUpdate = P110.GetStudentById(selectedStudentId);

            if(StudentToUpdate != null)
            {
                txtFirstname.Text = StudentToUpdate.Firstname;
                txtLastname.Text = StudentToUpdate.Lastname;
                txtEmail.Text = StudentToUpdate.Email;
                dtBirthdate.Value = StudentToUpdate.Birthdate;

                pnlEdit.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Email is not valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validation is OK, Update Student
            StudentToUpdate.Firstname = firstname;
            StudentToUpdate.Lastname = lastname;
            StudentToUpdate.Email = email;
            StudentToUpdate.Birthdate = birthdate;

            DialogResult result = MessageBox.Show("Student was successfully updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(result != 0)
            {
                Close();
            }
        }
    }
}
