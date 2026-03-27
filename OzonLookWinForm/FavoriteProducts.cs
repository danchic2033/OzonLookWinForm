using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
