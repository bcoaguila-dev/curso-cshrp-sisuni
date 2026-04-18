namespace LabSesionPOOCSharp
{
    partial class FrmVentaLibros
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
            txtTitulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPrecio = new TextBox();
            txtImporte = new TextBox();
            txtDescuento = new TextBox();
            txtIgv = new TextBox();
            txtTotal = new TextBox();
            groupBox1 = new GroupBox();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            chkOferta = new CheckBox();
            chkIgv = new CheckBox();
            btnCalcular = new Button();
            btnFinalizar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(150, 27);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(265, 23);
            txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 18);
            label1.TabIndex = 2;
            label1.Text = "Titulo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 57);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 3;
            label2.Text = "Precio :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 84);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 4;
            label3.Text = "Importe :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 114);
            label4.Name = "label4";
            label4.Size = new Size(95, 18);
            label4.TabIndex = 5;
            label4.Text = "Descuento :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 145);
            label5.Name = "label5";
            label5.Size = new Size(94, 18);
            label5.TabIndex = 6;
            label5.Text = "Igv(18%) :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(89, 173);
            label6.Name = "label6";
            label6.Size = new Size(55, 18);
            label6.TabIndex = 7;
            label6.Text = "Total :";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(150, 56);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtImporte
            // 
            txtImporte.BorderStyle = BorderStyle.FixedSingle;
            txtImporte.Enabled = false;
            txtImporte.Location = new Point(150, 85);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(110, 23);
            txtImporte.TabIndex = 9;
            // 
            // txtDescuento
            // 
            txtDescuento.BorderStyle = BorderStyle.FixedSingle;
            txtDescuento.Enabled = false;
            txtDescuento.Location = new Point(150, 114);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(110, 23);
            txtDescuento.TabIndex = 10;
            // 
            // txtIgv
            // 
            txtIgv.BorderStyle = BorderStyle.FixedSingle;
            txtIgv.Enabled = false;
            txtIgv.Location = new Point(150, 145);
            txtIgv.Name = "txtIgv";
            txtIgv.Size = new Size(110, 23);
            txtIgv.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(150, 174);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(110, 23);
            txtTotal.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb4);
            groupBox1.Controls.Add(rb3);
            groupBox1.Controls.Add(rb2);
            groupBox1.Controls.Add(rb1);
            groupBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(318, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 49);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ejemplares";
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(145, 23);
            rb4.Name = "rb4";
            rb4.Size = new Size(36, 22);
            rb4.TabIndex = 15;
            rb4.TabStop = true;
            rb4.Text = "4";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(103, 23);
            rb3.Name = "rb3";
            rb3.Size = new Size(36, 22);
            rb3.TabIndex = 14;
            rb3.TabStop = true;
            rb3.Text = "3";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(61, 23);
            rb2.Name = "rb2";
            rb2.Size = new Size(36, 22);
            rb2.TabIndex = 1;
            rb2.TabStop = true;
            rb2.Text = "2";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(19, 23);
            rb1.Name = "rb1";
            rb1.Size = new Size(36, 22);
            rb1.TabIndex = 0;
            rb1.TabStop = true;
            rb1.Text = "1";
            rb1.UseVisualStyleBackColor = true;
            // 
            // chkOferta
            // 
            chkOferta.AutoSize = true;
            chkOferta.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkOferta.Location = new Point(325, 124);
            chkOferta.Name = "chkOferta";
            chkOferta.Size = new Size(234, 22);
            chkOferta.TabIndex = 14;
            chkOferta.Text = "Oferta (10% de descuento)";
            chkOferta.UseVisualStyleBackColor = true;
            // 
            // chkIgv
            // 
            chkIgv.AutoSize = true;
            chkIgv.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkIgv.Location = new Point(325, 152);
            chkIgv.Name = "chkIgv";
            chkIgv.Size = new Size(112, 22);
            chkIgv.TabIndex = 15;
            chkIgv.Text = "Aplicar IGV";
            chkIgv.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            btnCalcular.Location = new Point(302, 190);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 27);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            btnFinalizar.Location = new Point(400, 190);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(82, 27);
            btnFinalizar.TabIndex = 17;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // FrmVentaLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(605, 231);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCalcular);
            Controls.Add(chkIgv);
            Controls.Add(chkOferta);
            Controls.Add(groupBox1);
            Controls.Add(txtTotal);
            Controls.Add(txtIgv);
            Controls.Add(txtDescuento);
            Controls.Add(txtImporte);
            Controls.Add(txtPrecio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Name = "FrmVentaLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVentaLibros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPrecio;
        private TextBox txtImporte;
        private TextBox txtDescuento;
        private TextBox txtIgv;
        private TextBox txtTotal;
        private GroupBox groupBox1;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private CheckBox chkOferta;
        private CheckBox chkIgv;
        private Button btnCalcular;
        private Button btnFinalizar;
    }
}