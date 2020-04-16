using System;
using System.Drawing;
using System.Windows.Forms;

namespace KassaSysteem_v1._0
{
    public partial class PaymentForm : Form
    {
        public byte printReceipt;
        public decimal totalPrice;

        public PaymentForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.AllScreens[0].Bounds.Left, Screen.AllScreens[0].Bounds.Top);
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            totaalLabelValue.Text = totalPrice.ToString();
            if (printReceipt == 1)
            {
                receiptLabel.Text = "Klant wilt bon";
            }
            else if (printReceipt == 2)
            {
                receiptLabel.Text = "Klant wilt geen bon";
            }
        }

        private void calculateChange(decimal price, decimal paid)
        {
            decimal change = paid - price;
            changeLabelValue.Text = change.ToString();
        }

        private void CalculateChangebutton_Click(object sender, EventArgs e)
        {
            calculateChange(decimal.Parse(totaalLabelValue.Text), decimal.Parse(moneyRecievedTextBox.Text));
        }

        private void TotaalLabelValue_Click(object sender, EventArgs e)
        {

        }

        private void AddAmountToMoneyRecieved(string number)
        {
            moneyRecievedTextBox.Text += number;
        }

        private void MoneyRecievedButtonPeriod_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved(".");
        }

        private void MoneyRecievedButtonDelete_Click(object sender, EventArgs e)
        {
            moneyRecievedTextBox.Text = "";
        }

        private void MoneyRecievedButton0_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved("0");
        }

        private void MoneyRecievedButton1_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved("1");
        }

        private void MoneyRecievedButton2_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved("2");
        }

        private void MoneyRecievedButton3_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved("3");
        }

        private void MoneyReceivedButton4_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved("4");
        }

        private void MoneyRecievedButton5_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved("5");
        }

        private void MoneyRecievedButton6_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved("6");
        }

        private void MoneyRecievedButton7_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved("7");
        }

        private void MoneyRecievedButton8_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved("8");
        }

        private void MoneyRecievedButton9_Click(object sender, EventArgs e)
        {
            AddAmountToMoneyRecieved("9");
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Program.receiptArticleAmount = new int[50];
            Program.receiptArticleNumber = new int[50];
            Close();
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int items = 1;
            float printHeight = items * 50;
            e.Graphics.DrawString("Naam:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, printHeight));
            e.Graphics.DrawString("Aantal:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(400, printHeight));
            e.Graphics.DrawString("Prijs:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, printHeight));
            items++;

            for (int i = 0; i < Program.receiptArticleNumber.Length; i++)
            {
                if (Program.receiptArticleAmount[i] != 0)
                {
                    items++;

                    printHeight = items * 50;
                    /*
                    e.Graphics.DrawString(Program.receiptArticleNumber[i].ToString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, printHeight));
                    e.Graphics.DrawString(Program.receiptArticleAmount[i].ToString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(400, printHeight));
                    */
                    int index = -1;
                    for (int a = 0; a < Program.articleNumber.Length; a++)
                    {
                        if (Program.articleNumber[a] == Program.receiptArticleNumber[i].ToString())
                        {
                            index = a;
                        }
                    }

                    if (index != -1)
                    {
                        decimal totalPrice = Program.receiptArticleAmount[i] * decimal.Parse(Program.articlePrice[index].ToString());
                        e.Graphics.DrawString(Program.articleDescription[index], new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, printHeight));
                        e.Graphics.DrawString(Program.receiptArticleAmount[i].ToString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(400, printHeight));
                        e.Graphics.DrawString(totalPrice.ToString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, printHeight));
                    }
                }
            }

            items++;
            printHeight = 50 * items;

            e.Graphics.DrawString("Totaal:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, printHeight));
            e.Graphics.DrawString(totalPrice.ToString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, printHeight));

        }
    }
}
