
namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductsAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblProdutName2 = new System.Windows.Forms.Label();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUptadeQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.gbxProductsUptade = new System.Windows.Forms.GroupBox();
            this.btnUptade = new System.Windows.Forms.Button();
            this.tbxUptadeStock = new System.Windows.Forms.TextBox();
            this.tbxUptadeUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxUptadeCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUptadeProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductsAdd.SuspendLayout();
            this.gbxProductsUptade.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 262);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(776, 193);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(776, 100);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye göre ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(95, 22);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(211, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(24, 29);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori :";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(12, 140);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(776, 100);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün adına göre ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(95, 21);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(211, 22);
            this.tbxProductName.TabIndex = 4;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(24, 26);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(70, 17);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Ürün adı :";
            // 
            // gbxProductsAdd
            // 
            this.gbxProductsAdd.Controls.Add(this.btnAdd);
            this.gbxProductsAdd.Controls.Add(this.tbxStock);
            this.gbxProductsAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductsAdd.Controls.Add(this.cbxCategoryId);
            this.gbxProductsAdd.Controls.Add(this.tbxProductName2);
            this.gbxProductsAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductsAdd.Controls.Add(this.lblStock);
            this.gbxProductsAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductsAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductsAdd.Controls.Add(this.lblProdutName2);
            this.gbxProductsAdd.Location = new System.Drawing.Point(12, 488);
            this.gbxProductsAdd.Name = "gbxProductsAdd";
            this.gbxProductsAdd.Size = new System.Drawing.Size(320, 283);
            this.gbxProductsAdd.TabIndex = 3;
            this.gbxProductsAdd.TabStop = false;
            this.gbxProductsAdd.Text = "Yeni ürün ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(6, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(282, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(95, 168);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(193, 22);
            this.tbxStock.TabIndex = 8;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(95, 127);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(193, 22);
            this.tbxUnitPrice.TabIndex = 7;
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(95, 82);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(193, 24);
            this.cbxCategoryId.TabIndex = 6;
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(95, 31);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(193, 22);
            this.tbxProductName2.TabIndex = 5;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(7, 211);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(87, 17);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Birim Adedi :";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(7, 168);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(80, 17);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adeti :";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(7, 127);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(46, 17);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Fiyat :";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(7, 82);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(69, 17);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Kategori :";
            // 
            // lblProdutName2
            // 
            this.lblProdutName2.AutoSize = true;
            this.lblProdutName2.Location = new System.Drawing.Point(7, 36);
            this.lblProdutName2.Name = "lblProdutName2";
            this.lblProdutName2.Size = new System.Drawing.Size(67, 17);
            this.lblProdutName2.TabIndex = 0;
            this.lblProdutName2.Text = "ÜrünAdı :";
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(107, 699);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(193, 22);
            this.tbxQuantityPerUnit.TabIndex = 9;
            // 
            // tbxUptadeQuantityPerUnit
            // 
            this.tbxUptadeQuantityPerUnit.Location = new System.Drawing.Point(95, 206);
            this.tbxUptadeQuantityPerUnit.Name = "tbxUptadeQuantityPerUnit";
            this.tbxUptadeQuantityPerUnit.Size = new System.Drawing.Size(193, 22);
            this.tbxUptadeQuantityPerUnit.TabIndex = 11;
            // 
            // gbxProductsUptade
            // 
            this.gbxProductsUptade.Controls.Add(this.tbxUptadeQuantityPerUnit);
            this.gbxProductsUptade.Controls.Add(this.btnUptade);
            this.gbxProductsUptade.Controls.Add(this.tbxUptadeStock);
            this.gbxProductsUptade.Controls.Add(this.tbxUptadeUnitPrice);
            this.gbxProductsUptade.Controls.Add(this.cbxUptadeCategoryId);
            this.gbxProductsUptade.Controls.Add(this.tbxUptadeProductName);
            this.gbxProductsUptade.Controls.Add(this.label1);
            this.gbxProductsUptade.Controls.Add(this.label2);
            this.gbxProductsUptade.Controls.Add(this.label3);
            this.gbxProductsUptade.Controls.Add(this.label4);
            this.gbxProductsUptade.Controls.Add(this.label5);
            this.gbxProductsUptade.Location = new System.Drawing.Point(374, 488);
            this.gbxProductsUptade.Name = "gbxProductsUptade";
            this.gbxProductsUptade.Size = new System.Drawing.Size(320, 283);
            this.gbxProductsUptade.TabIndex = 10;
            this.gbxProductsUptade.TabStop = false;
            this.gbxProductsUptade.Text = "Ürün güncelle";
            // 
            // btnUptade
            // 
            this.btnUptade.AutoSize = true;
            this.btnUptade.Location = new System.Drawing.Point(6, 241);
            this.btnUptade.Name = "btnUptade";
            this.btnUptade.Size = new System.Drawing.Size(282, 36);
            this.btnUptade.TabIndex = 9;
            this.btnUptade.Text = "Güncelle";
            this.btnUptade.UseVisualStyleBackColor = true;
            this.btnUptade.Click += new System.EventHandler(this.btnUptade_Click);
            // 
            // tbxUptadeStock
            // 
            this.tbxUptadeStock.Location = new System.Drawing.Point(95, 168);
            this.tbxUptadeStock.Name = "tbxUptadeStock";
            this.tbxUptadeStock.Size = new System.Drawing.Size(193, 22);
            this.tbxUptadeStock.TabIndex = 8;
            // 
            // tbxUptadeUnitPrice
            // 
            this.tbxUptadeUnitPrice.Location = new System.Drawing.Point(95, 127);
            this.tbxUptadeUnitPrice.Name = "tbxUptadeUnitPrice";
            this.tbxUptadeUnitPrice.Size = new System.Drawing.Size(193, 22);
            this.tbxUptadeUnitPrice.TabIndex = 7;
            // 
            // cbxUptadeCategoryId
            // 
            this.cbxUptadeCategoryId.FormattingEnabled = true;
            this.cbxUptadeCategoryId.Location = new System.Drawing.Point(95, 82);
            this.cbxUptadeCategoryId.Name = "cbxUptadeCategoryId";
            this.cbxUptadeCategoryId.Size = new System.Drawing.Size(193, 24);
            this.cbxUptadeCategoryId.TabIndex = 6;
            // 
            // tbxUptadeProductName
            // 
            this.tbxUptadeProductName.Location = new System.Drawing.Point(95, 36);
            this.tbxUptadeProductName.Name = "tbxUptadeProductName";
            this.tbxUptadeProductName.Size = new System.Drawing.Size(193, 22);
            this.tbxUptadeProductName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim Adedi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adeti :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ÜrünAdı :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 787);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(289, 36);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 884);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxProductsUptade);
            this.Controls.Add(this.tbxQuantityPerUnit);
            this.Controls.Add(this.gbxProductsAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductsAdd.ResumeLayout(false);
            this.gbxProductsAdd.PerformLayout();
            this.gbxProductsUptade.ResumeLayout(false);
            this.gbxProductsUptade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductsAdd;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblProdutName2;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxUptadeQuantityPerUnit;
        private System.Windows.Forms.GroupBox gbxProductsUptade;
        private System.Windows.Forms.Button btnUptade;
        private System.Windows.Forms.TextBox tbxUptadeStock;
        private System.Windows.Forms.TextBox tbxUptadeUnitPrice;
        private System.Windows.Forms.ComboBox cbxUptadeCategoryId;
        private System.Windows.Forms.TextBox tbxUptadeProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
    }
}

