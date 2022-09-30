namespace ConversorExamOr
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Resultado4 = new System.Windows.Forms.TextBox();
            this.Resultado3 = new System.Windows.Forms.TextBox();
            this.Resultado2 = new System.Windows.Forms.TextBox();
            this.Resultado1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moneda";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(253, 47);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(100, 20);
            this.txtMoneda.TabIndex = 2;
            this.txtMoneda.TextChanged += new System.EventHandler(this.txtMoneda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(325, 116);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Resultado4);
            this.panel1.Controls.Add(this.Resultado3);
            this.panel1.Controls.Add(this.Resultado2);
            this.panel1.Controls.Add(this.Resultado1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(27, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 193);
            this.panel1.TabIndex = 5;
            // 
            // Resultado4
            // 
            this.Resultado4.Location = new System.Drawing.Point(208, 130);
            this.Resultado4.Name = "Resultado4";
            this.Resultado4.Size = new System.Drawing.Size(100, 20);
            this.Resultado4.TabIndex = 5;
            // 
            // Resultado3
            // 
            this.Resultado3.Location = new System.Drawing.Point(208, 95);
            this.Resultado3.Name = "Resultado3";
            this.Resultado3.Size = new System.Drawing.Size(100, 20);
            this.Resultado3.TabIndex = 4;
            // 
            // Resultado2
            // 
            this.Resultado2.Location = new System.Drawing.Point(208, 69);
            this.Resultado2.Name = "Resultado2";
            this.Resultado2.Size = new System.Drawing.Size(100, 20);
            this.Resultado2.TabIndex = 3;
            // 
            // Resultado1
            // 
            this.Resultado1.Location = new System.Drawing.Point(208, 34);
            this.Resultado1.Name = "Resultado1";
            this.Resultado1.Size = new System.Drawing.Size(100, 20);
            this.Resultado1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Conversiones";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MXN - Peso mexicano",
            "USD - Dólar estadounidense",
            "CAD - Dólar canadiense",
            "EUR - Euro",
            "JPY - Yen japonés"});
            this.comboBox1.Location = new System.Drawing.Point(27, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Resultado4;
        private System.Windows.Forms.TextBox Resultado3;
        private System.Windows.Forms.TextBox Resultado2;
        private System.Windows.Forms.TextBox Resultado1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

