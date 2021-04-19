using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecgurus.ThreeLayers.ExampleApp.BL;
using Tecgurus.ThreeLayers.ExampleApp.Entities;

namespace Tecgurus.ThreeLayers.ExampleApp.WindowFormApp
{
    public partial class Form1 : Form
    {
        Book currentBook = new Book();
        List<Book> Books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Método utilizado para obtener los datos del formulario
        /// </summary>
        /// <returns></returns>
        private Book GetBookForm()
        {

            var messageValidation = ValidateNewBookForm();

            if (!string.IsNullOrEmpty(messageValidation))
            {
                MessageBox.Show(messageValidation, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }

            var book = new Book
            {
                NameBook = txtNameBook.Text
                ,
                DatePublishBook = dtpDatePublish.Value
                ,
                NumberPages = Convert.ToInt16(nupNumberPage.Value)
                ,
                SalePrice = (float)Convert.ToDouble(txtSalePrice.Text)
                ,
                PurchasePrice = !string.IsNullOrEmpty(txtPurchasePrice.Text) ? (double)Convert.ToDecimal(txtPurchasePrice.Text) : 0
                ,
                IsAvaible = chkIsAvaible.Checked

            };

            return book;

        }

        /// <summary>
        /// Validar datos de un formulario
        /// </summary>
        /// <returns></returns>
        private string ValidateNewBookForm()
        {


            if (txtNameBook.Text == string.Empty)
            {
                return "No ha agregado un nombre de libro";
            }

            if (txtNameBook.Text.Length < 10)
            {
                return "El nombre de libro es muy corto, debe de ser mayor a 10 caracteres";
            }

            if (txtSalePrice.Text == string.Empty)
            {
                return "No ha agregado un precio de compra";
            }

            var salePrice = 0D;

            //intentar castear el valor
            if (Double.TryParse(txtSalePrice.Text, out salePrice))
            {
                if (salePrice < 49.99)
                    return $"El valor de compra debe ser mayor a {String.Format("{0:C2}", 49.99) } y menor a {String.Format("{0:C2}", 9999.99) } ";
            }
            else
            {
                return $"El valor de compra no es un número";

            }

            var purcharsePrice = 0D;

            if (!string.IsNullOrEmpty(txtPurchasePrice.Text) && !Double.TryParse(txtPurchasePrice.Text, out purcharsePrice))
            {
                return $"El valor de venta no es un número";

            }

            return string.Empty;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //agregamos un libro con las clases que ya tenemos
            //try..chatch, no se usa en todo, se recomienda en las interacciones finales, conexion a bd, conversiones, uso de WS, operaciones
            try
            {
                #region procesoant
                //var nameBook = txtNameBook.Text;
                //var publishDate = dtpDatePublish.Value;//obtenemos el valor
                //var numberPage = nupNumberPage.Value;
                //var salePrice = txtSalePrice.Text;
                //var purchasePrice = txtPurchasePrice.Text;
                //var isAvaible = chkIsAvaible.Checked;

                //var book = new Book
                //{
                //    NameBook = nameBook,
                //    DatePublishBook = publishDate,
                //    NumberPages = Convert.ToInt32(numberPage),
                //    SalePrice = (float)Convert.ToDecimal(salePrice),
                //    PurchasePrice= (float)Convert.ToDecimal(purchasePrice),
                //    //PurchasePrice=float.Parse(purchasePrice),
                //    //PurchasePrice=double.Parse(purchasePrice),
                //    IsAvaible=isAvaible
                //};
                #endregion
                var book = GetBookForm();
                if (book != null)
                {
                    var logic = new BookLogic();

                    if (logic.AddBook(book))
                    {
                        ClearForm();
                        MessageBox.Show("Libro creado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo generar registro");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! se ha generado un error, favor de validar con el administrador");
                //throw; //lanza la execpsion
            }
        }
        private void ClearForm()
        {
            txtNameBook.Text = string.Empty;
            dtpDatePublish.Value = DateTime.Now;
            nupNumberPage.Value = 0;
            txtSalePrice.Text = string.Empty;
            txtPurchasePrice.Text = string.Empty;
            chkIsAvaible.Checked = false;

        }
        private void txt_OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void loadData()
        {
            Books= new BookLogic().GetAllBooks();
            dataBooksGridView.DataSource = Books;
        }

        private void dataBooksGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex.Equals(-1))
                {
                    return;
                }
                currentBook = Books[e.RowIndex];

                txtNameBook.Text = currentBook.IdBook.ToString();
                dtpDatePublish.Value = currentBook.DatePublishBook;
                nupNumberPage.Value = currentBook.NumberPages;
                txtSalePrice.Text = currentBook.SalePrice.ToString();
                txtPurchasePrice.Text = currentBook.PurchasePrice.ToString();
                chkIsAvaible.Checked = currentBook.IsAvaible;
            }
            catch (Exception ex)
            {
                //throw;
            }

        }
    }
}
