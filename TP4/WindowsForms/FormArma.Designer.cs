
namespace WindowsForms
{
    partial class FormArma
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAk47 = new System.Windows.Forms.RadioButton();
            this.rbDragunov = new System.Windows.Forms.RadioButton();
            this.rbUzi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCañon = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuerpo:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(108, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 95);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbCañon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbUzi);
            this.groupBox1.Controls.Add(this.rbDragunov);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.rbAk47);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 347);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CLASE:";
            // 
            // rbAk47
            // 
            this.rbAk47.AutoSize = true;
            this.rbAk47.Location = new System.Drawing.Point(257, 14);
            this.rbAk47.Name = "rbAk47";
            this.rbAk47.Size = new System.Drawing.Size(51, 17);
            this.rbAk47.TabIndex = 4;
            this.rbAk47.TabStop = true;
            this.rbAk47.Text = "AK47";
            this.rbAk47.UseVisualStyleBackColor = true;
            // 
            // rbDragunov
            // 
            this.rbDragunov.AutoSize = true;
            this.rbDragunov.Location = new System.Drawing.Point(108, 12);
            this.rbDragunov.Name = "rbDragunov";
            this.rbDragunov.Size = new System.Drawing.Size(72, 17);
            this.rbDragunov.TabIndex = 5;
            this.rbDragunov.TabStop = true;
            this.rbDragunov.Text = "Dragunov";
            this.rbDragunov.UseVisualStyleBackColor = true;
            // 
            // rbUzi
            // 
            this.rbUzi.AutoSize = true;
            this.rbUzi.Location = new System.Drawing.Point(200, 14);
            this.rbUzi.Name = "rbUzi";
            this.rbUzi.Size = new System.Drawing.Size(40, 17);
            this.rbUzi.TabIndex = 6;
            this.rbUzi.TabStop = true;
            this.rbUzi.Text = "Uzi";
            this.rbUzi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cañon:";
            // 
            // cmbCañon
            // 
            this.cmbCañon.FormattingEnabled = true;
            this.cmbCañon.Location = new System.Drawing.Point(108, 193);
            this.cmbCañon.Name = "cmbCañon";
            this.cmbCañon.Size = new System.Drawing.Size(121, 21);
            this.cmbCañon.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fabricar Arma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormArma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormArma";
            this.Text = "FormArma";
            this.Load += new System.EventHandler(this.formLoading);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbUzi;
        private System.Windows.Forms.RadioButton rbDragunov;
        private System.Windows.Forms.RadioButton rbAk47;
        private System.Windows.Forms.ComboBox cmbCañon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}