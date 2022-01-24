
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigopedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcodigoproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprecunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnumerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigopedido,
            this.colcodigoproducto,
            this.colcant,
            this.colprecunidad,
            this.colnumerolinea});
            this.dataGridView1.Location = new System.Drawing.Point(35, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(694, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigopedido
            // 
            this.codigopedido.HeaderText = "Codigo Pedido";
            this.codigopedido.Name = "codigopedido";
            this.codigopedido.ReadOnly = true;
            // 
            // colcodigoproducto
            // 
            this.colcodigoproducto.HeaderText = "Codigo Producto";
            this.colcodigoproducto.Name = "colcodigoproducto";
            this.colcodigoproducto.ReadOnly = true;
            // 
            // colcant
            // 
            this.colcant.HeaderText = "Cantidad";
            this.colcant.Name = "colcant";
            this.colcant.ReadOnly = true;
            // 
            // colprecunidad
            // 
            this.colprecunidad.HeaderText = "Precio Unidad";
            this.colprecunidad.Name = "colprecunidad";
            this.colprecunidad.ReadOnly = true;
            // 
            // colnumerolinea
            // 
            this.colnumerolinea.HeaderText = "Numero Linea";
            this.colnumerolinea.Name = "colnumerolinea";
            this.colnumerolinea.ReadOnly = true;
            // 
            // WFDataGridPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WFDataGridPedidos";
            this.Text = "WFDataGridPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcodigoproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprecunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnumerolinea;
    }
}