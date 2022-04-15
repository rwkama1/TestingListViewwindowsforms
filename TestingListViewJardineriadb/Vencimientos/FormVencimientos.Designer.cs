
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
            this.grpVenc = new System.Windows.Forms.GroupBox();
            this.btnVenc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpVenc
            // 
            this.grpVenc.ForeColor = System.Drawing.Color.Navy;
            this.grpVenc.Location = new System.Drawing.Point(12, 21);
            this.grpVenc.Name = "grpVenc";
            this.grpVenc.Size = new System.Drawing.Size(137, 49);
            this.grpVenc.TabIndex = 1;
            this.grpVenc.TabStop = false;
            this.grpVenc.Text = "Cantidad Vencimientos";
            // 
            // btnVenc
            // 
            this.btnVenc.Location = new System.Drawing.Point(12, 93);
            this.btnVenc.Name = "btnVenc";
            this.btnVenc.Size = new System.Drawing.Size(102, 23);
            this.btnVenc.TabIndex = 22;
            this.btnVenc.Text = "Vencimientos";
            this.btnVenc.UseVisualStyleBackColor = true;
            this.btnVenc.Click += new System.EventHandler(this.btnVenc_Click);
            // 
            // FormVencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 149);
            this.Controls.Add(this.btnVenc);
            this.Controls.Add(this.grpVenc);
            this.Name = "FormVencimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vencimientos";
            this.Load += new System.EventHandler(this.FormVencimientos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVenc;
        private System.Windows.Forms.Button btnVenc;
    }
}