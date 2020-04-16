using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassaSysteem_v1._0
{
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.AllScreens[0].Bounds.Left, Screen.AllScreens[0].Bounds.Top);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Test button x1, test newly made item in Array ID 23
            string artDesc = Program.articleDescription[23];
            float artPrice = Program.articlePrice[23];
            string artNumber = Program.articleNumber[23];
            testTextBox.Text = "Art Description: " + artDesc + " Art Price: " + artPrice + " Art Number: " + artNumber;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            int emptyIndex = 0;
            for (int i = 0; i < Program.articleNumber.Length; i++)
            {
                string currentArtDesc = Program.articleDescription[i];

                if (string.IsNullOrEmpty(currentArtDesc))
                {
                    emptyIndex = i;
                    break;
                }
            }

            string artPrice = articlePriceTextBox.Text;
            float artPriceF;

            if (float.TryParse(artPrice, out artPriceF))
            {
                Program.articleNumber[emptyIndex] = articleNumberTextBox.Text;
                Program.articleDescription[emptyIndex] = articleNameTextBox.Text;
                Program.articlePrice[emptyIndex] = artPriceF;
                alertLabel.Visible = false;
            }
            else
            {
                alertLabel.Visible = true;
                alertLabel.ForeColor = System.Drawing.Color.Red;
            }

            // shows current index which was overwritten
            indexLabel.Text = "Current Index: " + emptyIndex;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Test button x2, test newly made item in Array ID 24
            string artDesc = Program.articleDescription[24];
            float artPrice = Program.articlePrice[24];
            string artNumber = Program.articleNumber[24];
            testTextBox.Text = "Art Description: " + artDesc + " Art Price: " + artPrice + " Art Number: " + artNumber;
        }

        // Keyboard buttons vvvv
        private void oneButton_Click(object sender, EventArgs e)
        {
            if (artNumberRadioButton.Checked == true)
            {
                articleNumberTextBox.AppendText("1");
            }
            else if (artDescRadioButton.Checked == true)
            {
                articleNameTextBox.AppendText("1");
            }
            else if (artPriceRadioButton.Checked == true)
            {
                articlePriceTextBox.AppendText("1");
            }
        }

        private void qButton_Click(object sender, EventArgs e)
        {
            if (artNumberRadioButton.Checked == true)
            {
                articleNumberTextBox.AppendText("Q");
            }
            else if (artDescRadioButton.Checked == true)
            {
                articleNameTextBox.AppendText("Q");
            }
            else if (artPriceRadioButton.Checked == true)
            {
                articlePriceTextBox.AppendText("Q");
            }
        }

        private void spaceButton_Click(object sender, EventArgs e)
        {
            if (artNumberRadioButton.Checked == true)
            {
                articleNumberTextBox.AppendText(" ");
            }
            else if (artDescRadioButton.Checked == true)
            {
                articleNameTextBox.AppendText(" ");
            }
            else if (artPriceRadioButton.Checked == true)
            {
                articlePriceTextBox.AppendText(" ");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (artNumberRadioButton.Checked == true)
            {
                articleNumberTextBox.Clear();
            }
            else if (artDescRadioButton.Checked == true)
            {
                articleNameTextBox.Clear();
            }
            else if (artPriceRadioButton.Checked == true)
            {
                articlePriceTextBox.Clear();
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
