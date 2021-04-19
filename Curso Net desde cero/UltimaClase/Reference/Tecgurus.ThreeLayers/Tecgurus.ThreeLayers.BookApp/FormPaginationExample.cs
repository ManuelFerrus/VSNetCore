using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using OfficeOpenXml;
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
using Tecgurus.ThreeLayers.Tools;

namespace Tecgurus.ThreeLayers.BookApp
{
    public partial class FormPaginationExample : MaterialForm
    {
        private int _pageIndex;
        private int _totalPages;
        private int _pageSize;
        private List<BookEnt> _books;

        public FormPaginationExample()
        {

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

            InitializeComponent();


            bindingNavigationCboxPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            bindingNavigationCboxPageSize.Items.Add(new ComboboxItem { Text = "Todo", Value = 1 });
            bindingNavigationCboxPageSize.Items.Add(new ComboboxItem { Text = "3", Value = 3 });
            bindingNavigationCboxPageSize.Items.Add(new ComboboxItem { Text = "5", Value = 5 });
            bindingNavigationCboxPageSize.Items.Add(new ComboboxItem { Text = "10", Value = 10 });
            bindingNavigationCboxPageSize.SelectedIndex = 0;

            GetPagedList(null);
        }

        private void GetPagedList(int? page)
        {
            var totalRows = 0;
            _pageIndex = page.HasValue ? page.Value : 0;

            if (page.HasValue && page.Value > 0)
            {
                _pageIndex = _pageIndex - 1;
            }
            _pageSize = ((ComboboxItem)bindingNavigationCboxPageSize.SelectedItem).Value;
            _totalPages = 0;

            _books = new BookLogic().GetPagedBooks(_pageIndex, _pageSize, "IdBook", true, string.Empty, out totalRows);
            dataGridView1.DataSource = _books;
            bookEntBindingSource.DataSource = _books;

            if (_pageSize == 1)
            {
                _totalPages = 1;

            }
            else
            {
                var module = (totalRows % _pageSize);
                var ttPages = totalRows / _pageSize;
                _totalPages = module > 0 ? ttPages + 1 : ttPages;

            }
            
            _pageIndex = _pageIndex + 1;
           
            bindingNavigatorCountItem.Text = _totalPages.ToString();
            bindingNavigatorPositionItem.Text = _pageIndex.ToString();

            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            GetPagedList(null);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            GetPagedList(_totalPages);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            GetPagedList(_pageIndex - 1);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            GetPagedList(_pageIndex + 1);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_books.Any())
                {
                    Cursor.Current = Cursors.WaitCursor;

                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            //using (StreamWriter file = File.CreateText($@"{fbd.SelectedPath}\{Guid.NewGuid()}.json"))
                            //{
                            //    file.Write(JsonConvert.SerializeObject(_books, Formatting.Indented));
                            //}

                            CreateExcelFile($@"{fbd.SelectedPath}\{Guid.NewGuid()}.xlsx", _books);

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
                CustomLogger.logger.Error(ex.Message);
            }
        }

        private void CreateExcelFile(string filePath, List<BookEnt> books)
        {
            var file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(file))
            {
                var sheet = package.Workbook.Worksheets.Add("My Sheet");
                sheet.Cells[1, 1].Value = "Id";
                sheet.Cells[1, 2].Value = "NameBook";
                sheet.Cells[1, 3].Value = "NumberPages";
                sheet.Cells[1, 4].Value = "PurchasePrice";
                sheet.Cells[1, 5].Value = "SalePrice";
                sheet.Cells[1, 6].Value = "DatePublishBook";
                sheet.Cells[1, 7].Value = "IsAvaible";

                var row = 2;
                foreach (var item in books)
                {
                    sheet.Cells[row, 1].Value = item.IdBook;
                    sheet.Cells[row, 2].Value = item.NameBook;
                    sheet.Cells[row, 3].Value = item.NumberPages;
                    sheet.Cells[row, 4].Value = item.PurchasePrice;
                    sheet.Cells[row, 5].Value = item.SalePrice;
                    sheet.Cells[row, 6].Value = item.DatePublishBook.ToString("dd/MM/yyyy");
                    sheet.Cells[row, 7].Value = item.IsAvaible;

                    row++;

                }

                // Save to file
                package.Save();
            }
        }

        private void bindingNavigationCboxPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPagedList(null);
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
