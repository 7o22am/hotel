namespace Hotel
{
    partial class CancelPage
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
            this.labelCancel = new System.Windows.Forms.Label();
            this.BoxCancel = new System.Windows.Forms.TextBox();
            this.DoCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCancel
            // 
            this.labelCancel.AutoSize = true;
            this.labelCancel.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelCancel.Location = new System.Drawing.Point(105, 96);
            this.labelCancel.Name = "labelCancel";
            this.labelCancel.Size = new System.Drawing.Size(230, 29);
            this.labelCancel.TabIndex = 0;
            this.labelCancel.Text = "Enter Room Number";
            this.labelCancel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BoxCancel
            // 
            this.BoxCancel.Location = new System.Drawing.Point(110, 163);
            this.BoxCancel.Multiline = true;
            this.BoxCancel.Name = "BoxCancel";
            this.BoxCancel.Size = new System.Drawing.Size(225, 40);
            this.BoxCancel.TabIndex = 1;
            // 
            // DoCancel
            // 
            this.DoCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.DoCancel.Location = new System.Drawing.Point(140, 245);
            this.DoCancel.Name = "DoCancel";
            this.DoCancel.Size = new System.Drawing.Size(151, 38);
            this.DoCancel.TabIndex = 2;
            this.DoCancel.Text = "Cancel";
            this.DoCancel.UseVisualStyleBackColor = true;
            // 
            // CancelPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 384);
            this.Controls.Add(this.DoCancel);
            this.Controls.Add(this.BoxCancel);
            this.Controls.Add(this.labelCancel);
            this.Name = "CancelPage";
            this.Text = "CancelPage";
            this.Load += new System.EventHandler(this.CancelPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCancel;
        private System.Windows.Forms.TextBox BoxCancel;
        private System.Windows.Forms.Button DoCancel;
    }
}