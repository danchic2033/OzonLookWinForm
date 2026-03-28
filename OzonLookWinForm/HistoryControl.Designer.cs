namespace OzonLookWinForm
{
    partial class HistoryControl
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
            historyCatalogPanel = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
            // 
            // historyCatalogPanel
            // 
            historyCatalogPanel.CustomizableEdges = customizableEdges3;
            historyCatalogPanel.Location = new Point(90, 0);
            historyCatalogPanel.Name = "historyCatalogPanel";
            historyCatalogPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            historyCatalogPanel.Size = new Size(710, 450);
            historyCatalogPanel.TabIndex = 0;
            // 
            // HistoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 251);
            Controls.Add(historyCatalogPanel);
            Name = "HistoryControl";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel historyCatalogPanel;
    }
}
