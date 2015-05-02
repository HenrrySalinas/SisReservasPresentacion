namespace SisReservasPresentacion.Sitio
{
    partial class RegistroPersona
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCi = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.rdoCi = new System.Windows.Forms.RadioButton();
            this.rdoNit = new System.Windows.Forms.RadioButton();
            this.pnlTipoDocumento = new System.Windows.Forms.Panel();
            this.btnRegistrarPersona = new System.Windows.Forms.Button();
            this.pnlGenero = new System.Windows.Forms.Panel();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.pnlTipoDocumento.SuspendLayout();
            this.pnlGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Location = new System.Drawing.Point(29, 79);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(62, 13);
            this.lblCi.TabIndex = 1;
            this.lblCi.Text = "Documento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(373, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(103, 72);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(200, 20);
            this.txtCi.TabIndex = 3;
            this.txtCi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCi_KeyPress);
            // 
            // rdoCi
            // 
            this.rdoCi.AutoSize = true;
            this.rdoCi.Checked = true;
            this.rdoCi.Location = new System.Drawing.Point(3, 3);
            this.rdoCi.Name = "rdoCi";
            this.rdoCi.Size = new System.Drawing.Size(41, 17);
            this.rdoCi.TabIndex = 4;
            this.rdoCi.TabStop = true;
            this.rdoCi.Text = "C.I.";
            this.rdoCi.UseVisualStyleBackColor = true;
            // 
            // rdoNit
            // 
            this.rdoNit.AutoSize = true;
            this.rdoNit.Location = new System.Drawing.Point(63, 3);
            this.rdoNit.Name = "rdoNit";
            this.rdoNit.Size = new System.Drawing.Size(49, 17);
            this.rdoNit.TabIndex = 5;
            this.rdoNit.Text = "N.I.T";
            this.rdoNit.UseVisualStyleBackColor = true;
            // 
            // pnlTipoDocumento
            // 
            this.pnlTipoDocumento.Controls.Add(this.rdoCi);
            this.pnlTipoDocumento.Controls.Add(this.rdoNit);
            this.pnlTipoDocumento.Location = new System.Drawing.Point(315, 65);
            this.pnlTipoDocumento.Name = "pnlTipoDocumento";
            this.pnlTipoDocumento.Size = new System.Drawing.Size(161, 27);
            this.pnlTipoDocumento.TabIndex = 7;
            // 
            // btnRegistrarPersona
            // 
            this.btnRegistrarPersona.Location = new System.Drawing.Point(106, 186);
            this.btnRegistrarPersona.Name = "btnRegistrarPersona";
            this.btnRegistrarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarPersona.TabIndex = 8;
            this.btnRegistrarPersona.Text = "Registrar";
            this.btnRegistrarPersona.UseVisualStyleBackColor = true;
            this.btnRegistrarPersona.Click += new System.EventHandler(this.btnRegistrarPersona_Click);
            // 
            // pnlGenero
            // 
            this.pnlGenero.Controls.Add(this.rdoFemenino);
            this.pnlGenero.Controls.Add(this.rdoMasculino);
            this.pnlGenero.Location = new System.Drawing.Point(103, 140);
            this.pnlGenero.Name = "pnlGenero";
            this.pnlGenero.Size = new System.Drawing.Size(200, 26);
            this.pnlGenero.TabIndex = 9;
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.Location = new System.Drawing.Point(93, 3);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdoFemenino.TabIndex = 10;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Checked = true;
            this.rdoMasculino.Location = new System.Drawing.Point(3, 3);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdoMasculino.TabIndex = 10;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // RegistroPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 251);
            this.Controls.Add(this.pnlGenero);
            this.Controls.Add(this.btnRegistrarPersona);
            this.Controls.Add(this.pnlTipoDocumento);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCi);
            this.Controls.Add(this.lblNombre);
            this.Name = "RegistroPersona";
            this.Text = "RegistroPersona";
            this.pnlTipoDocumento.ResumeLayout(false);
            this.pnlTipoDocumento.PerformLayout();
            this.pnlGenero.ResumeLayout(false);
            this.pnlGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.RadioButton rdoCi;
        private System.Windows.Forms.RadioButton rdoNit;
        private System.Windows.Forms.Panel pnlTipoDocumento;
        private System.Windows.Forms.Button btnRegistrarPersona;
        private System.Windows.Forms.Panel pnlGenero;
        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.RadioButton rdoMasculino;
    }
}