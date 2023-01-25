using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientenAkte
{
    public partial class StartSeite : Form
    {
        public StartSeite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientenEingabe newForm = new PatientenEingabe();
            newForm.form = this;
            newForm.Show();
            this.Hide();
        }

        public void showST()
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientenSuchen newForm = new PatientenSuchen();
            newForm.Show();
            this.Close();

        }

        private void StartSeite_Load(object sender, EventArgs e)
        {

        }
    }
}
