namespace OzonLookWinForm
{
    partial class ProfileControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            numberFitNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            numberOfFitLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            favoriteCategoriesGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            NumberItem = new DataGridViewTextBoxColumn();
            NameTypeClothes = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)favoriteCategoriesGridView).BeginInit();
            SuspendLayout();
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.FillColor = Color.FromArgb(200, 213, 218, 223);
            guna2CircleProgressBar1.Font = new Font("Segoe UI", 12F);
            guna2CircleProgressBar1.ForeColor = Color.White;
            guna2CircleProgressBar1.Location = new Point(111, 50);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ProgressColor = Color.GreenYellow;
            guna2CircleProgressBar1.ProgressColor2 = Color.Brown;
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new Size(256, 256);
            guna2CircleProgressBar1.TabIndex = 0;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            // 
            // numberFitNameLabel
            // 
            numberFitNameLabel.BackColor = Color.Transparent;
            numberFitNameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberFitNameLabel.Location = new Point(388, 80);
            numberFitNameLabel.Name = "numberFitNameLabel";
            numberFitNameLabel.Size = new Size(233, 32);
            numberFitNameLabel.TabIndex = 1;
            numberFitNameLabel.Text = "Количество примерок:";
            // 
            // numberOfFitLabel
            // 
            numberOfFitLabel.BackColor = Color.Transparent;
            numberOfFitLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberOfFitLabel.Location = new Point(627, 80);
            numberOfFitLabel.Name = "numberOfFitLabel";
            numberOfFitLabel.Size = new Size(15, 32);
            numberOfFitLabel.TabIndex = 2;
            numberOfFitLabel.Text = "0";
            // 
            // favoriteCategoriesGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            favoriteCategoriesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            favoriteCategoriesGridView.BackgroundColor = Color.FromArgb(246, 247, 251);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            favoriteCategoriesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            favoriteCategoriesGridView.ColumnHeadersHeight = 32;
            favoriteCategoriesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            favoriteCategoriesGridView.Columns.AddRange(new DataGridViewColumn[] { NumberItem, NameTypeClothes });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(246, 247, 251);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            favoriteCategoriesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            favoriteCategoriesGridView.GridColor = Color.FromArgb(231, 229, 255);
            favoriteCategoriesGridView.Location = new Point(388, 133);
            favoriteCategoriesGridView.Name = "favoriteCategoriesGridView";
            favoriteCategoriesGridView.RowHeadersVisible = false;
            favoriteCategoriesGridView.Size = new Size(240, 150);
            favoriteCategoriesGridView.TabIndex = 5;
            favoriteCategoriesGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            favoriteCategoriesGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            favoriteCategoriesGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            favoriteCategoriesGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            favoriteCategoriesGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            favoriteCategoriesGridView.ThemeStyle.BackColor = Color.FromArgb(246, 247, 251);
            favoriteCategoriesGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            favoriteCategoriesGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            favoriteCategoriesGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            favoriteCategoriesGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            favoriteCategoriesGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            favoriteCategoriesGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            favoriteCategoriesGridView.ThemeStyle.HeaderStyle.Height = 32;
            favoriteCategoriesGridView.ThemeStyle.ReadOnly = false;
            favoriteCategoriesGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            favoriteCategoriesGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            favoriteCategoriesGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            favoriteCategoriesGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            favoriteCategoriesGridView.ThemeStyle.RowsStyle.Height = 25;
            favoriteCategoriesGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            favoriteCategoriesGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // NumberItem
            // 
            NumberItem.HeaderText = "№";
            NumberItem.Name = "NumberItem";
            // 
            // NameTypeClothes
            // 
            NameTypeClothes.HeaderText = "Любимые категории";
            NameTypeClothes.Name = "NameTypeClothes";
            // 
            // ProfileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 251);
            Controls.Add(favoriteCategoriesGridView);
            Controls.Add(numberOfFitLabel);
            Controls.Add(numberFitNameLabel);
            Controls.Add(guna2CircleProgressBar1);
            Name = "ProfileControl";
            Size = new Size(702, 426);
            ((System.ComponentModel.ISupportInitialize)favoriteCategoriesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2HtmlLabel numberFitNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel numberOfFitLabel;
        private Guna.UI2.WinForms.Guna2DataGridView favoriteCategoriesGridView;
        private DataGridViewTextBoxColumn NumberItem;
        private DataGridViewTextBoxColumn NameTypeClothes;
    }
}
