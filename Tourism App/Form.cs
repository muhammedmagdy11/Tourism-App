using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Employee obj = (from emp in Program._dbContext.Employees
                           where emp.Email == txt_UserName.Text && emp.Password == txt_Password.Text
                           select emp).FirstOrDefault();

            if (obj != null)
            {
                lbl_Error.Visible = false;
                if (obj.IsAdmin)
                    MessageBox.Show("Hello Admin");
                else
                {
                    MessageBox.Show("Hello Employee");
                    EmployeeForm employeeForm = new EmployeeForm();
                    this.Hide();
                    employeeForm.Show();
                }
            }
            else
                lbl_Error.Visible = true;

        }
    }
}
