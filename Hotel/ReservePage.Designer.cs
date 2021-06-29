namespace Hotel
{
    partial class ReservePage
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
            this.id = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Roomnum = new System.Windows.Forms.TextBox();
            this.days = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.labelroom = new System.Windows.Forms.Label();
            this.labelday = new System.Windows.Forms.Label();
            this.DoReserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(272, 116);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(193, 35);
            this.id.TabIndex = 0;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(272, 171);
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(193, 35);
            this.Phone.TabIndex = 1;
            // 
            // Roomnum
            // 
            this.Roomnum.Location = new System.Drawing.Point(272, 221);
            this.Roomnum.Multiline = true;
            this.Roomnum.Name = "Roomnum";
            this.Roomnum.Size = new System.Drawing.Size(193, 35);
            this.Roomnum.TabIndex = 2;
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(272, 279);
            this.days.Multiline = true;
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(193, 35);
            this.days.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(272, 65);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(193, 35);
            this.name.TabIndex = 4;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(120, 77);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(59, 23);
            this.labelname.TabIndex = 5;
            this.labelname.Text = "Name";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(120, 128);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(30, 23);
            this.labelid.TabIndex = 6;
            this.labelid.Text = "ID";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.Location = new System.Drawing.Point(120, 183);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(134, 23);
            this.labelphone.TabIndex = 7;
            this.labelphone.Text = "Phone number";
            // 
            // labelroom
            // 
            this.labelroom.AutoSize = true;
            this.labelroom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelroom.Location = new System.Drawing.Point(120, 233);
            this.labelroom.Name = "labelroom";
            this.labelroom.Size = new System.Drawing.Size(130, 23);
            this.labelroom.TabIndex = 8;
            this.labelroom.Text = "Room number";
            // 
            // labelday
            // 
            this.labelday.AutoSize = true;
            this.labelday.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelday.Location = new System.Drawing.Point(120, 291);
            this.labelday.Name = "labelday";
            this.labelday.Size = new System.Drawing.Size(136, 23);
            this.labelday.TabIndex = 9;
            this.labelday.Text = "Number of day";
            // 
            // DoReserve
            // 
            this.DoReserve.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DoReserve.Location = new System.Drawing.Point(297, 359);
            this.DoReserve.Name = "DoReserve";
            this.DoReserve.Size = new System.Drawing.Size(112, 37);
            this.DoReserve.TabIndex = 10;
            this.DoReserve.Text = "Submit";
            this.DoReserve.UseVisualStyleBackColor = true;
            // 
            // ReservePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DoReserve);
            this.Controls.Add(this.labelday);
            this.Controls.Add(this.labelroom);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.days);
            this.Controls.Add(this.Roomnum);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.id);
            this.Name = "ReservePage";
            this.Text = "ReservePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Roomnum;
        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labelroom;
        private System.Windows.Forms.Label labelday;
        private System.Windows.Forms.Button DoReserve;
    }
}