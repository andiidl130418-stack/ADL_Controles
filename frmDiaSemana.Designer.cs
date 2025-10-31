namespace ADL_Controles
{
    partial class frmDiaSemana
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
            this.btnND = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnND
            // 
            this.btnND.BackColor = System.Drawing.Color.PaleGreen;
            this.btnND.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnND.Location = new System.Drawing.Point(223, 176);
            this.btnND.Name = "btnND";
            this.btnND.Size = new System.Drawing.Size(160, 42);
            this.btnND.TabIndex = 0;
            this.btnND.Text = "Nombre Dia";
            this.btnND.UseVisualStyleBackColor = false;
            this.btnND.Click += new System.EventHandler(this.btnND_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(69, 109);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(340, 26);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Escribe el nombre de la semana:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(442, 190);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 16);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "label2";
            this.lbl1.Visible = false;
            // 
            // txtDia
            // 
            this.txtDia.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtDia.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(431, 109);
            this.txtDia.Multiline = true;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 22);
            this.txtDia.TabIndex = 3;
            // 
            // frmDiaSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnND);
            this.Name = "frmDiaSemana";
            this.Text = "Escribe el nombre de la semana:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnND;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtDia;
    }
}