namespace Cis560_proj
{
    partial class begincs
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
            this.rent = new System.Windows.Forms.Button();
            this.lease = new System.Windows.Forms.Button();
            this.more = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rent
            // 
            this.rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent.Location = new System.Drawing.Point(270, 102);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(100, 75);
            this.rent.TabIndex = 1;
            this.rent.Text = "rent";
            this.rent.UseVisualStyleBackColor = true;
            this.rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // lease
            // 
            this.lease.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lease.Location = new System.Drawing.Point(95, 102);
            this.lease.Name = "lease";
            this.lease.Size = new System.Drawing.Size(100, 75);
            this.lease.TabIndex = 3;
            this.lease.Text = "lease";
            this.lease.UseVisualStyleBackColor = true;
            this.lease.Click += new System.EventHandler(this.Lease_Click);
            // 
            // more
            // 
            this.more.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more.Location = new System.Drawing.Point(446, 102);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(100, 75);
            this.more.TabIndex = 4;
            this.more.Text = "more";
            this.more.UseVisualStyleBackColor = true;
            this.more.Click += new System.EventHandler(this.More_Click);
            // 
            // begincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 335);
            this.Controls.Add(this.more);
            this.Controls.Add(this.lease);
            this.Controls.Add(this.rent);
            this.Name = "begincs";
            this.Text = "begincs";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.Button lease;
        private System.Windows.Forms.Button more;
    }
}