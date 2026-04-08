namespace LabWindows
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboTrabajador = new ComboBox();
            TxtSueldoBasico = new TextBox();
            TxtAumento = new TextBox();
            TxtNuevoSueldo = new TextBox();
            btnNuevo = new Button();
            btnCalcular = new Button();
            btnFinalizar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 106);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 0;
            label1.Text = "Trabajador:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 143);
            label2.Name = "label2";
            label2.Size = new Size(114, 19);
            label2.TabIndex = 1;
            label2.Text = "Sueldo Base:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 305);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 2;
            label3.Text = "Aumento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(98, 336);
            label4.Name = "label4";
            label4.Size = new Size(126, 19);
            label4.TabIndex = 3;
            label4.Text = "Nuevo Sueldo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(276, 27);
            label5.Name = "label5";
            label5.Size = new Size(202, 23);
            label5.TabIndex = 4;
            label5.Text = "Pago del Trabajador";
            label5.Click += label5_Click;
            // 
            // cboTrabajador
            // 
            cboTrabajador.FormattingEnabled = true;
            cboTrabajador.Location = new Point(259, 102);
            cboTrabajador.Name = "cboTrabajador";
            cboTrabajador.Size = new Size(274, 23);
            cboTrabajador.TabIndex = 5;
            // 
            // TxtSueldoBasico
            // 
            TxtSueldoBasico.BorderStyle = BorderStyle.FixedSingle;
            TxtSueldoBasico.Location = new Point(259, 143);
            TxtSueldoBasico.Name = "TxtSueldoBasico";
            TxtSueldoBasico.Size = new Size(214, 23);
            TxtSueldoBasico.TabIndex = 6;
            TxtSueldoBasico.KeyPress += TxtSueldoBasico_KeyPress;
            // 
            // TxtAumento
            // 
            TxtAumento.BorderStyle = BorderStyle.FixedSingle;
            TxtAumento.Enabled = false;
            TxtAumento.Location = new Point(259, 301);
            TxtAumento.Name = "TxtAumento";
            TxtAumento.Size = new Size(219, 23);
            TxtAumento.TabIndex = 7;
            TxtAumento.TextChanged += TxtAumento_TextChanged;
            // 
            // TxtNuevoSueldo
            // 
            TxtNuevoSueldo.BorderStyle = BorderStyle.FixedSingle;
            TxtNuevoSueldo.Enabled = false;
            TxtNuevoSueldo.Location = new Point(259, 337);
            TxtNuevoSueldo.Name = "TxtNuevoSueldo";
            TxtNuevoSueldo.Size = new Size(219, 23);
            TxtNuevoSueldo.TabIndex = 8;
            TxtNuevoSueldo.TextChanged += TxtNuevoSueldo_TextChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(193, 223);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(91, 29);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(328, 223);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(91, 29);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.Location = new Point(468, 223);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(91, 29);
            btnFinalizar.TabIndex = 11;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCalcular);
            Controls.Add(btnNuevo);
            Controls.Add(TxtNuevoSueldo);
            Controls.Add(TxtAumento);
            Controls.Add(TxtSueldoBasico);
            Controls.Add(cboTrabajador);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboTrabajador;
        private TextBox TxtSueldoBasico;
        private TextBox TxtAumento;
        private TextBox TxtNuevoSueldo;
        private Button btnNuevo;
        private Button btnCalcular;
        private Button btnFinalizar;
        private ErrorProvider errorProvider1;
    }
}
