using Library;
using Microsoft.EntityFrameworkCore;
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
    public partial class CatalogControl : UserControl
    {
        private ProductControl? productControl;
        private ApplicationDbContext _context = new ApplicationDbContext();
        private List<Product> products;
        public CatalogControl()
        {
            InitializeComponent();
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            productControl = new ProductControl();
            productControl.Visible = true;
            this.Controls.Add(productControl);
        }
    }
}
