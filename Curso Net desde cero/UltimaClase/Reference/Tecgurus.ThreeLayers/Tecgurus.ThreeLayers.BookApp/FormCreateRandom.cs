using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecgurus.ThreeLayers.BL;
using Tecgurus.ThreeLayers.Ent;

namespace Tecgurus.ThreeLayers.BookApp
{
    public partial class FormCreateRandom : MaterialForm
    {
        public BookEnt RandBook;

        public FormCreateRandom()
        {

            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );


        }

        private void btnCreateRand_Click(object sender, EventArgs e)
        {
            var book = BookEntHelper.GetRandomBooks(1).First();

            lblNameBook.Text = book.NameBook;
            lblNumberPages.Text = book.NumberPages.ToString();
            lblSalePrice.Text = book.SalePrice.ToString("0.00");
            lblPurchasePrice.Text = book.PurchasePrice.ToString("0.0000");
            lblIsAvaible.Text = book.IsAvaible.ToString();
            lblDatePublishBook.Text = book.DatePublishBook.ToString("dd/MM/yyyy");

            RandBook = book;

        }

        private void btnSendToForm_Click(object sender, EventArgs e)
        {
            if (RandBook == null) return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
