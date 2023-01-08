
namespace CursoPuntoDeVentasTresCapas
{
    partial class FrmAgregarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProducto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CantidadInventario = new System.Windows.Forms.TextBox();
            this.txt_PrecioUnitario = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.txt_CodigoProducto = new System.Windows.Forms.TextBox();
            this.lbl_CantidadInventario = new System.Windows.Forms.Label();
            this.lbl_PrecioUnitario = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lbl_CodigoProducto = new System.Windows.Forms.Label();
            this.btn_GuardarProductos = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumPrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidadInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btn_actualizar);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.txt_CantidadInventario);
            this.groupBox1.Controls.Add(this.btn_GuardarProductos);
            this.groupBox1.Controls.Add(this.txt_PrecioUnitario);
            this.groupBox1.Controls.Add(this.txt_NombreProducto);
            this.groupBox1.Controls.Add(this.txt_CodigoProducto);
            this.groupBox1.Controls.Add(this.lbl_CantidadInventario);
            this.groupBox1.Controls.Add(this.lbl_PrecioUnitario);
            this.groupBox1.Controls.Add(this.lblNombreProducto);
            this.groupBox1.Controls.Add(this.lbl_CodigoProducto);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(179, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa la informacion del nuevo producto";
            // 
            // txt_CantidadInventario
            // 
            this.txt_CantidadInventario.Location = new System.Drawing.Point(593, 106);
            this.txt_CantidadInventario.MaxLength = 9;
            this.txt_CantidadInventario.Name = "txt_CantidadInventario";
            this.txt_CantidadInventario.Size = new System.Drawing.Size(188, 29);
            this.txt_CantidadInventario.TabIndex = 7;
            this.txt_CantidadInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadInventario_KeyPress);
            // 
            // txt_PrecioUnitario
            // 
            this.txt_PrecioUnitario.Location = new System.Drawing.Point(211, 106);
            this.txt_PrecioUnitario.MaxLength = 9;
            this.txt_PrecioUnitario.Name = "txt_PrecioUnitario";
            this.txt_PrecioUnitario.Size = new System.Drawing.Size(188, 29);
            this.txt_PrecioUnitario.TabIndex = 6;
            this.txt_PrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioUnitario_KeyPress);
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Location = new System.Drawing.Point(594, 57);
            this.txt_NombreProducto.MaxLength = 20;
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(188, 29);
            this.txt_NombreProducto.TabIndex = 5;
            this.txt_NombreProducto.TextChanged += new System.EventHandler(this.txt_NombreProducto_TextChanged);
            this.txt_NombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProducto_KeyPress);
            // 
            // txt_CodigoProducto
            // 
            this.txt_CodigoProducto.Location = new System.Drawing.Point(212, 54);
            this.txt_CodigoProducto.MaxLength = 13;
            this.txt_CodigoProducto.Name = "txt_CodigoProducto";
            this.txt_CodigoProducto.Size = new System.Drawing.Size(188, 29);
            this.txt_CodigoProducto.TabIndex = 4;
            this.txt_CodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProducto_KeyPress);
            // 
            // lbl_CantidadInventario
            // 
            this.lbl_CantidadInventario.AutoSize = true;
            this.lbl_CantidadInventario.Location = new System.Drawing.Point(416, 109);
            this.lbl_CantidadInventario.Name = "lbl_CantidadInventario";
            this.lbl_CantidadInventario.Size = new System.Drawing.Size(170, 21);
            this.lbl_CantidadInventario.TabIndex = 3;
            this.lbl_CantidadInventario.Text = "Cantidad en inventario:";
            // 
            // lbl_PrecioUnitario
            // 
            this.lbl_PrecioUnitario.AutoSize = true;
            this.lbl_PrecioUnitario.Location = new System.Drawing.Point(35, 109);
            this.lbl_PrecioUnitario.Name = "lbl_PrecioUnitario";
            this.lbl_PrecioUnitario.Size = new System.Drawing.Size(114, 21);
            this.lbl_PrecioUnitario.TabIndex = 2;
            this.lbl_PrecioUnitario.Text = "Precio unitario:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(418, 60);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(163, 21);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre del producto:";
            // 
            // lbl_CodigoProducto
            // 
            this.lbl_CodigoProducto.AutoSize = true;
            this.lbl_CodigoProducto.Location = new System.Drawing.Point(36, 57);
            this.lbl_CodigoProducto.Name = "lbl_CodigoProducto";
            this.lbl_CodigoProducto.Size = new System.Drawing.Size(155, 21);
            this.lbl_CodigoProducto.TabIndex = 0;
            this.lbl_CodigoProducto.Text = "Codigo del producto:";
            // 
            // btn_GuardarProductos
            // 
            this.btn_GuardarProductos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_GuardarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GuardarProductos.Location = new System.Drawing.Point(52, 166);
            this.btn_GuardarProductos.Name = "btn_GuardarProductos";
            this.btn_GuardarProductos.Size = new System.Drawing.Size(128, 37);
            this.btn_GuardarProductos.TabIndex = 15;
            this.btn_GuardarProductos.Text = "GUARDAR";
            this.btn_GuardarProductos.UseVisualStyleBackColor = false;
            this.btn_GuardarProductos.Click += new System.EventHandler(this.btn_GuardarProductos_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(494, 166);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(128, 37);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "REGRESAR";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_actualizar.Location = new System.Drawing.Point(201, 166);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(128, 37);
            this.btn_actualizar.TabIndex = 18;
            this.btn_actualizar.Text = "ACTUALIZAR";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(346, 166);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(128, 37);
            this.btn_Eliminar.TabIndex = 19;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNombreProducto,
            this.ColumPrecioProducto,
            this.ColumnCantidadInventario,
            this.ColumnCodigoProducto,
            this.ColumnFechaRegistro});
            this.dataGridView1.Location = new System.Drawing.Point(179, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(967, 312);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // ColumNombreProducto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumNombreProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumNombreProducto.HeaderText = "Nombre Producto";
            this.ColumNombreProducto.Name = "ColumNombreProducto";
            this.ColumNombreProducto.Width = 200;
            // 
            // ColumPrecioProducto
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumPrecioProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumPrecioProducto.HeaderText = "Precio Producto";
            this.ColumPrecioProducto.Name = "ColumPrecioProducto";
            // 
            // ColumnCantidadInventario
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnCantidadInventario.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnCantidadInventario.HeaderText = "Cantidad Inventario";
            this.ColumnCantidadInventario.Name = "ColumnCantidadInventario";
            // 
            // ColumnCodigoProducto
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnCodigoProducto.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnCodigoProducto.HeaderText = "Codigo Producto";
            this.ColumnCodigoProducto.Name = "ColumnCodigoProducto";
            this.ColumnCodigoProducto.Width = 300;
            // 
            // ColumnFechaRegistro
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnFechaRegistro.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnFechaRegistro.HeaderText = "Fecha Registro";
            this.ColumnFechaRegistro.Name = "ColumnFechaRegistro";
            this.ColumnFechaRegistro.Width = 220;
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1263, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAgregarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CantidadInventario;
        private System.Windows.Forms.TextBox txt_PrecioUnitario;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.TextBox txt_CodigoProducto;
        private System.Windows.Forms.Label lbl_CantidadInventario;
        private System.Windows.Forms.Label lbl_PrecioUnitario;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lbl_CodigoProducto;
        private System.Windows.Forms.Button btn_GuardarProductos;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidadInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaRegistro;
    }
}