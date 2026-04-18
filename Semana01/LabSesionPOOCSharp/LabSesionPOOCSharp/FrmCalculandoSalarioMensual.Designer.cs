namespace LabSesionPOOCSharp
{
    partial class FrmCalculandoSalarioMensual
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
            comboBox1 = new ComboBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            btnFinalizar = new Button();
            btnCalcular = new Button();
            btnNuevo = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(515, 24);
            label1.TabIndex = 0;
            label1.Text = "CALCULANDO EL SALARIO MENSUAL POR HORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 64);
            label2.Name = "label2";
            label2.Size = new Size(214, 22);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Trabajador :";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(243, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 25);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(130, 101);
            label3.Name = "label3";
            label3.Size = new Size(112, 22);
            label3.TabIndex = 3;
            label3.Text = "Nro. Horas :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(244, 97);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 29);
            numericUpDown1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 134);
            label4.Name = "label4";
            label4.Size = new Size(153, 22);
            label4.TabIndex = 5;
            label4.Text = "Precio por Hora :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(243, 134);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(105, 22);
            maskedTextBox1.TabIndex = 6;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnFinalizar.Location = new Point(363, 175);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(98, 30);
            btnFinalizar.TabIndex = 21;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnCalcular.Location = new Point(259, 175);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(98, 30);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnNuevo.Location = new Point(149, 175);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 30);
            btnNuevo.TabIndex = 19;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(149, 259);
            label5.Name = "label5";
            label5.Size = new Size(90, 22);
            label5.TabIndex = 23;
            label5.Text = "Mensaje :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(163, 226);
            label6.Name = "label6";
            label6.Size = new Size(79, 22);
            label6.TabIndex = 22;
            label6.Text = "Salario :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(249, 259);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 81);
            textBox2.TabIndex = 25;
            // 
            // FrmCalculandoSalarioMensual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 364);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCalcular);
            Controls.Add(btnNuevo);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCalculandoSalarioMensual";
            Text = "FrmCalculandoSalarioMensual";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Button btnFinalizar;
        private Button btnCalcular;
        private Button btnNuevo;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}