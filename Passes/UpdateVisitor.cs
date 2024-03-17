using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passes
{
    public partial class UpdateVisitor : Form
    {
        DatabaseOperation databaseOperation=new DatabaseOperation();
        String query;
        DataSet ds;

        public UpdateVisitor()
        {
            InitializeComponent();
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Boolean isvisitorFound=false;

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                String Visitor=txtvisitorid.Text;
               // query = "select * from visitors where visitorid='" + visitorId + "'";
                ds = databaseOperation.getData(query);
                if(ds!=null && ds.Tables[0].Rows.Count !=0)
                { 
                    isvisitorFound = true;
                    textname.Text = ds.Tables[0].Rows[0][1].ToString();
                    textcontact.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtgender.Text = ds.Tables[0].Rows[0][3].ToString();
                    textadress.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtuniqueid.Text = ds.Tables[0].Rows[0][5].ToString();
                    Utility.setImageInPictureBox(pictureBox1,visitorId);



                }
                else
                {
                    isvisitorFound = false;
                    MessageBox.Show("No record found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }catch(Exception ex)
            {

            }
          

            
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearAllField();
        }
        private void clearAllField()
        {
            textname.Clear();
            textcontact.Clear();
            txtgender.SelectedIndex = -1;
            textadress.Clear();
            txtuniqueid.Clear();
            isvisitorFound=false;
            if(pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void textcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);

        }

        private void txtvisitorid_TextChanged(object sender, EventArgs e)
        {
            clearAllField();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String visitorId=txtvisitorid.Text;
            if (isvisitorFound)
            {
                String path = Utility.getImageStorePath(visitorId);
                OpenFileDialog open=new OpenFileDialog();
                open.InitialDirectory = "C:\\";
                open.Filter = "(*.jpg;*.jpeg;*.bmp;)|*.jpg;*.jpeg;*.bmp;";
                open.FilterIndex = 1;

                if(open.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    if(open.CheckFileExists)
                    {
                        if(!File.Exists(path))
                        {
                            System.IO.File.Copy(open.FileName, path);
                        }
                        else
                        {
                            pictureBox1.Image.Dispose ();
                            pictureBox1.Image = null;
                            System.IO.File.Delete(path);
                            System.IO.File.Copy(open.FileName, path);

                        }
                        pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image=Image.FromFile(path);
                    }
                }

            }
            else
            {
                MessageBox.Show("Visitor not found","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String name=textname.Text;
                String contact=textcontact.Text;
                String gender=txtgender.Text;
                String address=textadress.Text;
                String uniqueid=txtuniqueid.Text;
                String visitorid=txtvisitorid.Text;

                if(isvisitorFound)
                {
                    if(!String.IsNullOrEmpty(name)&&
                        !String.IsNullOrEmpty(contact)&&
                        !String.IsNullOrEmpty(gender)&&
                        !String.IsNullOrEmpty(address)&&
                        !String.IsNullOrEmpty(uniqueid)&&
                        !String.IsNullOrEmpty(visitorid))
                    {
                        Int64 number=Int64.Parse(contact);
                        query = "update visitor set vname='" + name + "',contact='" + contact + "',gender='" + gender + "',vaddress='" + address + "',uniqueid='" + uniqueid + "' where visitorid='" + visitorid + "'";
                        databaseOperation.setData(query, "visitor updated sucessfully");
                        clearAllField();

                    }
                    else
                    {
                        MessageBox.Show("Fields empty","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    }
                    

                    

                }
                else
                {
                    MessageBox.Show("Vistior not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went Wrong",ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);


            }
        }
    }
}
