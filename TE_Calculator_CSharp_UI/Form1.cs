using System;
using System.Windows.Forms;
using TE_Calculator_CSharp_Lib;
using static System.Double;

namespace TE_Calculator_CSharp_UI
{
    public partial class Form1 : Form
    {
        private readonly Grootheid _grootheid = new Grootheid();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerekenSpanning_Click(object sender, EventArgs e)
        {
            ReadAllData();
            txtbSpanning.Text = _grootheid.CalculateSpanning().ToString();
        }

        private void btnBerekenStroom_Click(object sender, EventArgs e)
        {
            ReadAllData();
            txtbStroom.Text = _grootheid.CalculateStroom().ToString();
        }

        private void btnBerekenWeerstand_Click(object sender, EventArgs e)
        {
            ReadAllData();
            txtbWeerstand.Text = _grootheid.CalculateWeerstand().ToString();
        }

        private void btnBerekenVermogen_Click(object sender, EventArgs e)
        {
            ReadAllData();
            txtbVermogen.Text = _grootheid.CalculateVermogen().ToString();
        }

        private void ReadAllData()
        {
            _grootheid.Spanning = txtbSpanning.Text == "" ? 0.0 : Parse(txtbSpanning.Text);
            _grootheid.Stroom = txtbStroom.Text == "" ? 0.0 : Parse(txtbStroom.Text);
            _grootheid.Weerstand = txtbWeerstand.Text == "" ? 0.0 : Parse(txtbWeerstand.Text);
            _grootheid.Vermogen = txtbVermogen.Text == "" ? 0.0 : Parse(txtbVermogen.Text);
        }
    }
}
