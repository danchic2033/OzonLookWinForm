using Guna.UI2.WinForms.Suite;
using Library;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzonLookWinForm
{
    public partial class CatalogControl : UserControl
    {
        private CatalogItem[,] catalogMap;
        private ProductControl? productControl;
        private ApplicationDbContext _context = new ApplicationDbContext();
        private List<Product> products;
        public CatalogControl()
        {
            InitializeComponent();
            products = _context.Products.ToList();
            InitCatalogMap();
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            productControl = new ProductControl();
            productControl.Visible = true;
            this.Controls.Add(productControl);
        }

        private void InitCatalogMap()
        {
            catalogMap = new CatalogItem[2, products.Count / 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < products.Count / 2; j++)
                {
                    var newCatalogItem = CreateCatalogItem(i, j);
                    Controls.Add(newCatalogItem.PictureBox);
                    Controls.Add(newCatalogItem.Button);
                    newCatalogItem.Button.BringToFront();
                    catalogMap[i, j] = newCatalogItem;
                }
            }
        }

        private CatalogItem CreateCatalogItem(int indexRow, int indexColumn)
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            // 
            // fitButton
            // 
            var catalogItem = new CatalogItem();

            catalogItem.Button = new Guna.UI2.WinForms.Guna2Button();
            catalogItem.PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)catalogItem.PictureBox).BeginInit();
            SuspendLayout();

            catalogItem.Button.CustomizableEdges = customizableEdges5;
            catalogItem.Button.DisabledState.BorderColor = Color.DarkGray;
            catalogItem.Button.DisabledState.CustomBorderColor = Color.DarkGray;
            catalogItem.Button.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            catalogItem.Button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            catalogItem.Button.FillColor = Color.FromArgb(26, 108, 254);
            catalogItem.Button.Font = new Font("Segoe UI", 9F);
            catalogItem.Button.ForeColor = Color.White;
            int x = 200 + indexColumn * 210;
            int y = 210 + indexRow * 220;
            catalogItem.Button.Location = new Point(x, y);
            catalogItem.Button.Name = "fitButton";
            catalogItem.Button.ShadowDecoration.CustomizableEdges = customizableEdges6;
            catalogItem.Button.Size = new Size(200, 40);
            catalogItem.Button.TabIndex = 1;
            catalogItem.Button.Text = "Примерить";
            catalogItem.Button.Click += fitButton_Click;
            // 
            // guna2PictureBox1
            // 
            catalogItem.PictureBox.CustomizableEdges = customizableEdges7;
            catalogItem.PictureBox.ImageRotate = 0F;
            x = 200 + indexColumn * 210;
            y = 50 + indexRow * 210;
            catalogItem.PictureBox.Location = new Point(x, y);
            catalogItem.PictureBox.Name = "guna2PictureBox1";
            catalogItem.PictureBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            catalogItem.PictureBox.Size = new Size(200, 200);
            catalogItem.PictureBox.TabIndex = 0;
            catalogItem.PictureBox.TabStop = false;

            return catalogItem;
        }
    }
}
