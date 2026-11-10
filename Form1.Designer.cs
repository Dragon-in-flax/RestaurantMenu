namespace RestaurantMenu
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtOutput = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lstDishes = new System.Windows.Forms.ListBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.PeachPuff;
            this.txtOutput.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.Brown;
            this.txtOutput.Location = new System.Drawing.Point(804, 391);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(395, 59);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "Сформировать список блюд";
            this.txtOutput.UseVisualStyleBackColor = false;
            this.txtOutput.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Brown;
            this.btnAdd.Location = new System.Drawing.Point(804, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(395, 59);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить блюдо";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Состав";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PeachPuff;
            this.button3.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Brown;
            this.button3.Location = new System.Drawing.Point(804, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(395, 85);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавить ингредиенты\r\n(пока недоступно)";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.SandyBrown;
            this.txtName.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(20, 391);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(417, 41);
            this.txtName.TabIndex = 7;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.SandyBrown;
            this.txtCategory.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(20, 474);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(417, 41);
            this.txtCategory.TabIndex = 8;
            this.txtCategory.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtComposition
            // 
            this.txtComposition.BackColor = System.Drawing.Color.SandyBrown;
            this.txtComposition.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComposition.Location = new System.Drawing.Point(20, 557);
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(417, 41);
            this.txtComposition.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.SandyBrown;
            this.txtPrice.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(20, 640);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(417, 41);
            this.txtPrice.TabIndex = 10;
            // 
            // lstDishes
            // 
            this.lstDishes.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lstDishes.Font = new System.Drawing.Font("1 Blackmoor LET", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstDishes.FormattingEnabled = true;
            this.lstDishes.ItemHeight = 35;
            this.lstDishes.Location = new System.Drawing.Point(16, 21);
            this.lstDishes.Name = "lstDishes";
            this.lstDishes.Size = new System.Drawing.Size(421, 319);
            this.lstDishes.TabIndex = 11;
            // 
            // cmbFormat
            // 
            this.cmbFormat.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "HTML",
            "Текст"});
            this.cmbFormat.Location = new System.Drawing.Point(804, 456);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(395, 28);
            this.cmbFormat.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Brown;
            this.textBox5.Font = new System.Drawing.Font("Greengoth", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Bisque;
            this.textBox5.Location = new System.Drawing.Point(554, 490);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(645, 259);
            this.textBox5.TabIndex = 13;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(458, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(323, 319);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 761);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.lstDishes);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtComposition);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtOutput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox lstDishes;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

