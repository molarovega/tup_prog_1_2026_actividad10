namespace Ejercicio_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btnListarOrdenado = new System.Windows.Forms.Button();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promedio:";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(107, 35);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(81, 20);
            this.tbValor.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(276, 23);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 31);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.Location = new System.Drawing.Point(276, 69);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(84, 41);
            this.btnCalcularPromedio.TabIndex = 5;
            this.btnCalcularPromedio.Text = "Calcular promedio";
            this.btnCalcularPromedio.UseVisualStyleBackColor = true;
            this.btnCalcularPromedio.Click += new System.EventHandler(this.btnCalcularPromedio_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(62, 150);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(132, 20);
            this.tbBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 143);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 32);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(35, 220);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(193, 77);
            this.tbResultado.TabIndex = 8;
            // 
            // btnListarOrdenado
            // 
            this.btnListarOrdenado.Location = new System.Drawing.Point(260, 240);
            this.btnListarOrdenado.Name = "btnListarOrdenado";
            this.btnListarOrdenado.Size = new System.Drawing.Size(86, 45);
            this.btnListarOrdenado.TabIndex = 9;
            this.btnListarOrdenado.Text = "Listar ordenado";
            this.btnListarOrdenado.UseVisualStyleBackColor = true;
            this.btnListarOrdenado.Click += new System.EventHandler(this.btnListarOrdenado_Click);
            // 
            // lbPromedio
            // 
            this.lbPromedio.Location = new System.Drawing.Point(104, 69);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(84, 25);
            this.lbPromedio.TabIndex = 10;
            this.lbPromedio.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 352);
            this.Controls.Add(this.lbPromedio);
            this.Controls.Add(this.btnListarOrdenado);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnCalcularPromedio);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btnListarOrdenado;
        private System.Windows.Forms.Label lbPromedio;
    }
}

