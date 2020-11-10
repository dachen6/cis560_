namespace Cis560_proj
{
    partial class More
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
            this.ux_MoreReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ux_MoreReturn
            // 
            this.ux_MoreReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_MoreReturn.Location = new System.Drawing.Point(632, 333);
            this.ux_MoreReturn.Name = "ux_MoreReturn";
            this.ux_MoreReturn.Size = new System.Drawing.Size(100, 75);
            this.ux_MoreReturn.TabIndex = 43;
            this.ux_MoreReturn.Text = "Return";
            this.ux_MoreReturn.UseVisualStyleBackColor = true;
            this.ux_MoreReturn.Click += new System.EventHandler(this.Ux_MoreReturn_Click);
            // 
            // More
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ux_MoreReturn);
            this.Name = "More";
            this.Text = "More";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ux_MoreReturn;
    }
}