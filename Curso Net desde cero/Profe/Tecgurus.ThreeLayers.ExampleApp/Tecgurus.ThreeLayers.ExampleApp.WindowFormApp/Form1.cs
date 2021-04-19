using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Book CurrentBook = new Book();

        List<Book> Books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
            LoadData();
            Logger.logger.Info("Inicializacion de formulario");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //var nameBook = txtNameBook.Text;
                //var publishDate = dtpDatePublish.Value;
                //var numberPage = nupNumberPages.Value;
                //var salePrice = txtSalePrice.Text;
                //var purchasePrice = txtPurchasePrice.Text;
                //var isAvaible = chkIsAvaible.Checked;

                //var book = new Book
                //{
                //    NameBook = nameBook,
                //    DatePublishBook = publishDate,
                //    NumberPages = Convert.ToInt32(numberPage),
                //    SalePrice = (float)Convert.ToDecimal(salePrice),
                //    PurchasePrice = (double)Convert.ToDecimal(purchasePrice),
                //    IsAvaible = isAvaible

                //};

                var book = GetBookForm();

                if (book != null)
                {


                    var logic = new BookLogic();

                    if (logic.AddBook(book))
                    {

                        ClearForm();

                        MessageBox.Show("Libro Creado");
                        LoadData();



                    }
                    else
                    {

                        MessageBox.Show("No se pudo generar registro");

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! se ha generado un error, Favor de validar con el adminsitrador");
                Logger.logger.Error(ex);// se nanda la excepcion al log
            }
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
                NumberPages = Convert.ToInt16(nupNumberPages.Value)
                ,
                SalePrice = (float)Convert.ToDouble(txtSalePrice.Text)
                ,
                PurchasePrice = !string.IsNullOrEmpty(txtPurchasePrice.Text) ? (double)Convert.ToDecimal(txtPurchasePrice.Text) : 0
                ,
                IsAvaible = chkIsAvaible.Checked

            };

            var messageForm = JsonConvert.SerializeObject(book, Formatting.Indented);
            var bookMessage = JsonConvert.DeserializeObject<Book>(messageForm);//se le manda la variable string y se le indica la clase, para el formato de salida

            Logger.logger.Trace($"se ha enviado el libro: {messageForm}");
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
                return "El nombre de libro es muy corto, debe de ser mayor a 10 caraceres";
            }

            if (txtSalePrice.Text == string.Empty)
            {
                return "No ha agregado un precio de compra";
            }

            var salePrice = 0D;

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

        private void LoadData()
        {


            var list = new BookLogic().GetAllBooks();

            Books = list;

            dataBooksGridView.DataSource = Books;

        }

        private void ClearForm()
        {

            txtNameBook.Text = string.Empty;
            dtpDatePublish.Value = DateTime.Now;
            nupNumberPages.Value = 0;
            txtSalePrice.Text = string.Empty;
            txtPurchasePrice.Text = string.Empty;
            chkIsAvaible.Checked = false;

            btnSave.Visible = false;
            btnDelete.Visible = false;

            btnAdd.Visible = true;
        }

        private void dataBooksGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //BUSCRA ELEMENTO EN GRID
                // PONERLO EN SESION
                if (e.RowIndex.Equals(-1))
                {

                    return;
                }

                CurrentBook = Books[e.RowIndex];


                //ASIGNAR VALORE A FORMULARIO
                txtNameBook.Text = CurrentBook.NameBook;
                txtPurchasePrice.Text = CurrentBook.PurchasePrice.ToString();
                txtSalePrice.Text = CurrentBook.SalePrice.ToString();
                dtpDatePublish.Value = CurrentBook.DatePublishBook;
                chkIsAvaible.Checked = CurrentBook.IsAvaible;
                nupNumberPages.Value = CurrentBook.NumberPages;

                btnDelete.Visible = true;
                btnSave.Visible = true;
                btnAdd.Visible = false;
            }
            catch (Exception ex)
            {
                Logger.logger.Error(ex);// se nanda la excepcion al log
                throw;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("¿Desea eliminar'", "confirmar operacion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    var book = GetBookForm();

                    if (book != null)
                    {


                        var logic = new BookLogic();

                        if (logic.UpdateBook(CurrentBook.IdBook, book))
                        {

                            ClearForm();

                            MessageBox.Show("Libro Actualizado");

                            LoadData();


                        }
                        else
                        {
                            MessageBox.Show("No se pudo Actualizar");
                        }
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show("Ups! se ha generado un error, Favor de validar con el adminsitrador");
                Logger.logger.Error(ex);// se nanda la excepcion al log
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("¿Desea eliminar'", "confirmar operacion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var logic = new BookLogic();
                    if (logic.DeleteBook(CurrentBook.IdBook))
                    {
                        ClearForm();
                        LoadData();
                        MessageBox.Show("Libro eliminado!");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show("Ups! se ha generado un error, Favor de validar con el adminsitrador");
                Logger.logger.Error(ex);// se nanda la excepcion al log
            }
        }

        private void btnSaveGrid_Click(object sender, EventArgs e)
        {
            try
            {
                //preguntamos donde quiere guardar el usuario
                //guardamos el json en la ruta que el usuario indico
                if (Books.Any()) //tru si tiene valores, false, si no
                {
                    //el using limita en que momento se va a utilizar el objeto
                    //al terminar su uso, se le indica al sistema que lo puede quitar de memoria
                    using (var fbd = new FolderBrowserDialog())
                    {
                        var result = fbd.ShowDialog();
                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            using (StreamWriter file = File.CreateText($@"{fbd.SelectedPath}\{Guid.NewGuid()}"))
                            {
                                file.Write(JsonConvert.SerializeObject(Books, Formatting.Indented));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! se ha generado un error, Favor de validar con el adminsitrador");
                Logger.logger.Error(ex);// se nanda la excepcion al log
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;//se cambia el simbolod el cursor

                var logic = new BookLogic();
                var list = logic.GetBookByName(txtNameBook.Text);

                dataBooksGridView.DataSource = list;
                Books = list;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! se ha generado un error, Favor de validar con el adminsitrador");
                Logger.logger.Error(ex);// se nanda la excepcion al log
            }
        }
    }
}
