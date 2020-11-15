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
            this.ux_ScoreOK = new System.Windows.Forms.Button();
            this.ux_ScoreReturn = new System.Windows.Forms.Button();
            this.ux_score = new System.Windows.Forms.ComboBox();
            this.ux_apartId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ux_ScoreOK
            // 
            this.ux_ScoreOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_ScoreOK.Location = new System.Drawing.Point(316, 157);
            this.ux_ScoreOK.Name = "ux_ScoreOK";
            this.ux_ScoreOK.Size = new System.Drawing.Size(140, 38);
            this.ux_ScoreOK.TabIndex = 1;
            this.ux_ScoreOK.Text = "Confirm";
            this.ux_ScoreOK.UseVisualStyleBackColor = true;
            this.ux_ScoreOK.Click += new System.EventHandler(this.Ux_ScoreOK_Click);
            // 
            // ux_ScoreReturn
            // 
            this.ux_ScoreReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_ScoreReturn.Location = new System.Drawing.Point(637, 215);
            this.ux_ScoreReturn.Name = "ux_ScoreReturn";
            this.ux_ScoreReturn.Size = new System.Drawing.Size(81, 38);
            this.ux_ScoreReturn.TabIndex = 2;
            this.ux_ScoreReturn.Text = "Return";
            this.ux_ScoreReturn.UseVisualStyleBackColor = true;
            this.ux_ScoreReturn.Click += new System.EventHandler(this.Ux_ScoreReturn_Click);
            // 
            // ux_score
            // 
            this.ux_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_score.FormattingEnabled = true;
            this.ux_score.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ux_score.Location = new System.Drawing.Point(411, 47);
            this.ux_score.Name = "ux_score";
            this.ux_score.Size = new System.Drawing.Size(200, 30);
            this.ux_score.TabIndex = 3;
            // 
            // ux_apartId
            // 
            this.ux_apartId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_apartId.Location = new System.Drawing.Point(133, 47);
            this.ux_apartId.Name = "ux_apartId";
            this.ux_apartId.Size = new System.Drawing.Size(200, 32);
            this.ux_apartId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "YourApartmentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose your Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ux_apartId);
            this.Controls.Add(this.ux_score);
            this.Controls.Add(this.ux_ScoreReturn);
            this.Controls.Add(this.ux_ScoreOK);
            this.Name = "score";
            this.Text = "score";
            this.Load += new System.EventHandler(this.score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ux_ScoreOK;
        private System.Windows.Forms.Button ux_ScoreReturn;
        private System.Windows.Forms.ComboBox ux_score;
        private System.Windows.Forms.TextBox ux_apartId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}