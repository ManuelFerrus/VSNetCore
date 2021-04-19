
namespace Tecgurus.ThreeLayers.WndowsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.dtPublishDateBook = new System.Windows.Forms.DateTimePicker();
            this.nudPagesBook = new System.Windows.Forms.NumericUpDown();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.chAvaible = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataBooksGridView = new System.Windows.Forms.DataGridView();
            this.nameBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePublishBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvaibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookEntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagesBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookEntBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de publicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio de compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio de venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "N° de paginas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Disponble";
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(41, 79);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(324, 26);
            this.txtNameBook.TabIndex = 1;
            // 
            // dtPublishDateBook
            // 
            this.dtPublishDateBook.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPublishDateBook.Location = new System.Drawing.Point(41, 158);
            this.dtPublishDateBook.Name = "dtPublishDateBook";
            this.dtPublishDateBook.Size = new System.Drawing.Size(200, 26);
            this.dtPublishDateBook.TabIndex = 2;
            // 
            // nudPagesBook
            // 
            this.nudPagesBook.Location = new System.Drawing.Point(41, 230);
            this.nudPagesBook.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPagesBook.Name = "nudPagesBook";
            this.nudPagesBook.Size = new System.Drawing.Size(120, 26);
            this.nudPagesBook.TabIndex = 3;
            this.nudPagesBook.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(41, 381);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(128, 26);
            this.txtPurchasePrice.TabIndex = 5;
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OnlyNumbers_KeyPress);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(41, 300);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(128, 26);
            this.txtSalePrice.TabIndex = 4;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OnlyNumbers_KeyPress);
            // 
            // chAvaible
            // 
            this.chAvaible.AutoSize = true;
            this.chAvaible.Location = new System.Drawing.Point(41, 457);
            this.chAvaible.Name = "chAvaible";
            this.chAvaible.Size = new System.Drawing.Size(22, 21);
            this.chAvaible.TabIndex = 6;
            this.chAvaible.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 31);
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
            this.nameBookDataGridViewTextBoxColumn,
            this.datePublishBookDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.isAvaibleDataGridViewCheckBoxColumn});
            this.dataBooksGridView.DataSource = this.bookEntBindingSource;
            this.dataBooksGridView.Location = new System.Drawing.Point(500, 36);
            this.dataBooksGridView.Name = "dataBooksGridView";
            this.dataBooksGridView.ReadOnly = true;
            this.dataBooksGridView.RowHeadersWidth = 62;
            this.dataBooksGridView.RowTemplate.Height = 28;
            this.dataBooksGridView.Size = new System.Drawing.Size(644, 410);
            this.dataBooksGridView.TabIndex = 13;
            this.dataBooksGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBooksGridView_CellDoubleClick);
            // 
            // nameBookDataGridViewTextBoxColumn
            // 
            this.nameBookDataGridViewTextBoxColumn.DataPropertyName = "NameBook";
            this.nameBookDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameBookDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameBookDataGridViewTextBoxColumn.Name = "nameBookDataGridViewTextBoxColumn";
            this.nameBookDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameBookDataGridViewTextBoxColumn.Width = 150;
            // 
            // datePublishBookDataGridViewTextBoxColumn
            // 
            this.datePublishBookDataGridViewTextBoxColumn.DataPropertyName = "DatePublishBook";
            this.datePublishBookDataGridViewTextBoxColumn.HeaderText = "Publicado";
            this.datePublishBookDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datePublishBookDataGridViewTextBoxColumn.Name = "datePublishBookDataGridViewTextBoxColumn";
            this.datePublishBookDataGridViewTextBoxColumn.ReadOnly = true;
            this.datePublishBookDataGridViewTextBoxColumn.Width = 150;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "Precio de compra";
            this.salePriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.salePriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Precio a la venta";
            this.purchasePriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchasePriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // isAvaibleDataGridViewCheckBoxColumn
            // 
            this.isAvaibleDataGridViewCheckBoxColumn.DataPropertyName = "IsAvaible";
            this.isAvaibleDataGridViewCheckBoxColumn.HeaderText = "Disponibilidad";
            this.isAvaibleDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isAvaibleDataGridViewCheckBoxColumn.Name = "isAvaibleDataGridViewCheckBoxColumn";
            this.isAvaibleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isAvaibleDataGridViewCheckBoxColumn.Width = 150;
            // 
            // bookEntBindingSource
            // 
            //this.bookEntBindingSource.DataSource = typeof(Tecgurus.ThreeLayers.Ent.BookEnt);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(382, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 31);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(390, 399);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 31);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(390, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 31);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Cancelar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 449);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 31);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(500, 469);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(118, 65);
            this.btnLoadFile.TabIndex = 18;
            this.btnLoadFile.Text = "Cargar de archivo";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(648, 469);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(118, 65);
            this.btnSaveFile.TabIndex = 19;
            this.btnSaveFile.Text = "Guardar en";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(809, 469);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(118, 65);
            this.btnReload.TabIndex = 20;
            this.btnReload.Text = "Recargar";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FormCrudBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 544);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
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
            this.Name = "FormCrudBook";
            this.Text = "EJEMPLO CRUD BOOK";
            ((System.ComponentModel.ISupportInitialize)(this.nudPagesBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookEntBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.DateTimePicker dtPublishDateBook;
        private System.Windows.Forms.NumericUpDown nudPagesBook;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.CheckBox chAvaible;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataBooksGridView;
        private System.Windows.Forms.BindingSource bookEntBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePublishBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAvaibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnReload;
    }
}

