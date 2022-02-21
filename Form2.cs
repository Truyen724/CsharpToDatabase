using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection strcon = new OleDbConnection();
            try
            {
                string s = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtserver.Text;

                strcon.ConnectionString = s;

                strcon.Open();
                MessageBox.Show("Kết nối thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗ kết nối \n" + ex.Message);
            }
           
        }
    }
}
