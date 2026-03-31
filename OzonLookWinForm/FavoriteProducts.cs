using Library;

namespace OzonLookWinForm
{
    public class FavoriteProducts
    {
        public List<Product> FavoriteProduct { get; set; }
        public List<Image> PhotosFavoriteProduct { get; set; }

        public FavoriteProducts()
        {
            FavoriteProduct = new List<Product>();
            PhotosFavoriteProduct = new List<Image>();
        }
    }
}
