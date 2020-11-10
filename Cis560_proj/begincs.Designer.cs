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
            this.lease = new System.Windows.Forms.Button();
            this.rent = new System.Windows.Forms.Button();
            this.more = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lease
            // 
            this.lease.Location = new System.Drawing.Point(106, 103);
            this.lease.Name = "lease";
            this.lease.Size = new System.Drawing.Size(75, 23);
            this.lease.TabIndex = 0;
            this.lease.Text = "lease";
            this.lease.UseVisualStyleBackColor = true;
            // 
            // rent
            // 
            this.rent.Location = new System.Drawing.Point(270, 102);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(75, 23);
            this.rent.TabIndex = 1;
            this.rent.Text = "button2";
            this.rent.UseVisualStyleBackColor = true;
            // 
            // more
            // 
            this.more.Location = new System.Drawing.Point(460, 102);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(75, 23);
            this.more.TabIndex = 2;
            this.more.Text = "button3";
            this.more.UseVisualStyleBackColor = true;
            // 
            // begincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.more);
            this.Controls.Add(this.rent);
            this.Controls.Add(this.lease);
            this.Name = "begincs";
            this.Text = "begincs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lease;
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.Button more;
    }
}