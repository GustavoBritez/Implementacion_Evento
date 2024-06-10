namespace Clase5_1
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
            Panel1 = new Panel();
            BTN_MyEdad = new Button();
            BTN_MyClass = new Button();
            BTN_Soy = new Button();
            LB_Edad = new Label();
            LB_Nombre = new Label();
            BTN_Agregar = new Button();
            DGV_Clases = new DataGridView();
            C_Alumno = new CheckBox();
            C_Profesor = new CheckBox();
            BTN_Eliminar = new Button();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Clases).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Controls.Add(BTN_MyEdad);
            Panel1.Controls.Add(BTN_MyClass);
            Panel1.Controls.Add(BTN_Soy);
            Panel1.Controls.Add(LB_Edad);
            Panel1.Controls.Add(LB_Nombre);
            Panel1.Location = new Point(27, 56);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(200, 189);
            Panel1.TabIndex = 0;
            // 
            // BTN_MyEdad
            // 
            BTN_MyEdad.Location = new Point(106, 123);
            BTN_MyEdad.Name = "BTN_MyEdad";
            BTN_MyEdad.Size = new Size(75, 23);
            BTN_MyEdad.TabIndex = 4;
            BTN_MyEdad.Text = "My Edad";
            BTN_MyEdad.UseVisualStyleBackColor = true;
            // 
            // BTN_MyClass
            // 
            BTN_MyClass.Location = new Point(106, 94);
            BTN_MyClass.Name = "BTN_MyClass";
            BTN_MyClass.Size = new Size(75, 23);
            BTN_MyClass.TabIndex = 3;
            BTN_MyClass.Text = "My Class";
            BTN_MyClass.UseVisualStyleBackColor = true;
            // 
            // BTN_Soy
            // 
            BTN_Soy.Location = new Point(106, 65);
            BTN_Soy.Name = "BTN_Soy";
            BTN_Soy.Size = new Size(75, 23);
            BTN_Soy.TabIndex = 2;
            BTN_Soy.Text = "Soy";
            BTN_Soy.UseVisualStyleBackColor = true;
            // 
            // LB_Edad
            // 
            LB_Edad.AutoSize = true;
            LB_Edad.Location = new Point(27, 69);
            LB_Edad.Name = "LB_Edad";
            LB_Edad.Size = new Size(33, 15);
            LB_Edad.TabIndex = 1;
            LB_Edad.Text = "Edad";
            // 
            // LB_Nombre
            // 
            LB_Nombre.AutoSize = true;
            LB_Nombre.Location = new Point(66, 29);
            LB_Nombre.Name = "LB_Nombre";
            LB_Nombre.Size = new Size(51, 15);
            LB_Nombre.TabIndex = 0;
            LB_Nombre.Text = "Nombre";
            // 
            // BTN_Agregar
            // 
            BTN_Agregar.Location = new Point(268, 45);
            BTN_Agregar.Name = "BTN_Agregar";
            BTN_Agregar.Size = new Size(75, 23);
            BTN_Agregar.TabIndex = 1;
            BTN_Agregar.Text = "Agregar";
            BTN_Agregar.UseVisualStyleBackColor = true;
            BTN_Agregar.Click += Agregar_Click;
            // 
            // DGV_Clases
            // 
            DGV_Clases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Clases.Location = new Point(404, 85);
            DGV_Clases.Name = "DGV_Clases";
            DGV_Clases.RowTemplate.Height = 25;
            DGV_Clases.Size = new Size(369, 150);
            DGV_Clases.TabIndex = 2;
            // 
            // C_Alumno
            // 
            C_Alumno.AutoSize = true;
            C_Alumno.Location = new Point(273, 85);
            C_Alumno.Name = "C_Alumno";
            C_Alumno.Size = new Size(69, 19);
            C_Alumno.TabIndex = 3;
            C_Alumno.Text = "Alumno";
            C_Alumno.UseVisualStyleBackColor = true;
            // 
            // C_Profesor
            // 
            C_Profesor.AutoSize = true;
            C_Profesor.Location = new Point(273, 110);
            C_Profesor.Name = "C_Profesor";
            C_Profesor.Size = new Size(70, 19);
            C_Profesor.TabIndex = 4;
            C_Profesor.Text = "Profesor";
            C_Profesor.UseVisualStyleBackColor = true;
            // 
            // BTN_Eliminar
            // 
            BTN_Eliminar.Location = new Point(404, 241);
            BTN_Eliminar.Name = "BTN_Eliminar";
            BTN_Eliminar.Size = new Size(75, 23);
            BTN_Eliminar.TabIndex = 5;
            BTN_Eliminar.Text = "Eliminar";
            BTN_Eliminar.UseVisualStyleBackColor = true;
            BTN_Eliminar.Click += BTN_Eliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_Eliminar);
            Controls.Add(C_Profesor);
            Controls.Add(C_Alumno);
            Controls.Add(DGV_Clases);
            Controls.Add(BTN_Agregar);
            Controls.Add(Panel1);
            Name = "Form1";
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Clases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Panel1;
        private Button BTN_MyEdad;
        private Button BTN_MyClass;
        private Button BTN_Soy;
        private Label LB_Edad;
        private Label LB_Nombre;
        private Button BTN_Agregar;
        private DataGridView DGV_Clases;
        private CheckBox C_Alumno;
        private CheckBox C_Profesor;
        private Button BTN_Eliminar;
    }
}