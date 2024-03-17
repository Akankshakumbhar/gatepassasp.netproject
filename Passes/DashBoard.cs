using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passes
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        String role;
        public DashBoard (String role)
        {
            InitializeComponent();
            this.role = role;
        } 
        private void labelwelcometxt_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            String backgroundname;
            if("Admin.".Equals(role))
            {
                EmployeetoolStripMenuItem1.Visible = true;
                backgroundname = "getPassBg1";
                labelwelcometxt.Text = "Welcome Admin";

            }
            else
            {
                EmployeetoolStripMenuItem1.Visible = false;
                backgroundname = "gatePassBg2";
                labelwelcometxt.Text = "Employee Dashboard";

            }
            Image image = Image.FromFile(Utility.getImageStorePath(backgroundname));
            this.BackgroundImage= image;
            this.BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void btnLogoutMenuStrip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();


            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you want to exit ", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<AddEmployee>().First().BringToFront();

            }
            else
            {
                AddEmployee addEmployee = new AddEmployee();
                addEmployee.Show();
            }
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<UpdateEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<UpdateEmployee>().First().BringToFront();
                    
            }
            else
            {
                UpdateEmployee updateEmployee = new UpdateEmployee();
                updateEmployee.Show();
            }
        }

        private void viewAllEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<ViewEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<ViewEmployee>().First().BringToFront();  
            }
            else
            {
                ViewEmployee viewEmployee = new ViewEmployee();
                viewEmployee.Show();

            }
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<DeleteEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<DeleteEmployee>().First().BringToFront();

            }
            else
            {
                DeleteEmployee deleteEmployee = new DeleteEmployee();
                deleteEmployee.Show();
            }
        }

        private void addVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<AddVisitor>().Count() == 1)
            {
                Application.OpenForms.OfType<AddVisitor>().First().BringToFront();

            }
            else
            {
                AddVisitor addVisitor = new AddVisitor();
                addVisitor.Show();
            }
        }

        private void updateVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<UpdateVisitor>().Count() == 1)
            {
                Application.OpenForms.OfType<UpdateVisitor>().First().BringToFront();
            }
            else
            {
                UpdateVisitor updateVisitor = new UpdateVisitor();
                updateVisitor.Show();

            }
        }

        private void viewVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ViewVisitors>().Count() == 1)
            {
                Application.OpenForms.OfType<ViewVisitors>().First().BringToFront();
            }
            else
            {
                ViewVisitors viewvisitor = new ViewVisitors();
                viewvisitor.Show();

            }
        }

        private void generatePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<GeneratePass>().Count() == 1)
            {
                Application.OpenForms.OfType<GeneratePass>().First().BringToFront();

            }
            else
            {
                GeneratePass generatepass = new GeneratePass();
                generatepass.Show();
            }

        }

        private void validatePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<ValidateForm>().Count() == 1)
            {
                Application.OpenForms.OfType<ValidateForm>().First().BringToFront();

            }
            else
            {
                ValidateForm validateform = new ValidateForm();
                validateform.Show();

            }
        }

        private void filterPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FilterPass>().Count() == 1)
            {
                Application.OpenForms.OfType<FilterPass>().First().BringToFront();

            }
            else
            {
                FilterPass filterpass = new FilterPass();
                filterpass.Show();

            }
        }
    }
    }

