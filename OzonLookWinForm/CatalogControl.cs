using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Library;
using Microsoft.EntityFrameworkCore;
using OzonLookWinForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tensorflow.Operations.Initializers;

namespace OzonLookWinForm
{
    public partial class CatalogControl : UserControl
    {
        private CatalogItem[,] catalogMap;
        private ProductControl? productControl;
        private ApplicationDbContext _context = new ApplicationDbContext();
        private List<Product> products;
        private int _selectedKey;
        private int _primaryKey = 1;
        private List<Product> filteredProducts;
        private List<Photo> _photos;
        private int _photoId = 0;
        public CatalogControl()
        {
            InitializeComponent();
            products = _context.Products.ToList();
            _photos = PhotoRepository.GetPhotos();
            InitCatalogMap(products);
            guna2vScrollBar1.BindingContainer = catalogPanel;
        }

        private void InitCatalogMap(List<Product> products)
        {
            catalogMap = new CatalogItem[products.Count / 2, 2];

            for (int i = 0; i < products.Count / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var newCatalogItem = CreateCatalogItem(i, j);
                    newCatalogItem.PictureBox.Image = _photos[_photoId].Images[0];
                    catalogPanel.Controls.Add(newCatalogItem.PictureBox);
                    catalogPanel.Controls.Add(newCatalogItem.Button);
                    newCatalogItem.Button.BringToFront();
                    catalogMap[i, j] = newCatalogItem;
                    _photoId++;
                }
            }
        }

        private List<Product> ApplyFilters()
        {
            var selectedFilters = new List<string>();
            foreach (var item in filterCheckedListBox.CheckedItems)
            {
                selectedFilters.Add(item.ToString());
            }

            var filteredList = products.Where(item =>
            {
                bool matches = true;
                foreach (var filter in selectedFilters)
                {
                    switch (filter)
                    {
                        case "Мужская одежда":
                            matches &= item.Gender == "Мужчинам";
                            break;
                        case "Женская одежда":
                            matches &= item.Gender == "Женщинам";
                            break;
                        case "Верхняя одежда":
                            matches &= item.TypeClothes == "Верхняя Одежда";
                            break;
                        case "Джинсы":
                            matches &= item.TypeClothes == "Джинсы";
                            break;
                        case "Футболки":
                            matches &= item.TypeClothes == "Футболки";
                            break;
                        default:
                            break;

                    }
                }
                return matches;
            }).ToList();
            _primaryKey = 1;
            return filteredList;
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

        private void CatalogScroll(object sender, ScrollEventArgs e)
        {
            var scrollBar = sender as Guna2VScrollBar;
            if (scrollBar != null)
            {
                var newValue = scrollBar.Value;
                this.Location = new Point(this.Location.X, -newValue);
            }
        }

        private void CatalogItemButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button && button.Tag is ButtonTag tagData)
            {
                _selectedKey = tagData.PrimaryKey;
                MessageBox.Show($"Нажата кнопка для элемента [{tagData.I}, {tagData.J}]. Ключ: {tagData.PrimaryKey}");

                this.Controls.Clear();
                filteredProducts = ApplyFilters();
                productControl = new ProductControl(_selectedKey, filteredProducts);
                productControl.Visible = true;
                this.Controls.Add(productControl);
            }
        }

        private void acceptFilterButton_Click(object sender, EventArgs e)
        {
            filteredProducts = ApplyFilters();
            catalogPanel.Controls.Clear();
            InitCatalogMap(filteredProducts);
        }
    }
}
