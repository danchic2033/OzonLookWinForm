namespace OzonLookWinForm
{
    public partial class MainForm : Form
    {
        private ProfileControl? profileControl;
        private CatalogControl? catalogControl;

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
            profileControl.Visible = false;
            catalogControl.Visible = true;
            this.Controls.Add(catalogControl);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
