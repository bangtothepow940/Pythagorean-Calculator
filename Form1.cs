using Microsoft.VisualBasic;
using System.Globalization;
using System.Linq.Expressions;

namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBoxAB.Text == "Aka" && textBoxBC.Text == "Ao" && textBoxAC.Text == "Kii")
            {
                if (MessageBox.Show("Congrats, you found the secret message lol.\n" +
                    "Anyways, I wanna tell a little bit about random things...\n" +
                    "So... How about we talk about... Eevees, maybe ?\n" +
                    "Nah, let's instead... go back to the software, shall we ?\n" +
                    "If you found this secret by yourself, congrats.\n" +
                    "But if you looked up the source code, then, still congrats...\n" +
                    "But if it's myself, reminder to not try to cringe at elsagate today.\n" +
                    "Anyways, go back to the software. I've told everything.", "Notes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    MessageBox.Show("You should have went back to the software.", ">:(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Welcome to Arinone's Pythagorean Calculation Program.\n" +
                "You can put the variables & click the functions, according to the triangle drawing.\n" +
                "For example, you want to know AB's length, so put your values inside AC and BC.", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNonHypCalc_Click(object sender, EventArgs e)
        {
            //Adjacent calculation.
            double numberOne;
            double numberTwo;
            double.TryParse(textBoxAB.Text, out numberOne);
            double.TryParse(textBoxBC.Text, out numberTwo);
            double calc = Math.Sqrt(Math.Pow(numberOne, 2) - Math.Pow(numberTwo, 2));
            string result = $"AC = {calc}";
            MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHypCalc_Click(object sender, EventArgs e)
        {
            //Hypotenusis calculation.
            double numberOne;
            double numberTwo;
            double.TryParse(textBoxAC.Text, out numberOne);
            double.TryParse(textBoxBC.Text, out numberTwo);
            double calc = Math.Sqrt(Math.Pow(numberOne, 2) + Math.Pow(numberTwo, 2));
            string result = $"AB = {calc}";
            MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void title_Click(object sender, EventArgs e)
        {
            //If anyone ever reads this, I want to tell you that Laissure is my favorite pokémon.
            //Y'know, it's the ground-type funny 2-meters tall horned bunny from Pokémon Uranium ?
        }

        private void buttonReciprocal_Click(object sender, EventArgs e)
        {
            double numberOne;
            double numberTwo;
            double numberThree;
            double.TryParse(textBoxAB.Text, out numberOne);
            double.TryParse(textBoxBC.Text, out numberTwo);
            double.TryParse(textBoxAC.Text, out numberThree);
            if (Math.Pow(numberOne, 2) == Math.Pow(numberTwo, 2) + Math.Pow(numberThree, 2))
            {
                MessageBox.Show($"Yes, your triangle is right-angled !\nBecause {numberOne}² = {numberTwo}² + {numberThree}².", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No, your triangle is not right-angled.\nBecause {numberOne}² \u2260 {numberTwo}² + {numberThree}².", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}