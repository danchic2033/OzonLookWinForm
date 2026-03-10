using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzonLookWinForm
{
    public partial class ProductControl : UserControl
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        private List<Product> products;
        public ProductControl()
        {
            InitializeComponent();
            products = _context.Products.ToList();
            this.Load += ProductControl_Load;
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            ShowProduct();
        }

        private void ShowProduct()
        {
            var product = products[0];

            nameOfBrendLabel.Text = product.Brend;
            nameOfClothe.Text = product.Name;
            compositionProductLabel.Text = product.Composition;
            articleNumberLabel.Text = product.Article;
            priceOfProduct.Text = product.Price;
            descriptionLabel.Text = product.Description;
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            var image = productPicture.Image;
            var fitClothesForm = new FitClothesForm(image);
            fitClothesForm.ShowDialog();
        }
    }
}
