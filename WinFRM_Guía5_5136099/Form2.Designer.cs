namespace WinFRM_Guía5_5136099
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnIngresarC = new System.Windows.Forms.Button();
            this.btnLimpiarC = new System.Windows.Forms.Button();
            this.btnVolverC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Nombre";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(80, 64);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(188, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // btnIngresarC
            // 
            this.btnIngresarC.Location = new System.Drawing.Point(30, 112);
            this.btnIngresarC.Name = "btnIngresarC";
            this.btnIngresarC.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarC.TabIndex = 3;
            this.btnIngresarC.Text = "Ingresar";
            this.btnIngresarC.UseVisualStyleBackColor = true;
            this.btnIngresarC.Click += new System.EventHandler(this.btnIngresarC_Click);
            // 
            // btnLimpiarC
            // 
            this.btnLimpiarC.Location = new System.Drawing.Point(111, 112);
            this.btnLimpiarC.Name = "btnLimpiarC";
            this.btnLimpiarC.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarC.TabIndex = 4;
            this.btnLimpiarC.Text = "Limpiar";
            this.btnLimpiarC.UseVisualStyleBackColor = true;
            this.btnLimpiarC.Click += new System.EventHandler(this.btnLimpiarC_Click);
            // 
            // btnVolverC
            // 
            this.btnVolverC.Location = new System.Drawing.Point(193, 111);
            this.btnVolverC.Name = "btnVolverC";
            this.btnVolverC.Size = new System.Drawing.Size(75, 23);
            this.btnVolverC.TabIndex = 5;
            this.btnVolverC.Text = "Volver";
            this.btnVolverC.UseVisualStyleBackColor = true;
            this.btnVolverC.Click += new System.EventHandler(this.btnVolverC_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 168);
            this.Controls.Add(this.btnVolverC);
            this.Controls.Add(this.btnLimpiarC);
            this.Controls.Add(this.btnIngresarC);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnIngresarC;
        private System.Windows.Forms.Button btnLimpiarC;
        private System.Windows.Forms.Button btnVolverC;
    }
}