namespace Programa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nombre = new System.Windows.Forms.Button();
            this.Calificacion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(24, 74);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(75, 23);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "NOMBRE";
            this.Nombre.UseVisualStyleBackColor = true;
            // 
            // Calificacion
            // 
            this.Calificacion.Location = new System.Drawing.Point(12, 127);
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.Size = new System.Drawing.Size(97, 23);
            this.Calificacion.TabIndex = 1;
            this.Calificacion.Text = "CALIFICACION";
            this.Calificacion.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "UNIVERSIDAD";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(133, 209);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 3;
            this.Guardar.Text = "GUARDAR";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(260, 245);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "BUSCAR";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // dgLista
            // 
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Location = new System.Drawing.Point(260, 59);
            this.dgLista.Name = "dgLista";
            this.dgLista.RowTemplate.Height = 25;
            this.dgLista.Size = new System.Drawing.Size(379, 150);
            this.dgLista.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(133, 128);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 23);
            this.txtCalificacion.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 280);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Calificacion);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Nombre;
        private Button Calificacion;
        private Button button3;
        private Button Guardar;
        private Button Buscar;
        private DataGridView dgLista;
        private TextBox txtNombre;
        private TextBox txtCalificacion;
    }
}