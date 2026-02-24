namespace OzonLookWinForm
{
    public partial class MainForm : Form
    {
        private Profile? profileControl;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Profile(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_First(object sender, EventArgs e)
        {
            profileControl = new Profile();
            profileControl.Visible = true;
            this.Controls.Add(profileControl);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
