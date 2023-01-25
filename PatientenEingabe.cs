using System;
using System.Data;
using System.Data.SqlClient;

namespace PatientenAkte
{
    public partial class PatientenEingabe : Form
    {
        public new event System.Windows.Forms.FormClosingEventHandler? FormClosing;

        public Form form;
        public PatientenEingabe()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ""||textBox2.Text == ""|| textBox3.Text == "")
            {

            }
            else
            {

                SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Arzt;Integrated Security=True");
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = @$"INSERT INTO Patienten(Name, Nachname,Straﬂe,Postleitzahl,Ort,Telefonnummer) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}');";

                SqlCommand cmd = conn.CreateCommand();

                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();

                MessageBox.Show("Gespeichert");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            StartSeite PageOne = new StartSeite();
            PageOne.Show();
        }

        private void PatientenEingabe_Load(object sender, EventArgs e)
        {

        }
        override protected  void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            form.Show();
        }

    }
}