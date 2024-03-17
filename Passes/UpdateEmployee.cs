using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passes
{
    public partial class UpdateEmployee : Form
    {
        DatabaseOperation databaseOperation=new DatabaseOperation();
        String query;
        DataSet ds;
        Boolean employeeAvailable=false;
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                String UserName=txtusername.Text;
                //query="select e.",a."from employee as e inner join appUser as a on  e.appuser_fk=a.appuser_pk where  a.username='" + UserName + "'";
                ds = databaseOperation.getData(query);
                if(ds!=null && ds.Tables[0].Rows.Count!=0)
                {
                    employeeAvailable = true;
                    textname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txthiredate.Text = ds.Tables[0].Rows[0][2].ToString();
                    textcontact.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtgender.Text = ds.Tables[0].Rows[0][4].ToString();
                    textadress.Text = ds.Tables[0].Rows[0][5].ToString();
                    textcity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtstate.Text = ds.Tables[0].Rows[0][7].ToString ();



                }
                else
                {
                    employeeAvailable = false;
                    MessageBox.Show("Employee not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
               


            }catch(Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }
        private void clearAllFields()
        {
            textname.Clear();
            textadress.Clear();
            textcity.Clear();
            txtstate.Clear();
            textcontact.Clear();
            txtgender.SelectedIndex = -1;
            txthiredate.ResetText();
            employeeAvailable=false;

                
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                String Name=textname.Text;
                String Contact=textcontact.Text;
                String Gender=txtgender.Text;
                String Address=textadress.Text;
                String City=textcity.Text;
                String State=txtstate.Text;
                String UserName=txtusername.Text;   
                if(employeeAvailable)
                {
                    if(!String.IsNullOrEmpty(Name)&&
                        !String.IsNullOrEmpty(Contact)&&
                        !String.IsNullOrEmpty(Gender)&&
                        !String.IsNullOrEmpty(Address)&&
                        !String.IsNullOrEmpty(City)&&
                        !String.IsNullOrEmpty(State)&&
                        !String.IsNullOrEmpty(UserName))
                        {
                        Int64 number=Int64.Parse(Contact);
                        //if error occur please checkthe exact name in sql table like e.ename etc
                        query = "update e set e.ename ='" + Name + "',e.contact=" + number + ",e.gender='" + Gender + "',e.address='" + Address + "',e.city='" + City + "',e.state='" + State + "' from employee as e inner join appUser as a on e.appUser_fk=a.appUser_pk where a.username='"+UserName+"'";
                        databaseOperation.setData(query, "Employee updated");
                        clearAllFields();

                    }
                    else
                    {
                        MessageBox.Show("Fieldempty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }

                }
                else
                {
                    MessageBox.Show("Employee not found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void textcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void textcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthiredate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstate_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateemp_Click(object sender, EventArgs e)
        {

        }
    }
}
