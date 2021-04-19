
namespace Tecgurus.ThreeLayers.ExampleApp.WindowFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.dtpDatePublish = new System.Windows.Forms.DateTimePicker();
            this.nupNumberPage = new System.Windows.Forms.NumericUpDown();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.chkIsAvaible = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataBooksGridView = new System.Windows.Forms.DataGridView();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isAvaibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePublishBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumberPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Location = new System.Drawing.Point(12, 9);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(81, 13);
            this.lblNameBook.TabIndex = 0;
            this.lblNameBook.Text = "Nombre del ibro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de publicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de páginas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio de compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Precio de venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Disponibilidad";
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(12, 27);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(244, 20);
            this.txtNameBook.TabIndex = 1;
            // 
            // dtpDatePublish
            // 
            this.dtpDatePublish.Location = new System.Drawing.Point(12, 70);
            this.dtpDatePublish.Name = "dtpDatePublish";
            this.dtpDatePublish.Size = new System.Drawing.Size(200, 20);
            this.dtpDatePublish.TabIndex = 2;
            // 
            // nupNumberPage
            // 
            this.nupNumberPage.Location = new System.Drawing.Point(12, 113);
            this.nupNumberPage.Name = "nupNumberPage";
            this.nupNumberPage.Size = new System.Drawing.Size(120, 20);
            this.nupNumberPage.TabIndex = 3;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(12, 156);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(100, 20);
            this.txtSalePrice.TabIndex = 4;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OnlyNumbers_KeyPress);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(12, 199);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtPurchasePrice.TabIndex = 5;
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OnlyNumbers_KeyPress);
            // 
            // chkIsAvaible
            // 
            this.chkIsAvaible.AutoSize = true;
            this.chkIsAvaible.Location = new System.Drawing.Point(96, 225);
            this.chkIsAvaible.Name = "chkIsAvaible";
            this.chkIsAvaible.Size = new System.Drawing.Size(15, 14);
            this.chkIsAvaible.TabIndex = 6;
            this.chkIsAvaible.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 48);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataBooksGridView
            // 
            this.dataBooksGridView.AllowUserToAddRows = false;
            this.dataBooksGridView.AllowUserToDeleteRows = false;
            this.dataBooksGridView.AutoGenerateColumns = false;
            this.dataBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBooksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isAvaibleDataGridViewCheckBoxColumn,
            this.idBookDataGridViewTextBoxColumn,
            this.nameBookDataGridViewTextBoxColumn,
            this.datePublishBookDataGridViewTextBoxColumn,
            this.numberPagesDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn});
            this.dataBooksGridView.DataSource = this.bookBindingSource;
            this.dataBooksGridView.Location = new System.Drawing.Point(262, 9);
            this.dataBooksGridView.Name = "dataBooksGridView";
            this.dataBooksGridView.ReadOnly = true;
            this.dataBooksGridView.Size = new System.Drawing.Size(749, 231);
            this.dataBooksGridView.TabIndex = 8;
            this.dataBooksGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBooksGridView_CellDoubleClick);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Tecgurus.ThreeLayers.ExampleApp.Entities.Book);
            // 
            // isAvaibleDataGridViewCheckBoxColumn
            // 
            this.isAvaibleDataGridViewCheckBoxColumn.DataPropertyName = "IsAvaible";
            this.isAvaibleDataGridViewCheckBoxColumn.HeaderText = "Disponible";
            this.isAvaibleDataGridViewCheckBoxColumn.Name = "isAvaibleDataGridViewCheckBoxColumn";
            this.isAvaibleDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // idBookDataGridViewTextBoxColumn
            // 
            this.idBookDataGridViewTextBoxColumn.DataPropertyName = "IdBook";
            this.idBookDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idBookDataGridViewTextBoxColumn.Name = "idBookDataGridViewTextBoxColumn";
            this.idBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameBookDataGridViewTextBoxColumn
            // 
            this.nameBookDataGridViewTextBoxColumn.DataPropertyName = "NameBook";
            this.nameBookDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameBookDataGridViewTextBoxColumn.Name = "nameBookDataGridViewTextBoxColumn";
            this.nameBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datePublishBookDataGridViewTextBoxColumn
            // 
            this.datePublishBookDataGridViewTextBoxColumn.DataPropertyName = "DatePublishBook";
            this.datePublishBookDataGridViewTextBoxColumn.HeaderText = "Fecha de Publicación";
            this.datePublishBookDataGridViewTextBoxColumn.Name = "datePublishBookDataGridViewTextBoxColumn";
            this.datePublishBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberPagesDataGridViewTextBoxColumn
            // 
            this.numberPagesDataGridViewTextBoxColumn.DataPropertyName = "NumberPages";
            this.numberPagesDataGridViewTextBoxColumn.HeaderText = "Número de páginas";
            this.numberPagesDataGridViewTextBoxColumn.Name = "numberPagesDataGridViewTextBoxColumn";
            this.numberPagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "Precio de venta";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Precio de compra";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 252);
            this.Controls.Add(this.dataBooksGridView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkIsAvaible);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.nupNumberPage);
            this.Controls.Add(this.dtpDatePublish);
            this.Controls.Add(this.txtNameBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNameBook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupNumberPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.DateTimePicker dtpDatePublish;
        private System.Windows.Forms.NumericUpDown nupNumberPage;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.CheckBox chkIsAvaible;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataBooksGridView;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAvaibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePublishBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
    }
}

