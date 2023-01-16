
namespace AppAhorcado.AppAhorcadoFrontend
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblHangman = new System.Windows.Forms.Label();
            this.lblUnderlined = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnConfirm.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnConfirm.Location = new System.Drawing.Point(275, 489);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(102, 40);
            this.btnConfirm.TabIndex = 155;
            this.btnConfirm.Text = "Confirm.";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(99, 195);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 26);
            this.txtEmail.TabIndex = 154;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HighlightText;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HighlightText;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReturn.Location = new System.Drawing.Point(14, 489);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 40);
            this.btnReturn.TabIndex = 153;
            this.btnReturn.Text = "Return.";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblHangman
            // 
            this.lblHangman.BackColor = System.Drawing.Color.Transparent;
            this.lblHangman.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHangman.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblHangman.Location = new System.Drawing.Point(72, 71);
            this.lblHangman.Name = "lblHangman";
            this.lblHangman.Size = new System.Drawing.Size(254, 44);
            this.lblHangman.TabIndex = 151;
            this.lblHangman.Text = "HANGMAN";
            this.lblHangman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnderlined
            // 
            this.lblUnderlined.BackColor = System.Drawing.Color.Transparent;
            this.lblUnderlined.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnderlined.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblUnderlined.Location = new System.Drawing.Point(83, 67);
            this.lblUnderlined.Name = "lblUnderlined";
            this.lblUnderlined.Size = new System.Drawing.Size(229, 63);
            this.lblUnderlined.TabIndex = 152;
            this.lblUnderlined.Text = "_ _ _ _ _ _ _";
            this.lblUnderlined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 545);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblHangman);
            this.Controls.Add(this.lblUnderlined);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblHangman;
        private System.Windows.Forms.Label lblUnderlined;
    }
}