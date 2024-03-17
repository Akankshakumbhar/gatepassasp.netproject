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
    public partial class GeneratePass : Form
    {
        DatabaseOperation databaseOperation=new DatabaseOperation();
        String query;
        DataSet ds;



        public GeneratePass()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void GeneratePass_Load(object sender, EventArgs e)
        {
            query = "select * from visitor";
            ds=databaseOperation.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

            pictureBox1.BackColor = Color.Gray;
            pictureBox1.BackColor = Color.Yellow;
            pictureBox1.BackColor = Color.SkyBlue;




        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            String searchtext=txtsearch.Text;
            query = "select * visitors where vname like'%" + searchtext + "%' or uniqueid like'%"+searchtext+"%'or  visitorid like '%"+searchtext+"%'";
            ds=databaseOperation.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
        String passid;
        String path;
        Int64 visitorPk;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Images\\"+
                dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() + ".jpeg";
                passid = Utility.GetUniqueId("PID");
                visitorPk = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                labelpassid.Text = passid;
                labelname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                labelcontact.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                labelgender.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                if(pictureBoxProfile.Image != null)
                {
                    pictureBoxProfile.Image.Dispose();
                    pictureBoxProfile.Image = null;

                }
                else
                {
                    pictureBoxProfile.SizeMode=PictureBoxSizeMode.StretchImage;
                    pictureBoxProfile.Image = Image.FromFile(path);


                }
                


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private void setPassColor(Int64 days)
        {
            if(days==0)
            {
                panel1.BackColor = Color.Gray;

            }
            else if(days <=6)
            {
                panel1.BackColor = Color.Yellow;
            }
            else
            {
                panel1.BackColor = Color.SkyBlue;
            }
        }
        private void compareDate(String input)
        {
            DateTime  dtCurrent=DateTime.Now;
            DateTime inputDate=DateTime.ParseExact(input,"dd.MM,yyyy",CultureInfo.InvariantCulture);


            int result=DateTime.Compare(dtCurrent,inputDate);
            Console.WriteLine(result);


        }
        public static bool IsDateBeforeOrToday(string input)
        {
            DateTime pdate;
            if (!DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out pdate)) ;
            {
                return false;
            }
            return DateTime.Today<= pdate;



        }
        public static bool IsDateAfterValidForm(String date,String dateForm)
        {
            DateTime validto, ValidFrom;
            if (!DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out validto))
            {
                return false;

            }
            if (!DateTime.TryParseExact(dateForm, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ValidFrom))
            {
                return false;

            }
            return ValidFrom <= validto;

        }

        private void dateTimePickerValiidform_ValueChanged(object sender, EventArgs e)
        {
            if(IsDateBeforeOrToday(dateTimePickerValiidform.Text))
            {
                labelvalidform.Text = dateTimePickerValiidform.Text;

            }
            else
            {
                MessageBox.Show("Select today date or date after today","Information",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);


            }
        }
        Int64 days;


        private void dateTimePickerValidto_ValueChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(labelvalidform.Text))
            {
                if(IsDateAfterValidForm(dateTimePickerValidto.Text,labelvalidform.Text))
                {
                    labelvalidto.Text = dateTimePickerValidto.Text;
                    DateTime StartTime = DateTime.ParseExact(labelvalidform.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    DateTime EndDate= DateTime.ParseExact(labelvalidto.Text,"dd.MM.yyyy",CultureInfo.InvariantCulture);
                    days = (EndDate.Date - StartTime.Date).Days;
                    setPassColor(days);



                }
                else
                {
                    MessageBox.Show("Select dateafter valid from date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
            else
            {
                MessageBox.Show("Select valid form date first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
        private  void reset()
        {
            labelpassid.ResetText();
            labelname.ResetText();
            labelcontact.ResetText();
            labelgender.ResetText();
            labelvalidform.ResetText();
            labelvalidto.ResetText();
            if(pictureBoxProfile.Image != null)
            {
                pictureBoxProfile.Image.Dispose();
                pictureBoxProfile.Image = null;

            }

        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            reset();
            String passId=labelpassid.Text;
            String name = labelname.Text;
            String contact = labelcontact.Text;
            String gender = labelgender.Text;
            String validform = labelvalidform.Text;
            String validto = labelvalidto.Text;
            if(!string.IsNullOrEmpty(passId) && 
                !string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(contact) &&
                !string.IsNullOrEmpty(gender) &&
                !string.IsNullOrEmpty(validform) &&
                !string.IsNullOrEmpty(validto) )
            {
                Pass p = Pass(path, passId, name, contact, gender, validform,validto,visitorPk,days);
                p.Show();

                reset();


            }
            else
            {
                MessageBox.Show("Invalid pass data .Complete Selection to generate pass", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
