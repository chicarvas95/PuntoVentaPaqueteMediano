
namespace CursoPuntoDeVentasTresCapas
{
    partial class FrmVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvProductos = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_TotalVenta = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btn_Cobrar = new System.Windows.Forms.Button();
            this.btnReporteDelDia = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_EliminarProducto = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_AltaProductos = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.txt_CodigoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.gvProductos);
            this.groupBox1.Location = new System.Drawing.Point(13, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gvProductos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.Precio,
            this.Col_importe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvProductos.EnableHeadersVisualStyles = false;
            this.gvProductos.Location = new System.Drawing.Point(6, 12);
            this.gvProductos.Name = "gvProductos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvProductos.RowTemplate.Height = 40;
            this.gvProductos.Size = new System.Drawing.Size(587, 508);
            this.gvProductos.TabIndex = 0;
            this.gvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductos_CellDoubleClick);
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 280;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Col_importe
            // 
            this.Col_importe.HeaderText = "Importe";
            this.Col_importe.Name = "Col_importe";
            this.Col_importe.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lbl_precio);
            this.groupBox2.Location = new System.Drawing.Point(237, 642);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_precio.Location = new System.Drawing.Point(180, 16);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(29, 31);
            this.lbl_precio.TabIndex = 0;
            this.lbl_precio.Text = "$";
            // 
            // lbl_TotalVenta
            // 
            this.lbl_TotalVenta.AutoSize = true;
            this.lbl_TotalVenta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalVenta.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalVenta.Location = new System.Drawing.Point(437, 615);
            this.lbl_TotalVenta.Name = "lbl_TotalVenta";
            this.lbl_TotalVenta.Size = new System.Drawing.Size(163, 25);
            this.lbl_TotalVenta.TabIndex = 2;
            this.lbl_TotalVenta.Text = "Total de la Venta:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(634, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 589);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox5.Controls.Add(this.Btn_Cobrar);
            this.groupBox5.Controls.Add(this.btnReporteDelDia);
            this.groupBox5.Controls.Add(this.btn_buscar);
            this.groupBox5.Controls.Add(this.btn_EliminarProducto);
            this.groupBox5.Controls.Add(this.btn_borrar);
            this.groupBox5.Controls.Add(this.btn_AltaProductos);
            this.groupBox5.Controls.Add(this.btn_0);
            this.groupBox5.Controls.Add(this.btn_1);
            this.groupBox5.Controls.Add(this.btn_9);
            this.groupBox5.Controls.Add(this.btn_8);
            this.groupBox5.Controls.Add(this.btn_3);
            this.groupBox5.Controls.Add(this.btn_2);
            this.groupBox5.Controls.Add(this.btn_7);
            this.groupBox5.Controls.Add(this.btn_4);
            this.groupBox5.Controls.Add(this.btn_6);
            this.groupBox5.Controls.Add(this.btn_5);
            this.groupBox5.Location = new System.Drawing.Point(7, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(311, 572);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // Btn_Cobrar
            // 
            this.Btn_Cobrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cobrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Cobrar.Location = new System.Drawing.Point(110, 481);
            this.Btn_Cobrar.Name = "Btn_Cobrar";
            this.Btn_Cobrar.Size = new System.Drawing.Size(93, 85);
            this.Btn_Cobrar.TabIndex = 13;
            this.Btn_Cobrar.Text = "COBRAR";
            this.Btn_Cobrar.UseVisualStyleBackColor = false;
            this.Btn_Cobrar.Click += new System.EventHandler(this.Btn_Cobrar_Click);
            // 
            // btnReporteDelDia
            // 
            this.btnReporteDelDia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReporteDelDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteDelDia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporteDelDia.Location = new System.Drawing.Point(209, 391);
            this.btnReporteDelDia.Name = "btnReporteDelDia";
            this.btnReporteDelDia.Size = new System.Drawing.Size(93, 84);
            this.btnReporteDelDia.TabIndex = 15;
            this.btnReporteDelDia.Text = "REPORTE DIARIO DE VENTAS";
            this.btnReporteDelDia.UseVisualStyleBackColor = false;
            this.btnReporteDelDia.Click += new System.EventHandler(this.btnReporteDelDia_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscar.Location = new System.Drawing.Point(11, 297);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(93, 88);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_EliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EliminarProducto.Location = new System.Drawing.Point(110, 391);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(93, 84);
            this.btn_EliminarProducto.TabIndex = 15;
            this.btn_EliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.btn_EliminarProducto.UseVisualStyleBackColor = false;
            this.btn_EliminarProducto.Click += new System.EventHandler(this.btn_EliminarProducto_Click_1);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_borrar.Location = new System.Drawing.Point(209, 297);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(93, 88);
            this.btn_borrar.TabIndex = 10;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_AltaProductos
            // 
            this.btn_AltaProductos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_AltaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AltaProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AltaProductos.Location = new System.Drawing.Point(11, 391);
            this.btn_AltaProductos.Name = "btn_AltaProductos";
            this.btn_AltaProductos.Size = new System.Drawing.Size(93, 85);
            this.btn_AltaProductos.TabIndex = 14;
            this.btn_AltaProductos.Text = "ALTA DE PRODUCTOS";
            this.btn_AltaProductos.UseVisualStyleBackColor = false;
            this.btn_AltaProductos.Click += new System.EventHandler(this.btn_AltaProductos_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_0.Location = new System.Drawing.Point(110, 297);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(93, 88);
            this.btn_0.TabIndex = 9;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_1.Location = new System.Drawing.Point(11, 203);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(93, 88);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_9.Location = new System.Drawing.Point(209, 15);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(93, 88);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_8.Location = new System.Drawing.Point(110, 15);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(93, 88);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_3.Location = new System.Drawing.Point(209, 203);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(93, 88);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_2.Location = new System.Drawing.Point(110, 203);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(93, 88);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_7.Location = new System.Drawing.Point(10, 15);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(93, 88);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_4.Location = new System.Drawing.Point(11, 109);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(93, 88);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_6.Location = new System.Drawing.Point(209, 109);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(93, 88);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_5.Location = new System.Drawing.Point(110, 109);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(93, 88);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // txt_CodigoProducto
            // 
            this.txt_CodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoProducto.Location = new System.Drawing.Point(13, 61);
            this.txt_CodigoProducto.MaxLength = 13;
            this.txt_CodigoProducto.Name = "txt_CodigoProducto";
            this.txt_CodigoProducto.Size = new System.Drawing.Size(316, 35);
            this.txt_CodigoProducto.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo de producto";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1343, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CodigoProducto);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbl_TotalVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_TotalVenta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_CodigoProducto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView gvProductos;
        private System.Windows.Forms.Button Btn_Cobrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AltaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_importe;
        private System.Windows.Forms.Button btnReporteDelDia;
        private System.Windows.Forms.Button btn_EliminarProducto;
    }
}

