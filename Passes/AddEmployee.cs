using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Passes
{
    public partial class AddEmployee : Form
    {
        DatabaseOperation databaseOperation =new DatabaseOperation();
        String query;
        DataSet ds;

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                String NAME = textname.Text;
                String hiredate = txthiredate.Text;

                String contact =textcontact.Text;
                String gender = txtgender.Text;
                String adress = textadress.Text;
                String city = textcity.Text;
                String state = textstate.Text;
                String username = txtusername.Text;//remeber same must be in the sql table username not allow as UserName or anything else (remeber while creating table sql wala)
                String Password = textpassword.Text;

                if(!String.IsNullOrEmpty(NAME) &&
                    !String.IsNullOrEmpty(hiredate)
                    && !String.IsNullOrEmpty(contact)
                    && !String.IsNullOrEmpty(gender)
                    && !String.IsNullOrEmpty(adress)
                    && !String.IsNullOrEmpty(city)
                    && !String.IsNullOrEmpty(state)
                    && !String.IsNullOrEmpty(username)
                    && !String.IsNullOrEmpty(Password))
                    {
                    Int64 contactInt=Int64.Parse(contact);
                    string query = "SELECT * FROM appUser WHERE username='" + username + "' AND unabled=1";
                    ds=databaseOperation.getData(query);
                    if(ds!=null && ds.Tables[0].Rows.Count == 0)
                    {
                        query = "insert into appUser( username,upass,urole)values('" + username + "','" + Password + "','+ EMPLOYEE + ')";
                        databaseOperation.setData(query,null);
                        query = "select  * from appUser where username='" + username + "' andupass='" + Password + "' and unabled==1";
                        databaseOperation.getData(query);

                        //     query="insert into employee (ename,hiredate,contact,address,city,state,appuser_fk")values('"+name+"','"+hiredate+"',"+contactInt+",'"+gender+'','"adess)"
                        databaseOperation.setData(query, "Employee addedSucessFully");
                        clearAllFields();

                    }
                    else
                    {
                        MessageBox.Show("Username already linked with another account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }




                }
                else
                {
                    MessageBox.Show("Field empty. Fill and try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in Add Employee btnSave click:"+ex);
                MessageBox.Show("Something went wrong" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);

        }
        private void clearAllFields()
        {
            textname.Clear();
            txthiredate.ResetText();
            textcontact.Clear();
            txtgender.SelectedIndex = 1;
            textadress.Clear();
            textcity.Clear();   
            textstate.Clear();
            txtusername.Clear();
            textpassword.Clear();



        }
    }
}
