using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseMinggu12
{
    public partial class Brinding_Navigator : Form
    {
        public Brinding_Navigator()
        {
            InitializeComponent();
        }

        private void Brinding_Navigator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet1.Mahasiswa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mnu = new Menu();
            mnu.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
