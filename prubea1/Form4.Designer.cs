namespace prubea1
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "¡Rellena los siguientes campos y se uno más!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Regístrate";
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.MistyRose;
            this.btnReg.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(189, 471);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(229, 76);
            this.btnReg.TabIndex = 26;
            this.btnReg.Text = "Registrarse";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtTlf
            // 
            this.txtTlf.BackColor = System.Drawing.Color.Snow;
            this.txtTlf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTlf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTlf.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTlf.ForeColor = System.Drawing.Color.Silver;
            this.txtTlf.Location = new System.Drawing.Point(336, 379);
            this.txtTlf.Multiline = true;
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(229, 33);
            this.txtTlf.TabIndex = 25;
            this.txtTlf.Text = "Teléfono";
            this.txtTlf.Enter += new System.EventHandler(this.txtTlf_Enter);
            this.txtTlf.Leave += new System.EventHandler(this.txtTlf_Leave);
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.Snow;
            this.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCP.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.ForeColor = System.Drawing.Color.Silver;
            this.txtCP.Location = new System.Drawing.Point(47, 379);
            this.txtCP.Multiline = true;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(229, 33);
            this.txtCP.TabIndex = 24;
            this.txtCP.Text = "Código Postal";
            this.txtCP.Enter += new System.EventHandler(this.txtCP_Enter);
            this.txtCP.Leave += new System.EventHandler(this.txtCP_Leave);
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.Snow;
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenero.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.ForeColor = System.Drawing.Color.Silver;
            this.txtGenero.Location = new System.Drawing.Point(336, 322);
            this.txtGenero.Multiline = true;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(229, 33);
            this.txtGenero.TabIndex = 23;
            this.txtGenero.Text = "Género";
            this.txtGenero.Enter += new System.EventHandler(this.txtGenero_Enter);
            this.txtGenero.Leave += new System.EventHandler(this.txtGenero_Leave);
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.Snow;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.Silver;
            this.txtEdad.Location = new System.Drawing.Point(47, 265);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(229, 33);
            this.txtEdad.TabIndex = 22;
            this.txtEdad.Text = "Edad";
            this.txtEdad.Enter += new System.EventHandler(this.txtEdad_Enter);
            this.txtEdad.Leave += new System.EventHandler(this.txtEdad_Leave);
            // 
            // txtapellidos
            // 
            this.txtapellidos.BackColor = System.Drawing.Color.Snow;
            this.txtapellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtapellidos.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.ForeColor = System.Drawing.Color.Silver;
            this.txtapellidos.Location = new System.Drawing.Point(47, 208);
            this.txtapellidos.Multiline = true;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(229, 33);
            this.txtapellidos.TabIndex = 21;
            this.txtapellidos.Text = "Apellidos";
            this.txtapellidos.Enter += new System.EventHandler(this.txtapellidos_Enter);
            this.txtapellidos.Leave += new System.EventHandler(this.txtapellidos_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Snow;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Silver;
            this.txtName.Location = new System.Drawing.Point(47, 151);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 33);
            this.txtName.TabIndex = 20;
            this.txtName.Text = "Nombre";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Snow;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Silver;
            this.txtDireccion.Location = new System.Drawing.Point(47, 322);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(229, 33);
            this.txtDireccion.TabIndex = 19;
            this.txtDireccion.Text = "Dirección";
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Snow;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(336, 265);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 33);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Snow;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Silver;
            this.txtPass.Location = new System.Drawing.Point(336, 208);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(229, 33);
            this.txtPass.TabIndex = 17;
            this.txtPass.Text = "Password";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Snow;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Silver;
            this.txtUser.Location = new System.Drawing.Point(336, 151);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(229, 33);
            this.txtUser.TabIndex = 16;
            this.txtUser.Text = "Usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(612, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtTlf);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
    }
}