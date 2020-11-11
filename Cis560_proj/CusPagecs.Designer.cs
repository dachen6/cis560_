namespace Cis560_proj
{
    partial class CusPagecs
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
            this.ux_CusOK = new System.Windows.Forms.Button();
            this.ux_CusApartmentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ux_CusReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ux_CusOK
            // 
            this.ux_CusOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_CusOK.Location = new System.Drawing.Point(513, 46);
            this.ux_CusOK.Name = "ux_CusOK";
            this.ux_CusOK.Size = new System.Drawing.Size(72, 30);
            this.ux_CusOK.TabIndex = 0;
            this.ux_CusOK.Text = "OK";
            this.ux_CusOK.UseVisualStyleBackColor = true;
            // 
            // ux_CusApartmentID
            // 
            this.ux_CusApartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_CusApartmentID.Location = new System.Drawing.Point(237, 46);
            this.ux_CusApartmentID.Name = "ux_CusApartmentID";
            this.ux_CusApartmentID.Size = new System.Drawing.Size(151, 26);
            this.ux_CusApartmentID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enrer ApartmentID:";
            // 
            // ux_CusReturn
            // 
            this.ux_CusReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_CusReturn.Location = new System.Drawing.Point(638, 46);
            this.ux_CusReturn.Name = "ux_CusReturn";
            this.ux_CusReturn.Size = new System.Drawing.Size(77, 30);
            this.ux_CusReturn.TabIndex = 3;
            this.ux_CusReturn.Text = "Return";
            this.ux_CusReturn.UseVisualStyleBackColor = true;
            this.ux_CusReturn.Click += new System.EventHandler(this.ux_CusReturn_Click);
            // 
            // CusPagecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 680);
            this.Controls.Add(this.ux_CusReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ux_CusApartmentID);
            this.Controls.Add(this.ux_CusOK);
            this.Name = "CusPagecs";
            this.Text = "CusPagecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ux_CusOK;
        private System.Windows.Forms.TextBox ux_CusApartmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ux_CusReturn;
    }
}