namespace ADL_Controles
{
    partial class frmRFC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimeFN = new System.Windows.Forms.DateTimePicker();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dateTimeFN);
            this.groupBox1.Controls.Add(this.txtRFC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnGenear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.Location = new System.Drawing.Point(327, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 42);
            this.button3.TabIndex = 16;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimeFN
            // 
            this.dateTimeFN.Location = new System.Drawing.Point(234, 154);
            this.dateTimeFN.Name = "dateTimeFN";
            this.dateTimeFN.Size = new System.Drawing.Size(432, 29);
            this.dateTimeFN.TabIndex = 15;
            this.dateTimeFN.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(235, 236);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(432, 29);
            this.txtRFC.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "RFC:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(233, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(432, 29);
            this.txtNombre.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Khaki;
            this.btnSalir.Location = new System.Drawing.Point(567, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 42);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenear
            // 
            this.btnGenear.BackColor = System.Drawing.Color.Khaki;
            this.btnGenear.Location = new System.Drawing.Point(89, 352);
            this.btnGenear.Name = "btnGenear";
            this.btnGenear.Size = new System.Drawing.Size(99, 42);
            this.btnGenear.TabIndex = 5;
            this.btnGenear.Text = "Generar ";
            this.btnGenear.UseVisualStyleBackColor = false;
            this.btnGenear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            // 
            // frmRFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(804, 503);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRFC";
            this.Text = "frmRFC";
            this.Load += new System.EventHandler(this.frmRFC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeFN;
        private System.Windows.Forms.Button button3;
    }
}