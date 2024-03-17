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
    public partial class DeleteEmployee : Form
    {
        DatabaseOperation databaseOperation=new DatabaseOperation();
        String query;
        DataSet ds;
        Boolean employeeAvailable=false;




        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                String UserName=txtusername.Text;
                query="select e. *,a.* from employee as e inner join  appUser as a on e.appUser_fk=a.appuser_pk where a.username='"+UserName+"'";
                ds = databaseOperation.getData(query);
                if(ds!= null && ds.Tables[0].Rows.Count!=0) 
                {
                    employeeAvailable = true;
                    textname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txthiredate.Text = ds.Tables[0].Rows[0][2].ToString();
                    textcontact.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtgender.Text = ds.Tables[0].Rows[0][4].ToString();
                    textadress.Text = ds.Tables[0].Rows[0][5].ToString();
                    textcity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtstate.Text = ds.Tables[0].Rows[0][7].ToString();



                }
                else
                {
                    employeeAvailable = false;
                    MessageBox.Show("Employee not found","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                this.Close();
            }

        }
        private void clearAllField()
        {
            textadress.Clear();
            textcity.Clear();
            textcontact.Clear();
            txtgender.SelectedIndex = -1;
            txthiredate.ResetText();
            textname.Clear();
            txtstate.Clear();
            employeeAvailable=false;

        }

        private void btreset_Click(object sender, EventArgs e)
        {
            clearAllField();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(employeeAvailable)
                {
                    query="delete from employee from appUser where appuser_fk=appuser_pk and username='"+txtusername.Text+"'";
                    databaseOperation.setData(query,"Employee deleted");
                    query = "select from appUser where username='" + txtusername.Text + "'";
                    databaseOperation.setData(query, null);
                    clearAllField();



                }
                else
                {


                    employeeAvailable = false;
                    MessageBox.Show("Employee not Found","Information",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                }
            } catch (Exception ex) 
            {

                Console.WriteLine(ex);
                }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            clearAllField();
        }
    }
}
