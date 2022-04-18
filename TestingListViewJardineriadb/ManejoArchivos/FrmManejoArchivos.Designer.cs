
namespace TestingListViewJardineriadb.ManejoArchivos
{
    partial class FrmManejoArchivos
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
            this.btnCopiarArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopiarArchivo
            // 
            this.btnCopiarArchivo.Location = new System.Drawing.Point(27, 12);
            this.btnCopiarArchivo.Name = "btnCopiarArchivo";
            this.btnCopiarArchivo.Size = new System.Drawing.Size(117, 23);
            this.btnCopiarArchivo.TabIndex = 2;
            this.btnCopiarArchivo.Text = "Copiar Archivo";
            this.btnCopiarArchivo.UseVisualStyleBackColor = true;
            this.btnCopiarArchivo.Click += new System.EventHandler(this.btnCopiarArchivo_Click);
            // 
            // FrmManejoArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 44);
            this.Controls.Add(this.btnCopiarArchivo);
            this.Name = "FrmManejoArchivos";
            this.Text = "Manejo de Archivos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCopiarArchivo;
    }
}