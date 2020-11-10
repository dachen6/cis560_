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
            this.ux_BeginRent = new System.Windows.Forms.Button();
            this.ux_BeginLease = new System.Windows.Forms.Button();
            this.ux_BeginMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ux_BeginRent
            // 
            this.ux_BeginRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_BeginRent.Location = new System.Drawing.Point(270, 102);
            this.ux_BeginRent.Name = "ux_BeginRent";
            this.ux_BeginRent.Size = new System.Drawing.Size(100, 75);
            this.ux_BeginRent.TabIndex = 1;
            this.ux_BeginRent.Text = "rent";
            this.ux_BeginRent.UseVisualStyleBackColor = true;
            this.ux_BeginRent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // ux_BeginLease
            // 
            this.ux_BeginLease.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_BeginLease.Location = new System.Drawing.Point(95, 102);
            this.ux_BeginLease.Name = "ux_BeginLease";
            this.ux_BeginLease.Size = new System.Drawing.Size(100, 75);
            this.ux_BeginLease.TabIndex = 3;
            this.ux_BeginLease.Text = "lease";
            this.ux_BeginLease.UseVisualStyleBackColor = true;
            this.ux_BeginLease.Click += new System.EventHandler(this.Lease_Click);
            // 
            // ux_BeginMore
            // 
            this.ux_BeginMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_BeginMore.Location = new System.Drawing.Point(446, 102);
            this.ux_BeginMore.Name = "ux_BeginMore";
            this.ux_BeginMore.Size = new System.Drawing.Size(100, 75);
            this.ux_BeginMore.TabIndex = 4;
            this.ux_BeginMore.Text = "more";
            this.ux_BeginMore.UseVisualStyleBackColor = true;
            this.ux_BeginMore.Click += new System.EventHandler(this.More_Click);
            // 
            // begincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 335);
            this.Controls.Add(this.ux_BeginMore);
            this.Controls.Add(this.ux_BeginLease);
            this.Controls.Add(this.ux_BeginRent);
            this.Name = "begincs";
            this.Text = "begincs";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ux_BeginRent;
        private System.Windows.Forms.Button ux_BeginLease;
        private System.Windows.Forms.Button ux_BeginMore;
    }
}