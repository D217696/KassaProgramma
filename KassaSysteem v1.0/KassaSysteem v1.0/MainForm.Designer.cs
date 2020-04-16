namespace KassaSysteem_v1._0
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Artikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Omschrijving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afbeelding = new System.Windows.Forms.DataGridViewImageColumn();
            this.Aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doneButton = new System.Windows.Forms.Button();
            this.bonLabel = new System.Windows.Forms.Label();
            this.mainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.amountOfArticles = new System.Windows.Forms.Label();
            this.amountOfArticlesValue = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.totalPriceValue = new System.Windows.Forms.Label();
            this.newProductButton = new System.Windows.Forms.Button();
            this.articleInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikelnummer,
            this.Omschrijving,
            this.Afbeelding,
            this.Aantal,
            this.Prijs,
            this.deleteItem});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 564);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Artikelnummer
            // 
            this.Artikelnummer.HeaderText = "Artikelnummer";
            this.Artikelnummer.MinimumWidth = 6;
            this.Artikelnummer.Name = "Artikelnummer";
            this.Artikelnummer.Width = 125;
            // 
            // Omschrijving
            // 
            this.Omschrijving.HeaderText = "Omschrijving";
            this.Omschrijving.MinimumWidth = 6;
            this.Omschrijving.Name = "Omschrijving";
            this.Omschrijving.Width = 125;
            // 
            // Afbeelding
            // 
            this.Afbeelding.HeaderText = "Afbeelding";
            this.Afbeelding.MinimumWidth = 6;
            this.Afbeelding.Name = "Afbeelding";
            this.Afbeelding.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Afbeelding.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Afbeelding.Width = 125;
            // 
            // Aantal
            // 
            this.Aantal.HeaderText = "Aantal";
            this.Aantal.MinimumWidth = 6;
            this.Aantal.Name = "Aantal";
            this.Aantal.Width = 125;
            // 
            // Prijs
            // 
            this.Prijs.HeaderText = "Prijs";
            this.Prijs.MinimumWidth = 6;
            this.Prijs.Name = "Prijs";
            this.Prijs.Width = 125;
            // 
            // deleteItem
            // 
            this.deleteItem.HeaderText = "Verwijder item";
            this.deleteItem.MinimumWidth = 6;
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Width = 125;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(1050, 491);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(124, 85);
            this.doneButton.TabIndex = 2;
            this.doneButton.Text = "Klaar";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // bonLabel
            // 
            this.bonLabel.AutoSize = true;
            this.bonLabel.Location = new System.Drawing.Point(1053, 471);
            this.bonLabel.Name = "bonLabel";
            this.bonLabel.Size = new System.Drawing.Size(46, 17);
            this.bonLabel.TabIndex = 3;
            this.bonLabel.Text = "label1";
            // 
            // mainFormTimer
            // 
            this.mainFormTimer.Tick += new System.EventHandler(this.MainFormTimer_Tick);
            // 
            // amountOfArticles
            // 
            this.amountOfArticles.AutoSize = true;
            this.amountOfArticles.Location = new System.Drawing.Point(1047, 50);
            this.amountOfArticles.Name = "amountOfArticles";
            this.amountOfArticles.Size = new System.Drawing.Size(52, 17);
            this.amountOfArticles.TabIndex = 4;
            this.amountOfArticles.Text = "Aantal:";
            // 
            // amountOfArticlesValue
            // 
            this.amountOfArticlesValue.AutoSize = true;
            this.amountOfArticlesValue.Location = new System.Drawing.Point(1105, 50);
            this.amountOfArticlesValue.Name = "amountOfArticlesValue";
            this.amountOfArticlesValue.Size = new System.Drawing.Size(16, 17);
            this.amountOfArticlesValue.TabIndex = 5;
            this.amountOfArticlesValue.Text = "0";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(1047, 103);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(52, 17);
            this.totalPrice.TabIndex = 6;
            this.totalPrice.Text = "Totaal:";
            // 
            // totalPriceValue
            // 
            this.totalPriceValue.AutoSize = true;
            this.totalPriceValue.Location = new System.Drawing.Point(1105, 103);
            this.totalPriceValue.Name = "totalPriceValue";
            this.totalPriceValue.Size = new System.Drawing.Size(36, 17);
            this.totalPriceValue.TabIndex = 7;
            this.totalPriceValue.Text = "0,00";
            // 
            // newProductButton
            // 
            this.newProductButton.Location = new System.Drawing.Point(1050, 383);
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(124, 85);
            this.newProductButton.TabIndex = 8;
            this.newProductButton.Text = "Nieuw Product";
            this.newProductButton.UseVisualStyleBackColor = true;
            this.newProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // articleInput
            // 
            this.articleInput.Location = new System.Drawing.Point(1047, 12);
            this.articleInput.Name = "articleInput";
            this.articleInput.Size = new System.Drawing.Size(100, 22);
            this.articleInput.TabIndex = 9;
            this.articleInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1050, 292);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(124, 85);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Zoek";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 626);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.articleInput);
            this.Controls.Add(this.newProductButton);
            this.Controls.Add(this.totalPriceValue);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.amountOfArticlesValue);
            this.Controls.Add(this.amountOfArticles);
            this.Controls.Add(this.bonLabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label bonLabel;
        private System.Windows.Forms.Timer mainFormTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Omschrijving;
        private System.Windows.Forms.DataGridViewImageColumn Afbeelding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijs;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteItem;
        private System.Windows.Forms.Label amountOfArticles;
        private System.Windows.Forms.Label amountOfArticlesValue;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label totalPriceValue;
        private System.Windows.Forms.Button newProductButton;
        private System.Windows.Forms.TextBox articleInput;
        private System.Windows.Forms.Button searchButton;
    }
}

