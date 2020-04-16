using System;
using System.Drawing;
using System.Windows.Forms;

namespace KassaSysteem_v1._0
{
    public partial class MainForm : Form
    {
        public decimal totalPriceFinal = 0;

        CustomerForm customerForm = new CustomerForm();
        //PaymentForm paymentForm = new PaymentForm();
        public MainForm()
        {
            InitializeComponent();
            mainFormTimer.Start();
            mainFormTimer.Interval = 100;
        }

        private void getData()
        /*
         * with this method the global arrays with article information is filles with data
         * This data can be used within the program.
        */
        {
            Program.articleDescription[0] = "Tauge";
            Program.articleDescription[1] = "Paksoi";
            Program.articleDescription[2] = "Blokjes tomaat in tomatensap";
            Program.articleDescription[3] = "Kikkererwten";
            Program.articleDescription[4] = "Boemboe Java";
            Program.articleDescription[5] = "Arachide olie";
            Program.articleDescription[6] = "Warmgerookte zalmstukken";
            Program.articleDescription[7] = "Bieslook";
            Program.articleDescription[8] = "Kippenbouillon";
            Program.articleDescription[9] = "Olijfolie mild";
            Program.articleDescription[10] = "Prei";
            Program.articleDescription[11] = "Iets kruimige aardappel";
            Program.articleDescription[12] = "Middelgrote uien";
            Program.articleDescription[13] = "Kleine krieltjes";
            Program.articleDescription[14] = "Knoflook";
            Program.articleDescription[15] = "Platte peterselie";
            Program.articleDescription[16] = "Mandarijnen net";
            Program.articleDescription[17] = "Witlof";
            Program.articleDescription[18] = "Blanke rozijnen";
            Program.articleDescription[19] = "Yoghurt kruiden dressing";
            Program.articleDescription[20] = "Spitskool (gesneden)";
            Program.articleDescription[21] = "Gerookte amandelen";
            Program.articleDescription[22] = "Kaasschnitzel";

            Program.articlePrice[0] = 1f;
            Program.articlePrice[1] = 1.49f;
            Program.articlePrice[2] = 0.79f;
            Program.articlePrice[3] = 1.89f;
            Program.articlePrice[4] = 1.02f;
            Program.articlePrice[5] = 3.49f;
            Program.articlePrice[6] = 7.49f;
            Program.articlePrice[7] = 1.69f;
            Program.articlePrice[8] = 1.12f;
            Program.articlePrice[9] = 4.85f;
            Program.articlePrice[10] = 0.46f;
            Program.articlePrice[11] = 3.99f;
            Program.articlePrice[12] = 1.09f;
            Program.articlePrice[13] = 0.99f;
            Program.articlePrice[14] = 0.89f;
            Program.articlePrice[15] = 1.39f;
            Program.articlePrice[16] = 3.49f;
            Program.articlePrice[17] = 1.49f;
            Program.articlePrice[18] = 3.39f;
            Program.articlePrice[19] = 1.59f;
            Program.articlePrice[20] = 1.79f;
            Program.articlePrice[21] = 2.59f;
            Program.articlePrice[22] = 1.24f;

            Program.articlePicture[0] = @".\img\0.jpg";
            Program.articlePicture[1] = @".\img\1.jpg";
            Program.articlePicture[2] = @".\img\2.jpg";
            Program.articlePicture[3] = @".\img\3.jpg";
            Program.articlePicture[4] = @".\img\4.jpg";
            Program.articlePicture[5] = @".\img\5.jpg";
            Program.articlePicture[6] = @".\img\6.jpg";
            Program.articlePicture[7] = @".\img\7.jpg";
            Program.articlePicture[8] = @".\img\8.jpg";
            Program.articlePicture[9] = @".\img\9.jpg";
            Program.articlePicture[10] = @".\img\10.jpg";
            Program.articlePicture[11] = @".\img\11.jpg";
            Program.articlePicture[12] = @".\img\12.jpg";
            Program.articlePicture[13] = @".\img\13.jpg";
            Program.articlePicture[14] = @".\img\14.jpg";
            Program.articlePicture[15] = @".\img\15.jpg";
            Program.articlePicture[16] = @".\img\16.jpg";
            Program.articlePicture[17] = @".\img\17.jpg";
            Program.articlePicture[18] = @".\img\18.jpg";
            Program.articlePicture[19] = @".\img\19.jpg";
            Program.articlePicture[20] = @".\img\20.jpg";
            Program.articlePicture[21] = @".\img\21.jpg";
            Program.articlePicture[22] = @".\img\22.jpg";

            Program.articleNumber[0] = "4590";
            Program.articleNumber[1] = "4483";
            Program.articleNumber[2] = "2434";
            Program.articleNumber[3] = "7636";
            Program.articleNumber[4] = "5220";
            Program.articleNumber[5] = "4048";
            Program.articleNumber[6] = "6377";
            Program.articleNumber[7] = "8701";
            Program.articleNumber[8] = "1741";
            Program.articleNumber[9] = "5608";
            Program.articleNumber[10] = "8781";
            Program.articleNumber[11] = "3601";
            Program.articleNumber[12] = "4000";
            Program.articleNumber[13] = "2507";
            Program.articleNumber[14] = "2025";
            Program.articleNumber[15] = "5548";
            Program.articleNumber[16] = "5010";
            Program.articleNumber[17] = "8537";
            Program.articleNumber[18] = "8133";
            Program.articleNumber[19] = "7505";
            Program.articleNumber[20] = "6418";
            Program.articleNumber[21] = "8677";
            Program.articleNumber[22] = "5947";

            dataGridView1.AllowUserToAddRows = false;
        }

        private void addNumberToArticleNumber(string number)
        /*
         * adds a number to the acticlenumber textbox
         */
        {
            int i = int.Parse(number);
            int indexArticle = Program.receiptArticleNumber[i];
            dataGridView1.Rows[i].Cells[0].Value = Program.articleNumber[indexArticle];
            dataGridView1.Rows[i].Cells[1].Value = Program.articleDescription[indexArticle];
            dataGridView1.Rows[i].Cells[2].Value = Image.FromFile(Program.articlePicture[indexArticle]);
            dataGridView1.Rows[i].Cells[3].Value = Program.receiptArticleAmount[i];
            dataGridView1.Rows[i].Cells[4].Value = Program.articlePrice[indexArticle];
        }

        private int articleSearch(string articleNumber)
        /*
         * this method searches in the articlenumber array and checks if the
         * number is present in the array
         * if the articlenumber is found in the array it returns the array index
         * if the articlenumber cannot be found it returns -1
         */
        {
            for (int i = 0; i < Program.articleNumber.Length; i++)
            {
                if (Program.articleNumber[i] == articleNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        private float calculateTotalprice(int[] receiptArticleNumbers)
        /*
         * this function calculates the total price of the receipt (prices array as input)
         * the method loops through the array and adds the price to the totalprice and 
         * returns this value
         * 
         */
        {
            float totalprice = 0.0f;

            for (int i = 0; i < receiptArticleNumbers.Length; i++)
            {

            }
            return totalprice;
        }

        private void setupScreen()
        /*
         * setup the different screens
         */
        {
            customerForm.StartPosition = FormStartPosition.Manual;
            customerForm.Location = new Point(Screen.AllScreens[0].Bounds.Right - customerForm.Width, Screen.AllScreens[0].Bounds.Top);
            customerForm.Show();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.AllScreens[0].Bounds.Left, Screen.AllScreens[0].Bounds.Top);
            // zorg ervoor dat bij het starten alle schermen op een vaste positie komen
            // dus het scherm van de kassiere en klant
            // het programma moet uiteindelijk zonder dat de gebruiker iets hoeft te doen
            // gereed staan, klaar voor gebruikt
        }

        private void MainForm_Load(object sender, EventArgs e)
        /*
         * methods for preparing the program
         */
        {
            getData();
            setupScreen();


        }

        private void printReceipt()
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < Program.receiptArticleNumber.Length; i++)
            {
                if (Program.receiptArticleAmount[i] == 0)
                {
                    break;
                }
                dataGridView1.Rows.Add();
                addNumberToArticleNumber(i.ToString());
            }
        }
        private void addReceipt(string articleNumber, int amount)
        {
            mainFormTimer.Stop();
            int foundIndex = 0;
            for (int i = 0; i < Program.articleNumber.Length; i++)
            {
                if (Program.articleNumber[i] == articleNumber)
                {
                    foundIndex = i;
                    break;
                }
            }

            for (int i = 0; i < Program.receiptArticleNumber.Length; i++)
            {
                if (Program.receiptArticleNumber[i].ToString() == articleNumber)
                {
                    Program.receiptArticleAmount[i]++;
                    break;
                }
                else
                {
                    if (Program.receiptArticleAmount[i] == 0)
                    {
                        Program.receiptArticleNumber[i] = int.Parse(Program.articleNumber[foundIndex]);
                        Program.receiptArticleAmount[i] = amount;
                        break;
                    }
                }
            }
            mainFormTimer.Start();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            totalPriceFinal = decimal.Parse(totalPriceValue.Text);
            paymentForm.totalPrice = totalPriceFinal;
            paymentForm.printReceipt = customerForm.printBon;
            paymentForm.Show();
        }

        private void MainFormTimer_Tick(object sender, EventArgs e)
        {
            if (customerForm.printBon == 2)
            {
                bonLabel.Text = "Klant wilt geen bon";
            }
            else if (customerForm.printBon == 1)
            {
                bonLabel.Text = "Klant wilt bon";
            }
            else
            {
                bonLabel.Text = "Nog geen keuze ingegeven";
            }

            dataGridView1.Rows.Clear();
            decimal totalPrice = 0;
            int totalProducts = 0;

            for (int i = 0; i < Program.receiptArticleNumber.Length; i++)
            {
                if (Program.receiptArticleAmount[i] != 0)
                {
                    dataGridView1.Rows.Add();
                    int index = articleSearch(Program.receiptArticleNumber[i].ToString());

                    if (index != -1)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = Program.articleNumber[index]; //article number
                        dataGridView1.Rows[i].Cells[1].Value = Program.articleDescription[index]; //article description
                        if (Program.articlePicture[index] != null)
                        {
                            dataGridView1.Rows[i].Cells[2].Value = Image.FromFile(Program.articlePicture[index]); //article picture
                        }
                        dataGridView1.Rows[i].Cells[3].Value = Program.receiptArticleAmount[i]; //article amount
                        dataGridView1.Rows[i].Cells[4].Value = Program.articlePrice[index]; //article price

                        totalProducts += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                        totalPrice += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) * decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                }
            }

            totalPriceValue.Text = totalPrice.ToString();
            amountOfArticlesValue.Text = totalProducts.ToString();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                Program.receiptArticleNumber[e.RowIndex] = 0;
                Program.receiptArticleAmount[e.RowIndex] = 0;

                bool emptySpotFound = false;
                for (int i = 0; i < Program.receiptArticleNumber.Length; i++)
                {
                    if (Program.receiptArticleAmount[i] == 0)
                    {
                        emptySpotFound = true;
                    }

                    if (emptySpotFound)
                    {
                        if (i == 49)
                        {
                            break;
                        }
                        Program.receiptArticleAmount[i] = Program.receiptArticleAmount[i + 1];
                        Program.receiptArticleNumber[i] = Program.receiptArticleNumber[i + 1];
                    }
                }
            }
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            NewProductForm form = new NewProductForm();
            form.Show();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                addReceipt(articleInput.Text, 1);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ArticleSearchForm form = new ArticleSearchForm();
            form.Show();
        }
    }
}
