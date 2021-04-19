
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Tecgurus.ThreeLayers.BookApp
{
    partial class FormCrudBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrudBook));
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNameBook = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtPublishDateBook = new System.Windows.Forms.DateTimePicker();
            this.nudPagesBook = new System.Windows.Forms.NumericUpDown();
            this.txtPurchasePrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSalePrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chAvaible = new System.Windows.Forms.CheckBox();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataBooksGridView = new System.Windows.Forms.DataGridView();
            this.NumberPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tecGurusDataSet = new Tecgurus.ThreeLayers.BookAppWorkShop.TecGurusDataSet();
            this.bookEntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLoadFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSaveFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnReload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.booksTableAdapter = new Tecgurus.ThreeLayers.BookAppWorkShop.TecGurusDataSetTableAdapters.BooksTableAdapter();
            this.btnRandom = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagesBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecGurusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookEntBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de publicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio de compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(19, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio de venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(19, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "N° de paginas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(19, 382);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Disponble";
            // 
            // txtNameBook
            // 
            this.txtNameBook.Depth = 0;
            this.txtNameBook.Hint = "";
            this.txtNameBook.Location = new System.Drawing.Point(19, 103);
            this.txtNameBook.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameBook.MaxLength = 32767;
            this.txtNameBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.PasswordChar = '\0';
            this.txtNameBook.SelectedText = "";
            this.txtNameBook.SelectionLength = 0;
            this.txtNameBook.SelectionStart = 0;
            this.txtNameBook.Size = new System.Drawing.Size(217, 23);
            this.txtNameBook.TabIndex = 1;
            this.txtNameBook.TabStop = false;
            this.txtNameBook.UseSystemPasswordChar = false;
            // 
            // dtPublishDateBook
            // 
            this.dtPublishDateBook.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPublishDateBook.Location = new System.Drawing.Point(19, 177);
            this.dtPublishDateBook.Margin = new System.Windows.Forms.Padding(2);
            this.dtPublishDateBook.Name = "dtPublishDateBook";
            this.dtPublishDateBook.Size = new System.Drawing.Size(135, 20);
            this.dtPublishDateBook.TabIndex = 2;
            // 
            // nudPagesBook
            // 
            this.nudPagesBook.Location = new System.Drawing.Point(19, 233);
            this.nudPagesBook.Margin = new System.Windows.Forms.Padding(2);
            this.nudPagesBook.Maximum = new decimal(new int[] {
            551,
            0,
            0,
            0});
            this.nudPagesBook.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPagesBook.Name = "nudPagesBook";
            this.nudPagesBook.Size = new System.Drawing.Size(80, 20);
            this.nudPagesBook.TabIndex = 3;
            this.nudPagesBook.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Depth = 0;
            this.txtPurchasePrice.Hint = "";
            this.txtPurchasePrice.Location = new System.Drawing.Point(19, 350);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchasePrice.MaxLength = 32767;
            this.txtPurchasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PasswordChar = '\0';
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.SelectionLength = 0;
            this.txtPurchasePrice.SelectionStart = 0;
            this.txtPurchasePrice.Size = new System.Drawing.Size(217, 23);
            this.txtPurchasePrice.TabIndex = 5;
            this.txtPurchasePrice.TabStop = false;
            this.txtPurchasePrice.UseSystemPasswordChar = false;
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OnlyNumbers_KeyPress);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Depth = 0;
            this.txtSalePrice.Hint = "";
            this.txtSalePrice.Location = new System.Drawing.Point(19, 290);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalePrice.MaxLength = 32767;
            this.txtSalePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PasswordChar = '\0';
            this.txtSalePrice.SelectedText = "";
            this.txtSalePrice.SelectionLength = 0;
            this.txtSalePrice.SelectionStart = 0;
            this.txtSalePrice.Size = new System.Drawing.Size(217, 23);
            this.txtSalePrice.TabIndex = 4;
            this.txtSalePrice.TabStop = false;
            this.txtSalePrice.UseSystemPasswordChar = false;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OnlyNumbers_KeyPress);
            // 
            // chAvaible
            // 
            this.chAvaible.AutoSize = true;
            this.chAvaible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chAvaible.Location = new System.Drawing.Point(19, 411);
            this.chAvaible.Margin = new System.Windows.Forms.Padding(0);
            this.chAvaible.Name = "chAvaible";
            this.chAvaible.Size = new System.Drawing.Size(15, 14);
            this.chAvaible.TabIndex = 6;
            this.chAvaible.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(297, 244);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(84, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataBooksGridView
            // 
            this.dataBooksGridView.AllowUserToAddRows = false;
            this.dataBooksGridView.AllowUserToDeleteRows = false;
            this.dataBooksGridView.AutoGenerateColumns = false;
            this.dataBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBooksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberPages,
            this.idBookDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.numberPagesDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.dataBooksGridView.DataSource = this.booksBindingSource;
            this.dataBooksGridView.Location = new System.Drawing.Point(421, 91);
            this.dataBooksGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataBooksGridView.Name = "dataBooksGridView";
            this.dataBooksGridView.ReadOnly = true;
            this.dataBooksGridView.RowHeadersWidth = 62;
            this.dataBooksGridView.RowTemplate.Height = 28;
            this.dataBooksGridView.Size = new System.Drawing.Size(682, 304);
            this.dataBooksGridView.TabIndex = 13;
            this.dataBooksGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBooksGridView_CellDoubleClick);
            // 
            // NumberPages
            // 
            this.NumberPages.DataPropertyName = "NumberPages";
            this.NumberPages.HeaderText = "Páginas";
            this.NumberPages.MinimumWidth = 8;
            this.NumberPages.Name = "NumberPages";
            this.NumberPages.ReadOnly = true;
            this.NumberPages.Width = 150;
            // 
            // idBookDataGridViewTextBoxColumn
            // 
            this.idBookDataGridViewTextBoxColumn.DataPropertyName = "IdBook";
            this.idBookDataGridViewTextBoxColumn.HeaderText = "IdBook";
            this.idBookDataGridViewTextBoxColumn.Name = "idBookDataGridViewTextBoxColumn";
            this.idBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NameBook";
            this.dataGridViewTextBoxColumn1.HeaderText = "NameBook";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DatePublishBook";
            this.dataGridViewTextBoxColumn2.HeaderText = "DatePublishBook";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // numberPagesDataGridViewTextBoxColumn
            // 
            this.numberPagesDataGridViewTextBoxColumn.DataPropertyName = "NumberPages";
            this.numberPagesDataGridViewTextBoxColumn.HeaderText = "NumberPages";
            this.numberPagesDataGridViewTextBoxColumn.Name = "numberPagesDataGridViewTextBoxColumn";
            this.numberPagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "SalePrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PurchasePrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "PurchasePrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsAvaible";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsAvaible";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.tecGurusDataSet;
            // 
            // tecGurusDataSet
            // 
            this.tecGurusDataSet.DataSetName = "TecGurusDataSet";
            this.tecGurusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(297, 188);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = true;
            this.btnSearch.Size = new System.Drawing.Size(74, 36);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(297, 290);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(103, 36);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(297, 406);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(91, 36);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Cancelar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(297, 350);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(83, 36);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.AutoSize = true;
            this.btnLoadFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadFile.Depth = 0;
            this.btnLoadFile.Icon = null;
            this.btnLoadFile.Location = new System.Drawing.Point(421, 406);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Primary = true;
            this.btnLoadFile.Size = new System.Drawing.Size(157, 36);
            this.btnLoadFile.TabIndex = 18;
            this.btnLoadFile.Text = "Cargar de archivo";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.AutoSize = true;
            this.btnSaveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveFile.Depth = 0;
            this.btnSaveFile.Icon = null;
            this.btnSaveFile.Location = new System.Drawing.Point(647, 406);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Primary = true;
            this.btnSaveFile.Size = new System.Drawing.Size(105, 36);
            this.btnSaveFile.TabIndex = 19;
            this.btnSaveFile.Text = "Guardar en";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReload.Depth = 0;
            this.btnReload.Icon = null;
            this.btnReload.Location = new System.Drawing.Point(817, 406);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReload.Name = "btnReload";
            this.btnReload.Primary = true;
            this.btnReload.Size = new System.Drawing.Size(91, 36);
            this.btnReload.TabIndex = 20;
            this.btnReload.Text = "Recargar";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de libro";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // btnRandom
            // 
            this.btnRandom.AutoSize = true;
            this.btnRandom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRandom.Depth = 0;
            this.btnRandom.Icon = null;
            this.btnRandom.Location = new System.Drawing.Point(297, 123);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandom.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Primary = true;
            this.btnRandom.Size = new System.Drawing.Size(94, 36);
            this.btnRandom.TabIndex = 14;
            this.btnRandom.Text = "ALEATORIO";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // FormCrudBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 453);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataBooksGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chAvaible);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.nudPagesBook);
            this.Controls.Add(this.dtPublishDateBook);
            this.Controls.Add(this.txtNameBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCrudBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EJEMPLO CRUD BOOK";
            this.Load += new System.EventHandler(this.FormCrudBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPagesBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecGurusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookEntBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialLabel label2;
        private MaterialLabel label3;
        private MaterialLabel label4;
        private MaterialLabel label5;
        private MaterialLabel label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNameBook;
        private System.Windows.Forms.DateTimePicker dtPublishDateBook;
        private System.Windows.Forms.NumericUpDown nudPagesBook;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPurchasePrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSalePrice;
        private CheckBox chAvaible;
        private MaterialRaisedButton btnSave;
        private System.Windows.Forms.DataGridView dataBooksGridView;
        private System.Windows.Forms.BindingSource bookEntBindingSource;
        private MaterialRaisedButton btnSearch;
        private MaterialRaisedButton btnClear;
        private MaterialRaisedButton btnDelete;
        private MaterialRaisedButton btnLoadFile;
        private MaterialRaisedButton btnSaveFile;
        private MaterialRaisedButton btnReload;
        private MaterialLabel label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePublishBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAvaibleDataGridViewCheckBoxColumn;
        private BookAppWorkShop.TecGurusDataSet tecGurusDataSet;
        private BindingSource booksBindingSource;
        private BookAppWorkShop.TecGurusDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private DataGridViewTextBoxColumn idBookDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn numberPagesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private MaterialRaisedButton btnUpdate;
        private MaterialRaisedButton btnRandom;
    }
}

