namespace SistemasEmpresa.VISTAS.EmpleadoVistas
{
    partial class EmpleadoEditarVistas
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
            Seleccionar_btn = new Button();
            txt_Salario = new TextBox();
            txt_Puesto = new TextBox();
            txt_IdPersona = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_DateTime = new TextBox();
            SuspendLayout();
            // 
            // Cancelar_btn
            // 
            Cancelar_btn.Location = new Point(311, 254);
            Cancelar_btn.Name = "Cancelar_btn";
            Cancelar_btn.Size = new Size(89, 35);
            Cancelar_btn.TabIndex = 21;
            Cancelar_btn.Text = "Cancelar";
            Cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // Guardar_btn
            // 
            Guardar_btn.Location = new Point(139, 254);
            Guardar_btn.Name = "Guardar_btn";
            Guardar_btn.Size = new Size(89, 35);
            Guardar_btn.TabIndex = 20;
            Guardar_btn.Text = "Guardar";
            Guardar_btn.UseVisualStyleBackColor = true;
            Guardar_btn.Click += Guardar_btn_Click;
            // 
            // Seleccionar_btn
            // 
            Seleccionar_btn.Location = new Point(450, 61);
            Seleccionar_btn.Name = "Seleccionar_btn";
            Seleccionar_btn.Size = new Size(103, 23);
            Seleccionar_btn.TabIndex = 19;
            Seleccionar_btn.Text = "Seleccionar";
            Seleccionar_btn.UseVisualStyleBackColor = true;
            Seleccionar_btn.Click += Seleccionar_btn_Click;
            // 
            // txt_Salario
            // 
            txt_Salario.Location = new Point(163, 212);
            txt_Salario.Name = "txt_Salario";
            txt_Salario.Size = new Size(264, 23);
            txt_Salario.TabIndex = 17;
            // 
            // txt_Puesto
            // 
            txt_Puesto.Location = new Point(163, 109);
            txt_Puesto.Name = "txt_Puesto";
            txt_Puesto.Size = new Size(264, 23);
            txt_Puesto.TabIndex = 16;
            // 
            // txt_IdPersona
            // 
            txt_IdPersona.Location = new Point(163, 61);
            txt_IdPersona.Name = "txt_IdPersona";
            txt_IdPersona.Size = new Size(264, 23);
            txt_IdPersona.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 212);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 14;
            label4.Text = "Salario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 162);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 13;
            label3.Text = "Fecha Contratacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 107);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 12;
            label2.Text = "Puesto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 59);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 11;
            label1.Text = "ID Persona";
            // 
            // txt_DateTime
            // 
            txt_DateTime.Location = new Point(163, 164);
            txt_DateTime.Name = "txt_DateTime";
            txt_DateTime.Size = new Size(264, 23);
            txt_DateTime.TabIndex = 22;
            // 
            // EmpleadoEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 348);
            Controls.Add(txt_DateTime);
            Controls.Add(Cancelar_btn);
            Controls.Add(Guardar_btn);
            Controls.Add(Seleccionar_btn);
            Controls.Add(txt_Salario);
            Controls.Add(txt_Puesto);
            Controls.Add(txt_IdPersona);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmpleadoEditarVistas";
            Text = "EmpleadoEditarVistas";
            Load += EmpleadoEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelar_btn;
        private Button Guardar_btn;
        private Button Seleccionar_btn;
        private TextBox txt_Salario;
        private TextBox txt_Puesto;
        private TextBox txt_IdPersona;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_DateTime;
    }
}