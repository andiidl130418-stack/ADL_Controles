namespace ADL_Controles
{
    partial class frmListAlumnos
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
            this.lstConEntrega = new System.Windows.Forms.ListBox();
            this.lstSinEntrega = new System.Windows.Forms.ListBox();
            this.lblSin = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.btnSinEntrega = new System.Windows.Forms.Button();
            this.btnConEntrega = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstConEntrega
            // 
            this.lstConEntrega.BackColor = System.Drawing.Color.LightCyan;
            this.lstConEntrega.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConEntrega.ForeColor = System.Drawing.Color.Black;
            this.lstConEntrega.FormattingEnabled = true;
            this.lstConEntrega.ItemHeight = 23;
            this.lstConEntrega.Location = new System.Drawing.Point(27, 177);
            this.lstConEntrega.Name = "lstConEntrega";
            this.lstConEntrega.Size = new System.Drawing.Size(270, 142);
            this.lstConEntrega.TabIndex = 0;
            // 
            // lstSinEntrega
            // 
            this.lstSinEntrega.BackColor = System.Drawing.Color.LightCyan;
            this.lstSinEntrega.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSinEntrega.FormattingEnabled = true;
            this.lstSinEntrega.ItemHeight = 23;
            this.lstSinEntrega.Location = new System.Drawing.Point(523, 177);
            this.lstSinEntrega.Name = "lstSinEntrega";
            this.lstSinEntrega.Size = new System.Drawing.Size(254, 142);
            this.lstSinEntrega.TabIndex = 1;
            // 
            // lblSin
            // 
            this.lblSin.AutoSize = true;
            this.lblSin.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSin.Location = new System.Drawing.Point(507, 122);
            this.lblSin.Name = "lblSin";
            this.lblSin.Size = new System.Drawing.Size(287, 25);
            this.lblSin.TabIndex = 2;
            this.lblSin.Text = "Alumnos sin Entrega";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(17, 124);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(298, 25);
            this.lblCon.TabIndex = 3;
            this.lblCon.Text = "Alumnos con Entrega";
            // 
            // btnSinEntrega
            // 
            this.btnSinEntrega.BackColor = System.Drawing.Color.Silver;
            this.btnSinEntrega.Font = new System.Drawing.Font("Copperplate Gothic Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinEntrega.Location = new System.Drawing.Point(344, 184);
            this.btnSinEntrega.Name = "btnSinEntrega";
            this.btnSinEntrega.Size = new System.Drawing.Size(91, 37);
            this.btnSinEntrega.TabIndex = 4;
            this.btnSinEntrega.Text = ">>";
            this.btnSinEntrega.UseVisualStyleBackColor = false;
            this.btnSinEntrega.Click += new System.EventHandler(this.btnSinEntrega_Click);
            // 
            // btnConEntrega
            // 
            this.btnConEntrega.BackColor = System.Drawing.Color.Silver;
            this.btnConEntrega.Font = new System.Drawing.Font("Copperplate Gothic Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConEntrega.Location = new System.Drawing.Point(344, 289);
            this.btnConEntrega.Name = "btnConEntrega";
            this.btnConEntrega.Size = new System.Drawing.Size(91, 33);
            this.btnConEntrega.TabIndex = 5;
            this.btnConEntrega.Text = "<<";
            this.btnConEntrega.UseVisualStyleBackColor = false;
            this.btnConEntrega.Click += new System.EventHandler(this.btnConEntrega_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(18, 475);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(415, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total de Alumnos con Entrega";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Silver;
            this.txtTotal.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(523, 471);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 29);
            this.txtTotal.TabIndex = 7;
            // 
            // frmListAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(833, 564);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConEntrega);
            this.Controls.Add(this.btnSinEntrega);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblSin);
            this.Controls.Add(this.lstSinEntrega);
            this.Controls.Add(this.lstConEntrega);
            this.Name = "frmListAlumnos";
            this.Text = "Reporte de Entregas";
            this.Load += new System.EventHandler(this.frmListAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstConEntrega;
        private System.Windows.Forms.ListBox lstSinEntrega;
        private System.Windows.Forms.Label lblSin;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Button btnSinEntrega;
        private System.Windows.Forms.Button btnConEntrega;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}