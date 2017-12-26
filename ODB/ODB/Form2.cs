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

namespace ODB
{
    public partial class Form2 : Form
    {
        Form1 Deform;
        SqlConnection SqlConnection;

        public Form2(Form1 SqlConnect, SqlConnection SqlCon)
        {
            InitializeComponent();
            Deform = SqlConnect;
            SqlConnection = SqlCon;
        }
        

        private async void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Source\Repos\C-\ODB\ODB\Database.mdf;Integrated Security=True";
            SqlConnection = new SqlConnection(connectionString);
            await SqlConnection.OpenAsync();


            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Rozm]", SqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                listBox1.Items.Add("№\n");
                listBox2.Items.Add("ТИП ЛІТАКА\n");

                while (await sqlReader.ReadAsync())
                {

                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + "\n");
                    listBox2.Items.Add(Convert.ToString(sqlReader["Name"]) + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deform.Show();
        }

        private void розміриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Rozm = new Form3(this, SqlConnection);

            Rozm.Show();
            this.Hide();
        }

        private void вагаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 waga = new Form4(this, SqlConnection);

            waga.Show();
            this.Hide();
        }

        private void льотніДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 LD = new Form5(this, SqlConnection);

            LD.Show();
            this.Hide();
        }

        private void салонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Salon = new Form6(this, SqlConnection);

            Salon.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
