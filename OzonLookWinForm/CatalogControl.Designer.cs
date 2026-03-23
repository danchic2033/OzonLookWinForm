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
            catalogPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2vScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            catalogPanel.SuspendLayout();
            SuspendLayout();
            // 
            // catalogPanel
            // 
            catalogPanel.Controls.Add(guna2vScrollBar1);
            catalogPanel.CustomizableEdges = customizableEdges1;
            catalogPanel.Location = new Point(0, 0);
            catalogPanel.Margin = new Padding(10);
            catalogPanel.Name = "catalogPanel";
            catalogPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            catalogPanel.Size = new Size(800, 450);
            catalogPanel.TabIndex = 1;
            // 
            // guna2vScrollBar1
            // 
            guna2vScrollBar1.FillColor = Color.FromArgb(246, 247, 251);
            guna2vScrollBar1.InUpdate = false;
            guna2vScrollBar1.LargeChange = 10;
            guna2vScrollBar1.Location = new Point(723, 113);
            guna2vScrollBar1.Name = "guna2vScrollBar1";
            guna2vScrollBar1.ScrollbarSize = 18;
            guna2vScrollBar1.Size = new Size(18, 262);
            guna2vScrollBar1.TabIndex = 0;
            guna2vScrollBar1.ThumbColor = Color.FromArgb(246, 247, 251);
            // 
            // CatalogControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(0, 10);
            BackColor = Color.FromArgb(246, 247, 251);
            Controls.Add(catalogPanel);
            Name = "CatalogControl";
            Size = new Size(806, 509);
            catalogPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2Panel catalogPanel;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2vScrollBar1;
    }
}
