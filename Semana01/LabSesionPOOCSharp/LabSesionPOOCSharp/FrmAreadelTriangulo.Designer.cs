namespace LabSesionPOOCSharp
{
    partial class FrmAreadelTriangulo
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
            label1 = new Label();
            label2 = new Label();
            txtLadoA = new TextBox();
            txtLadoB = new TextBox();
            label3 = new Label();
            txtLadoC = new TextBox();
            label4 = new Label();
            btnNuevo = new Button();
            btnCalcular = new Button();
            btnFinalizar = new Button();
            txtArea = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 9);
            label1.Name = "label1";
            label1.Size = new Size(325, 31);
            label1.TabIndex = 0;
            label1.Text = "AREA DEL TRIANGULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 74);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 1;
            label2.Text = "Lado A :";
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(179, 73);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(120, 23);
            txtLadoA.TabIndex = 2;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(179, 114);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(120, 23);
            txtLadoB.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 112);
            label3.Name = "label3";
            label3.Size = new Size(80, 22);
            label3.TabIndex = 3;
            label3.Text = "Lado B :";
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(179, 154);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(120, 23);
            txtLadoC.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 155);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 5;
            label4.Text = "Lado C :";
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(95, 202);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 30);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(183, 202);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 30);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.Location = new Point(271, 202);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(82, 30);
            btnFinalizar.TabIndex = 9;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(183, 271);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(135, 23);
            txtArea.TabIndex = 11;
            txtArea.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 269);
            label5.Name = "label5";
            label5.Size = new Size(169, 22);
            label5.TabIndex = 10;
            label5.Text = "Area del Triangulo:";
            // 
            // FrmAreadelTriangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 339);
            Controls.Add(txtArea);
            Controls.Add(label5);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCalcular);
            Controls.Add(btnNuevo);
            Controls.Add(txtLadoC);
            Controls.Add(label4);
            Controls.Add(txtLadoB);
            Controls.Add(label3);
            Controls.Add(txtLadoA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAreadelTriangulo";
            Text = "Variables";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLadoA;
        private TextBox txtLadoB;
        private Label label3;
        private TextBox txtLadoC;
        private Label label4;
        private Button btnNuevo;
        private Button btnCalcular;
        private Button btnFinalizar;
        private TextBox txtArea;
        private Label label5;
    }
}
