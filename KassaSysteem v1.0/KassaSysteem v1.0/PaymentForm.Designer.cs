namespace KassaSysteem_v1._0
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.totaalLabel = new System.Windows.Forms.Label();
            this.totaalLabelValue = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeLabelValue = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.calculateChangebutton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.moneyRecievedTextBox = new System.Windows.Forms.TextBox();
            this.moneyRecievedLabel = new System.Windows.Forms.Label();
            this.moneyRecievedButton9 = new System.Windows.Forms.Button();
            this.moneyRecievedButton8 = new System.Windows.Forms.Button();
            this.moneyRecievedButton7 = new System.Windows.Forms.Button();
            this.moneyRecievedButton6 = new System.Windows.Forms.Button();
            this.moneyRecievedButton5 = new System.Windows.Forms.Button();
            this.moneyReceivedButton4 = new System.Windows.Forms.Button();
            this.moneyRecievedButton3 = new System.Windows.Forms.Button();
            this.moneyRecievedButton2 = new System.Windows.Forms.Button();
            this.moneyRecievedButton1 = new System.Windows.Forms.Button();
            this.moneyRecievedButtonDelete = new System.Windows.Forms.Button();
            this.moneyRecievedButtonPeriod = new System.Windows.Forms.Button();
            this.moneyRecievedButton0 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // totaalLabel
            // 
            this.totaalLabel.AutoSize = true;
            this.totaalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaalLabel.Location = new System.Drawing.Point(12, 9);
            this.totaalLabel.Name = "totaalLabel";
            this.totaalLabel.Size = new System.Drawing.Size(103, 32);
            this.totaalLabel.TabIndex = 0;
            this.totaalLabel.Text = "Totaal:";
            // 
            // totaalLabelValue
            // 
            this.totaalLabelValue.AutoSize = true;
            this.totaalLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaalLabelValue.Location = new System.Drawing.Point(109, 9);
            this.totaalLabelValue.Name = "totaalLabelValue";
            this.totaalLabelValue.Size = new System.Drawing.Size(31, 32);
            this.totaalLabelValue.TabIndex = 1;
            this.totaalLabelValue.Text = "0";
            this.totaalLabelValue.Click += new System.EventHandler(this.TotaalLabelValue_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 337);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(162, 32);
            this.changeLabel.TabIndex = 2;
            this.changeLabel.Text = "Wisselgeld:";
            // 
            // changeLabelValue
            // 
            this.changeLabelValue.AutoSize = true;
            this.changeLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabelValue.Location = new System.Drawing.Point(180, 337);
            this.changeLabelValue.Name = "changeLabelValue";
            this.changeLabelValue.Size = new System.Drawing.Size(71, 32);
            this.changeLabelValue.TabIndex = 3;
            this.changeLabelValue.Text = "0,00";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(711, 399);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(77, 39);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Klaar";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // calculateChangebutton
            // 
            this.calculateChangebutton.Location = new System.Drawing.Point(12, 295);
            this.calculateChangebutton.Name = "calculateChangebutton";
            this.calculateChangebutton.Size = new System.Drawing.Size(77, 39);
            this.calculateChangebutton.TabIndex = 5;
            this.calculateChangebutton.Text = "Bereken";
            this.calculateChangebutton.UseVisualStyleBackColor = true;
            this.calculateChangebutton.Click += new System.EventHandler(this.CalculateChangebutton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(628, 399);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(77, 39);
            this.receiptButton.TabIndex = 6;
            this.receiptButton.Text = "Bon";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(504, 337);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(284, 32);
            this.receiptLabel.TabIndex = 7;
            this.receiptLabel.Text = "Geen keuze gemaakt";
            // 
            // moneyRecievedTextBox
            // 
            this.moneyRecievedTextBox.Location = new System.Drawing.Point(139, 82);
            this.moneyRecievedTextBox.Name = "moneyRecievedTextBox";
            this.moneyRecievedTextBox.Size = new System.Drawing.Size(100, 22);
            this.moneyRecievedTextBox.TabIndex = 8;
            // 
            // moneyRecievedLabel
            // 
            this.moneyRecievedLabel.AutoSize = true;
            this.moneyRecievedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyRecievedLabel.Location = new System.Drawing.Point(12, 72);
            this.moneyRecievedLabel.Name = "moneyRecievedLabel";
            this.moneyRecievedLabel.Size = new System.Drawing.Size(121, 32);
            this.moneyRecievedLabel.TabIndex = 9;
            this.moneyRecievedLabel.Text = "Betaald:";
            // 
            // moneyRecievedButton9
            // 
            this.moneyRecievedButton9.Location = new System.Drawing.Point(744, 12);
            this.moneyRecievedButton9.Name = "moneyRecievedButton9";
            this.moneyRecievedButton9.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButton9.TabIndex = 10;
            this.moneyRecievedButton9.Text = "9";
            this.moneyRecievedButton9.UseVisualStyleBackColor = true;
            this.moneyRecievedButton9.Click += new System.EventHandler(this.MoneyRecievedButton9_Click);
            // 
            // moneyRecievedButton8
            // 
            this.moneyRecievedButton8.Location = new System.Drawing.Point(694, 12);
            this.moneyRecievedButton8.Name = "moneyRecievedButton8";
            this.moneyRecievedButton8.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButton8.TabIndex = 11;
            this.moneyRecievedButton8.Text = "8";
            this.moneyRecievedButton8.UseVisualStyleBackColor = true;
            this.moneyRecievedButton8.Click += new System.EventHandler(this.MoneyRecievedButton8_Click);
            // 
            // moneyRecievedButton7
            // 
            this.moneyRecievedButton7.Location = new System.Drawing.Point(644, 12);
            this.moneyRecievedButton7.Name = "moneyRecievedButton7";
            this.moneyRecievedButton7.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButton7.TabIndex = 12;
            this.moneyRecievedButton7.Text = "7";
            this.moneyRecievedButton7.UseVisualStyleBackColor = true;
            this.moneyRecievedButton7.Click += new System.EventHandler(this.MoneyRecievedButton7_Click);
            // 
            // moneyRecievedButton6
            // 
            this.moneyRecievedButton6.Location = new System.Drawing.Point(744, 62);
            this.moneyRecievedButton6.Name = "moneyRecievedButton6";
            this.moneyRecievedButton6.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButton6.TabIndex = 13;
            this.moneyRecievedButton6.Text = "6";
            this.moneyRecievedButton6.UseVisualStyleBackColor = true;
            this.moneyRecievedButton6.Click += new System.EventHandler(this.MoneyRecievedButton6_Click);
            // 
            // moneyRecievedButton5
            // 
            this.moneyRecievedButton5.Location = new System.Drawing.Point(694, 62);
            this.moneyRecievedButton5.Name = "moneyRecievedButton5";
            this.moneyRecievedButton5.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButton5.TabIndex = 14;
            this.moneyRecievedButton5.Text = "5";
            this.moneyRecievedButton5.UseVisualStyleBackColor = true;
            this.moneyRecievedButton5.Click += new System.EventHandler(this.MoneyRecievedButton5_Click);
            // 
            // moneyReceivedButton4
            // 
            this.moneyReceivedButton4.Location = new System.Drawing.Point(644, 62);
            this.moneyReceivedButton4.Name = "moneyReceivedButton4";
            this.moneyReceivedButton4.Size = new System.Drawing.Size(44, 44);
            this.moneyReceivedButton4.TabIndex = 15;
            this.moneyReceivedButton4.Text = "4";
            this.moneyReceivedButton4.UseVisualStyleBackColor = true;
            this.moneyReceivedButton4.Click += new System.EventHandler(this.MoneyReceivedButton4_Click);
            // 
            // moneyRecievedButton3
            // 
            this.moneyRecievedButton3.Location = new System.Drawing.Point(744, 112);
            this.moneyRecievedButton3.Name = "moneyRecievedButton3";
            this.moneyRecievedButton3.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButton3.TabIndex = 16;
            this.moneyRecievedButton3.Text = "3";
            this.moneyRecievedButton3.UseVisualStyleBackColor = true;
            this.moneyRecievedButton3.Click += new System.EventHandler(this.MoneyRecievedButton3_Click);
            // 
            // moneyRecievedButton2
            // 
            this.moneyRecievedButton2.Location = new System.Drawing.Point(694, 112);
            this.moneyRecievedButton2.Name = "moneyRecievedButton2";
            this.moneyRecievedButton2.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButton2.TabIndex = 17;
            this.moneyRecievedButton2.Text = "2";
            this.moneyRecievedButton2.UseVisualStyleBackColor = true;
            this.moneyRecievedButton2.Click += new System.EventHandler(this.MoneyRecievedButton2_Click);
            // 
            // moneyRecievedButton1
            // 
            this.moneyRecievedButton1.Location = new System.Drawing.Point(644, 112);
            this.moneyRecievedButton1.Name = "moneyRecievedButton1";
            this.moneyRecievedButton1.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButton1.TabIndex = 18;
            this.moneyRecievedButton1.Text = "1";
            this.moneyRecievedButton1.UseVisualStyleBackColor = true;
            this.moneyRecievedButton1.Click += new System.EventHandler(this.MoneyRecievedButton1_Click);
            // 
            // moneyRecievedButtonDelete
            // 
            this.moneyRecievedButtonDelete.Location = new System.Drawing.Point(644, 162);
            this.moneyRecievedButtonDelete.Name = "moneyRecievedButtonDelete";
            this.moneyRecievedButtonDelete.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButtonDelete.TabIndex = 19;
            this.moneyRecievedButtonDelete.Text = "C";
            this.moneyRecievedButtonDelete.UseVisualStyleBackColor = true;
            this.moneyRecievedButtonDelete.Click += new System.EventHandler(this.MoneyRecievedButtonDelete_Click);
            // 
            // moneyRecievedButtonPeriod
            // 
            this.moneyRecievedButtonPeriod.Location = new System.Drawing.Point(744, 162);
            this.moneyRecievedButtonPeriod.Name = "moneyRecievedButtonPeriod";
            this.moneyRecievedButtonPeriod.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButtonPeriod.TabIndex = 19;
            this.moneyRecievedButtonPeriod.Text = ".";
            this.moneyRecievedButtonPeriod.UseVisualStyleBackColor = true;
            this.moneyRecievedButtonPeriod.Click += new System.EventHandler(this.MoneyRecievedButtonPeriod_Click);
            // 
            // moneyRecievedButton0
            // 
            this.moneyRecievedButton0.Location = new System.Drawing.Point(694, 162);
            this.moneyRecievedButton0.Name = "moneyRecievedButton0";
            this.moneyRecievedButton0.Size = new System.Drawing.Size(44, 44);
            this.moneyRecievedButton0.TabIndex = 20;
            this.moneyRecievedButton0.Text = "0";
            this.moneyRecievedButton0.UseVisualStyleBackColor = true;
            this.moneyRecievedButton0.Click += new System.EventHandler(this.MoneyRecievedButton0_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyRecievedButton0);
            this.Controls.Add(this.moneyRecievedButtonPeriod);
            this.Controls.Add(this.moneyRecievedButtonDelete);
            this.Controls.Add(this.moneyRecievedButton1);
            this.Controls.Add(this.moneyRecievedButton2);
            this.Controls.Add(this.moneyRecievedButton3);
            this.Controls.Add(this.moneyReceivedButton4);
            this.Controls.Add(this.moneyRecievedButton5);
            this.Controls.Add(this.moneyRecievedButton6);
            this.Controls.Add(this.moneyRecievedButton7);
            this.Controls.Add(this.moneyRecievedButton8);
            this.Controls.Add(this.moneyRecievedButton9);
            this.Controls.Add(this.moneyRecievedLabel);
            this.Controls.Add(this.moneyRecievedTextBox);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.calculateChangebutton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.changeLabelValue);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.totaalLabelValue);
            this.Controls.Add(this.totaalLabel);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totaalLabel;
        private System.Windows.Forms.Label totaalLabelValue;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeLabelValue;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button calculateChangebutton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.TextBox moneyRecievedTextBox;
        private System.Windows.Forms.Label moneyRecievedLabel;
        private System.Windows.Forms.Button moneyRecievedButton9;
        private System.Windows.Forms.Button moneyRecievedButton8;
        private System.Windows.Forms.Button moneyRecievedButton7;
        private System.Windows.Forms.Button moneyRecievedButton6;
        private System.Windows.Forms.Button moneyRecievedButton5;
        private System.Windows.Forms.Button moneyReceivedButton4;
        private System.Windows.Forms.Button moneyRecievedButton3;
        private System.Windows.Forms.Button moneyRecievedButton2;
        private System.Windows.Forms.Button moneyRecievedButton1;
        private System.Windows.Forms.Button moneyRecievedButtonDelete;
        private System.Windows.Forms.Button moneyRecievedButtonPeriod;
        private System.Windows.Forms.Button moneyRecievedButton0;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}