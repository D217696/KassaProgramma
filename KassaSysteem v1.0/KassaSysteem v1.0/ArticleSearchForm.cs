using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KassaSysteem_v1._0
{
    public partial class ArticleSearchForm : Form
    {
        public string currentArticleNumber;
        public ArticleSearchForm()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.AllScreens[0].Bounds.Left, Screen.AllScreens[0].Bounds.Top);
        }

        private void showArticles(string Letter)
        /*
         * This method shows all the articles that starts with the given Letter
         * it fills the datagridview with the found articles
         */
        {
            for (int i = 0; i < Program.articleDescription.Length; i++)
            {

            }
        }

        private void ArticleSearchForm_Load(object sender, EventArgs e)
        {
            //setup the screen to the right position (the center of the mainForm)
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("a");
            pictureBox1.Image = null;
        }
        private void BButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("b");
            pictureBox1.Image = null;
        }
        private void CButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("c");
            pictureBox1.Image = null;
        }

        private void DButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("d");
            pictureBox1.Image = null;
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("e");
            pictureBox1.Image = null;
        }

        private void FButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("f");
            pictureBox1.Image = null;
        }

        private void GButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("g");
            pictureBox1.Image = null;
        }

        private void HButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("h");
            pictureBox1.Image = null;
        }

        private void IButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("i");
            pictureBox1.Image = null;
        }

        private void JButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("j");
            pictureBox1.Image = null;
        }

        private void KButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("k");
            pictureBox1.Image = null;
        }

        private void LButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("l");
            pictureBox1.Image = null;
        }

        private void MButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("m");
            pictureBox1.Image = null;
        }

        private void NButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("n");
            pictureBox1.Image = null;
        }

        private void OButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("o");
            pictureBox1.Image = null;
        }

        private void PButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("p");
            pictureBox1.Image = null;
        }

        private void QButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("q");
            pictureBox1.Image = null;
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("r");
            pictureBox1.Image = null;
        }

        private void SButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("s");
            pictureBox1.Image = null;
        }

        private void TButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("t");
            pictureBox1.Image = null;
        }

        private void UButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("u");
            pictureBox1.Image = null;
        }

        private void VButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("v");
            pictureBox1.Image = null;
        }

        private void WButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("w");
            pictureBox1.Image = null;
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("x");
            pictureBox1.Image = null;
        }

        private void YButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("y");
            pictureBox1.Image = null;
        }

        private void ZButton_Click(object sender, EventArgs e)
        {
            SearchItemByLetter("z");
            pictureBox1.Image = null;
        }
        private void SearchItemByLetter(string letter)
        {
            int rows = 0;

            string mySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=testing";

            string query = $"SELECT * FROM products WHERE description LIKE '{letter}%'";
            MySqlConnection db = new MySqlConnection(mySqlConnectionString);

            MySqlCommand commandDb = new MySqlCommand(query, db);

            try
            {
                db.Open();
                MySqlDataReader myReader = commandDb.ExecuteReader();

                int i = 0;
                dataGridView1.Rows.Clear();

                while (myReader.Read())
                {
                    Console.WriteLine(myReader.GetString(0));
                    Console.WriteLine(myReader.GetString(1));
                    Console.WriteLine(myReader.GetFloat(2));

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = myReader.GetString(0);
                    dataGridView1.Rows[i].Cells[1].Value = myReader.GetString(1);
                    dataGridView1.Rows[i].Cells[2].Value = myReader.GetFloat(2);
                    i++;
                    rows = i;
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            db.Close();

            for (int i = 23; i < Program.articleNumber.Length; i++)
            {
                if (Program.articleNumber[i] != "0")
                {
                    string articleDescription = Program.articleDescription[i];
                    if (articleDescription != null)
                    {
                        if (articleDescription[0].ToString().ToLower() == letter)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[rows].Cells[0].Value = Program.articleNumber[i];
                            dataGridView1.Rows[rows].Cells[1].Value = Program.articleDescription[i];
                            dataGridView1.Rows[rows].Cells[2].Value = Program.articlePrice[i];
                        }
                    }
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = "";
            try
            {
                name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                currentArticleNumber = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
                return;
            }

            string mySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=testing";

            string query = $"SELECT * FROM products WHERE description='{name}'";
            MySqlConnection db = new MySqlConnection(mySqlConnectionString);

            MySqlCommand commandDb = new MySqlCommand(query, db);

            try
            {
                db.Open();
                MySqlDataReader myReader = commandDb.ExecuteReader();
                while (myReader.Read())
                {
                    string imageLocation = myReader.GetString(3);

                    pictureBox1.Image = Image.FromFile(imageLocation);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.Close();
        }

        private void AddToRecieptButton_Click(object sender, EventArgs e)
        {
            foreach (string articleNumber in Program.articleNumber)
            {
                if (articleNumber == currentArticleNumber)
                {
                    for (int i = 0; i < Program.receiptArticleNumber.Length; i++)
                    {
                        if (Program.receiptArticleNumber[i] == int.Parse(articleNumber))
                        {
                            Program.receiptArticleAmount[i] = Program.receiptArticleAmount[i] + (int)productAmount.Value;
                            break;
                        }
                        else
                        {
                            if (Program.receiptArticleAmount[i] == 0)
                            {
                                Program.receiptArticleNumber[i] = int.Parse(articleNumber);
                                Program.receiptArticleAmount[i] = (int)productAmount.Value;
                                productAmount.Value = 1;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
