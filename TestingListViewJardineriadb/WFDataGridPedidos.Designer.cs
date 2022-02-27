
namespace TestingListViewJardineriadb
{
    partial class WFDataGridPedidos
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colenvase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colimporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltro1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpFiltro2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpFiltro1.SuspendLayout();
            this.grpFiltro2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colproducto,
            this.colenvase,
            this.colcodigo,
            this.colcant,
            this.colprecio,
            this.colimporte});
            this.dgvProductos.Location = new System.Drawing.Point(12, 163);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.Size = new System.Drawing.Size(896, 310);
            this.dgvProductos.TabIndex = 4;
            // 
            // colproducto
            // 
            this.colproducto.HeaderText = "Producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.ReadOnly = true;
            // 
            // colenvase
            // 
            this.colenvase.HeaderText = "Envase";
            this.colenvase.Name = "colenvase";
            this.colenvase.ReadOnly = true;
            // 
            // colcodigo
            // 
            this.colcodigo.HeaderText = "Codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.ReadOnly = true;
            // 
            // colcant
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.colcant.DefaultCellStyle = dataGridViewCellStyle1;
            this.colcant.HeaderText = "Cantidad";
            this.colcant.Name = "colcant";
            // 
            // colprecio
            // 
            this.colprecio.HeaderText = "Precio";
            this.colprecio.Name = "colprecio";
            // 
            // colimporte
            // 
            this.colimporte.HeaderText = "Importe";
            this.colimporte.Name = "colimporte";
            // 
            // grpFiltro1
            // 
            this.grpFiltro1.Controls.Add(this.textBox1);
            this.grpFiltro1.Location = new System.Drawing.Point(12, 12);
            this.grpFiltro1.Name = "grpFiltro1";
            this.grpFiltro1.Size = new System.Drawing.Size(273, 63);
            this.grpFiltro1.TabIndex = 0;
            this.grpFiltro1.TabStop = false;
            this.grpFiltro1.Text = "Filtro 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // grpFiltro2
            // 
            this.grpFiltro2.Controls.Add(this.textBox3);
            this.grpFiltro2.Location = new System.Drawing.Point(12, 81);
            this.grpFiltro2.Name = "grpFiltro2";
            this.grpFiltro2.Size = new System.Drawing.Size(273, 63);
            this.grpFiltro2.TabIndex = 2;
            this.grpFiltro2.TabStop = false;
            this.grpFiltro2.Text = "Filtro 2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "0";
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(305, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "0";
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(305, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro 1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(833, 508);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TOTAL: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(830, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // WFDataGridPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFiltro2);
            this.Controls.Add(this.grpFiltro1);
            this.Controls.Add(this.dgvProductos);
            this.Name = "WFDataGridPedidos";
            this.Text = "WFDataGridPedidos";
            this.Load += new System.EventHandler(this.WFDataGridPedidos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WFDataGridPedidos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpFiltro1.ResumeLayout(false);
            this.grpFiltro1.PerformLayout();
            this.grpFiltro2.ResumeLayout(false);
            this.grpFiltro2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox grpFiltro1;
        private System.Windows.Forms.GroupBox grpFiltro2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colenvase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colimporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}