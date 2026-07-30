namespace Registro_Cliente
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
            btn_Guardar = new Button();
            list_Clientes = new ListBox();
            label1 = new Label();
            txt_Nombre = new TextBox();
            lbl_nombre = new Label();
            lbl_Telefono = new Label();
            lbl_correo = new Label();
            txt_Telefono = new TextBox();
            txt_Correo = new TextBox();
            SuspendLayout();
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(542, 575);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(150, 46);
            btn_Guardar.TabIndex = 0;
            btn_Guardar.Text = "Mostrar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // list_Clientes
            // 
            list_Clientes.FormattingEnabled = true;
            list_Clientes.Location = new Point(696, 187);
            list_Clientes.Name = "list_Clientes";
            list_Clientes.Size = new Size(458, 196);
            list_Clientes.TabIndex = 1;
            list_Clientes.SelectedIndexChanged += list_Clientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(565, 37);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 2;
            label1.Text = "Registro Cliente";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(364, 175);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(200, 39);
            txt_Nombre.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(250, 175);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(102, 32);
            lbl_nombre.TabIndex = 4;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(250, 268);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(107, 32);
            lbl_Telefono.TabIndex = 5;
            lbl_Telefono.Text = "Telefono";
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.Location = new Point(250, 381);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(86, 32);
            lbl_correo.TabIndex = 6;
            lbl_correo.Text = "Correo";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(364, 261);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(200, 39);
            txt_Telefono.TabIndex = 7;
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(364, 378);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(200, 39);
            txt_Correo.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 707);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Telefono);
            Controls.Add(lbl_correo);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_nombre);
            Controls.Add(txt_Nombre);
            Controls.Add(label1);
            Controls.Add(list_Clientes);
            Controls.Add(btn_Guardar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Guardar;
        private ListBox list_Clientes;
        private Label label1;
        private TextBox txt_Nombre;
        private Label lbl_nombre;
        private Label lbl_Telefono;
        private Label lbl_correo;
        private TextBox txt_Telefono;
        private TextBox txt_Correo;
    }
}
