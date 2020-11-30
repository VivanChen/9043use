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
            this.SuspendLayout();
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Location = new System.Drawing.Point(12, 9);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(47, 13);
            this.label_Product.TabIndex = 0;
            this.label_Product.Text = "Product:";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(12, 59);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(34, 13);
            this.label_Price.TabIndex = 0;
            this.label_Price.Text = "Price:";
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Location = new System.Drawing.Point(12, 107);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(38, 13);
            this.label_Count.TabIndex = 0;
            this.label_Count.Text = "Count:";
            // 
            // textBox_Product
            // 
            this.textBox_Product.Location = new System.Drawing.Point(62, 6);
            this.textBox_Product.Name = "textBox_Product";
            this.textBox_Product.Size = new System.Drawing.Size(100, 20);
            this.textBox_Product.TabIndex = 1;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(62, 56);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price.TabIndex = 2;
            this.textBox_Price.TextChanged += new System.EventHandler(this.textBox_Price_TextChanged);
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(62, 100);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(100, 20);
            this.textBox_Count.TabIndex = 3;
            this.textBox_Count.TextChanged += new System.EventHandler(this.textBox_Count_TextChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(62, 162);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 209);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Product);
            this.Controls.Add(this.label_Count);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_Product);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.TextBox textBox_Product;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.Button button_Save;
    }
}

