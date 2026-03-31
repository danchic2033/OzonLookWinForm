using Library;

namespace OzonLookWinForm
{
    public class HistoryProducts
    {
        public List<Product> HistoryProduct { get; set; }
        public List<Image> PhotosHistoryProduct { get; set; }

        public HistoryProducts()
        {
            HistoryProduct = new List<Product>();
            PhotosHistoryProduct = new List<Image>();
        }
    }
}
