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
    public partial class Form1 : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        String query;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                query = "SELECT * FROM appUser WHERE username = @username AND upass = @password AND uenabled = 1";
                DataSet ds = databaseOperation.getData(query);
                if (ds != null && ds.Tables[0].Rows.Count != 0)
                {

                    String role = ds.Tables[0].Rows[0][3].ToString();
                   Int64 appUserPk = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    DashBoard dashbord=new DashBoard(role);
                    dashbord.Show();
                    this.Hide();

               }
                else
                {
                    MessageBox.Show("Bad Credential ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in button Login"+ex);
                MessageBox.Show("Something went wrong:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
