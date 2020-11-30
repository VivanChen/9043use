namespace schoolHomeWork
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Education = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Region = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.button_Education = new System.Windows.Forms.Button();
            this.button_Region = new System.Windows.Forms.Button();
            this.button_Tel = new System.Windows.Forms.Button();
            this.button_Output = new System.Windows.Forms.Button();
            this.listBox_Show = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "類型：";
            // 
            // comboBox_Education
            // 
            this.comboBox_Education.FormattingEnabled = true;
            this.comboBox_Education.Location = new System.Drawing.Point(89, 21);
            this.comboBox_Education.Name = "comboBox_Education";
            this.comboBox_Education.Size = new System.Drawing.Size(88, 20);
            this.comboBox_Education.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "區域：";
            // 
            // textBox_Region
            // 
            this.textBox_Region.Location = new System.Drawing.Point(89, 107);
            this.textBox_Region.Name = "textBox_Region";
            this.textBox_Region.Size = new System.Drawing.Size(88, 22);
            this.textBox_Region.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(27, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "電話：";
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Location = new System.Drawing.Point(89, 198);
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(88, 22);
            this.textBox_Tel.TabIndex = 3;
            // 
            // button_Education
            // 
            this.button_Education.Location = new System.Drawing.Point(102, 47);
            this.button_Education.Name = "button_Education";
            this.button_Education.Size = new System.Drawing.Size(75, 23);
            this.button_Education.TabIndex = 5;
            this.button_Education.Text = "查詢";
            this.button_Education.UseVisualStyleBackColor = true;
            this.button_Education.Click += new System.EventHandler(this.button_Education_Click);
            // 
            // button_Region
            // 
            this.button_Region.Location = new System.Drawing.Point(102, 135);
            this.button_Region.Name = "button_Region";
            this.button_Region.Size = new System.Drawing.Size(75, 23);
            this.button_Region.TabIndex = 5;
            this.button_Region.Text = "查詢";
            this.button_Region.UseVisualStyleBackColor = true;
            this.button_Region.Click += new System.EventHandler(this.button_Region_Click);
            // 
            // button_Tel
            // 
            this.button_Tel.Location = new System.Drawing.Point(102, 226);
            this.button_Tel.Name = "button_Tel";
            this.button_Tel.Size = new System.Drawing.Size(75, 23);
            this.button_Tel.TabIndex = 5;
            this.button_Tel.Text = "查詢";
            this.button_Tel.UseVisualStyleBackColor = true;
            this.button_Tel.Click += new System.EventHandler(this.button_Tel_Click);
            // 
            // button_Output
            // 
            this.button_Output.Location = new System.Drawing.Point(36, 307);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(141, 54);
            this.button_Output.TabIndex = 5;
            this.button_Output.Text = "根據區域分別輸出檔案";
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // listBox_Show
            // 
            this.listBox_Show.FormattingEnabled = true;
            this.listBox_Show.HorizontalScrollbar = true;
            this.listBox_Show.ItemHeight = 12;
            this.listBox_Show.Location = new System.Drawing.Point(195, 21);
            this.listBox_Show.Name = "listBox_Show";
            this.listBox_Show.Size = new System.Drawing.Size(526, 340);
            this.listBox_Show.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 377);
            this.Controls.Add(this.listBox_Show);
            this.Controls.Add(this.button_Output);
            this.Controls.Add(this.button_Tel);
            this.Controls.Add(this.button_Region);
            this.Controls.Add(this.button_Education);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Tel);
            this.Controls.Add(this.textBox_Region);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Education);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Education;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Region;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.Button button_Education;
        private System.Windows.Forms.Button button_Region;
        private System.Windows.Forms.Button button_Tel;
        private System.Windows.Forms.Button button_Output;
        private System.Windows.Forms.ListBox listBox_Show;
    }
}

