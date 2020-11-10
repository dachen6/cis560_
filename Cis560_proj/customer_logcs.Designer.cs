namespace Cis560_proj
{
    partial class customer_logcs
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
            this.ux_LogUserEmail = new System.Windows.Forms.TextBox();
            this.ux_LogPassword = new System.Windows.Forms.TextBox();
            this.ux_LogSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ux_LogReturn = new System.Windows.Forms.Button();
            this.ux_LogSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ux_LogUserEmail
            // 
            this.ux_LogUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_LogUserEmail.Location = new System.Drawing.Point(373, 131);
            this.ux_LogUserEmail.Name = "ux_LogUserEmail";
            this.ux_LogUserEmail.Size = new System.Drawing.Size(160, 30);
            this.ux_LogUserEmail.TabIndex = 0;
            // 
            // ux_LogPassword
            // 
            this.ux_LogPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_LogPassword.Location = new System.Drawing.Point(373, 172);
            this.ux_LogPassword.Name = "ux_LogPassword";
            this.ux_LogPassword.Size = new System.Drawing.Size(160, 30);
            this.ux_LogPassword.TabIndex = 1;
            // 
            // ux_LogSignIn
            // 
            this.ux_LogSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_LogSignIn.Location = new System.Drawing.Point(293, 239);
            this.ux_LogSignIn.Name = "ux_LogSignIn";
            this.ux_LogSignIn.Size = new System.Drawing.Size(86, 44);
            this.ux_LogSignIn.TabIndex = 2;
            this.ux_LogSignIn.Text = "Sign In";
            this.ux_LogSignIn.UseVisualStyleBackColor = true;
            this.ux_LogSignIn.Click += new System.EventHandler(this.Ux_LogSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserEmail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // ux_LogReturn
            // 
            this.ux_LogReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_LogReturn.Location = new System.Drawing.Point(652, 359);
            this.ux_LogReturn.Name = "ux_LogReturn";
            this.ux_LogReturn.Size = new System.Drawing.Size(86, 44);
            this.ux_LogReturn.TabIndex = 7;
            this.ux_LogReturn.Text = "Return";
            this.ux_LogReturn.UseVisualStyleBackColor = true;
            this.ux_LogReturn.Click += new System.EventHandler(this.Ux_LogReturn_Click);
            // 
            // ux_LogSignUp
            // 
            this.ux_LogSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_LogSignUp.Location = new System.Drawing.Point(441, 239);
            this.ux_LogSignUp.Name = "ux_LogSignUp";
            this.ux_LogSignUp.Size = new System.Drawing.Size(90, 44);
            this.ux_LogSignUp.TabIndex = 8;
            this.ux_LogSignUp.Text = "Sign Up";
            this.ux_LogSignUp.UseVisualStyleBackColor = true;
            this.ux_LogSignUp.Click += new System.EventHandler(this.Ux_LogSignUp_Click);
            // 
            // customer_logcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ux_LogSignUp);
            this.Controls.Add(this.ux_LogReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ux_LogSignIn);
            this.Controls.Add(this.ux_LogPassword);
            this.Controls.Add(this.ux_LogUserEmail);
            this.Name = "customer_logcs";
            this.Text = "customer_logcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ux_LogUserEmail;
        private System.Windows.Forms.TextBox ux_LogPassword;
        private System.Windows.Forms.Button ux_LogSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ux_LogReturn;
        private System.Windows.Forms.Button ux_LogSignUp;
    }
}