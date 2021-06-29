namespace Hotel
{
    partial class PricePage
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
            this.DoPrice = new System.Windows.Forms.Button();
            this.BoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoPrice
            // 
            this.DoPrice.Font = new System.Drawing.Font("Tahoma", 12F);
            this.DoPrice.Location = new System.Drawing.Point(119, 262);
            this.DoPrice.Name = "DoPrice";
            this.DoPrice.Size = new System.Drawing.Size(151, 38);
            this.DoPrice.TabIndex = 5;
            this.DoPrice.Text = "Show Price";
            this.DoPrice.UseVisualStyleBackColor = true;
            // 
            // BoxPrice
            // 
            this.BoxPrice.Location = new System.Drawing.Point(89, 180);
            this.BoxPrice.Multiline = true;
            this.BoxPrice.Name = "BoxPrice";
            this.BoxPrice.Size = new System.Drawing.Size(225, 40);
            this.BoxPrice.TabIndex = 4;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelPrice.Location = new System.Drawing.Point(84, 113);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(230, 29);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Enter Room Number";
            // 
            // PricePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 413);
            this.Controls.Add(this.DoPrice);
            this.Controls.Add(this.BoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Name = "PricePage";
            this.Text = "PricePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoPrice;
        private System.Windows.Forms.TextBox BoxPrice;
        private System.Windows.Forms.Label labelPrice;
    }
}