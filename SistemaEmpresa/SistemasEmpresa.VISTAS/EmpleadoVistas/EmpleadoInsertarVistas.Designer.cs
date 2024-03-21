namespace SistemasEmpresa.VISTAS.EmpleadoVistas
{
    partial class EmpleadoInsertarVistas
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
            Cancelar_btn = new Button();
            Guardar_btn = new Button();
            dateTimePicker1 = new DateTimePicker();
            txt_Salario = new TextBox();
            txt_Puesto = new TextBox();
            txt_Apellido = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txt_Nombre = new TextBox();
            SuspendLayout();
            // 
            // Cancelar_btn
            // 
            Cancelar_btn.Location = new Point(336, 289);
            Cancelar_btn.Name = "Cancelar_btn";
            Cancelar_btn.Size = new Size(89, 35);
            Cancelar_btn.TabIndex = 31;
            Cancelar_btn.Text = "Cancelar";
            Cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // Guardar_btn
            // 
            Guardar_btn.Location = new Point(164, 289);
            Guardar_btn.Name = "Guardar_btn";
            Guardar_btn.Size = new Size(89, 35);
            Guardar_btn.TabIndex = 30;
            Guardar_btn.Text = "Guardar";
            Guardar_btn.UseVisualStyleBackColor = true;
            Guardar_btn.Click += Guardar_btn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(188, 195);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 23);
            dateTimePicker1.TabIndex = 29;
            // 
            // txt_Salario
            // 
            txt_Salario.Location = new Point(188, 247);
            txt_Salario.Name = "txt_Salario";
            txt_Salario.Size = new Size(264, 23);
            txt_Salario.TabIndex = 28;
            // 
            // txt_Puesto
            // 
            txt_Puesto.Location = new Point(188, 144);
            txt_Puesto.Name = "txt_Puesto";
            txt_Puesto.Size = new Size(264, 23);
            txt_Puesto.TabIndex = 27;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(188, 96);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(264, 23);
            txt_Apellido.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 247);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 25;
            label4.Text = "Salario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 197);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 24;
            label3.Text = "Fecha Contratacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 142);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 23;
            label2.Text = "Puesto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 94);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 22;
            label1.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 50);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 32;
            label5.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(188, 52);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(264, 23);
            txt_Nombre.TabIndex = 33;
            // 
            // EmpleadoInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 367);
            Controls.Add(txt_Nombre);
            Controls.Add(label5);
            Controls.Add(Cancelar_btn);
            Controls.Add(Guardar_btn);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_Salario);
            Controls.Add(txt_Puesto);
            Controls.Add(txt_Apellido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmpleadoInsertarVistas";
            Text = "EmpleadoInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelar_btn;
        private Button Guardar_btn;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_Salario;
        private TextBox txt_Puesto;
        private TextBox txt_Apellido;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txt_Nombre;
    }
}