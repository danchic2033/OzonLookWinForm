using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzonLookWinForm
{
    public static class FitClothesDataRepository
    {
        public static List<Product> TypeOfClothes = new List<Product>();

        public static void AddClothesTop(Product product)
        {
            TypeOfClothes.Add(product);
        }
        public static List<Product> GetProductsStats()
        {
            return TypeOfClothes;
        }
    }
}
