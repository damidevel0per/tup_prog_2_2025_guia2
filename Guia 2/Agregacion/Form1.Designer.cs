namespace Agregacion
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
            this.lbPersonas = new System.Windows.Forms.ListBox();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btnListarPersonas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtBusqDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDniEliminar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPersonas
            // 
            this.lbPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonas.FormattingEnabled = true;
            this.lbPersonas.ItemHeight = 20;
            this.lbPersonas.Location = new System.Drawing.Point(12, 12);
            this.lbPersonas.Name = "lbPersonas";
            this.lbPersonas.Size = new System.Drawing.Size(575, 224);
            this.lbPersonas.TabIndex = 0;
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPersona.Location = new System.Drawing.Point(605, 12);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(264, 41);
            this.btnAgregarPersona.TabIndex = 1;
            this.btnAgregarPersona.Text = "Agregar persona";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btnListarPersonas
            // 
            this.btnListarPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPersonas.Location = new System.Drawing.Point(605, 68);
            this.btnListarPersonas.Name = "btnListarPersonas";
            this.btnListarPersonas.Size = new System.Drawing.Size(264, 41);
            this.btnListarPersonas.TabIndex = 2;
            this.btnListarPersonas.Text = "Listar";
            this.btnListarPersonas.UseVisualStyleBackColor = true;
            this.btnListarPersonas.Click += new System.EventHandler(this.btnListarPersonas_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(743, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ver persona";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(743, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtBusqDNI
            // 
            this.txtBusqDNI.Location = new System.Drawing.Point(605, 200);
            this.txtBusqDNI.Name = "txtBusqDNI";
            this.txtBusqDNI.Size = new System.Drawing.Size(113, 20);
            this.txtBusqDNI.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DNI a eliminar";
            // 
            // txtDniEliminar
            // 
            this.txtDniEliminar.Location = new System.Drawing.Point(605, 145);
            this.txtDniEliminar.Name = "txtDniEliminar";
            this.txtDniEliminar.Size = new System.Drawing.Size(113, 20);
            this.txtDniEliminar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDniEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusqDNI);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnListarPersonas);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.lbPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPersonas;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Button btnListarPersonas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtBusqDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDniEliminar;
    }
}

