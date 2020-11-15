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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_CusOK
            // 
            this.ux_CusOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_CusOK.Location = new System.Drawing.Point(440, 44);
            this.ux_CusOK.Name = "ux_CusOK";
            this.ux_CusOK.Size = new System.Drawing.Size(90, 30);
            this.ux_CusOK.TabIndex = 0;
            this.ux_CusOK.Text = "Check";
            this.ux_CusOK.UseVisualStyleBackColor = true;
            this.ux_CusOK.Click += new System.EventHandler(this.ux_CusOK_Click);
            // 
            // ux_CusApartmentID
            // 
            this.ux_CusApartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_CusApartmentID.Location = new System.Drawing.Point(237, 46);
            this.ux_CusApartmentID.Name = "ux_CusApartmentID";
            this.ux_CusApartmentID.Size = new System.Drawing.Size(151, 30);
            this.ux_CusApartmentID.TabIndex = 1;
            this.ux_CusApartmentID.TextChanged += new System.EventHandler(this.Ux_CusApartmentID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter ApartmentID:";
            // 
            // ux_CusReturn
            // 
            this.ux_CusReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_CusReturn.Location = new System.Drawing.Point(651, 491);
            this.ux_CusReturn.Name = "ux_CusReturn";
            this.ux_CusReturn.Size = new System.Drawing.Size(77, 30);
            this.ux_CusReturn.TabIndex = 3;
            this.ux_CusReturn.Text = "Return";
            this.ux_CusReturn.UseVisualStyleBackColor = true;
            this.ux_CusReturn.Click += new System.EventHandler(this.ux_CusReturn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(671, 91);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(57, 263);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(671, 98);
            this.dataGridView2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(628, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CusPagecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ux_CusReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ux_CusApartmentID);
            this.Controls.Add(this.ux_CusOK);
            this.Name = "CusPagecs";
            this.Text = "CusPagecs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ux_CusOK;
        private System.Windows.Forms.TextBox ux_CusApartmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ux_CusReturn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
    }
}