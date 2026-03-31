using Library;

namespace OzonLookWinForm
{
    public partial class ProductControl : UserControl
    {
        public List<HistoryProducts> HistoryProduct { get; }
        public List<FavoriteProducts> FavoriteProducts { get; }
        private List<Product> _products;
        private List<Photo> _photos;
        private Product _topProduct;
        private int _primaryKey;
        private bool _marker = false;
        

        public ProductControl(int primaryKey, List<Product> filteredProducts)
        {
            InitializeComponent();
            _products = filteredProducts;
            _primaryKey = primaryKey;
            _photos = PhotoRepository.GetPhotos();
            this.Load += ProductControl_Load;
        }

        public ProductControl(int primaryKey, List<FavoriteProducts> favoriteProducts)
        {
            InitializeComponent();
            _primaryKey = primaryKey;
            FavoriteProducts = favoriteProducts;
            ShowFavoriteProduct();
        }
        public ProductControl(int primaryKey, List<HistoryProducts> _historyProducts)
        {
            InitializeComponent();
            _primaryKey = primaryKey;
            HistoryProduct = _historyProducts;
            ShowHistoryProduct();
        }

        private void ShowHistoryProduct()
        {
            _marker = true;
            var product = HistoryProduct[_primaryKey - 1];

            productPicture.Image = product.PhotosHistoryProduct[_primaryKey - 1];
            nameOfBrendLabel.Text = product.HistoryProduct[_primaryKey - 1].Brend;
            nameOfClothe.Text = product.HistoryProduct[_primaryKey - 1].Name;
            compositionProductLabel.Text = product.HistoryProduct[_primaryKey - 1].Composition;
            articleNumberLabel.Text = product.HistoryProduct[_primaryKey - 1].Article;
            priceOfProduct.Text = product.HistoryProduct[_primaryKey - 1].Price;
            descriptionLabel.Text = product.HistoryProduct[_primaryKey - 1].Description;
        }

        private void ShowFavoriteProduct()
        {
            _marker = true;
            var product = FavoriteProducts[_primaryKey - 1];

            productPicture.Image = product.PhotosFavoriteProduct[_primaryKey - 1];
            nameOfBrendLabel.Text = product.FavoriteProduct[_primaryKey - 1].Brend;
            nameOfClothe.Text = product.FavoriteProduct[_primaryKey - 1].Name;
            compositionProductLabel.Text = product.FavoriteProduct[_primaryKey - 1].Composition;
            articleNumberLabel.Text = product.FavoriteProduct[_primaryKey - 1].Article;
            priceOfProduct.Text = product.FavoriteProduct[_primaryKey - 1].Price;
            descriptionLabel.Text = product.FavoriteProduct[_primaryKey - 1].Description;
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            if (_marker == false)
            {
                ShowProduct();
            }
        }

        private void ShowProduct()
        {
            var product = _products[_primaryKey - 1];

            _topProduct = product;

            productPicture.Image = _photos[_primaryKey - 1].Images[0];
            nameOfBrendLabel.Text = product.Brend;
            nameOfClothe.Text = product.Name;
            compositionProductLabel.Text = product.Composition;
            articleNumberLabel.Text = product.Article;
            priceOfProduct.Text = product.Price;
            descriptionLabel.Text = product.Description;
            AddItemHistoryCatalog();
            _marker = true;
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            FitClothesDataRepository.AddClothesTop(_topProduct);


            //var image = productPicture.Image;
            //var fitClothesForm = new FitClothesForm(image);
            //fitClothesForm.ShowDialog();
        }

        private void addFavoriteButton_Click(object sender, EventArgs e)
        {
            var product = _products[_primaryKey - 1];
            FavoriteProductsRepository.SaveProduct(product, _photos[_primaryKey - 1].Images[0]);
        }

        private void AddItemHistoryCatalog()
        {
            var product = _products[_primaryKey - 1];
            HistoryProductsRepository.SaveProduct(product, _photos[_primaryKey - 1].Images[0]);
        }
    }
}
