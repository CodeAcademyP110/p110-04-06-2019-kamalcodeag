using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P110_WinForm_demo
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            UpdateStudentDropdown();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure to delete student?", "Confirmation!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                string selectedStudentId = cmbStudents.Text.Substring(0, 4);

                if (P110.DeleteStudentById(selectedStudentId))
                {
                    UpdateStudentDropdown();
                }
                else
                {
                    MessageBox.Show("Not found");
                }

            }
        }

        private void UpdateStudentDropdown()
        {
            cmbStudents.Items.Clear();
            foreach (var stu in P110.GetStudents())
            {
                cmbStudents.Items.Add(stu.Id + " - " + stu.Fullname);
            }
            cmbStudents.SelectedIndex = 0;
        }
    }
}
