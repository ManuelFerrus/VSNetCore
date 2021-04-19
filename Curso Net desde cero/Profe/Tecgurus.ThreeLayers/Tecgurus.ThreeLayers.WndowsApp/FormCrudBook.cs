using Newtonsoft.Json;
using NLog;
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
using Tecgurus.ThreeLayers.BL;
using Tecgurus.ThreeLayers.Ent;

namespace Tecgurus.ThreeLayers.WndowsApp
{
    public partial class FormCrudBook : Form
    {
        /// <summary>
        /// Libro seleccionado y  que esta actualemte en edición
        /// </summary>
        public BookEnt CurrentBook { get; set; }

        public List<BookEnt> Books { get; set; }

        public FormCrudBook()
        {
            InitializeComponent();
            ClearForm();

            Logger.logger.Info("Inicio programa");
        }

        #region Formevents

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                var book = GetBookForm();

                if (book == null)
                {
                    return;
                }

                ///Instancia de capa logica
                var logic = new BookLogic();


                if (logic.AddBook(book))
                {
                    ClearForm();
                    MessageBox.Show("Libro Guardado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Ups! se ha generado un error");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! se ha generado un error");

                Logger.logger.Error(ex);
                Logger.logger.Info(ex.Message);

            }
            finally
            {

                LoadDataGrid();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ///Instancia de capa logica
                var logic = new BookLogic();


                if (logic.DeleteBook(CurrentBook.IdBook))
                {
                    ClearForm();
                    MessageBox.Show("Libro Eliminado");
                }
                else
                {
                    MessageBox.Show("Ups! se ha generado un error");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! se ha generado un error");
                Logger.logger.Error(ex.Message);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var book = GetBookForm();


                if (book == null)
                {
                    MessageBox.Show("Revisar información de formulario");
                    return;
                }


                book.IdBook = CurrentBook.IdBook;


                ///Instancia de capa logica
                var logic = new BookLogic();


                if (logic.UpdateBook(CurrentBook.IdBook, book))
                {
                    MessageBox.Show("Actualización correcta");

                    ClearForm();

                }
                else
                {

                    MessageBox.Show("Ups! se ha generado un error");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ups! se ha generado un error");
                Logger.logger.Error(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var logic = new BookLogic();
                var listBooks = logic.GetBookByName(txtNameBook.Text);
                //La fuente de datos es la lista de objetos que se obtiene de 
                //la base de datos
                dataBooksGridView.DataSource = listBooks;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ups! se ha generado un error");
                Logger.logger.Error(ex.Message);
            }

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (Books.Any())
                {
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            using (StreamWriter file = File.CreateText($@"{fbd.SelectedPath}\{Guid.NewGuid()}.json"))
                            {
                                file.Write(JsonConvert.SerializeObject(Books, Formatting.Indented));
                            }

                            MessageBox.Show("Se ha guardado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No existen libros que guaradar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }





            }
            catch (Exception ex)
            {

                MessageBox.Show("Ups! se ha generado un error");
                Logger.logger.Error(ex.Message);
            }
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
                dtPublishDateBook.Value = CurrentBook.DatePublishBook;
                chAvaible.Checked = CurrentBook.IsAvaible;

                btnSave.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnClear.Visible = true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = "JSON files |*.json";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    String path = dialog.FileName;
                    using (var reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                    {
                        dataBooksGridView.DataSource = JsonConvert.DeserializeObject<List<BookEnt>>(reader.ReadToEnd());
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ups! se ha generado un error");
                Logger.logger.Error(ex.Message);
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            LoadDataGrid();


        }

        #endregion

        #region Operations

        /// <summary>
        /// Método utilizado para obtener los datos del formulario
        /// </summary>
        /// <returns></returns>
        private BookEnt GetBookForm()
        {

            var messageValidation = ValidateNewBookForm();

            if (!string.IsNullOrEmpty(messageValidation))
            {
                MessageBox.Show(messageValidation, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }

            var book = new BookEnt
            {
                NameBook = txtNameBook.Text
                ,
                DatePublishBook = dtPublishDateBook.Value
                ,
                NumberPages = Convert.ToInt16(nudPagesBook.Value)
                ,
                SalePrice = Convert.ToDouble(txtSalePrice.Text)
                ,
                PurchasePrice = !string.IsNullOrEmpty(txtPurchasePrice.Text) ? Convert.ToDecimal(txtPurchasePrice.Text) : 0
                ,
                IsAvaible = chAvaible.Checked

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
                return "El nombre de libro es muy corto";
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

        /// <summary>
        /// Cargar lista de libros
        /// </summary>
        private void LoadDataGrid()
        {
            try
            {
                ///Instancia de capa logica
                var logic = new BookLogic();

                var listBooks = logic.GetAllBooks();

                //La fuente de datos es la lista de objetos que se obtiene de 
                //la base de datos
                dataBooksGridView.DataSource = listBooks;

                Books = listBooks;


            }
            catch (Exception ex)
            {

                Logger.logger.Error(ex);
                Logger.logger.Info(ex.Message);
            }


        }

        /// <summary>
        /// Método utilizado para limpiar el formulario y restablecer valores de inicio
        /// </summary>
        private void ClearForm()
        {
            txtNameBook.Clear();
            txtSalePrice.Clear();
            txtPurchasePrice.Clear();
            dtPublishDateBook.Value = DateTime.Now;
            btnSave.Visible = true;
            chAvaible.Checked = false;

            btnSave.Visible = true;
            btnClear.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            LoadDataGrid();

        }

        #endregion

        #region FormHelpers

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


        #endregion
    }
}
