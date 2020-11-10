namespace NLayer_Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lst_Prestamos = new System.Windows.Forms.ListBox();
            this.lst_TipoPrestamos = new System.Windows.Forms.ListBox();
            this.lbl_Plazo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Tna = new System.Windows.Forms.Label();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.lbl_Linea = new System.Windows.Forms.Label();
            this.lbl_Capital = new System.Windows.Forms.Label();
            this.lbl_CuotaTotal = new System.Windows.Forms.Label();
            this.lbl_Cuotas = new System.Windows.Forms.Label();
            this.lbl_ComisiónTotal = new System.Windows.Forms.Label();
            this.lbl_TipoPrestamo = new System.Windows.Forms.Label();
            this.lbl_Prestamo = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.txt_Linea = new System.Windows.Forms.TextBox();
            this.txt_Tna = new System.Windows.Forms.TextBox();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.txt_Plazo = new System.Windows.Forms.TextBox();
            this.txt_CuotaCapital = new System.Windows.Forms.TextBox();
            this.txt_CuotaInterés = new System.Windows.Forms.TextBox();
            this.txt_CuotaTotal = new System.Windows.Forms.TextBox();
            this.txt_ComisionTotal = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ComisionTotal);
            this.groupBox2.Controls.Add(this.lbl_Prestamo);
            this.groupBox2.Controls.Add(this.lbl_ComisiónTotal);
            this.groupBox2.Controls.Add(this.lst_Prestamos);
            this.groupBox2.Location = new System.Drawing.Point(407, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lst_Prestamos
            // 
            this.lst_Prestamos.FormattingEnabled = true;
            this.lst_Prestamos.Location = new System.Drawing.Point(20, 53);
            this.lst_Prestamos.Name = "lst_Prestamos";
            this.lst_Prestamos.Size = new System.Drawing.Size(315, 264);
            this.lst_Prestamos.TabIndex = 1;
            // 
            // lst_TipoPrestamos
            // 
            this.lst_TipoPrestamos.FormattingEnabled = true;
            this.lst_TipoPrestamos.Location = new System.Drawing.Point(26, 53);
            this.lst_TipoPrestamos.Name = "lst_TipoPrestamos";
            this.lst_TipoPrestamos.Size = new System.Drawing.Size(158, 329);
            this.lst_TipoPrestamos.TabIndex = 2;
            // 
            // lbl_Plazo
            // 
            this.lbl_Plazo.AutoSize = true;
            this.lbl_Plazo.Location = new System.Drawing.Point(201, 171);
            this.lbl_Plazo.Name = "lbl_Plazo";
            this.lbl_Plazo.Size = new System.Drawing.Size(33, 13);
            this.lbl_Plazo.TabIndex = 6;
            this.lbl_Plazo.Text = "Plazo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_CuotaTotal);
            this.groupBox1.Controls.Add(this.txt_CuotaInterés);
            this.groupBox1.Controls.Add(this.txt_CuotaCapital);
            this.groupBox1.Controls.Add(this.txt_Plazo);
            this.groupBox1.Controls.Add(this.txt_Monto);
            this.groupBox1.Controls.Add(this.txt_Tna);
            this.groupBox1.Controls.Add(this.txt_Linea);
            this.groupBox1.Controls.Add(this.btn_Alta);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.lbl_TipoPrestamo);
            this.groupBox1.Controls.Add(this.lbl_Capital);
            this.groupBox1.Controls.Add(this.lbl_CuotaTotal);
            this.groupBox1.Controls.Add(this.lbl_Cuotas);
            this.groupBox1.Controls.Add(this.lbl_Plazo);
            this.groupBox1.Controls.Add(this.lbl_Linea);
            this.groupBox1.Controls.Add(this.lbl_Monto);
            this.groupBox1.Controls.Add(this.lbl_Tna);
            this.groupBox1.Controls.Add(this.lst_TipoPrestamos);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_Tna
            // 
            this.lbl_Tna.AutoSize = true;
            this.lbl_Tna.Location = new System.Drawing.Point(201, 94);
            this.lbl_Tna.Name = "lbl_Tna";
            this.lbl_Tna.Size = new System.Drawing.Size(29, 13);
            this.lbl_Tna.TabIndex = 4;
            this.lbl_Tna.Text = "TNA";
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Location = new System.Drawing.Point(201, 130);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(37, 13);
            this.lbl_Monto.TabIndex = 5;
            this.lbl_Monto.Text = "Monto";
            // 
            // lbl_Linea
            // 
            this.lbl_Linea.AutoSize = true;
            this.lbl_Linea.Location = new System.Drawing.Point(201, 61);
            this.lbl_Linea.Name = "lbl_Linea";
            this.lbl_Linea.Size = new System.Drawing.Size(33, 13);
            this.lbl_Linea.TabIndex = 3;
            this.lbl_Linea.Text = "Linea";
            // 
            // lbl_Capital
            // 
            this.lbl_Capital.AutoSize = true;
            this.lbl_Capital.Location = new System.Drawing.Point(201, 248);
            this.lbl_Capital.Name = "lbl_Capital";
            this.lbl_Capital.Size = new System.Drawing.Size(76, 13);
            this.lbl_Capital.TabIndex = 7;
            this.lbl_Capital.Text = "Cuota (Capital)";
            // 
            // lbl_CuotaTotal
            // 
            this.lbl_CuotaTotal.AutoSize = true;
            this.lbl_CuotaTotal.Location = new System.Drawing.Point(201, 317);
            this.lbl_CuotaTotal.Name = "lbl_CuotaTotal";
            this.lbl_CuotaTotal.Size = new System.Drawing.Size(82, 13);
            this.lbl_CuotaTotal.TabIndex = 9;
            this.lbl_CuotaTotal.Text = "CUOTA TOTAL";
            // 
            // lbl_Cuotas
            // 
            this.lbl_Cuotas.AutoSize = true;
            this.lbl_Cuotas.Location = new System.Drawing.Point(201, 281);
            this.lbl_Cuotas.Name = "lbl_Cuotas";
            this.lbl_Cuotas.Size = new System.Drawing.Size(76, 13);
            this.lbl_Cuotas.TabIndex = 8;
            this.lbl_Cuotas.Text = "Cuota (Interés)";
            // 
            // lbl_ComisiónTotal
            // 
            this.lbl_ComisiónTotal.AutoSize = true;
            this.lbl_ComisiónTotal.Location = new System.Drawing.Point(17, 341);
            this.lbl_ComisiónTotal.Name = "lbl_ComisiónTotal";
            this.lbl_ComisiónTotal.Size = new System.Drawing.Size(76, 13);
            this.lbl_ComisiónTotal.TabIndex = 10;
            this.lbl_ComisiónTotal.Text = "Comisión Total";
            // 
            // lbl_TipoPrestamo
            // 
            this.lbl_TipoPrestamo.AutoSize = true;
            this.lbl_TipoPrestamo.Location = new System.Drawing.Point(23, 16);
            this.lbl_TipoPrestamo.Name = "lbl_TipoPrestamo";
            this.lbl_TipoPrestamo.Size = new System.Drawing.Size(95, 13);
            this.lbl_TipoPrestamo.TabIndex = 11;
            this.lbl_TipoPrestamo.Text = "TIPO PRESTAMO";
            // 
            // lbl_Prestamo
            // 
            this.lbl_Prestamo.AutoSize = true;
            this.lbl_Prestamo.Location = new System.Drawing.Point(17, 16);
            this.lbl_Prestamo.Name = "lbl_Prestamo";
            this.lbl_Prestamo.Size = new System.Drawing.Size(159, 13);
            this.lbl_Prestamo.TabIndex = 12;
            this.lbl_Prestamo.Text = "PRESTAMO DADOS DE  ALTA";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(204, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Simular";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(204, 341);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(150, 23);
            this.btn_Alta.TabIndex = 21;
            this.btn_Alta.Text = "ALTA";
            this.btn_Alta.UseVisualStyleBackColor = true;
            // 
            // txt_Linea
            // 
            this.txt_Linea.Location = new System.Drawing.Point(283, 58);
            this.txt_Linea.Name = "txt_Linea";
            this.txt_Linea.Size = new System.Drawing.Size(75, 20);
            this.txt_Linea.TabIndex = 22;
            // 
            // txt_Tna
            // 
            this.txt_Tna.Location = new System.Drawing.Point(283, 91);
            this.txt_Tna.Name = "txt_Tna";
            this.txt_Tna.Size = new System.Drawing.Size(75, 20);
            this.txt_Tna.TabIndex = 23;
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(283, 127);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(75, 20);
            this.txt_Monto.TabIndex = 24;
            // 
            // txt_Plazo
            // 
            this.txt_Plazo.Location = new System.Drawing.Point(283, 164);
            this.txt_Plazo.Name = "txt_Plazo";
            this.txt_Plazo.Size = new System.Drawing.Size(75, 20);
            this.txt_Plazo.TabIndex = 25;
            // 
            // txt_CuotaCapital
            // 
            this.txt_CuotaCapital.Location = new System.Drawing.Point(283, 245);
            this.txt_CuotaCapital.Name = "txt_CuotaCapital";
            this.txt_CuotaCapital.Size = new System.Drawing.Size(75, 20);
            this.txt_CuotaCapital.TabIndex = 26;
            // 
            // txt_CuotaInterés
            // 
            this.txt_CuotaInterés.Location = new System.Drawing.Point(283, 278);
            this.txt_CuotaInterés.Name = "txt_CuotaInterés";
            this.txt_CuotaInterés.Size = new System.Drawing.Size(75, 20);
            this.txt_CuotaInterés.TabIndex = 27;
            // 
            // txt_CuotaTotal
            // 
            this.txt_CuotaTotal.Location = new System.Drawing.Point(283, 310);
            this.txt_CuotaTotal.Name = "txt_CuotaTotal";
            this.txt_CuotaTotal.Size = new System.Drawing.Size(75, 20);
            this.txt_CuotaTotal.TabIndex = 28;
            // 
            // txt_ComisionTotal
            // 
            this.txt_ComisionTotal.Location = new System.Drawing.Point(112, 334);
            this.txt_ComisionTotal.Name = "txt_ComisionTotal";
            this.txt_ComisionTotal.Size = new System.Drawing.Size(223, 20);
            this.txt_ComisionTotal.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Prestamo;
        private System.Windows.Forms.Label lbl_ComisiónTotal;
        private System.Windows.Forms.ListBox lst_Prestamos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lst_TipoPrestamos;
        private System.Windows.Forms.Label lbl_Plazo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbl_TipoPrestamo;
        private System.Windows.Forms.Label lbl_Capital;
        private System.Windows.Forms.Label lbl_CuotaTotal;
        private System.Windows.Forms.Label lbl_Cuotas;
        private System.Windows.Forms.Label lbl_Linea;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Label lbl_Tna;
        private System.Windows.Forms.TextBox txt_ComisionTotal;
        private System.Windows.Forms.TextBox txt_CuotaTotal;
        private System.Windows.Forms.TextBox txt_CuotaInterés;
        private System.Windows.Forms.TextBox txt_CuotaCapital;
        private System.Windows.Forms.TextBox txt_Plazo;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.TextBox txt_Tna;
        private System.Windows.Forms.TextBox txt_Linea;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

