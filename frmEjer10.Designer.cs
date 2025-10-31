namespace ADL_Controles
{
    partial class frmEjer10
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
            this.gboSexo = new System.Windows.Forms.GroupBox();
            this.rbMas = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.gboClub = new System.Windows.Forms.GroupBox();
            this.chbNata = new System.Windows.Forms.CheckBox();
            this.chbVolei = new System.Windows.Forms.CheckBox();
            this.chbBas = new System.Windows.Forms.CheckBox();
            this.gboDatos = new System.Windows.Forms.GroupBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEs = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnLim = new System.Windows.Forms.Button();
            this.btnRegi = new System.Windows.Forms.Button();
            this.btnMos = new System.Windows.Forms.Button();
            this.btnIMC = new System.Windows.Forms.Button();
            this.gboSexo.SuspendLayout();
            this.gboClub.SuspendLayout();
            this.gboDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSexo
            // 
            this.gboSexo.Controls.Add(this.rbMas);
            this.gboSexo.Controls.Add(this.rbFem);
            this.gboSexo.Location = new System.Drawing.Point(23, 354);
            this.gboSexo.Name = "gboSexo";
            this.gboSexo.Size = new System.Drawing.Size(195, 227);
            this.gboSexo.TabIndex = 0;
            this.gboSexo.TabStop = false;
            this.gboSexo.Text = "Sexo";
            // 
            // rbMas
            // 
            this.rbMas.AutoSize = true;
            this.rbMas.Location = new System.Drawing.Point(18, 96);
            this.rbMas.Name = "rbMas";
            this.rbMas.Size = new System.Drawing.Size(126, 30);
            this.rbMas.TabIndex = 1;
            this.rbMas.TabStop = true;
            this.rbMas.Text = "Masculino";
            this.rbMas.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(18, 54);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(127, 30);
            this.rbFem.TabIndex = 0;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // gboClub
            // 
            this.gboClub.Controls.Add(this.chbNata);
            this.gboClub.Controls.Add(this.chbVolei);
            this.gboClub.Controls.Add(this.chbBas);
            this.gboClub.Location = new System.Drawing.Point(258, 354);
            this.gboClub.Name = "gboClub";
            this.gboClub.Size = new System.Drawing.Size(219, 227);
            this.gboClub.TabIndex = 1;
            this.gboClub.TabStop = false;
            this.gboClub.Text = "Clubs Deportivos";
            // 
            // chbNata
            // 
            this.chbNata.AutoSize = true;
            this.chbNata.Location = new System.Drawing.Point(11, 128);
            this.chbNata.Name = "chbNata";
            this.chbNata.Size = new System.Drawing.Size(123, 30);
            this.chbNata.TabIndex = 2;
            this.chbNata.Text = "Natacion";
            this.chbNata.UseVisualStyleBackColor = true;
            // 
            // chbVolei
            // 
            this.chbVolei.AutoSize = true;
            this.chbVolei.Location = new System.Drawing.Point(11, 90);
            this.chbVolei.Name = "chbVolei";
            this.chbVolei.Size = new System.Drawing.Size(111, 30);
            this.chbVolei.TabIndex = 1;
            this.chbVolei.Text = "Voleibol";
            this.chbVolei.UseVisualStyleBackColor = true;
            // 
            // chbBas
            // 
            this.chbBas.AutoSize = true;
            this.chbBas.Location = new System.Drawing.Point(11, 50);
            this.chbBas.Name = "chbBas";
            this.chbBas.Size = new System.Drawing.Size(143, 30);
            this.chbBas.TabIndex = 0;
            this.chbBas.Text = "Basquetbol";
            this.chbBas.UseVisualStyleBackColor = true;
            // 
            // gboDatos
            // 
            this.gboDatos.Controls.Add(this.txtPeso);
            this.gboDatos.Controls.Add(this.txtEs);
            this.gboDatos.Controls.Add(this.lblPeso);
            this.gboDatos.Controls.Add(this.lblM);
            this.gboDatos.Controls.Add(this.lblNombre);
            this.gboDatos.Controls.Add(this.txtNom);
            this.gboDatos.Controls.Add(this.txtId);
            this.gboDatos.Controls.Add(this.lblID);
            this.gboDatos.Controls.Add(this.gboSexo);
            this.gboDatos.Controls.Add(this.gboClub);
            this.gboDatos.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDatos.Location = new System.Drawing.Point(12, 12);
            this.gboDatos.Name = "gboDatos";
            this.gboDatos.Size = new System.Drawing.Size(637, 615);
            this.gboDatos.TabIndex = 2;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "Datos Generales";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(167, 213);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(83, 33);
            this.txtPeso.TabIndex = 9;
            // 
            // txtEs
            // 
            this.txtEs.Location = new System.Drawing.Point(166, 156);
            this.txtEs.Name = "txtEs";
            this.txtEs.Size = new System.Drawing.Size(139, 33);
            this.txtEs.TabIndex = 8;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(94, 216);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(61, 26);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso:";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(14, 159);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(140, 26);
            this.lblM.TabIndex = 6;
            this.lblM.Text = "Estatura (m):";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 26);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(165, 105);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(453, 33);
            this.txtNom.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(164, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(175, 33);
            this.txtId.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(113, 48);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 26);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Id:";
            // 
            // btnLim
            // 
            this.btnLim.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLim.Location = new System.Drawing.Point(721, 88);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(103, 36);
            this.btnLim.TabIndex = 3;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // btnRegi
            // 
            this.btnRegi.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegi.Location = new System.Drawing.Point(719, 147);
            this.btnRegi.Name = "btnRegi";
            this.btnRegi.Size = new System.Drawing.Size(105, 32);
            this.btnRegi.TabIndex = 4;
            this.btnRegi.Text = "Registrar";
            this.btnRegi.UseVisualStyleBackColor = true;
            this.btnRegi.Click += new System.EventHandler(this.btnRegi_Click);
            // 
            // btnMos
            // 
            this.btnMos.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMos.Location = new System.Drawing.Point(721, 208);
            this.btnMos.Name = "btnMos";
            this.btnMos.Size = new System.Drawing.Size(103, 36);
            this.btnMos.TabIndex = 5;
            this.btnMos.Text = "Mostrar";
            this.btnMos.UseVisualStyleBackColor = true;
            this.btnMos.Click += new System.EventHandler(this.btnMos_Click);
            // 
            // btnIMC
            // 
            this.btnIMC.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMC.Location = new System.Drawing.Point(721, 276);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(103, 41);
            this.btnIMC.TabIndex = 6;
            this.btnIMC.Text = "IMC";
            this.btnIMC.UseVisualStyleBackColor = true;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // frmEjer10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(897, 639);
            this.Controls.Add(this.btnIMC);
            this.Controls.Add(this.btnMos);
            this.Controls.Add(this.btnRegi);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.gboDatos);
            this.Name = "frmEjer10";
            this.Text = "frmEjer10";
            this.gboSexo.ResumeLayout(false);
            this.gboSexo.PerformLayout();
            this.gboClub.ResumeLayout(false);
            this.gboClub.PerformLayout();
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSexo;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMas;
        private System.Windows.Forms.GroupBox gboClub;
        private System.Windows.Forms.CheckBox chbBas;
        private System.Windows.Forms.CheckBox chbNata;
        private System.Windows.Forms.CheckBox chbVolei;
        private System.Windows.Forms.GroupBox gboDatos;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.Button btnRegi;
        private System.Windows.Forms.Button btnMos;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEs;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnIMC;
    }
}