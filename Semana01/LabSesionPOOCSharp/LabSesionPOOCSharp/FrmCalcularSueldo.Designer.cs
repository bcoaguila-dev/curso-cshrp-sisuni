namespace LabSesionPOOCSharp
{
    partial class FrmCalcularSueldo
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtFechaPago = new MaskedTextBox();
            groupBox1 = new GroupBox();
            rbC = new RadioButton();
            rbB = new RadioButton();
            rbA = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            txtsueldo = new TextBox();
            groupBox2 = new GroupBox();
            rbONP = new RadioButton();
            rbHabitat = new RadioButton();
            rbProfuturo = new RadioButton();
            label6 = new Label();
            txtpension = new TextBox();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            label8 = new Label();
            txtbonificacion = new TextBox();
            btnprocesarsueldoneto = new Button();
            txtsueldoneto = new TextBox();
            btnNuevocalculo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(513, 29);
            label1.TabIndex = 0;
            label1.Text = "CALCULANDO EL SUELDO DEL EMPLEADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 59);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(26, 81);
            listView1.Name = "listView1";
            listView1.Size = new Size(261, 122);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Empleados";
            columnHeader2.Width = 250;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(328, 60);
            label3.Name = "label3";
            label3.Size = new Size(41, 18);
            label3.TabIndex = 3;
            label3.Text = "Foto";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(328, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 122);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtFechaPago
            // 
            txtFechaPago.Location = new Point(156, 215);
            txtFechaPago.Mask = "00/00/0000";
            txtFechaPago.Name = "txtFechaPago";
            txtFechaPago.Size = new Size(88, 23);
            txtFechaPago.TabIndex = 6;
            txtFechaPago.ValidatingType = typeof(DateTime);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbC);
            groupBox1.Controls.Add(rbB);
            groupBox1.Controls.Add(rbA);
            groupBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(26, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 57);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Elegir Categoria";
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.Location = new Point(98, 29);
            rbC.Name = "rbC";
            rbC.Size = new Size(36, 22);
            rbC.TabIndex = 2;
            rbC.TabStop = true;
            rbC.Text = "C";
            rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.Location = new Point(56, 29);
            rbB.Name = "rbB";
            rbB.Size = new Size(36, 22);
            rbB.TabIndex = 1;
            rbB.TabStop = true;
            rbB.Text = "B";
            rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.Location = new Point(9, 29);
            rbA.Name = "rbA";
            rbA.Size = new Size(36, 22);
            rbA.TabIndex = 0;
            rbA.TabStop = true;
            rbA.Text = "A";
            rbA.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 215);
            label4.Name = "label4";
            label4.Size = new Size(124, 18);
            label4.TabIndex = 5;
            label4.Text = "Fecha de Pago :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(219, 275);
            label5.Name = "label5";
            label5.Size = new Size(68, 18);
            label5.TabIndex = 8;
            label5.Text = "Sueldo :";
            // 
            // txtsueldo
            // 
            txtsueldo.BorderStyle = BorderStyle.FixedSingle;
            txtsueldo.Location = new Point(289, 273);
            txtsueldo.Name = "txtsueldo";
            txtsueldo.Size = new Size(134, 23);
            txtsueldo.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbONP);
            groupBox2.Controls.Add(rbHabitat);
            groupBox2.Controls.Add(rbProfuturo);
            groupBox2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(26, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 57);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Elegir Sistema de Pension";
            // 
            // rbONP
            // 
            rbONP.AutoSize = true;
            rbONP.Location = new Point(200, 29);
            rbONP.Name = "rbONP";
            rbONP.Size = new Size(60, 22);
            rbONP.TabIndex = 2;
            rbONP.TabStop = true;
            rbONP.Tag = "O";
            rbONP.Text = "ONP";
            rbONP.UseVisualStyleBackColor = true;
            // 
            // rbHabitat
            // 
            rbHabitat.AutoSize = true;
            rbHabitat.Location = new Point(113, 29);
            rbHabitat.Name = "rbHabitat";
            rbHabitat.Size = new Size(81, 22);
            rbHabitat.TabIndex = 1;
            rbHabitat.TabStop = true;
            rbHabitat.Tag = "H";
            rbHabitat.Text = "Habitat";
            rbHabitat.UseVisualStyleBackColor = true;
            // 
            // rbProfuturo
            // 
            rbProfuturo.AutoSize = true;
            rbProfuturo.Location = new Point(9, 29);
            rbProfuturo.Name = "rbProfuturo";
            rbProfuturo.Size = new Size(98, 22);
            rbProfuturo.TabIndex = 0;
            rbProfuturo.TabStop = true;
            rbProfuturo.Tag = "P";
            rbProfuturo.Text = "Profuturo";
            rbProfuturo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(328, 317);
            label6.Name = "label6";
            label6.Size = new Size(95, 18);
            label6.TabIndex = 11;
            label6.Text = "Pension S/.";
            // 
            // txtpension
            // 
            txtpension.BorderStyle = BorderStyle.FixedSingle;
            txtpension.Location = new Point(315, 340);
            txtpension.Name = "txtpension";
            txtpension.Size = new Size(134, 23);
            txtpension.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 381);
            label7.Name = "label7";
            label7.Size = new Size(109, 18);
            label7.TabIndex = 13;
            label7.Text = "Nro de Hijos :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(142, 379);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(57, 26);
            numericUpDown1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(212, 381);
            label8.Name = "label8";
            label8.Size = new Size(109, 18);
            label8.TabIndex = 15;
            label8.Text = "Bonificacion :";
            // 
            // txtbonificacion
            // 
            txtbonificacion.BorderStyle = BorderStyle.FixedSingle;
            txtbonificacion.Location = new Point(328, 379);
            txtbonificacion.Name = "txtbonificacion";
            txtbonificacion.Size = new Size(134, 23);
            txtbonificacion.TabIndex = 16;
            // 
            // btnprocesarsueldoneto
            // 
            btnprocesarsueldoneto.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnprocesarsueldoneto.Location = new Point(82, 434);
            btnprocesarsueldoneto.Name = "btnprocesarsueldoneto";
            btnprocesarsueldoneto.Size = new Size(191, 30);
            btnprocesarsueldoneto.TabIndex = 17;
            btnprocesarsueldoneto.Text = "Procesar Sueldo Neto";
            btnprocesarsueldoneto.UseVisualStyleBackColor = true;
            // 
            // txtsueldoneto
            // 
            txtsueldoneto.BorderStyle = BorderStyle.FixedSingle;
            txtsueldoneto.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtsueldoneto.Location = new Point(289, 441);
            txtsueldoneto.Name = "txtsueldoneto";
            txtsueldoneto.Size = new Size(151, 23);
            txtsueldoneto.TabIndex = 18;
            // 
            // btnNuevocalculo
            // 
            btnNuevocalculo.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevocalculo.Location = new Point(26, 485);
            btnNuevocalculo.Name = "btnNuevocalculo";
            btnNuevocalculo.Size = new Size(161, 30);
            btnNuevocalculo.TabIndex = 19;
            btnNuevocalculo.Text = "Nuevo Calculo";
            btnNuevocalculo.UseVisualStyleBackColor = true;
            // 
            // FrmCalcularSueldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 528);
            Controls.Add(btnNuevocalculo);
            Controls.Add(txtsueldoneto);
            Controls.Add(btnprocesarsueldoneto);
            Controls.Add(txtbonificacion);
            Controls.Add(label8);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(txtpension);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(txtsueldo);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(txtFechaPago);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCalcularSueldo";
            Text = "FrmCalcularSueldo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label3;
        private PictureBox pictureBox1;
        private MaskedTextBox txtFechaPago;
        private GroupBox groupBox1;
        private RadioButton rbC;
        private RadioButton rbB;
        private RadioButton rbA;
        private Label label4;
        private Label label5;
        private TextBox txtsueldo;
        private GroupBox groupBox2;
        private RadioButton rbONP;
        private RadioButton rbHabitat;
        private RadioButton rbProfuturo;
        private Label label6;
        private TextBox txtpension;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private TextBox txtbonificacion;
        private Button btnprocesarsueldoneto;
        private TextBox txtsueldoneto;
        private Button btnNuevocalculo;
    }
}