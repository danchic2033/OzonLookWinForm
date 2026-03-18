namespace OzonLookWinForm
{
    partial class FitClothesForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            userPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            catalogPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            resultPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            uploadPhoto = new Guna.UI2.WinForms.Guna2Button();
            getFitResult = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)userPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultPicture).BeginInit();
            SuspendLayout();
            // 
            // userPicture
            // 
            userPicture.CustomizableEdges = customizableEdges1;
            userPicture.ImageRotate = 0F;
            userPicture.Location = new Point(12, 87);
            userPicture.Name = "userPicture";
            userPicture.ShadowDecoration.CustomizableEdges = customizableEdges2;
            userPicture.Size = new Size(155, 188);
            userPicture.SizeMode = PictureBoxSizeMode.Zoom;
            userPicture.TabIndex = 0;
            userPicture.TabStop = false;
            // 
            // catalogPicture
            // 
            catalogPicture.CustomizableEdges = customizableEdges3;
            catalogPicture.ImageRotate = 0F;
            catalogPicture.Location = new Point(200, 87);
            catalogPicture.Name = "catalogPicture";
            catalogPicture.ShadowDecoration.CustomizableEdges = customizableEdges4;
            catalogPicture.Size = new Size(152, 188);
            catalogPicture.SizeMode = PictureBoxSizeMode.Zoom;
            catalogPicture.TabIndex = 1;
            catalogPicture.TabStop = false;
            // 
            // resultPicture
            // 
            resultPicture.CustomizableEdges = customizableEdges5;
            resultPicture.ImageRotate = 0F;
            resultPicture.Location = new Point(407, 12);
            resultPicture.Name = "resultPicture";
            resultPicture.ShadowDecoration.CustomizableEdges = customizableEdges6;
            resultPicture.Size = new Size(381, 426);
            resultPicture.SizeMode = PictureBoxSizeMode.Zoom;
            resultPicture.TabIndex = 2;
            resultPicture.TabStop = false;
            // 
            // uploadPhoto
            // 
            uploadPhoto.CustomizableEdges = customizableEdges7;
            uploadPhoto.DisabledState.BorderColor = Color.DarkGray;
            uploadPhoto.DisabledState.CustomBorderColor = Color.DarkGray;
            uploadPhoto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            uploadPhoto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            uploadPhoto.FillColor = Color.FromArgb(26, 108, 254);
            uploadPhoto.Font = new Font("Segoe UI", 9F);
            uploadPhoto.ForeColor = Color.White;
            uploadPhoto.Location = new Point(12, 333);
            uploadPhoto.Name = "uploadPhoto";
            uploadPhoto.ShadowDecoration.CustomizableEdges = customizableEdges8;
            uploadPhoto.Size = new Size(155, 33);
            uploadPhoto.TabIndex = 3;
            uploadPhoto.Text = "Загрузить фото";
            uploadPhoto.Click += uploadPhoto_Click;
            // 
            // getFitResult
            // 
            getFitResult.CustomizableEdges = customizableEdges9;
            getFitResult.DisabledState.BorderColor = Color.DarkGray;
            getFitResult.DisabledState.CustomBorderColor = Color.DarkGray;
            getFitResult.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            getFitResult.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            getFitResult.FillColor = Color.FromArgb(26, 108, 254);
            getFitResult.Font = new Font("Segoe UI", 9F);
            getFitResult.ForeColor = Color.White;
            getFitResult.Location = new Point(200, 333);
            getFitResult.Name = "getFitResult";
            getFitResult.ShadowDecoration.CustomizableEdges = customizableEdges10;
            getFitResult.Size = new Size(152, 33);
            getFitResult.TabIndex = 4;
            getFitResult.Text = "Примерить";
            getFitResult.Click += getFitResult_Click;
            // 
            // FitClothesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(getFitResult);
            Controls.Add(uploadPhoto);
            Controls.Add(resultPicture);
            Controls.Add(catalogPicture);
            Controls.Add(userPicture);
            Name = "FitClothesForm";
            Text = "FitClothesForm";
            Load += FitClothesForm_Load;
            ((System.ComponentModel.ISupportInitialize)userPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox userPicture;
        private Guna.UI2.WinForms.Guna2PictureBox catalogPicture;
        private Guna.UI2.WinForms.Guna2PictureBox resultPicture;
        private Guna.UI2.WinForms.Guna2Button uploadPhoto;
        private Guna.UI2.WinForms.Guna2Button getFitResult;
    }
}