namespace OzonLookWinForm
{
    partial class CatalogControl
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
            fitButton = new Guna.UI2.WinForms.Guna2Button();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fitButton
            // 
            fitButton.CustomizableEdges = customizableEdges1;
            fitButton.DisabledState.BorderColor = Color.DarkGray;
            fitButton.DisabledState.CustomBorderColor = Color.DarkGray;
            fitButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            fitButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            fitButton.FillColor = Color.FromArgb(26, 108, 254);
            fitButton.Font = new Font("Segoe UI", 9F);
            fitButton.ForeColor = Color.White;
            fitButton.Location = new Point(200, 213);
            fitButton.Name = "fitButton";
            fitButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            fitButton.Size = new Size(200, 37);
            fitButton.TabIndex = 0;
            fitButton.Text = "Примерить";
            fitButton.Click += fitButton_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(200, 50);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(200, 200);
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fitButton);
            Controls.Add(guna2PictureBox1);
            Name = "Catalog";
            Size = new Size(702, 426);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2Button fitButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
