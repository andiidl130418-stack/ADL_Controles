namespace ADL_Controles
{
    partial class frmEtiqueta_texto_boton
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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.txtSaludo = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(268, 111);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(89, 19);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Saludos";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSaludo
            // 
            this.txtSaludo.Font = new System.Drawing.Font("Noto Serif SC SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaludo.Location = new System.Drawing.Point(389, 100);
            this.txtSaludo.MaxLength = 60;
            this.txtSaludo.Name = "txtSaludo";
            this.txtSaludo.Size = new System.Drawing.Size(140, 36);
            this.txtSaludo.TabIndex = 1;
            this.txtSaludo.Text = "Dame Saludo";
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSaludar.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludar.Location = new System.Drawing.Point(419, 142);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(84, 39);
            this.btnSaludar.TabIndex = 2;
            this.btnSaludar.Text = "saludar";
            this.btnSaludar.UseVisualStyleBackColor = false;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // frmEtiqueta_texto_boton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.txtSaludo);
            this.Controls.Add(this.lblSaludo);
            this.Name = "frmEtiqueta_texto_boton";
            this.Text = "frmEtiqueta_texto_boton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.TextBox txtSaludo;
        private System.Windows.Forms.Button btnSaludar;
    }
}