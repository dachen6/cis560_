namespace Cis560_proj
{
    partial class score
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
            this.ux_ScoreDropMonth = new System.Windows.Forms.CheckedListBox();
            this.ux_ScoreOK = new System.Windows.Forms.Button();
            this.ux_ScoreReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ux_ScoreDropMonth
            // 
            this.ux_ScoreDropMonth.FormattingEnabled = true;
            this.ux_ScoreDropMonth.Location = new System.Drawing.Point(95, 35);
            this.ux_ScoreDropMonth.Name = "ux_ScoreDropMonth";
            this.ux_ScoreDropMonth.Size = new System.Drawing.Size(120, 94);
            this.ux_ScoreDropMonth.TabIndex = 0;
            // 
            // ux_ScoreOK
            // 
            this.ux_ScoreOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_ScoreOK.Location = new System.Drawing.Point(541, 371);
            this.ux_ScoreOK.Name = "ux_ScoreOK";
            this.ux_ScoreOK.Size = new System.Drawing.Size(83, 38);
            this.ux_ScoreOK.TabIndex = 1;
            this.ux_ScoreOK.Text = "OK";
            this.ux_ScoreOK.UseVisualStyleBackColor = true;
            this.ux_ScoreOK.Click += new System.EventHandler(this.Ux_ScoreOK_Click);
            // 
            // ux_ScoreReturn
            // 
            this.ux_ScoreReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_ScoreReturn.Location = new System.Drawing.Point(666, 371);
            this.ux_ScoreReturn.Name = "ux_ScoreReturn";
            this.ux_ScoreReturn.Size = new System.Drawing.Size(81, 38);
            this.ux_ScoreReturn.TabIndex = 2;
            this.ux_ScoreReturn.Text = "Return";
            this.ux_ScoreReturn.UseVisualStyleBackColor = true;
            this.ux_ScoreReturn.Click += new System.EventHandler(this.Ux_ScoreReturn_Click);
            // 
            // score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ux_ScoreReturn);
            this.Controls.Add(this.ux_ScoreOK);
            this.Controls.Add(this.ux_ScoreDropMonth);
            this.Name = "score";
            this.Text = "score";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ux_ScoreDropMonth;
        private System.Windows.Forms.Button ux_ScoreOK;
        private System.Windows.Forms.Button ux_ScoreReturn;
    }
}