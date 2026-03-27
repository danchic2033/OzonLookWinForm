namespace OzonLookWinForm
{
    public partial class MainForm : Form
    {
        private ProfileControl? profileControl;
        private CatalogControl? catalogControl;
        private ProfileControl? productControl;
        private FavoriteCatalog? favoriteCatalog;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Profile(object sender, EventArgs e)
        {

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
            productControl = new ProfileControl();
            productControl.Visible = false;
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

        }
    }
}
