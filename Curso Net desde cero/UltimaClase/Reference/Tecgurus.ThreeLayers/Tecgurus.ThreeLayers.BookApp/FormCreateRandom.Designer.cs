
namespace Tecgurus.ThreeLayers.BookApp
{
    partial class FormCreateRandom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateRandom));
            this.btnCreateRand = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblNameBook = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumberPages = new MaterialSkin.Controls.MaterialLabel();
            this.lblPurchasePrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblSalePrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblDatePublishBook = new MaterialSkin.Controls.MaterialLabel();
            this.lblIsAvaible = new MaterialSkin.Controls.MaterialLabel();
            this.btnSendToForm = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnCreateRand
            // 
            this.btnCreateRand.AutoSize = true;
            this.btnCreateRand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateRand.Depth = 0;
            this.btnCreateRand.Icon = null;
            this.btnCreateRand.Location = new System.Drawing.Point(12, 124);
            this.btnCreateRand.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateRand.Name = "btnCreateRand";
            this.btnCreateRand.Primary = true;
            this.btnCreateRand.Size = new System.Drawing.Size(229, 36);
            this.btnCreateRand.TabIndex = 0;
            this.btnCreateRand.Text = "Generar aleatorio";
            this.btnCreateRand.UseVisualStyleBackColor = true;
            this.btnCreateRand.Click += new System.EventHandler(this.btnCreateRand_Click);
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Depth = 0;
            this.lblNameBook.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNameBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNameBook.Location = new System.Drawing.Point(12, 181);
            this.lblNameBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(71, 27);
            this.lblNameBook.TabIndex = 2;
            this.lblNameBook.Text = "Name";
            // 
            // lblNumberPages
            // 
            this.lblNumberPages.AutoSize = true;
            this.lblNumberPages.Depth = 0;
            this.lblNumberPages.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumberPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumberPages.Location = new System.Drawing.Point(12, 263);
            this.lblNumberPages.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumberPages.Name = "lblNumberPages";
            this.lblNumberPages.Size = new System.Drawing.Size(151, 27);
            this.lblNumberPages.TabIndex = 3;
            this.lblNumberPages.Text = "NumberPages";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Depth = 0;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPurchasePrice.Location = new System.Drawing.Point(12, 345);
            this.lblPurchasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(154, 27);
            this.lblPurchasePrice.TabIndex = 4;
            this.lblPurchasePrice.Text = "PurchasePrice";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Depth = 0;
            this.lblSalePrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalePrice.Location = new System.Drawing.Point(12, 304);
            this.lblSalePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(104, 27);
            this.lblSalePrice.TabIndex = 5;
            this.lblSalePrice.Text = "SalePrice";
            // 
            // lblDatePublishBook
            // 
            this.lblDatePublishBook.AutoSize = true;
            this.lblDatePublishBook.Depth = 0;
            this.lblDatePublishBook.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatePublishBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatePublishBook.Location = new System.Drawing.Point(12, 222);
            this.lblDatePublishBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatePublishBook.Name = "lblDatePublishBook";
            this.lblDatePublishBook.Size = new System.Drawing.Size(179, 27);
            this.lblDatePublishBook.TabIndex = 6;
            this.lblDatePublishBook.Text = "DatePublishBook";
            // 
            // lblIsAvaible
            // 
            this.lblIsAvaible.AutoSize = true;
            this.lblIsAvaible.Depth = 0;
            this.lblIsAvaible.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIsAvaible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIsAvaible.Location = new System.Drawing.Point(12, 386);
            this.lblIsAvaible.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIsAvaible.Name = "lblIsAvaible";
            this.lblIsAvaible.Size = new System.Drawing.Size(100, 27);
            this.lblIsAvaible.TabIndex = 7;
            this.lblIsAvaible.Text = "IsAvaible";
            // 
            // btnSendToForm
            // 
            this.btnSendToForm.AutoSize = true;
            this.btnSendToForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSendToForm.Depth = 0;
            this.btnSendToForm.Icon = null;
            this.btnSendToForm.Location = new System.Drawing.Point(17, 461);
            this.btnSendToForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSendToForm.Name = "btnSendToForm";
            this.btnSendToForm.Primary = true;
            this.btnSendToForm.Size = new System.Drawing.Size(247, 36);
            this.btnSendToForm.TabIndex = 8;
            this.btnSendToForm.Text = "Enviar a Formulario";
            this.btnSendToForm.UseVisualStyleBackColor = true;
            this.btnSendToForm.Click += new System.EventHandler(this.btnSendToForm_Click);
            // 
            // FormCreateRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 522);
            this.Controls.Add(this.btnSendToForm);
            this.Controls.Add(this.lblIsAvaible);
            this.Controls.Add(this.lblDatePublishBook);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblNumberPages);
            this.Controls.Add(this.lblNameBook);
            this.Controls.Add(this.btnCreateRand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateRandom";
            this.Text = "FormCreateRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnCreateRand;
        private MaterialSkin.Controls.MaterialLabel lblNameBook;
        private MaterialSkin.Controls.MaterialLabel lblNumberPages;
        private MaterialSkin.Controls.MaterialLabel lblPurchasePrice;
        private MaterialSkin.Controls.MaterialLabel lblSalePrice;
        private MaterialSkin.Controls.MaterialLabel lblDatePublishBook;
        private MaterialSkin.Controls.MaterialLabel lblIsAvaible;
        private MaterialSkin.Controls.MaterialRaisedButton btnSendToForm;
    }
}