using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passes
{
    public partial class Pass : Form
    {
        DatabaseOperation databaseOperation=new DatabaseOperation();
        String query;
        DataSet ds;
        public Pass()
        {
            InitializeComponent();
        }
        String path,passId,name,contact,gender,validfrom,validto;
        public Pass(string path,string passId,string name,string contact,string gender,string validfrom,string validto,Int64 visitor_pk,Int64 days)
        {
            InitializeComponent();
            try
            {
                pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxProfile.Image = Image.FromFile(path);

            }
            catch(Exception ex)
            {

            }
            labelpassid.Text = passId;
            labelname.Text = name;
            labelcontact.Text = contact;
            labelgender.Text = gender;
            labelvalidfor.Text = validfrom;
            labelvalidt.Text = validto;

            setPassColor(days);
            savePassDetails(passId,validfrom,validto,visitor_pk);


            this.path=path;
            this.passId=passId;
            this.name=name;
            this.contact=contact;
            this.gender=gender;
            this.validfrom=validfrom;
            this.validto=validto;

        }

        private void setPassColor(object days)
        {
            throw new NotImplementedException();
        }

        private void setPassColor(Int64 days)
        {
            if (days == 0)
            {
                this.BackColor = Color.Gray;

            }
            else if (days <= 6)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.SkyBlue;
            }
        }
        private void savePassDetails(String passid,String validfrom,String vaildto,Int64 visitorpk)
        {
            try
            {
                DateTime validformdate = DateTime.ParseExact(validfrom, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                DateTime validtodate = DateTime.ParseExact(validto, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                query="Insert into pass(passid,validForm,validTo,visitor_fk)values('"+passid+"','"+validformdate.ToString("yyyy-MM-dd")+"','"+validtodate.ToString("yyyy-MM-dd")+"','"+visitorpk+")";
                databaseOperation.setData(query, null);


            }
            catch(Exception ex) { 

                Console.WriteLine(ex);
            }

        }
        Bitmap bmp;
        private void Print()
        {
            bmp=new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp,new Rectangle(0,0,this.Width,this.Height));


        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle r = e.PageBounds;
            e.Graphics.DrawImage(bmp,r);

        }

        private void labelpassid_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelNames_Click(object sender, EventArgs e)
        {

        }

        private void labelgender_Click(object sender, EventArgs e)
        {

        }

        private void Pass_Load(object sender, EventArgs e)
        {
            Print();
            printPreviewDialog1.ShowDialog();
            this.Close();


        }

        private void Pass_Load_1(object sender, EventArgs e)
        {

        }
    }
}
