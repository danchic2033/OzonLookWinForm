using Library;

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
