using System;
using System.Drawing;
using System.Windows.Forms;

namespace KassaSysteem_v1._0
{
    public partial class CustomerForm : Form
    {
        public byte printBon = 0;
        public CustomerForm()
        {
            InitializeComponent();
            adPictureBox.Image = Image.FromFile(adPictures[0]);
            adTimer.Interval = 5000;
            adTimer.Start();


        }

        int pictureCounter = 0;
        public string[] adPictures = { "image/ad1.png", "image/ad2.png", "image/ad3.png" };
        public string[] prPictures = { "image/1.jpg", "image/2.jpg", "image/3.jpg" };

        private void AdTimer_Tick(object sender, EventArgs e)
        {
            if (pictureCounter < 1)
            {
                adPictureBox.Image = Image.FromFile(adPictures[0]);
                pictureCounter++;
            }
            else if (pictureCounter < 2)
            {
                adPictureBox.Image = Image.FromFile(adPictures[1]);
                pictureCounter++;
            }
            else if (pictureCounter < 3)
            {
                adPictureBox.Image = Image.FromFile(adPictures[2]);
                pictureCounter = 0;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {/*
            productDataGridView.Rows.Add();
            ((DataGridViewImageColumn)productDataGridView.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            productDataGridView.Rows[0].Cells[0].Value = Image.FromFile(prPictures[0]);
            productDataGridView.Rows[0].Cells[1].Value = "Tauge";
            productDataGridView.Rows[0].Cells[2].Value = 1;
            productDataGridView.Rows[0].Cells[3].Value = 3.99;*/
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            printBon = 1;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            printBon = 2;
        }
    }
}
