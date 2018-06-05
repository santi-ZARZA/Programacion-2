namespace WF
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnTraer = new System.Windows.Forms.Button();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbApellido = new System.Windows.Forms.Label();
            this.LbPuesto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSerializaBinario = new System.Windows.Forms.Button();
            this.btnDescerializaBinario = new System.Windows.Forms.Button();
            this.btnSerializaXML = new System.Windows.Forms.Button();
            this.btnDescerializaXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(12, 198);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(97, 33);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnTraer
            // 
            this.BtnTraer.Location = new System.Drawing.Point(173, 198);
            this.BtnTraer.Name = "BtnTraer";
            this.BtnTraer.Size = new System.Drawing.Size(97, 33);
            this.BtnTraer.TabIndex = 1;
            this.BtnTraer.Text = "Traer";
            this.BtnTraer.UseVisualStyleBackColor = true;
            this.BtnTraer.Click += new System.EventHandler(this.BtnTraer_Click);
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(34, 23);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(58, 17);
            this.LbNombre.TabIndex = 2;
            this.LbNombre.Text = "Nombre";
            // 
            // LbApellido
            // 
            this.LbApellido.AutoSize = true;
            this.LbApellido.Location = new System.Drawing.Point(31, 78);
            this.LbApellido.Name = "LbApellido";
            this.LbApellido.Size = new System.Drawing.Size(58, 17);
            this.LbApellido.TabIndex = 3;
            this.LbApellido.Text = "Apellido";
            // 
            // LbPuesto
            // 
            this.LbPuesto.AutoSize = true;
            this.LbPuesto.Location = new System.Drawing.Point(34, 132);
            this.LbPuesto.Name = "LbPuesto";
            this.LbPuesto.Size = new System.Drawing.Size(52, 17);
            this.LbPuesto.TabIndex = 4;
            this.LbPuesto.Text = "Puesto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(136, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(134, 22);
            this.txtApellido.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // btnSerializaBinario
            // 
            this.btnSerializaBinario.Location = new System.Drawing.Point(12, 237);
            this.btnSerializaBinario.Name = "btnSerializaBinario";
            this.btnSerializaBinario.Size = new System.Drawing.Size(97, 33);
            this.btnSerializaBinario.TabIndex = 8;
            this.btnSerializaBinario.Text = "Ser.Bin";
            this.btnSerializaBinario.UseVisualStyleBackColor = true;
            this.btnSerializaBinario.Click += new System.EventHandler(this.btnSerializaBinario_Click);
            // 
            // btnDescerializaBinario
            // 
            this.btnDescerializaBinario.Location = new System.Drawing.Point(173, 237);
            this.btnDescerializaBinario.Name = "btnDescerializaBinario";
            this.btnDescerializaBinario.Size = new System.Drawing.Size(97, 33);
            this.btnDescerializaBinario.TabIndex = 9;
            this.btnDescerializaBinario.Text = "Deser.Bin";
            this.btnDescerializaBinario.UseVisualStyleBackColor = true;
            this.btnDescerializaBinario.Click += new System.EventHandler(this.btnDescerializaBinario_Click);
            // 
            // btnSerializaXML
            // 
            this.btnSerializaXML.Location = new System.Drawing.Point(12, 279);
            this.btnSerializaXML.Name = "btnSerializaXML";
            this.btnSerializaXML.Size = new System.Drawing.Size(97, 33);
            this.btnSerializaXML.TabIndex = 10;
            this.btnSerializaXML.Text = "Ser.XML";
            this.btnSerializaXML.UseVisualStyleBackColor = true;
            this.btnSerializaXML.Click += new System.EventHandler(this.btnSerializaXML_Click);
            // 
            // btnDescerializaXML
            // 
            this.btnDescerializaXML.Location = new System.Drawing.Point(173, 279);
            this.btnDescerializaXML.Name = "btnDescerializaXML";
            this.btnDescerializaXML.Size = new System.Drawing.Size(97, 33);
            this.btnDescerializaXML.TabIndex = 11;
            this.btnDescerializaXML.Text = "Descer.XML";
            this.btnDescerializaXML.UseVisualStyleBackColor = true;
            this.btnDescerializaXML.Click += new System.EventHandler(this.btnDescerializaXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 324);
            this.Controls.Add(this.btnDescerializaXML);
            this.Controls.Add(this.btnSerializaXML);
            this.Controls.Add(this.btnDescerializaBinario);
            this.Controls.Add(this.btnSerializaBinario);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LbPuesto);
            this.Controls.Add(this.LbApellido);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.BtnTraer);
            this.Controls.Add(this.BtnGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnTraer;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbApellido;
        private System.Windows.Forms.Label LbPuesto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSerializaBinario;
        private System.Windows.Forms.Button btnDescerializaBinario;
        private System.Windows.Forms.Button btnSerializaXML;
        private System.Windows.Forms.Button btnDescerializaXML;
    }
}

