namespace LabRepaso_Diego_Pérez_1114016
{
    partial class Form1
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
            this.addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.BackgroundImage = global::LabRepaso_Diego_Pérez_1114016.Properties.Resources.AddIcon;
            this.addbtn.Location = new System.Drawing.Point(12, 25);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(50, 49);
            this.addbtn.TabIndex = 0;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 307);
            this.Controls.Add(this.addbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
    }
}

