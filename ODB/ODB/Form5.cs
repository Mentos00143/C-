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
    public partial class Form5 : Form
    {

        Form2 Deform;
        SqlConnection SqlConnection;
        public Form5(Form2 SqlConnect, SqlConnection SqlCon)
        {
            InitializeComponent();
            Deform = SqlConnect;
            SqlConnection = SqlCon;
        }

        private async void Form5_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Source\Repos\C-\ODB\ODB\Database.mdf;Integrated Security=True";
            SqlConnection = new SqlConnection(connectionString);
            await SqlConnection.OpenAsync();


            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [FlyData]", SqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                listBox1.Items.Add("№\n");
                listBox2.Items.Add("ТИП ЛІТАКА\n");
                listBox3.Items.Add("ПОЛІТ З МАКС. ВАГОЮ, КМ\n");
                listBox4.Items.Add("МАКС. КРЕЙС. ШВ, КМ/ГОД\n");
                listBox5.Items.Add("СТЕЛЯ, М\n");
                listBox6.Items.Add("РОЗБІГ, М\n");

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + "\n");
                    listBox2.Items.Add(Convert.ToString(sqlReader["Name"]) + "\n");
                    listBox3.Items.Add(Convert.ToString(sqlReader["daln"]) + "\n");
                    listBox4.Items.Add(Convert.ToString(sqlReader["speed"]) + "\n");
                    listBox5.Items.Add(Convert.ToString(sqlReader["potolok"]) + "\n");
                    listBox6.Items.Add(Convert.ToString(sqlReader["razbeg"]) + "\n");
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
    }
}
