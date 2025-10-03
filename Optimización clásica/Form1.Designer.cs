namespace Optimización_clásica
{
    partial class FormaOptimizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaOptimizacion));
            this.label1 = new System.Windows.Forms.Label();
            this.txtfuncion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimeraDerivada = new System.Windows.Forms.TextBox();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.txtSegundaDerivada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRentabilidad = new System.Windows.Forms.TextBox();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 205);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtfuncion
            // 
            this.txtfuncion.Location = new System.Drawing.Point(103, 121);
            this.txtfuncion.Name = "txtfuncion";
            this.txtfuncion.Size = new System.Drawing.Size(205, 26);
            this.txtfuncion.TabIndex = 2;
            this.txtfuncion.Text = "-0.001x^2 + 0.4x + 3.5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(40, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "R\'(x) = ";
            // 
            // txtPrimeraDerivada
            // 
            this.txtPrimeraDerivada.Location = new System.Drawing.Point(116, 245);
            this.txtPrimeraDerivada.Name = "txtPrimeraDerivada";
            this.txtPrimeraDerivada.ReadOnly = true;
            this.txtPrimeraDerivada.Size = new System.Drawing.Size(204, 26);
            this.txtPrimeraDerivada.TabIndex = 4;
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(165, 377);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(102, 36);
            this.cmdCalcular.TabIndex = 5;
            this.cmdCalcular.Text = "&Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // txtSegundaDerivada
            // 
            this.txtSegundaDerivada.Location = new System.Drawing.Point(116, 288);
            this.txtSegundaDerivada.Name = "txtSegundaDerivada";
            this.txtSegundaDerivada.ReadOnly = true;
            this.txtSegundaDerivada.Size = new System.Drawing.Size(204, 26);
            this.txtSegundaDerivada.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(40, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "R\'\'(x) = ";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblM.Location = new System.Drawing.Point(383, 245);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(0, 24);
            this.lblM.TabIndex = 8;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(478, 245);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(100, 26);
            this.txtM.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(361, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rentabilidad";
            // 
            // txtRentabilidad
            // 
            this.txtRentabilidad.Location = new System.Drawing.Point(478, 293);
            this.txtRentabilidad.Name = "txtRentabilidad";
            this.txtRentabilidad.ReadOnly = true;
            this.txtRentabilidad.Size = new System.Drawing.Size(100, 26);
            this.txtRentabilidad.TabIndex = 11;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(365, 377);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(102, 36);
            this.cmdLimpiar.TabIndex = 12;
            this.cmdLimpiar.Text = "&Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // FormaOptimizacion
            // 
            this.AcceptButton = this.cmdCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 451);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.txtRentabilidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.txtSegundaDerivada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.txtPrimeraDerivada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfuncion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormaOptimizacion";
            this.Text = "Optimización clásica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfuncion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimeraDerivada;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.TextBox txtSegundaDerivada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRentabilidad;
        private System.Windows.Forms.Button cmdLimpiar;
    }
}

