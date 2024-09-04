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
using System.Data.SqlClient;

namespace BT00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccess2003_Click(object sender, EventArgs e)
        {
            string strcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\DATA\QLSV.mdb";
            OleDbConnection cnn = new OleDbConnection(strcon);
            cnn.Open();
            if (cnn.State == ConnectionState.Open)
                MessageBox.Show("Kết nối với QLSV.mdb thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            cnn.Close();
        }

        private void btnAccess2019_Click(object sender, EventArgs e)
        {
            string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\DATA\QLSV.accdb";
            OleDbConnection cnn = new OleDbConnection(strcon);
            cnn.Open();
            if (cnn.State == ConnectionState.Open)
                MessageBox.Show("Kết nối với QLSV.accdb thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            cnn.Close();
        }
    }
}
