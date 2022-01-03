
namespace TestingListViewJardineriadb
{
    partial class WFListarPedidos
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
            this.lstPedidos = new System.Windows.Forms.ListView();
            this.codigopedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoproducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preciounidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numerolinea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPedidos
            // 
            this.lstPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigopedido,
            this.codigoproducto,
            this.cantidad,
            this.preciounidad,
            this.numerolinea});
            this.lstPedidos.HideSelection = false;
            this.lstPedidos.Location = new System.Drawing.Point(12, 57);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(764, 390);
            this.lstPedidos.TabIndex = 0;
            this.lstPedidos.UseCompatibleStateImageBehavior = false;
            this.lstPedidos.View = System.Windows.Forms.View.Details;
            this.lstPedidos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstPedidos_ColumnClick);
            // 
            // codigopedido
            // 
            this.codigopedido.Text = "Codigo Pedido";
            this.codigopedido.Width = 100;
            // 
            // codigoproducto
            // 
            this.codigoproducto.Text = "Codigo Producto";
            this.codigoproducto.Width = 100;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.Width = 100;
            // 
            // preciounidad
            // 
            this.preciounidad.Text = "Precio Unidad";
            this.preciounidad.Width = 100;
            // 
            // numerolinea
            // 
            this.numerolinea.Text = "Numero Linea";
            this.numerolinea.Width = 100;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(713, 28);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // WFListarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstPedidos);
            this.Name = "WFListarPedidos";
            this.Text = "WFListarPedidos";
            this.Load += new System.EventHandler(this.WFListarPedidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPedidos;
        private System.Windows.Forms.ColumnHeader codigopedido;
        private System.Windows.Forms.ColumnHeader codigoproducto;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.ColumnHeader preciounidad;
        private System.Windows.Forms.ColumnHeader numerolinea;
        private System.Windows.Forms.Button btnListar;
    }
}