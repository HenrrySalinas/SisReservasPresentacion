namespace SisReservasPresentacion.Sitio
{
    partial class VistaAsientos
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
            this.lblAsiento1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAsiento1
            // 
            this.lblAsiento1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAsiento1.Location = new System.Drawing.Point(57, 56);
            this.lblAsiento1.Name = "lblAsiento1";
            this.lblAsiento1.Size = new System.Drawing.Size(50, 50);
            this.lblAsiento1.TabIndex = 0;
            this.lblAsiento1.Text = "1v";
            this.lblAsiento1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // VistaAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 261);
            this.Controls.Add(this.lblAsiento1);
            this.Name = "VistaAsientos";
            this.Text = "VistaAsientos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAsiento1;
    }
}