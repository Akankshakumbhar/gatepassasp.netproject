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
    public partial class AddVisitor : Form
    {
        DatabaseOperation databaseOperation=new DatabaseOperation();
        String query;
        DataSet ds;

        public AddVisitor()
        {
            InitializeComponent();
        }
        String visitorId;
        Boolean imageUploaded=false;
        String path;


        private void bexit_Click(object sender, EventArgs e)
        {
            if (imageUploaded)
            {
                if(MessageBox.Show("Image will be removed","warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    System.IO.File.Delete(path);
                    this.Close();
                     
                }


            }
            else
            {
                this.Close();
            }

        }

        private void AddVisitor_Load(object sender, EventArgs e)
        {
            visitorId = Utility.GetUniqueId("VID.");
            txtvisitorid.Text = visitorId;
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Images\\" + visitorId + ".jpg";


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "(*.jpg;*.jpeg;*.bmp;)|*.jpg;*.jpeg;.bmp";
            open.FilterIndex = 1;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(open.CheckFileExists)
                {
                    if (!File.Exists(path))
                    {
                        System.IO.File.Copy(open.FileName, path);


                    }
                    else
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                        System.IO.File.Delete(path);
                        System.IO.File.Copy(open.FileName, path);


                    }
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(path);
                    imageUploaded = true;


                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String Name = textname.Text;
                String Contact=textcontact.Text;
                String Gender=txtgender.Text;
                String Address=textadress.Text;
                String UniqueId =txtuniqueid.Text;
                if (imageUploaded)
                {
                    if (!String.IsNullOrEmpty(Name) &&
                        !String.IsNullOrEmpty(Contact) &&
                        !String.IsNullOrEmpty(Gender) &&
                        !String.IsNullOrEmpty(Address) &&
                        !String.IsNullOrEmpty(UniqueId))
                    {




                        Int64 contactnum = Int64.Parse(Contact);
                         query = "INSERT INTO visitors (vname, contact, gender, vaddress, uniqueid, visitorid) VALUES ('" + Name + "','" + Contact + "','" + Gender + "','" + Address + "','" + UniqueId + "','" + visitorId + "')";
                        databaseOperation.setData(query, "Visitor Added sucessfully");
                        clearAllFields();


                    }
                    else
                    {

                        MessageBox.Show("Fill Mandotory fieldsand try Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

                else
                {
                    MessageBox.Show("Picture not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Add visitor Save Click", ex);
                MessageBox.Show("Somethig went wrong"+ex,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void textcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }
        private  void clearAllFields()
        {
            textname.Clear();
            textcontact.Clear();
            txtuniqueid.Clear();
            txtgender.SelectedIndex = -1;
            textadress.Clear();

            imageUploaded = false;
            if(pictureBox1.Image != null)
            {
                pictureBox1 .Image.Dispose();
                pictureBox1 .Image = null;
            }
            AddVisitor_Load(this, null);




        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }
    }
}
