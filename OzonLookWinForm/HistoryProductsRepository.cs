using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tensorflow;

namespace OzonLookWinForm
{
    public static class HistoryProductsRepository
    {
        private static List<HistoryProducts> _historyProducts = new List<HistoryProducts>();
        public static void SaveProduct(Product product, Image image)
        {
            var historyProducts = new HistoryProducts();
            historyProducts.HistoryProduct.Add(product);
            historyProducts.PhotosHistoryProduct.Add(image);
            _historyProducts.Add(historyProducts);
        }
        public static List<HistoryProducts> GetProduct()
        {
            return _historyProducts;
        }
    }
}
