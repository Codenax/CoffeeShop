namespace CoffeeOderWindowsFormsApplication
{
    partial class CoffeeOrderUl
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
            this.coffeeNamecomboBox = new System.Windows.Forms.ComboBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.receptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.oderButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coffeeNamecomboBox
            // 
            this.coffeeNamecomboBox.FormattingEnabled = true;
            this.coffeeNamecomboBox.Items.AddRange(new object[] {
            "AD",
            "AS",
            "AD",
            "AF",
            "AE"});
            this.coffeeNamecomboBox.Location = new System.Drawing.Point(227, 70);
            this.coffeeNamecomboBox.Name = "coffeeNamecomboBox";
            this.coffeeNamecomboBox.Size = new System.Drawing.Size(204, 21);
            this.coffeeNamecomboBox.TabIndex = 0;
            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(227, 108);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(204, 20);
            this.unitTextBox.TabIndex = 1;
            // 
            // receptRichTextBox
            // 
            this.receptRichTextBox.Location = new System.Drawing.Point(116, 197);
            this.receptRichTextBox.Name = "receptRichTextBox";
            this.receptRichTextBox.Size = new System.Drawing.Size(457, 96);
            this.receptRichTextBox.TabIndex = 2;
            this.receptRichTextBox.Text = "";
            // 
            // oderButton
            // 
            this.oderButton.Location = new System.Drawing.Point(255, 151);
            this.oderButton.Name = "oderButton";
            this.oderButton.Size = new System.Drawing.Size(153, 23);
            this.oderButton.TabIndex = 3;
            this.oderButton.Text = "Order";
            this.oderButton.UseVisualStyleBackColor = true;
            this.oderButton.Click += new System.EventHandler(this.oderButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(255, 314);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(153, 23);
            this.buyButton.TabIndex = 3;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // CoffeeOrderUl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 459);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.oderButton);
            this.Controls.Add(this.receptRichTextBox);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.coffeeNamecomboBox);
            this.Name = "CoffeeOrderUl";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coffeeNamecomboBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.RichTextBox receptRichTextBox;
        private System.Windows.Forms.Button oderButton;
        private System.Windows.Forms.Button buyButton;
    }
}

