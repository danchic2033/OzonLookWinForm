namespace OzonLookWinForm
{
    public partial class MainForm : Form
    {
        private ProfileControl profileControl;
        private CatalogControl catalogControl;
        private FavoriteCatalog favoriteCatalog;
        private HistoryControl historyControl;

        public MainForm()
        {
            InitializeComponent();
            profileControl = new ProfileControl();
            catalogControl = new CatalogControl();
            favoriteCatalog = new FavoriteCatalog();
            historyControl = new HistoryControl();

            this.Controls.Add(profileControl);
            this.Controls.Add(catalogControl);
            this.Controls.Add(favoriteCatalog);
            this.Controls.Add(historyControl);

            ShowControl(profileControl);
        }

        private void ShowControl(Control controlToShow)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = false;
            }
            topPanel.Visible = true;
            inTrayControlBox.Visible = true;
            toWindowControlBox.Visible = true;
            exitControlBox.Visible = true;
            leftPanel.Visible = true;
            catalogeButton.Visible = true;
            profileButton.Visible = true;
            favoriteButton.Visible = true;
            historyButton.Visible = true;
            controlToShow.Visible = true;
        }

        private void Profile(object sender, EventArgs e)
        {
            ShowControl(profileControl);
        }

        private void MainForm_Load_First(object sender, EventArgs e)
        {
            ShowControl(profileControl);
        }

        private void Catalog_Button_Click(object sender, EventArgs e)
        {
            ShowControl(catalogControl);
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            ShowControl(favoriteCatalog);
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            ShowControl(favoriteCatalog);
        }
    }
}
