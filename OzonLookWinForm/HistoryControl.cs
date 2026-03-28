using Guna.UI2.WinForms;
using Library;
using OpenPoseDotNet;
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
    public partial class HistoryControl : UserControl
    {
        private List<HistoryProducts> _historyProducts;
        private CatalogItem[,] catalogMap;
        private ProductControl productControl;
        private int _selectedKey;
        private int _photoId = 0;
        private int _primaryKey = 1;
        public HistoryControl()
        {
            InitializeComponent();
            _historyProducts = HistoryProductsRepository.GetProduct();
            InitCatalogMap(_historyProducts);
        }
        private void InitCatalogMap(List<HistoryProducts> _historyProducts)
        {
            if (_historyProducts.Count == 1)
            {
                catalogMap = new CatalogItem[1, 1];

                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        var newCatalogItem = CreateCatalogItem(i, j);
                        newCatalogItem.PictureBox.Image = _historyProducts[i].PhotosHistoryProduct[i];
                        historyCatalogPanel.Controls.Add(newCatalogItem.PictureBox);
                        historyCatalogPanel.Controls.Add(newCatalogItem.Button);
                        newCatalogItem.Button.BringToFront();
                        catalogMap[i, j] = newCatalogItem;
                        _photoId++;
                    }
                }
            }
            else
            {
                catalogMap = new CatalogItem[_historyProducts.Count / 2, 2];

                for (int i = 0; i < _historyProducts.Count / 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        var newCatalogItem = CreateCatalogItem(i, j);
                        newCatalogItem.PictureBox.Image = _historyProducts[i].PhotosHistoryProduct[i];
                        historyCatalogPanel.Controls.Add(newCatalogItem.PictureBox);
                        historyCatalogPanel.Controls.Add(newCatalogItem.Button);
                        newCatalogItem.Button.BringToFront();
                        catalogMap[i, j] = newCatalogItem;
                        _photoId++;
                    }
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
            int x = 200 + indexColumn * 250;
            int y = 210 + indexRow * 260;
            catalogItem.Button.Location = new Point(x, y);
            catalogItem.Button.Name = "fitButton";
            catalogItem.Button.ShadowDecoration.CustomizableEdges = customizableEdges6;
            catalogItem.Button.Size = new Size(200, 40);
            catalogItem.Button.TabIndex = 1;
            catalogItem.Button.Text = "Примерить";
            //catalogItem.Button.Click += fitButton_Click;

            var tagData = new ButtonTag
            {
                I = indexRow,
                J = indexColumn,
                PrimaryKey = _primaryKey
            };

            _primaryKey++;

            // Назначаем Tag и событие
            catalogItem.Button.Tag = tagData;
            catalogItem.Button.Click += CatalogItemButton_Click;
            // 
            // guna2PictureBox1
            // 
            catalogItem.PictureBox.CustomizableEdges = customizableEdges7;
            catalogItem.PictureBox.ImageRotate = 0F;
            x = 200 + indexColumn * 250;
            y = 50 + indexRow * 260;
            catalogItem.PictureBox.Location = new Point(x, y);
            catalogItem.PictureBox.Name = "guna2PictureBox1";
            catalogItem.PictureBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            catalogItem.PictureBox.Size = new Size(200, 200);
            catalogItem.PictureBox.TabIndex = 0;
            catalogItem.PictureBox.TabStop = false;
            catalogItem.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            return catalogItem;
        }

        private void CatalogItemButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button && button.Tag is ButtonTag tagData)
            {
                _selectedKey = tagData.PrimaryKey;
                MessageBox.Show($"Нажата кнопка для элемента [{tagData.I}, {tagData.J}]. Ключ: {tagData.PrimaryKey}");

                this.Controls.Clear();
                productControl = new ProductControl(_selectedKey, _historyProducts);
                productControl.Visible = true;
                this.Controls.Add(productControl);
            }
        }
    }
}
