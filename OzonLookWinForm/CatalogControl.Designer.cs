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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            catalogPanel = new Guna.UI2.WinForms.Guna2Panel();
            filterCheckedListBox = new CheckedListBox();
            guna2vScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            acceptFilterButton = new Guna.UI2.WinForms.Guna2Button();
            catalogPanel.SuspendLayout();
            SuspendLayout();
            // 
            // catalogPanel
            // 
            catalogPanel.Controls.Add(acceptFilterButton);
            catalogPanel.Controls.Add(filterCheckedListBox);
            catalogPanel.Controls.Add(guna2vScrollBar1);
            catalogPanel.CustomizableEdges = customizableEdges3;
            catalogPanel.Location = new Point(90, 0);
            catalogPanel.Margin = new Padding(10);
            catalogPanel.Name = "catalogPanel";
            catalogPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            catalogPanel.Size = new Size(710, 450);
            catalogPanel.TabIndex = 1;
            // 
            // filterCheckedListBox
            // 
            filterCheckedListBox.BackColor = Color.FromArgb(246, 247, 251);
            filterCheckedListBox.BorderStyle = BorderStyle.None;
            filterCheckedListBox.FormattingEnabled = true;
            filterCheckedListBox.Items.AddRange(new object[] { "Мужская одежда", "Женская одежда", "Верхняя одежда", "Джинсы", "Футболки" });
            filterCheckedListBox.Location = new Point(23, 52);
            filterCheckedListBox.Name = "filterCheckedListBox";
            filterCheckedListBox.Size = new Size(148, 90);
            filterCheckedListBox.TabIndex = 2;
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
            // acceptFilterButton
            // 
            acceptFilterButton.CustomizableEdges = customizableEdges1;
            acceptFilterButton.DisabledState.BorderColor = Color.DarkGray;
            acceptFilterButton.DisabledState.CustomBorderColor = Color.DarkGray;
            acceptFilterButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            acceptFilterButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            acceptFilterButton.FillColor = Color.FromArgb(26, 108, 254);
            acceptFilterButton.Font = new Font("Segoe UI", 9F);
            acceptFilterButton.ForeColor = Color.White;
            acceptFilterButton.Location = new Point(23, 148);
            acceptFilterButton.Name = "acceptFilterButton";
            acceptFilterButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            acceptFilterButton.Size = new Size(148, 21);
            acceptFilterButton.TabIndex = 3;
            acceptFilterButton.Text = "Применить фильтр";
            acceptFilterButton.Click += acceptFilterButton_Click;
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
        private CheckedListBox filterCheckedListBox;
        private Guna.UI2.WinForms.Guna2Button acceptFilterButton;
    }
}
