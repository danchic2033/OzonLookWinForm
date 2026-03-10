using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzonLookWinForm
{
    public partial class FitClothesForm : Form
    {
        public FitClothesForm(Image image)
        {
            InitializeComponent();
            catalogPicture.Image = image;
        }

        private void FitClothesForm_Load(object sender, EventArgs e)
        {

        }

        private void uploadPhoto_Click(object sender, EventArgs e)
        {
            var openFileDialoge = new OpenFileDialog();
            if (openFileDialoge.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    userPicture.Image = new Bitmap(openFileDialoge.FileName);
                }
                catch 
                { }
            }
        }
    }
}
