namespace OzonLookWinForm
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            productPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            fitButton = new Guna.UI2.WinForms.Guna2Button();
            addFavoriteButton = new Guna.UI2.WinForms.Guna2Button();
            brendLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            nameOfClothe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            nameOfBrendLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            compositionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            compositionProductLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            articleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            articleNumberLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            priceLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            priceOfProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            descriptionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)productPicture).BeginInit();
            SuspendLayout();
            // 
            // productPicture
            // 
            productPicture.CustomizableEdges = customizableEdges1;
            productPicture.Image = Properties.Resources._5646975_01;
            productPicture.ImageRotate = 0F;
            productPicture.Location = new Point(127, 38);
            productPicture.Name = "productPicture";
            productPicture.ShadowDecoration.CustomizableEdges = customizableEdges2;
            productPicture.Size = new Size(220, 229);
            productPicture.SizeMode = PictureBoxSizeMode.Zoom;
            productPicture.TabIndex = 0;
            productPicture.TabStop = false;
            // 
            // fitButton
            // 
            fitButton.CustomizableEdges = customizableEdges3;
            fitButton.DisabledState.BorderColor = Color.DarkGray;
            fitButton.DisabledState.CustomBorderColor = Color.DarkGray;
            fitButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            fitButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            fitButton.FillColor = Color.FromArgb(26, 108, 254);
            fitButton.Font = new Font("Segoe UI", 9F);
            fitButton.ForeColor = Color.White;
            fitButton.Location = new Point(127, 330);
            fitButton.Name = "fitButton";
            fitButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            fitButton.Size = new Size(220, 45);
            fitButton.TabIndex = 1;
            fitButton.Text = "Примерить";
            fitButton.Click += fitButton_Click;
            // 
            // addFavoriteButton
            // 
            addFavoriteButton.CustomizableEdges = customizableEdges5;
            addFavoriteButton.DisabledState.BorderColor = Color.DarkGray;
            addFavoriteButton.DisabledState.CustomBorderColor = Color.DarkGray;
            addFavoriteButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addFavoriteButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addFavoriteButton.FillColor = Color.FromArgb(26, 108, 254);
            addFavoriteButton.Font = new Font("Segoe UI", 9F);
            addFavoriteButton.ForeColor = Color.White;
            addFavoriteButton.Location = new Point(127, 381);
            addFavoriteButton.Name = "addFavoriteButton";
            addFavoriteButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            addFavoriteButton.Size = new Size(220, 45);
            addFavoriteButton.TabIndex = 2;
            addFavoriteButton.Text = "Добавить в избранное";
            addFavoriteButton.Click += addFavoriteButton_Click;
            // 
            // brendLabel
            // 
            brendLabel.BackColor = Color.Transparent;
            brendLabel.Location = new Point(370, 58);
            brendLabel.Name = "brendLabel";
            brendLabel.Size = new Size(39, 17);
            brendLabel.TabIndex = 3;
            brendLabel.Text = "Бренд:";
            // 
            // nameOfClothe
            // 
            nameOfClothe.BackColor = Color.Transparent;
            nameOfClothe.Location = new Point(127, 273);
            nameOfClothe.Name = "nameOfClothe";
            nameOfClothe.Size = new Size(55, 17);
            nameOfClothe.TabIndex = 4;
            nameOfClothe.Text = "Название";
            // 
            // nameOfBrendLabel
            // 
            nameOfBrendLabel.BackColor = Color.Transparent;
            nameOfBrendLabel.Location = new Point(415, 58);
            nameOfBrendLabel.Name = "nameOfBrendLabel";
            nameOfBrendLabel.Size = new Size(97, 17);
            nameOfBrendLabel.TabIndex = 5;
            nameOfBrendLabel.Text = "Название бренда";
            // 
            // compositionLabel
            // 
            compositionLabel.BackColor = Color.Transparent;
            compositionLabel.Location = new Point(370, 93);
            compositionLabel.Name = "compositionLabel";
            compositionLabel.Size = new Size(44, 17);
            compositionLabel.TabIndex = 6;
            compositionLabel.Text = "Состав:";
            // 
            // compositionProductLabel
            // 
            compositionProductLabel.BackColor = Color.Transparent;
            compositionProductLabel.Location = new Point(420, 93);
            compositionProductLabel.Name = "compositionProductLabel";
            compositionProductLabel.Size = new Size(81, 17);
            compositionProductLabel.TabIndex = 7;
            compositionProductLabel.Text = "Состав товара";
            // 
            // articleLabel
            // 
            articleLabel.BackColor = Color.Transparent;
            articleLabel.Location = new Point(371, 128);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new Size(52, 17);
            articleLabel.TabIndex = 8;
            articleLabel.Text = "Артикул:";
            // 
            // articleNumberLabel
            // 
            articleNumberLabel.BackColor = Color.Transparent;
            articleNumberLabel.Location = new Point(429, 128);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new Size(94, 17);
            articleNumberLabel.TabIndex = 9;
            articleNumberLabel.Text = "Номер артикула";
            // 
            // priceLabel
            // 
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Location = new Point(371, 162);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(34, 17);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Цена:";
            // 
            // priceOfProduct
            // 
            priceOfProduct.BackColor = Color.Transparent;
            priceOfProduct.Location = new Point(426, 162);
            priceOfProduct.Name = "priceOfProduct";
            priceOfProduct.Size = new Size(31, 17);
            priceOfProduct.TabIndex = 11;
            priceOfProduct.Text = "Цена";
            // 
            // descriptionLabel
            // 
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Location = new Point(371, 201);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(58, 17);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Описание";
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(descriptionLabel);
            Controls.Add(priceOfProduct);
            Controls.Add(priceLabel);
            Controls.Add(articleNumberLabel);
            Controls.Add(articleLabel);
            Controls.Add(compositionProductLabel);
            Controls.Add(compositionLabel);
            Controls.Add(nameOfBrendLabel);
            Controls.Add(nameOfClothe);
            Controls.Add(brendLabel);
            Controls.Add(addFavoriteButton);
            Controls.Add(fitButton);
            Controls.Add(productPicture);
            Name = "ProductControl";
            Size = new Size(702, 426);
            Load += ProductControl_Load;
            ((System.ComponentModel.ISupportInitialize)productPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox productPicture;
        private Guna.UI2.WinForms.Guna2Button fitButton;
        private Guna.UI2.WinForms.Guna2Button addFavoriteButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel brendLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameOfClothe;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameOfBrendLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel compositionLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel compositionProductLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel articleLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel articleNumberLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel priceLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel priceOfProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel descriptionLabel;
    }
}
