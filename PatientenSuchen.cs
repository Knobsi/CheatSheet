using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PatientenAkte
{
    public partial class PatientenSuchen : Form
    {
        public PatientenSuchen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Arzt;Integrated Security=True");
            SqlCommand SelectCommand = new SqlCommand($"SELECT * FROM Patienten WHERE Name = '{textBox1.Text}' AND Nachname = '{textBox2.Text}'", con);
            SqlDataReader myreader;
            con.Open();

            myreader = SelectCommand.ExecuteReader();

            string[] patients = new string[myreader.FieldCount];


            while (myreader.Read())
            {
                for (int i = 0; i < myreader.FieldCount; i++)
                {
                    //lstEmails.Add(myreader[i].ToString());
                    patients[i] = (myreader[i].ToString());
                    
                }
                dataGridView1.Rows.Add(patients);
                patients = new string[myreader.FieldCount];
            }




            
            textBox3.Text = String.Join(",", patients);

            
            con.Close();

        }



        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientenSuchen_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PatientenSuchen_Load_1(object sender, EventArgs e)
        {

        }
    }
}
