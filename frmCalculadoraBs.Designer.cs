namespace ADL_Controles
{
    partial class frmCalculadoraBs
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnLimpia = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.PowderBlue;
            this.txtNum.Location = new System.Drawing.Point(96, 86);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(375, 22);
            this.txtNum.TabIndex = 0;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.PowderBlue;
            this.btn0.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(96, 132);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(89, 33);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.PowderBlue;
            this.btn1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(202, 134);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 31);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.PowderBlue;
            this.btn2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(311, 132);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(81, 32);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSuma.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(410, 134);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(61, 31);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnOpera);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.PowderBlue;
            this.btnResta.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(408, 187);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(62, 32);
            this.btnResta.TabIndex = 5;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnOpera);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.PowderBlue;
            this.btn5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(311, 186);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 29);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.PowderBlue;
            this.btn4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(202, 189);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 27);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.PowderBlue;
            this.btn3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(96, 187);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(89, 29);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.PowderBlue;
            this.btn8.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(311, 238);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(78, 28);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.PowderBlue;
            this.btn6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(96, 237);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(89, 27);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.PowderBlue;
            this.btn7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(202, 238);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 28);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMulti.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(408, 234);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(62, 30);
            this.btnMulti.TabIndex = 12;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnOpera);
            // 
            // btnDivi
            // 
            this.btnDivi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDivi.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivi.Location = new System.Drawing.Point(408, 288);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(62, 26);
            this.btnDivi.TabIndex = 13;
            this.btnDivi.Text = "/";
            this.btnDivi.UseVisualStyleBackColor = false;
            this.btnDivi.Click += new System.EventHandler(this.btnOpera);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.PowderBlue;
            this.btn9.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(96, 284);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(89, 30);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnLimpia
            // 
            this.btnLimpia.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLimpia.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpia.Location = new System.Drawing.Point(202, 284);
            this.btnLimpia.Name = "btnLimpia";
            this.btnLimpia.Size = new System.Drawing.Size(90, 28);
            this.btnLimpia.TabIndex = 15;
            this.btnLimpia.Text = "C";
            this.btnLimpia.UseVisualStyleBackColor = false;
            this.btnLimpia.Click += new System.EventHandler(this.btnLimpia_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIgual.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(311, 288);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(81, 26);
            this.btnIgual.TabIndex = 16;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // frmCalculadoraBs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnLimpia);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.txtNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCalculadoraBs";
            this.Text = "frmCalculadoraBs";
            this.Load += new System.EventHandler(this.frmCalculadoraBs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnLimpia;
        private System.Windows.Forms.Button btnIgual;
    }
}