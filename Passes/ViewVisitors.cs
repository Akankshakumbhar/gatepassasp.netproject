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
    public partial class ViewVisitors : Form
    {
        DatabaseOperation databaseOperation=new DatabaseOperation();
        String query;
        DataSet ds;
        public ViewVisitors()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ViewVisitors_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select * from visitor";
                ds=databaseOperation.getData(query);    
                dataGridViewVisitor.DataSource = ds.Tables[0];
                
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = "select * from visitor where vnamelike'" + textsearch.Text + "%'or visitorId like '" + textsearch.Text + "%'";
                ds=databaseOperation.getData(query);
                dataGridViewVisitor.DataSource = ds.Tables[0];



            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
