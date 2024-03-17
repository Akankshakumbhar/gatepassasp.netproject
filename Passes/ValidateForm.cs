using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passes
{
    public partial class ValidateForm : Form
    {
        DatabaseOperation databaseOperation=new DatabaseOperation();
        String query;
        DataSet ds;
        public ValidateForm()
        {
            InitializeComponent();
        }

        private void ValidateForm_Load(object sender, EventArgs e)
        {
            query = "select v.*,p.passId,p.validFrom,p.ValidTo from visitors as v inner join  pass as p  on v.visitors_pk=p.visitors_fk";
            ds=databaseOperation.getData(query);
            dataGridViewVisitors.DataSource = ds.Tables[0];

            pictureBox1.BackColor = Color.LightGreen;
            pictureBox2.BackColor = Color.IndianRed;




        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public static bool IsDateAfterTodayOrToday(String input)
        {
            DateTime pDate;
            if(!DateTime.TryParseExact(input,"dd-MM-yyyy hh:mm:ss",CultureInfo.InvariantCulture ,DateTimeStyles.None,out pDate))
            {
                return false;
            }
            else
            {
                return true;
            }
            return DateTime.Today <= pDate;

        }
        String path;
        Int64 visitorPk;


        private void dataGridViewVisitors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                path = Utility.getImageStorePath(dataGridViewVisitors.Rows[e.RowIndex].Cells[6].Value.ToString());
                visitorPk = Int64.Parse(dataGridViewVisitors.Rows[e.RowIndex].Cells[0].Value.ToString());
                labelpassid.Text = dataGridViewVisitors.Rows[e.RowIndex].Cells[7].Value.ToString();
                labelname.Text = dataGridViewVisitors.Rows[e.RowIndex].Cells[1].Value.ToString();
                labelcontact.Text = dataGridViewVisitors.Rows[e.RowIndex].Cells[2].Value.ToString();
                labelgender.Text = dataGridViewVisitors.Rows[e.RowIndex].Cells[3].Value.ToString();
                labelvalidform.Text = dataGridViewVisitors.Rows[e.RowIndex].Cells[8].Value.ToString();
                labelvalidto.Text = dataGridViewVisitors.Rows[e.RowIndex].Cells[9].Value.ToString();


                if (IsDateAfterTodayOrToday(dataGridViewVisitors.Rows[e.RowIndex].Cells[9].Value.ToString()))
                {
                    panel1.BackColor = Color.LightGreen;

                }
                else
                {
                    panel1.BackColor = Color.IndianRed;

                }

                if(pictureBoxProfile.Image != null)
                {
                    pictureBoxProfile.Image.Dispose();
                    pictureBoxProfile.Image = null;
                }
                pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxProfile.Image = Image.FromFile(path);




            }catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            query = "Select v.*,v.passId,v.validFrom,p.validTo from visitors as v inner join pass as p on v.visitors_pk=p.visitors_fk where v.passId like'" + txtsearch.Text + "%' or  v.visitorId like '" + txtsearch.Text + "%'or v.vname like '" + txtsearch.Text + "%'";
           ds= databaseOperation.getData(query);
            dataGridViewVisitors.DataSource = ds.Tables[0];

        }
    }
}
