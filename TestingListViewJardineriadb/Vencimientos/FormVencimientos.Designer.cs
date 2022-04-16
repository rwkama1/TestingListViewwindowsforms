
namespace TestingListViewJardineriadb.Vencimientos
{
    partial class FormVencimientos
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
            this.btnVenc = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVenc
            // 
            this.btnVenc.Location = new System.Drawing.Point(12, 59);
            this.btnVenc.Name = "btnVenc";
            this.btnVenc.Size = new System.Drawing.Size(102, 23);
            this.btnVenc.TabIndex = 22;
            this.btnVenc.Text = "Vencimientos";
            this.btnVenc.UseVisualStyleBackColor = true;
            this.btnVenc.Click += new System.EventHandler(this.btnVenc_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(120, 59);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormVencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 149);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnVenc);
            this.Name = "FormVencimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vencimientos";
            this.Load += new System.EventHandler(this.FormVencimientos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVenc;
        private System.Windows.Forms.Button btnAceptar;
    }
}