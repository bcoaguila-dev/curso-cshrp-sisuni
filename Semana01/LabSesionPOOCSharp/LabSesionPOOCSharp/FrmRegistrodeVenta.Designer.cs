namespace LabSesionPOOCSharp
{
    partial class FrmRegistrodeVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrodeVenta));
            label1 = new Label();
            cboProductos = new ComboBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnNuevo = new Button();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtHora = new TextBox();
            txtFecha = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtPrecio = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox3 = new GroupBox();
            txtTotalventa = new TextBox();
            txtIgv = new TextBox();
            txtSubTotal = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnVerDatos = new Button();
            btnFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(158, 16);
            label1.TabIndex = 0;
            label1.Text = "Seleccione un Producto";
            // 
            // cboProductos
            // 
            cboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(16, 35);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(229, 24);
            cboProductos.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(16, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 87);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 73);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 3;
            label2.Text = "Precio :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(txtDia);
            groupBox1.Controls.Add(txtMes);
            groupBox1.Controls.Add(txtHora);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(cboProductos);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(670, 157);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(388, 101);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(52, 39);
            btnNuevo.TabIndex = 15;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtDia
            // 
            txtDia.BorderStyle = BorderStyle.FixedSingle;
            txtDia.Enabled = false;
            txtDia.Location = new Point(505, 101);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(146, 23);
            txtDia.TabIndex = 14;
            // 
            // txtMes
            // 
            txtMes.BorderStyle = BorderStyle.FixedSingle;
            txtMes.Enabled = false;
            txtMes.Location = new Point(505, 71);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(146, 23);
            txtMes.TabIndex = 13;
            // 
            // txtHora
            // 
            txtHora.BorderStyle = BorderStyle.FixedSingle;
            txtHora.Enabled = false;
            txtHora.Location = new Point(505, 43);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(146, 23);
            txtHora.TabIndex = 12;
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(505, 16);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(146, 23);
            txtFecha.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(465, 105);
            label7.Name = "label7";
            label7.Size = new Size(36, 16);
            label7.TabIndex = 10;
            label7.Text = "Dia :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 76);
            label6.Name = "label6";
            label6.Size = new Size(42, 16);
            label6.TabIndex = 9;
            label6.Text = "Mes :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 47);
            label5.Name = "label5";
            label5.Size = new Size(47, 16);
            label5.TabIndex = 8;
            label5.Text = "Hora :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 18);
            label4.Name = "label4";
            label4.Size = new Size(53, 16);
            label4.TabIndex = 7;
            label4.Text = "Fecha :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(280, 101);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(279, 72);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 104);
            label3.Name = "label3";
            label3.Size = new Size(73, 16);
            label3.TabIndex = 4;
            label3.Text = "Cantidad :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(667, 172);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos Seleccionados";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(568, 112);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(52, 39);
            btnCancelar.TabIndex = 18;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(568, 67);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(52, 39);
            btnEliminar.TabIndex = 17;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(568, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(52, 39);
            btnAgregar.TabIndex = 16;
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.GridLines = true;
            listView1.Location = new Point(10, 19);
            listView1.Name = "listView1";
            listView1.Size = new Size(539, 147);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro";
            columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Productos";
            columnHeader2.Width = 187;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cantidad";
            columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Total";
            columnHeader5.Width = 100;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTotalventa);
            groupBox3.Controls.Add(txtIgv);
            groupBox3.Controls.Add(txtSubTotal);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnVerDatos);
            groupBox3.Controls.Add(btnFinalizar);
            groupBox3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(16, 357);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(666, 117);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Procesos y Calculos";
            // 
            // txtTotalventa
            // 
            txtTotalventa.BorderStyle = BorderStyle.FixedSingle;
            txtTotalventa.Enabled = false;
            txtTotalventa.Location = new Point(451, 77);
            txtTotalventa.Name = "txtTotalventa";
            txtTotalventa.Size = new Size(146, 23);
            txtTotalventa.TabIndex = 25;
            // 
            // txtIgv
            // 
            txtIgv.BorderStyle = BorderStyle.FixedSingle;
            txtIgv.Enabled = false;
            txtIgv.Location = new Point(451, 50);
            txtIgv.Name = "txtIgv";
            txtIgv.Size = new Size(146, 23);
            txtIgv.TabIndex = 24;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubTotal.Enabled = false;
            txtSubTotal.Location = new Point(451, 22);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(146, 23);
            txtSubTotal.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(339, 77);
            label10.Name = "label10";
            label10.Size = new Size(111, 16);
            label10.TabIndex = 22;
            label10.Text = "Total de Venta :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(367, 52);
            label9.Name = "label9";
            label9.Size = new Size(83, 16);
            label9.TabIndex = 21;
            label9.Text = "Igv (18%) :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(374, 27);
            label8.Name = "label8";
            label8.Size = new Size(76, 16);
            label8.TabIndex = 20;
            label8.Text = "Sub Total :";
            // 
            // btnVerDatos
            // 
            btnVerDatos.Image = (Image)resources.GetObject("btnVerDatos.Image");
            btnVerDatos.Location = new Point(85, 54);
            btnVerDatos.Name = "btnVerDatos";
            btnVerDatos.Size = new Size(52, 39);
            btnVerDatos.TabIndex = 19;
            btnVerDatos.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Image = (Image)resources.GetObject("btnFinalizar.Image");
            btnFinalizar.Location = new Point(27, 54);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(52, 39);
            btnFinalizar.TabIndex = 18;
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrodeVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(702, 503);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmRegistrodeVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cboProductos;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtHora;
        private TextBox txtFecha;
        private Button btnNuevo;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnAgregar;
        private GroupBox groupBox3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnVerDatos;
        private Button btnFinalizar;
        private TextBox txtTotalventa;
        private TextBox txtIgv;
        private TextBox txtSubTotal;
    }
}