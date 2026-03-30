namespace OzonLookWinForm
{
    public partial class MainForm : Form
    {
        private ProfileControl? profileControl;
        private CatalogControl? catalogControl;
        private ProductControl? productControl;
        private FavoriteCatalog? favoriteCatalog;
        private HistoryControl? historyControl;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Profile(object sender, EventArgs e)
        {
            profileControl = new ProfileControl();
            this.Controls.Add(profileControl);
            profileControl.Visible = true;
            profileControl.BringToFront();
            this.BringToFront();
            //favoriteCatalog.Visible = false;
            //historyControl.Visible = false;
        }

        private void MainForm_Load_First(object sender, EventArgs e)
        {
            profileControl = new ProfileControl();
            profileControl.Visible = true;
            this.Controls.Add(profileControl);
        }

        private void Catalog_Button_Click(object sender, EventArgs e)
        {
            catalogControl = new CatalogControl();
            this.Controls.Add(catalogControl);
            profileControl.Visible = false;
            catalogControl.Visible = true;
            this.Controls.Add(catalogControl);
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            this.Controls.Add(catalogControl);
            catalogControl.Hide();
            productControl.Visible = true;
            this.Controls.Add(productControl);
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            favoriteCatalog = new FavoriteCatalog();
            this.Controls.Add(favoriteCatalog);
            profileControl.Visible = false;
            catalogControl.Visible = false;
            favoriteCatalog.Visible = true;
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            historyControl = new HistoryControl();
            this.Controls.Add(historyControl);
            productControl.Visible = false;
            profileControl.Visible = false;
            catalogControl.Visible = false;
            historyControl.Visible = true;
        }
    }
}
