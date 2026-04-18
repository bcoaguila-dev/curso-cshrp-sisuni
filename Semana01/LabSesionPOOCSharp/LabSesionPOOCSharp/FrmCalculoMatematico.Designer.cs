namespace LabSesionPOOCSharp
{
    partial class FrmCalculoMatematico
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
            btnFinalizar = new Button();
            btnCalcular = new Button();
            btnNuevo = new Button();
            txtZ = new TextBox();
            label4 = new Label();
            txtY = new TextBox();
            label3 = new Label();
            txtX = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(346, 31);
            label1.TabIndex = 0;
            label1.Text = "CALCULO MATEMATICO";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.Location = new Point(259, 192);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(82, 30);
            btnFinalizar.TabIndex = 18;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(171, 192);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 30);
            btnCalcular.TabIndex = 17;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(83, 192);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 30);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtZ
            // 
            txtZ.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtZ.Location = new Point(167, 140);
            txtZ.Name = "txtZ";
            txtZ.Size = new Size(120, 25);
            txtZ.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(129, 142);
            label4.Name = "label4";
            label4.Size = new Size(32, 22);
            label4.TabIndex = 14;
            label4.Text = "Z :";
            // 
            // txtY
            // 
            txtY.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtY.Location = new Point(167, 102);
            txtY.Name = "txtY";
            txtY.Size = new Size(120, 25);
            txtY.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(129, 99);
            label3.Name = "label3";
            label3.Size = new Size(32, 22);
            label3.TabIndex = 12;
            label3.Text = "Y :";
            // 
            // txtX
            // 
            txtX.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtX.Location = new Point(167, 63);
            txtX.Name = "txtX";
            txtX.Size = new Size(120, 25);
            txtX.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 61);
            label2.Name = "label2";
            label2.Size = new Size(33, 22);
            label2.TabIndex = 10;
            label2.Text = "X :";
            // 
            // FrmCalculoMatematico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 245);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCalcular);
            Controls.Add(btnNuevo);
            Controls.Add(txtZ);
            Controls.Add(label4);
            Controls.Add(txtY);
            Controls.Add(label3);
            Controls.Add(txtX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCalculoMatematico";
            Text = "Variables";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFinalizar;
        private Button btnCalcular;
        private Button btnNuevo;
        private TextBox txtZ;
        private Label label4;
        private TextBox txtY;
        private Label label3;
        private TextBox txtX;
        private Label label2;
    }
}