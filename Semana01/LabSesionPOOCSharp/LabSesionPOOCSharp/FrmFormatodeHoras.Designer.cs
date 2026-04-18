namespace LabSesionPOOCSharp
{
    partial class FrmFormatodeHoras
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
            txtHora = new TextBox();
            txtMinuto = new TextBox();
            button1 = new Button();
            label4 = new Label();
            txtFormato12Horas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(454, 31);
            label1.TabIndex = 0;
            label1.Text = "Cambio de Formato de 24 a 12 Horas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 68);
            label2.Name = "label2";
            label2.Size = new Size(128, 22);
            label2.TabIndex = 1;
            label2.Text = "Ingrese Hora :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 102);
            label3.Name = "label3";
            label3.Size = new Size(145, 22);
            label3.TabIndex = 2;
            label3.Text = "Ingrese Minuto :";
            // 
            // txtHora
            // 
            txtHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHora.Location = new Point(233, 68);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(109, 25);
            txtHora.TabIndex = 12;
            // 
            // txtMinuto
            // 
            txtMinuto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMinuto.Location = new Point(233, 102);
            txtMinuto.Name = "txtMinuto";
            txtMinuto.Size = new Size(109, 25);
            txtMinuto.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(230, 139);
            button1.Name = "button1";
            button1.Size = new Size(112, 35);
            button1.TabIndex = 14;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 197);
            label4.Name = "label4";
            label4.Size = new Size(195, 22);
            label4.TabIndex = 15;
            label4.Text = "Formato de 12 Horas :";
            // 
            // txtFormato12Horas
            // 
            txtFormato12Horas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFormato12Horas.Location = new Point(230, 197);
            txtFormato12Horas.Name = "txtFormato12Horas";
            txtFormato12Horas.Size = new Size(177, 25);
            txtFormato12Horas.TabIndex = 16;
            // 
            // FrmFormatodeHoras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 244);
            Controls.Add(txtFormato12Horas);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtMinuto);
            Controls.Add(txtHora);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFormatodeHoras";
            Text = "FrmFormatodeHoras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHora;
        private TextBox txtMinuto;
        private Button button1;
        private Label label4;
        private TextBox txtFormato12Horas;
    }
}