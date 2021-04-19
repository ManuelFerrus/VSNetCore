using MaterialSkin.Controls;
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
using Tecgurus.ThreeLayers.BookAppWorkShop;
using Tecgurus.ThreeLayers.Ent;


namespace Tecgurus.ThreeLayers.BookApp
{
    public partial class FormCrudBook : MaterialForm
    {
        /// <summary>
        /// Libro seleccionado y  que esta actualemte en edición
        /// </summary>
        public BookEnt CurrentBook { get; set; }

        public List<BookEnt> Books { get; set; }

        private NotifyIcon notifyIcon1;
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;

        public FormCrudBook()
        {
            InitializeComponent();


            ClearForm();
            CreateNotify();

        }

        #region Formevents

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {


                var confirmResult = MessageBox.Show("¿Desea agregar?", "Confirmar operación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
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
                        //MessageBox.Show("Libro Guardado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetNotificationTip("Éxito!", $"Agrego el libro {book.NameBook}", ToolTipIcon.Info);
                    }
                    else
                    {

                        MessageBox.Show("Ups! se ha generado un error");
                    }
                }
                else
                {
                    //TO DO
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! se ha generado un error");
                Logger.logger.Error(ex.Message);
                //Logger.logger.Info(ex.Message);
                Logger.loggerDataBase.Error(ex);
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

                var confirmResult = MessageBox.Show("¿Desea eliminar?", "Confirmar operación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

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
                else
                {
                    //TO DO
                }


            }
            catch (Exception ex)
            {
                Logger.logger.Error(ex.Message);
                //Logger.logger.Info(ex.Message);
                Logger.loggerDataBase.Error(ex);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("¿Desea actualizar?", "Confirmar operación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

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
                else
                {
                    //TO DO
                }


            }
            catch (Exception ex)
            {
                Logger.logger.Error(ex.Message);
                //Logger.logger.Info(ex.Message);
                Logger.loggerDataBase.Error(ex);
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
                Cursor.Current = Cursors.WaitCursor;

                var logic = new BookLogic();
                var listBooks = logic.GetBookByName(txtNameBook.Text);
                //La fuente de datos es la lista de objetos que se obtiene de 
                //la base de datos
                dataBooksGridView.DataSource = listBooks;

                Books = listBooks;

            }
            catch (Exception ex)
            {
                Logger.logger.Error(ex.Message);
                //Logger.logger.Info(ex.Message);
                Logger.loggerDataBase.Error(ex);
            }

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (Books.Any())
                {
                    Cursor.Current = Cursors.WaitCursor;

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
                Logger.logger.Error(ex.Message);
                //Logger.logger.Info(ex.Message);
                Logger.loggerDataBase.Error(ex);
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

                Cursor.Current = Cursors.WaitCursor;

                CurrentBook = Books[e.RowIndex];


                //ASIGNAR VALORE A FORMULARIO
                txtNameBook.Text = CurrentBook.NameBook;
                txtPurchasePrice.Text = CurrentBook.PurchasePrice.ToString();
                txtSalePrice.Text = CurrentBook.SalePrice.ToString();
                dtPublishDateBook.Value = CurrentBook.DatePublishBook;
                chAvaible.Checked = CurrentBook.IsAvaible;
                nudPagesBook.Value = CurrentBook.NumberPages;

                btnSave.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnClear.Visible = true;
            }
            catch (Exception ex)
            {
                Logger.logger.Error(ex.Message);
                //Logger.logger.Info(ex.Message);
                Logger.loggerDataBase.Error(ex);
            }

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

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
            Cursor.Current = Cursors.WaitCursor;
            LoadDataGrid();


        }


        #endregion

        #region OperationsHelper

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

        private void FormCrudBook_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tecGurusDataSet.Books' Puede moverla o quitarla según sea necesario.
            this.booksTableAdapter.Fill(this.tecGurusDataSet.Books);

        }

        #region NotifiIcon
        public void CreateNotify()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();

            // Initialize contextMenu1
            this.contextMenu1.MenuItems.AddRange(
                        new System.Windows.Forms.MenuItem[] { this.menuItem1 });

            // Initialize menuItem1
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "E&xit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);

            //// Set up how the form should be displayed.
            //this.ClientSize = new System.Drawing.Size(292, 266);
            //this.Text = "Notify Icon Example";

            // Create the NotifyIcon.
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);

            // The Icon property sets the icon that will appear
            // in the systray for this application.
            //permitircopiar siempre // propiedas, copiar siempre
            notifyIcon1.Icon = new Icon("book-bookmark-icon_34486.ico");

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon1.ContextMenu = this.contextMenu1;

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.
            notifyIcon1.Text = "BookManagementApp";
            notifyIcon1.Visible = true;

            // Handle the DoubleClick event to activate the form.
            notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
        }

        private void notifyIcon1_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            //Se crea el icono y se pueden hacer varias acciones

            // Close the form, which closes the application.
            this.Close();
        }

        private void SetNotificationTip(string title, string message, ToolTipIcon icon)
        {
            //notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.BalloonTipIcon = icon;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30000);
        }

        #endregion

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ClearForm();
            if ((Application.OpenForms["FormCreateRandom"] as FormCreateRandom) != null)
            {
                //ya tenemos un formulario abierto
                SetNotificationTip("Cuidado!", "ya tenemos un formulario abierto.", ToolTipIcon.Info);
            }
            else
            {
                using (var formRand = new FormCreateRandom())
                {
                    var result = formRand.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        txtNameBook.Text = formRand.RandBook.NameBook;
                        txtPurchasePrice.Text = formRand.RandBook.PurchasePrice.ToString();
                        txtSalePrice.Text = formRand.RandBook.SalePrice.ToString();
                        dtPublishDateBook.Value = formRand.RandBook.DatePublishBook;
                        chAvaible.Checked = formRand.RandBook.IsAvaible;
                        nudPagesBook.Value = formRand.RandBook.NumberPages;
                    }
                    //formRand.Show();
                }
            }
            var formRandom = new FormCreateRandom();
            //formRandom.Show();
            //formRandom.ShowDialog();
        }
    }
}
