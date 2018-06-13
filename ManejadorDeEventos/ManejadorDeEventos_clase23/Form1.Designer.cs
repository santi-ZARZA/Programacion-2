namespace ManejadorDeEventos_clase23
{
    partial class Form1
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRetirar = new System.Windows.Forms.Label();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbilletes2 = new System.Windows.Forms.TextBox();
            this.lblBillete2 = new System.Windows.Forms.Label();
            this.txtbilletes5 = new System.Windows.Forms.TextBox();
            this.lblBillete5 = new System.Windows.Forms.Label();
            this.txtbilletes10 = new System.Windows.Forms.TextBox();
            this.lblBillete10 = new System.Windows.Forms.Label();
            this.txtbilletes20 = new System.Windows.Forms.TextBox();
            this.lblBillete20 = new System.Windows.Forms.Label();
            this.txtbilletes50 = new System.Windows.Forms.TextBox();
            this.lblBillete50 = new System.Windows.Forms.Label();
            this.txtbilletes100 = new System.Windows.Forms.TextBox();
            this.lblBillete100 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(275, 87);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(275, 135);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(275, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRetirar);
            this.groupBox1.Controls.Add(this.lblRetirar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad a Retirar";
            // 
            // lblRetirar
            // 
            this.lblRetirar.AutoSize = true;
            this.lblRetirar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRetirar.Location = new System.Drawing.Point(7, 20);
            this.lblRetirar.Name = "lblRetirar";
            this.lblRetirar.Size = new System.Drawing.Size(92, 13);
            this.lblRetirar.TabIndex = 0;
            this.lblRetirar.Text = "Cantidad a Retirar";
            // 
            // txtRetirar
            // 
            this.txtRetirar.Location = new System.Drawing.Point(118, 17);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(121, 20);
            this.txtRetirar.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbilletes100);
            this.groupBox2.Controls.Add(this.lblBillete100);
            this.groupBox2.Controls.Add(this.txtbilletes50);
            this.groupBox2.Controls.Add(this.lblBillete50);
            this.groupBox2.Controls.Add(this.txtbilletes20);
            this.groupBox2.Controls.Add(this.lblBillete20);
            this.groupBox2.Controls.Add(this.txtbilletes10);
            this.groupBox2.Controls.Add(this.lblBillete10);
            this.groupBox2.Controls.Add(this.txtbilletes5);
            this.groupBox2.Controls.Add(this.lblBillete5);
            this.groupBox2.Controls.Add(this.txtbilletes2);
            this.groupBox2.Controls.Add(this.lblBillete2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 178);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad de Billetes";
            // 
            // txtbilletes2
            // 
            this.txtbilletes2.Location = new System.Drawing.Point(118, 17);
            this.txtbilletes2.Name = "txtbilletes2";
            this.txtbilletes2.Size = new System.Drawing.Size(121, 20);
            this.txtbilletes2.TabIndex = 1;
            // 
            // lblBillete2
            // 
            this.lblBillete2.AutoSize = true;
            this.lblBillete2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBillete2.Location = new System.Drawing.Point(7, 20);
            this.lblBillete2.Name = "lblBillete2";
            this.lblBillete2.Size = new System.Drawing.Size(68, 13);
            this.lblBillete2.TabIndex = 0;
            this.lblBillete2.Text = "Billete de $ 2";
            // 
            // txtbilletes5
            // 
            this.txtbilletes5.Location = new System.Drawing.Point(118, 43);
            this.txtbilletes5.Name = "txtbilletes5";
            this.txtbilletes5.Size = new System.Drawing.Size(121, 20);
            this.txtbilletes5.TabIndex = 3;
            // 
            // lblBillete5
            // 
            this.lblBillete5.AutoSize = true;
            this.lblBillete5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBillete5.Location = new System.Drawing.Point(7, 46);
            this.lblBillete5.Name = "lblBillete5";
            this.lblBillete5.Size = new System.Drawing.Size(68, 13);
            this.lblBillete5.TabIndex = 2;
            this.lblBillete5.Text = "Billete de $ 5";
            // 
            // txtbilletes10
            // 
            this.txtbilletes10.Location = new System.Drawing.Point(118, 69);
            this.txtbilletes10.Name = "txtbilletes10";
            this.txtbilletes10.Size = new System.Drawing.Size(121, 20);
            this.txtbilletes10.TabIndex = 5;
            // 
            // lblBillete10
            // 
            this.lblBillete10.AutoSize = true;
            this.lblBillete10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBillete10.Location = new System.Drawing.Point(7, 72);
            this.lblBillete10.Name = "lblBillete10";
            this.lblBillete10.Size = new System.Drawing.Size(74, 13);
            this.lblBillete10.TabIndex = 4;
            this.lblBillete10.Text = "Billete de $ 10";
            // 
            // txtbilletes20
            // 
            this.txtbilletes20.Location = new System.Drawing.Point(118, 95);
            this.txtbilletes20.Name = "txtbilletes20";
            this.txtbilletes20.Size = new System.Drawing.Size(121, 20);
            this.txtbilletes20.TabIndex = 7;
            // 
            // lblBillete20
            // 
            this.lblBillete20.AutoSize = true;
            this.lblBillete20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBillete20.Location = new System.Drawing.Point(7, 98);
            this.lblBillete20.Name = "lblBillete20";
            this.lblBillete20.Size = new System.Drawing.Size(74, 13);
            this.lblBillete20.TabIndex = 6;
            this.lblBillete20.Text = "Billete de $ 20";
            // 
            // txtbilletes50
            // 
            this.txtbilletes50.Location = new System.Drawing.Point(118, 121);
            this.txtbilletes50.Name = "txtbilletes50";
            this.txtbilletes50.Size = new System.Drawing.Size(121, 20);
            this.txtbilletes50.TabIndex = 9;
            // 
            // lblBillete50
            // 
            this.lblBillete50.AutoSize = true;
            this.lblBillete50.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBillete50.Location = new System.Drawing.Point(7, 124);
            this.lblBillete50.Name = "lblBillete50";
            this.lblBillete50.Size = new System.Drawing.Size(74, 13);
            this.lblBillete50.TabIndex = 8;
            this.lblBillete50.Text = "Billete de $ 50";
            // 
            // txtbilletes100
            // 
            this.txtbilletes100.Location = new System.Drawing.Point(118, 147);
            this.txtbilletes100.Name = "txtbilletes100";
            this.txtbilletes100.Size = new System.Drawing.Size(121, 20);
            this.txtbilletes100.TabIndex = 11;
            // 
            // lblBillete100
            // 
            this.lblBillete100.AutoSize = true;
            this.lblBillete100.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBillete100.Location = new System.Drawing.Point(7, 150);
            this.lblBillete100.Name = "lblBillete100";
            this.lblBillete100.Size = new System.Drawing.Size(80, 13);
            this.lblBillete100.TabIndex = 10;
            this.lblBillete100.Text = "Billete de $ 100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRetirar;
        private System.Windows.Forms.Label lblRetirar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbilletes100;
        private System.Windows.Forms.Label lblBillete100;
        private System.Windows.Forms.TextBox txtbilletes50;
        private System.Windows.Forms.Label lblBillete50;
        private System.Windows.Forms.TextBox txtbilletes20;
        private System.Windows.Forms.Label lblBillete20;
        private System.Windows.Forms.TextBox txtbilletes10;
        private System.Windows.Forms.Label lblBillete10;
        private System.Windows.Forms.TextBox txtbilletes5;
        private System.Windows.Forms.Label lblBillete5;
        private System.Windows.Forms.TextBox txtbilletes2;
        private System.Windows.Forms.Label lblBillete2;
    }
}

