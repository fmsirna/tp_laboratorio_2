
namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.boxOperator = new System.Windows.Forms.ComboBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertBinary = new System.Windows.Forms.Button();
            this.btnConvertDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtNumero1.Location = new System.Drawing.Point(76, 63);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(102, 32);
            this.txtNumero1.TabIndex = 0;
            // 
            // boxOperator
            // 
            this.boxOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.boxOperator.FormattingEnabled = true;
            this.boxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.boxOperator.Location = new System.Drawing.Point(274, 63);
            this.boxOperator.Name = "boxOperator";
            this.boxOperator.Size = new System.Drawing.Size(55, 34);
            this.boxOperator.TabIndex = 1;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtNumero2.Location = new System.Drawing.Point(415, 63);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(104, 32);
            this.txtNumero2.TabIndex = 2;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(76, 148);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(102, 42);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "OPERAR";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResultado.Location = new System.Drawing.Point(463, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 26);
            this.lblResultado.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(249, 148);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 45);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(415, 148);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 45);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvertBinary
            // 
            this.btnConvertBinary.Location = new System.Drawing.Point(76, 224);
            this.btnConvertBinary.Name = "btnConvertBinary";
            this.btnConvertBinary.Size = new System.Drawing.Size(209, 47);
            this.btnConvertBinary.TabIndex = 7;
            this.btnConvertBinary.Text = "Convertir a binario";
            this.btnConvertBinary.UseVisualStyleBackColor = true;
            this.btnConvertBinary.Click += new System.EventHandler(this.btnConvertBinary_Click);
            // 
            // btnConvertDec
            // 
            this.btnConvertDec.Location = new System.Drawing.Point(322, 224);
            this.btnConvertDec.Name = "btnConvertDec";
            this.btnConvertDec.Size = new System.Drawing.Size(196, 46);
            this.btnConvertDec.TabIndex = 8;
            this.btnConvertDec.Text = "Convertir a decimal";
            this.btnConvertDec.UseVisualStyleBackColor = true;
            this.btnConvertDec.Click += new System.EventHandler(this.btnConvertDec_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 358);
            this.Controls.Add(this.btnConvertDec);
            this.Controls.Add(this.btnConvertBinary);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.boxOperator);
            this.Controls.Add(this.txtNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Federico Sirna del Curso 2D turno noche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.ComboBox boxOperator;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertBinary;
        private System.Windows.Forms.Button btnConvertDec;
    }
}

