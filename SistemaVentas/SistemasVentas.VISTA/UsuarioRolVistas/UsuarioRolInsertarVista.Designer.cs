namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    partial class UsuarioRolInsertarVista
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 46);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "IDUSUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 100);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "IDROL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 152);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "FECHA ASIGNADA:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 23);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(212, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(626, 69);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(626, 152);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // UsuarioRolInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioRolInsertarVista";
            Text = "UsuarioRolInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}