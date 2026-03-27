using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzonLookWinForm
{
    public static class FavoriteProductsRepository
    {
        private static List<FavoriteProducts> _favoriteProducts = new List<FavoriteProducts>();
        public static void SaveProduct(Product product, Image image)
        {
            var favoriteProduct = new FavoriteProducts();
            favoriteProduct.FavoriteProduct.Add(product);
            favoriteProduct.PhotosFavoriteProduct.Add(image);
            _favoriteProducts.Add(favoriteProduct);
        }
        public static List<FavoriteProducts> GetProduct()
        {
            
            return _favoriteProducts;
        }
    }
}
