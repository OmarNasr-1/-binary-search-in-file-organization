
namespace final_project
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price_txtBox = new System.Windows.Forms.TextBox();
            this.cat_txtBox = new System.Windows.Forms.TextBox();
            this.lang_txtBox = new System.Windows.Forms.TextBox();
            this.title_txtBox = new System.Windows.Forms.TextBox();
            this.ISBN_txtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flName_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // price_txtBox
            // 
            this.price_txtBox.Location = new System.Drawing.Point(149, 232);
            this.price_txtBox.Name = "price_txtBox";
            this.price_txtBox.Size = new System.Drawing.Size(100, 20);
            this.price_txtBox.TabIndex = 5;
            this.price_txtBox.TextChanged += new System.EventHandler(this.price_txtBox_TextChanged);
            this.price_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txtBox_KeyPress);
            // 
            // cat_txtBox
            // 
            this.cat_txtBox.Location = new System.Drawing.Point(149, 198);
            this.cat_txtBox.Name = "cat_txtBox";
            this.cat_txtBox.Size = new System.Drawing.Size(100, 20);
            this.cat_txtBox.TabIndex = 6;
            // 
            // lang_txtBox
            // 
            this.lang_txtBox.Location = new System.Drawing.Point(149, 163);
            this.lang_txtBox.Name = "lang_txtBox";
            this.lang_txtBox.Size = new System.Drawing.Size(100, 20);
            this.lang_txtBox.TabIndex = 7;
            // 
            // title_txtBox
            // 
            this.title_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_txtBox.Location = new System.Drawing.Point(149, 123);
            this.title_txtBox.Name = "title_txtBox";
            this.title_txtBox.Size = new System.Drawing.Size(100, 20);
            this.title_txtBox.TabIndex = 8;
            // 
            // ISBN_txtBox
            // 
            this.ISBN_txtBox.Location = new System.Drawing.Point(149, 86);
            this.ISBN_txtBox.Name = "ISBN_txtBox";
            this.ISBN_txtBox.Size = new System.Drawing.Size(100, 20);
            this.ISBN_txtBox.TabIndex = 13;
            this.ISBN_txtBox.TextChanged += new System.EventHandler(this.ISBN_txtBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flName_lbl
            // 
            this.flName_lbl.AutoSize = true;
            this.flName_lbl.ForeColor = System.Drawing.Color.Green;
            this.flName_lbl.Location = new System.Drawing.Point(132, 27);
            this.flName_lbl.Name = "flName_lbl";
            this.flName_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flName_lbl.Size = new System.Drawing.Size(53, 13);
            this.flName_lbl.TabIndex = 12;
            this.flName_lbl.Text = "File Name";
            this.flName_lbl.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 369);
            this.Controls.Add(this.flName_lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ISBN_txtBox);
            this.Controls.Add(this.title_txtBox);
            this.Controls.Add(this.lang_txtBox);
            this.Controls.Add(this.cat_txtBox);
            this.Controls.Add(this.price_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Insert new book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_txtBox;
        private System.Windows.Forms.TextBox cat_txtBox;
        private System.Windows.Forms.TextBox lang_txtBox;
        private System.Windows.Forms.TextBox title_txtBox;
        private System.Windows.Forms.TextBox ISBN_txtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label flName_lbl;
    }
}