using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=appsdev730;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            cn.Open();
            cmd = new SqlCommand("UserLogsSP");
            cmd.Parameters.AddWithValue("@logDate", dateTimePicker1.Value.ToShortDateString());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds,"UserLogsSP");
            dataGridView1.DataSource = ds.Tables[0];
            cn.Close();
        }
    }
}
