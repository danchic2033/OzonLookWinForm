namespace OzonLookWinForm
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
            InitStatistics();
        }

        private void InitStatistics()
        {
            var listProductsStats = FitClothesDataRepository.GetProductsStats()
                                    .ToArray();
            if (listProductsStats.Length == 0)
            { 
                return; 
            }

            var allTypeClothes = listProductsStats
                                 .ToArray();

            numberOfFitLabel.Text = allTypeClothes.Length.ToString();
        }
    }
}
