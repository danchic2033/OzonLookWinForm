namespace OzonLookWinForm
{
    partial class FavoriteCatalog
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            favoriteCatalogPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            SuspendLayout();
            // 
            // favoriteCatalogPanel
            // 
            favoriteCatalogPanel.CustomizableEdges = customizableEdges3;
            favoriteCatalogPanel.Location = new Point(90, 0);
            favoriteCatalogPanel.Name = "favoriteCatalogPanel";
            favoriteCatalogPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            favoriteCatalogPanel.Size = new Size(710, 450);
            favoriteCatalogPanel.TabIndex = 0;
            // 
            // FavoriteCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 251);
            Controls.Add(favoriteCatalogPanel);
            Name = "FavoriteCatalog";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel favoriteCatalogPanel;
    }
}
