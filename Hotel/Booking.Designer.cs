namespace Hotel
{
    partial class Booking
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
            this.Reserve = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.ShowRooms = new System.Windows.Forms.Button();
            this.Roomprice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reserve
            // 
            this.Reserve.Location = new System.Drawing.Point(54, 75);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(225, 49);
            this.Reserve.TabIndex = 0;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(389, 75);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(225, 49);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ShowRooms
            // 
            this.ShowRooms.Location = new System.Drawing.Point(389, 295);
            this.ShowRooms.Name = "ShowRooms";
            this.ShowRooms.Size = new System.Drawing.Size(225, 49);
            this.ShowRooms.TabIndex = 2;
            this.ShowRooms.Text = "Show avalible room";
            this.ShowRooms.UseVisualStyleBackColor = true;
            this.ShowRooms.Click += new System.EventHandler(this.ShowRooms_Click);
            // 
            // Roomprice
            // 
            this.Roomprice.Location = new System.Drawing.Point(54, 295);
            this.Roomprice.Name = "Roomprice";
            this.Roomprice.Size = new System.Drawing.Size(225, 49);
            this.Roomprice.TabIndex = 3;
            this.Roomprice.Text = "Price of Room";
            this.Roomprice.UseVisualStyleBackColor = true;
            this.Roomprice.Click += new System.EventHandler(this.Roomprice_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 435);
            this.Controls.Add(this.Roomprice);
            this.Controls.Add(this.ShowRooms);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Reserve);
            this.Name = "Booking";
            this.Text = "Booking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ShowRooms;
        private System.Windows.Forms.Button Roomprice;
    }
}