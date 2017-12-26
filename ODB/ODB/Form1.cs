using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ODB
{
    public partial class Form1 : Form
    {
        SqlConnection SqlConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Source\Repos\C-\ODB\ODB\Database.mdf;Integrated Security=True";
            SqlConnection = new SqlConnection(connectionString);
            await SqlConnection.OpenAsync();


            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Rases]", SqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                listBox1.Items.Add("№\n");
                listBox2.Items.Add("НАПРЯМОК\n");
                listBox3.Items.Add("НОМЕР РЕЙСУ\n");
                listBox7.Items.Add("ТИП ЛІТАКА\n");

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + "\n");
                    listBox2.Items.Add(Convert.ToString(sqlReader["Napr"])+"\n");
                    listBox3.Items.Add(Convert.ToString(sqlReader["Numb"])+"\n");
                    listBox7.Items.Add(Convert.ToString(sqlReader["Type"])+"\n");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlReader!=null)
                {
                    sqlReader.Close();
                }
            }

        }

        private void вивідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SqlConnection!=null&&SqlConnection.State!=ConnectionState.Closed)
            {
                SqlConnection.Close();
            }
        }
        private void Form1_FormClosing(object sender, EventArgs e)
        {
            if (SqlConnection != null && SqlConnection.State != ConnectionState.Closed)
            {
                SqlConnection.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (label15.Visible)
                label15.Visible = false;

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text) )
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Rases] (Napr, Numb, Type)VALUES(@Napr, @Numb, @Type)", SqlConnection);

                command.Parameters.AddWithValue("Napr", textBox1.Text);
                command.Parameters.AddWithValue("Numb", textBox2.Text);
                command.Parameters.AddWithValue("Type", textBox10.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                label15.Visible = true;
                label15.Text = "Всі поля повинні бути заповнені!";
            }
        }

        private async void оновитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox7.Items.Clear();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Rases]", SqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();


                listBox1.Items.Add("№\n");
                listBox2.Items.Add("НАПРЯМОК\n");
                listBox3.Items.Add("НОМЕР РЕЙСУ\n");
                listBox7.Items.Add("ТИП ЛІТАКА\n");

                while (await sqlReader.ReadAsync())
                {

                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + "\n");
                    listBox2.Items.Add(Convert.ToString(sqlReader["Napr"]) + "\n");
                    listBox3.Items.Add(Convert.ToString(sqlReader["Numb"]) + "\n");
                    listBox7.Items.Add(Convert.ToString(sqlReader["Type"]) + "\n");
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

        private async void button2_Click(object sender, EventArgs e)
        {
            if (label16.Visible)
                label16.Visible = false;

            if (!string.IsNullOrEmpty(textBox14.Text) && !string.IsNullOrWhiteSpace(textBox14.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                !string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrWhiteSpace(textBox13.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Rases] SET [Napr] = @Napr, [Numb] = @Numb, [Type] = @Type WHERE [Id] = @Id", SqlConnection);

                command.Parameters.AddWithValue("Id",textBox5.Text);
                command.Parameters.AddWithValue("Napr", textBox14.Text);
                command.Parameters.AddWithValue("Numb", textBox13.Text);
                command.Parameters.AddWithValue("Type", textBox3.Text);
                await command.ExecuteNonQueryAsync();
            }
            else if (!string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                label16.Visible = true;
                label16.Text = "Всі поля повинні бути заповнені!";
            }
            else
            {
                label16.Visible = true;
                label16.Text = "Вкажіть порядковий номер!";
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (label17.Visible)
                label17.Visible = false;

            if (!string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) )
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Rases] WHERE [Id]=@Id", SqlConnection);

                command.Parameters.AddWithValue("Id", textBox6.Text);

                await command.ExecuteNonQueryAsync();

            }
            else
            {
                label17.Visible = true;
                label17.Text = "Вкажіть порядковий номер!";
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Lit = new Form2(this, SqlConnection);

            Lit.Show();
            this.Hide();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void розкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 Lit = new Form7(this, SqlConnection);

            Lit.Show();
            //this.Hide();
        }
    }
}
