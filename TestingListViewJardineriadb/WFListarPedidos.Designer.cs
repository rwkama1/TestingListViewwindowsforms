
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
            this.components = new System.ComponentModel.Container();
            this.lstPedidos = new System.Windows.Forms.ListView();
            this.codigopedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoproducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preciounidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numerolinea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListar = new System.Windows.Forms.Button();
            this.cntMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seleccionarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.countproduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cntMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPedidos
            // 
            this.lstPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigopedido,
            this.codigoproducto,
            this.cantidad,
            this.preciounidad,
            this.numerolinea,
            this.countproduct});
            this.lstPedidos.FullRowSelect = true;
            this.lstPedidos.HideSelection = false;
            this.lstPedidos.Location = new System.Drawing.Point(12, 57);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(764, 340);
            this.lstPedidos.TabIndex = 1;
            this.lstPedidos.UseCompatibleStateImageBehavior = false;
            this.lstPedidos.View = System.Windows.Forms.View.Details;
            this.lstPedidos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstPedidos_ColumnClick);
            this.lstPedidos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPedidos_ItemSelectionChanged);
            this.lstPedidos.SelectedIndexChanged += new System.EventHandler(this.lstPedidos_SelectedIndexChanged);
            this.lstPedidos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstPedidos_MouseClick);
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
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(701, 28);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cntMenu
            // 
            this.cntMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarPedidoToolStripMenuItem});
            this.cntMenu.Name = "cntMenu";
            this.cntMenu.Size = new System.Drawing.Size(175, 26);
            // 
            // seleccionarPedidoToolStripMenuItem
            // 
            this.seleccionarPedidoToolStripMenuItem.Name = "seleccionarPedidoToolStripMenuItem";
            this.seleccionarPedidoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.seleccionarPedidoToolStripMenuItem.Text = "Seleccionar Pedido";
            this.seleccionarPedidoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarPedidoToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // countproduct
            // 
            this.countproduct.Text = "Count Producto";
            // 
            // WFListarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.ContextMenuStrip = this.cntMenu;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstPedidos);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "WFListarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WFListarPedidos";
            this.Load += new System.EventHandler(this.WFListarPedidos_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WFListarPedidos_MouseClick);
            this.cntMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cntMenu;
        private System.Windows.Forms.ToolStripMenuItem seleccionarPedidoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader countproduct;
    }
}