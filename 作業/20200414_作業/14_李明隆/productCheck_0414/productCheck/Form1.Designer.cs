namespace productCheck
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Product = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Count = new System.Windows.Forms.Label();
            this.textBox_Product = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Product = new System.Windows.Forms.GroupBox();
            this.groupBox_Serarch = new System.Windows.Forms.GroupBox();
            this.button_PrintAllPrice = new System.Windows.Forms.Button();
            this.button_PriceSearch = new System.Windows.Forms.Button();
            this.textBox_PriceSearch = new System.Windows.Forms.TextBox();
            this.button_ListboxClear = new System.Windows.Forms.Button();
            this.listBox_Show = new System.Windows.Forms.ListBox();
            this.button_ProductName = new System.Windows.Forms.Button();
            this.button__SearchKey = new System.Windows.Forms.Button();
            this.button_SearchCount = new System.Windows.Forms.Button();
            this.textBox_SearchKey = new System.Windows.Forms.TextBox();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.textBox_SearchCount = new System.Windows.Forms.TextBox();
            this.button_AllProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_DeleteProductName = new System.Windows.Forms.TextBox();
            this.label_Delet = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_EditCount = new System.Windows.Forms.TextBox();
            this.textBox_EditPrice = new System.Windows.Forms.TextBox();
            this.textBox_EditProductName = new System.Windows.Forms.TextBox();
            this.label_EditCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_EditProduct = new System.Windows.Forms.Label();
            this.button_Edit = new System.Windows.Forms.Button();
            this.groupBox_Product.SuspendLayout();
            this.groupBox_Serarch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Location = new System.Drawing.Point(23, 30);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(56, 12);
            this.label_Product.TabIndex = 0;
            this.label_Product.Text = "產品名稱:";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(47, 74);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(32, 12);
            this.label_Price.TabIndex = 0;
            this.label_Price.Text = "價格:";
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Location = new System.Drawing.Point(47, 123);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(32, 12);
            this.label_Count.TabIndex = 0;
            this.label_Count.Text = "數量:";
            // 
            // textBox_Product
            // 
            this.textBox_Product.Location = new System.Drawing.Point(87, 24);
            this.textBox_Product.Name = "textBox_Product";
            this.textBox_Product.Size = new System.Drawing.Size(100, 22);
            this.textBox_Product.TabIndex = 1;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(87, 71);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 22);
            this.textBox_Price.TabIndex = 2;
            this.textBox_Price.TextChanged += new System.EventHandler(this.textBox_Price_TextChanged);
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(87, 121);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(100, 22);
            this.textBox_Count.TabIndex = 3;
            this.textBox_Count.TextChanged += new System.EventHandler(this.textBox_Count_TextChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(87, 181);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 21);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "輸出";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // groupBox_Product
            // 
            this.groupBox_Product.Controls.Add(this.label_Product);
            this.groupBox_Product.Controls.Add(this.button_Save);
            this.groupBox_Product.Controls.Add(this.label_Price);
            this.groupBox_Product.Controls.Add(this.textBox_Count);
            this.groupBox_Product.Controls.Add(this.label_Count);
            this.groupBox_Product.Controls.Add(this.textBox_Price);
            this.groupBox_Product.Controls.Add(this.textBox_Product);
            this.groupBox_Product.Location = new System.Drawing.Point(12, 11);
            this.groupBox_Product.Name = "groupBox_Product";
            this.groupBox_Product.Size = new System.Drawing.Size(227, 261);
            this.groupBox_Product.TabIndex = 5;
            this.groupBox_Product.TabStop = false;
            this.groupBox_Product.Text = "新增產品";
            // 
            // groupBox_Serarch
            // 
            this.groupBox_Serarch.Controls.Add(this.button_PrintAllPrice);
            this.groupBox_Serarch.Controls.Add(this.button_PriceSearch);
            this.groupBox_Serarch.Controls.Add(this.textBox_PriceSearch);
            this.groupBox_Serarch.Controls.Add(this.button_ListboxClear);
            this.groupBox_Serarch.Controls.Add(this.listBox_Show);
            this.groupBox_Serarch.Controls.Add(this.button_ProductName);
            this.groupBox_Serarch.Controls.Add(this.button__SearchKey);
            this.groupBox_Serarch.Controls.Add(this.button_SearchCount);
            this.groupBox_Serarch.Controls.Add(this.textBox_SearchKey);
            this.groupBox_Serarch.Controls.Add(this.textBox_ProductName);
            this.groupBox_Serarch.Controls.Add(this.textBox_SearchCount);
            this.groupBox_Serarch.Controls.Add(this.button_AllProduct);
            this.groupBox_Serarch.Location = new System.Drawing.Point(263, 11);
            this.groupBox_Serarch.Name = "groupBox_Serarch";
            this.groupBox_Serarch.Size = new System.Drawing.Size(720, 261);
            this.groupBox_Serarch.TabIndex = 6;
            this.groupBox_Serarch.TabStop = false;
            this.groupBox_Serarch.Text = "查詢產品";
            // 
            // button_PrintAllPrice
            // 
            this.button_PrintAllPrice.Location = new System.Drawing.Point(195, 178);
            this.button_PrintAllPrice.Name = "button_PrintAllPrice";
            this.button_PrintAllPrice.Size = new System.Drawing.Size(100, 23);
            this.button_PrintAllPrice.TabIndex = 9;
            this.button_PrintAllPrice.Text = "列出所有產品價格";
            this.button_PrintAllPrice.UseVisualStyleBackColor = true;
            this.button_PrintAllPrice.Click += new System.EventHandler(this.button_PrintAllPrice_Click);
            // 
            // button_PriceSearch
            // 
            this.button_PriceSearch.Location = new System.Drawing.Point(195, 121);
            this.button_PriceSearch.Name = "button_PriceSearch";
            this.button_PriceSearch.Size = new System.Drawing.Size(100, 23);
            this.button_PriceSearch.TabIndex = 8;
            this.button_PriceSearch.Text = "查產品價格大於";
            this.button_PriceSearch.UseVisualStyleBackColor = true;
            this.button_PriceSearch.Click += new System.EventHandler(this.button_PriceSearch_Click);
            // 
            // textBox_PriceSearch
            // 
            this.textBox_PriceSearch.Location = new System.Drawing.Point(195, 93);
            this.textBox_PriceSearch.Name = "textBox_PriceSearch";
            this.textBox_PriceSearch.Size = new System.Drawing.Size(100, 22);
            this.textBox_PriceSearch.TabIndex = 7;
            this.textBox_PriceSearch.TextChanged += new System.EventHandler(this.textBox_PriceSearch_TextChanged);
            // 
            // button_ListboxClear
            // 
            this.button_ListboxClear.Location = new System.Drawing.Point(381, 218);
            this.button_ListboxClear.Name = "button_ListboxClear";
            this.button_ListboxClear.Size = new System.Drawing.Size(75, 23);
            this.button_ListboxClear.TabIndex = 11;
            this.button_ListboxClear.Text = "清空";
            this.button_ListboxClear.UseVisualStyleBackColor = true;
            this.button_ListboxClear.Click += new System.EventHandler(this.button_ListboxClear_Click);
            // 
            // listBox_Show
            // 
            this.listBox_Show.FormattingEnabled = true;
            this.listBox_Show.ItemHeight = 12;
            this.listBox_Show.Location = new System.Drawing.Point(381, 18);
            this.listBox_Show.Name = "listBox_Show";
            this.listBox_Show.Size = new System.Drawing.Size(262, 184);
            this.listBox_Show.TabIndex = 10;
            // 
            // button_ProductName
            // 
            this.button_ProductName.Location = new System.Drawing.Point(195, 52);
            this.button_ProductName.Name = "button_ProductName";
            this.button_ProductName.Size = new System.Drawing.Size(100, 21);
            this.button_ProductName.TabIndex = 6;
            this.button_ProductName.Text = "查產品名稱";
            this.button_ProductName.UseVisualStyleBackColor = true;
            this.button_ProductName.Click += new System.EventHandler(this.button_ProductName_Click);
            // 
            // button__SearchKey
            // 
            this.button__SearchKey.Location = new System.Drawing.Point(26, 208);
            this.button__SearchKey.Name = "button__SearchKey";
            this.button__SearchKey.Size = new System.Drawing.Size(125, 21);
            this.button__SearchKey.TabIndex = 4;
            this.button__SearchKey.Text = "查符合關鍵字的資料";
            this.button__SearchKey.UseVisualStyleBackColor = true;
            this.button__SearchKey.Click += new System.EventHandler(this.button__SearchKey_Click);
            // 
            // button_SearchCount
            // 
            this.button_SearchCount.Location = new System.Drawing.Point(26, 123);
            this.button_SearchCount.Name = "button_SearchCount";
            this.button_SearchCount.Size = new System.Drawing.Size(100, 21);
            this.button_SearchCount.TabIndex = 2;
            this.button_SearchCount.Text = "查第幾筆資料";
            this.button_SearchCount.UseVisualStyleBackColor = true;
            this.button_SearchCount.Click += new System.EventHandler(this.button_SearchCount_Click);
            // 
            // textBox_SearchKey
            // 
            this.textBox_SearchKey.Location = new System.Drawing.Point(26, 180);
            this.textBox_SearchKey.Name = "textBox_SearchKey";
            this.textBox_SearchKey.Size = new System.Drawing.Size(100, 22);
            this.textBox_SearchKey.TabIndex = 3;
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Location = new System.Drawing.Point(195, 24);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(100, 22);
            this.textBox_ProductName.TabIndex = 5;
            // 
            // textBox_SearchCount
            // 
            this.textBox_SearchCount.Location = new System.Drawing.Point(26, 94);
            this.textBox_SearchCount.Name = "textBox_SearchCount";
            this.textBox_SearchCount.Size = new System.Drawing.Size(100, 22);
            this.textBox_SearchCount.TabIndex = 1;
            this.textBox_SearchCount.TextChanged += new System.EventHandler(this.textBox_SearchCount_TextChanged);
            // 
            // button_AllProduct
            // 
            this.button_AllProduct.Location = new System.Drawing.Point(26, 30);
            this.button_AllProduct.Name = "button_AllProduct";
            this.button_AllProduct.Size = new System.Drawing.Size(75, 21);
            this.button_AllProduct.TabIndex = 0;
            this.button_AllProduct.Text = "全部產品";
            this.button_AllProduct.UseVisualStyleBackColor = true;
            this.button_AllProduct.Click += new System.EventHandler(this.button_AllProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_DeleteProductName);
            this.groupBox1.Controls.Add(this.label_Delet);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "刪除產品";
            // 
            // textBox_DeleteProductName
            // 
            this.textBox_DeleteProductName.Location = new System.Drawing.Point(87, 37);
            this.textBox_DeleteProductName.Name = "textBox_DeleteProductName";
            this.textBox_DeleteProductName.Size = new System.Drawing.Size(100, 22);
            this.textBox_DeleteProductName.TabIndex = 0;
            // 
            // label_Delet
            // 
            this.label_Delet.AutoSize = true;
            this.label_Delet.Location = new System.Drawing.Point(26, 37);
            this.label_Delet.Name = "label_Delet";
            this.label_Delet.Size = new System.Drawing.Size(56, 12);
            this.label_Delet.TabIndex = 1;
            this.label_Delet.Text = "產品名稱:";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(112, 77);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 21);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "刪除";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Edit);
            this.groupBox2.Controls.Add(this.textBox_EditCount);
            this.groupBox2.Controls.Add(this.textBox_EditPrice);
            this.groupBox2.Controls.Add(this.textBox_EditProductName);
            this.groupBox2.Controls.Add(this.label_EditCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label_EditProduct);
            this.groupBox2.Location = new System.Drawing.Point(263, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 202);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改產品";
            // 
            // textBox_EditCount
            // 
            this.textBox_EditCount.Location = new System.Drawing.Point(107, 116);
            this.textBox_EditCount.Name = "textBox_EditCount";
            this.textBox_EditCount.Size = new System.Drawing.Size(100, 22);
            this.textBox_EditCount.TabIndex = 3;
            this.textBox_EditCount.TextChanged += new System.EventHandler(this.textBox_EditCount_TextChanged);
            // 
            // textBox_EditPrice
            // 
            this.textBox_EditPrice.Location = new System.Drawing.Point(107, 74);
            this.textBox_EditPrice.Name = "textBox_EditPrice";
            this.textBox_EditPrice.Size = new System.Drawing.Size(100, 22);
            this.textBox_EditPrice.TabIndex = 2;
            this.textBox_EditPrice.TextChanged += new System.EventHandler(this.textBox_EditPrice_TextChanged);
            // 
            // textBox_EditProductName
            // 
            this.textBox_EditProductName.Location = new System.Drawing.Point(107, 27);
            this.textBox_EditProductName.Name = "textBox_EditProductName";
            this.textBox_EditProductName.Size = new System.Drawing.Size(100, 22);
            this.textBox_EditProductName.TabIndex = 1;
            // 
            // label_EditCount
            // 
            this.label_EditCount.AutoSize = true;
            this.label_EditCount.Location = new System.Drawing.Point(69, 126);
            this.label_EditCount.Name = "label_EditCount";
            this.label_EditCount.Size = new System.Drawing.Size(32, 12);
            this.label_EditCount.TabIndex = 2;
            this.label_EditCount.Text = "數量:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "價格:";
            // 
            // label_EditProduct
            // 
            this.label_EditProduct.AutoSize = true;
            this.label_EditProduct.Location = new System.Drawing.Point(45, 34);
            this.label_EditProduct.Name = "label_EditProduct";
            this.label_EditProduct.Size = new System.Drawing.Size(56, 12);
            this.label_EditProduct.TabIndex = 0;
            this.label_EditProduct.Text = "產品名稱:";
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(107, 155);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 4;
            this.button_Edit.Text = "修改";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Serarch);
            this.Controls.Add(this.groupBox_Product);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Product.ResumeLayout(false);
            this.groupBox_Product.PerformLayout();
            this.groupBox_Serarch.ResumeLayout(false);
            this.groupBox_Serarch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.TextBox textBox_Product;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.Button button_Save;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox_Product;
        private System.Windows.Forms.GroupBox groupBox_Serarch;
        private System.Windows.Forms.ListBox listBox_Show;
        private System.Windows.Forms.Button button_ProductName;
        private System.Windows.Forms.Button button__SearchKey;
        private System.Windows.Forms.Button button_SearchCount;
        private System.Windows.Forms.TextBox textBox_SearchKey;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.TextBox textBox_SearchCount;
        private System.Windows.Forms.Button button_AllProduct;
        private System.Windows.Forms.Button button_ListboxClear;
        private System.Windows.Forms.Button button_PrintAllPrice;
        private System.Windows.Forms.Button button_PriceSearch;
        private System.Windows.Forms.TextBox textBox_PriceSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_DeleteProductName;
        private System.Windows.Forms.Label label_Delet;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_EditCount;
        private System.Windows.Forms.TextBox textBox_EditPrice;
        private System.Windows.Forms.TextBox textBox_EditProductName;
        private System.Windows.Forms.Label label_EditCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_EditProduct;
        private System.Windows.Forms.Button button_Edit;
    }
}

