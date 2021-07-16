
namespace WindowsForms
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Cuerpobtn = new System.Windows.Forms.Button();
            this.btnArma = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cuerpobtn
            // 
            resources.ApplyResources(this.Cuerpobtn, "Cuerpobtn");
            this.Cuerpobtn.Name = "Cuerpobtn";
            this.Cuerpobtn.UseVisualStyleBackColor = true;
            this.Cuerpobtn.Click += new System.EventHandler(this.Cuerpobtn_Click);
            // 
            // btnArma
            // 
            resources.ApplyResources(this.btnArma, "btnArma");
            this.btnArma.Name = "btnArma";
            this.btnArma.UseVisualStyleBackColor = true;
            this.btnArma.Click += new System.EventHandler(this.btnArma_Click);
            // 
            // btnInforme
            // 
            resources.ApplyResources(this.btnInforme, "btnInforme");
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnArma);
            this.Controls.Add(this.Cuerpobtn);
            this.Name = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cuerpobtn;
        private System.Windows.Forms.Button btnArma;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button button1;
    }
}

