namespace SistemasVentas.VISTA.PersonaVistas
{
    partial class PersonaInsertarVista
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            label1.Location = new Point(58, 57);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            label2.Location = new Point(48, 119);
            label2.Name = "label2";
            label2.Size = new Size(82, 18);
            label2.TabIndex = 1;
            label2.Text = "APELLIDOS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            label3.Location = new Point(50, 176);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 2;
            label3.Text = "TELEFONO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            label4.Location = new Point(58, 288);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 3;
            label4.Text = "CORREO:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            label5.Location = new Point(93, 232);
            label5.Name = "label5";
            label5.Size = new Size(24, 18);
            label5.TabIndex = 4;
            label5.Text = "CI:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(379, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(151, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(379, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(151, 288);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(379, 23);
            textBox5.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold);
            btnGuardar.Location = new Point(211, 366);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 48);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(432, 366);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 48);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // PersonaInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonaInsertarVista";
            Text = "PersonaInsertarVista";
            Load += PersonaInsertarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}