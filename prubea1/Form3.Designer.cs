namespace prubea1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accede a tu perfil";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Snow;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Silver;
            this.txtUser.Location = new System.Drawing.Point(188, 162);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(229, 33);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.MistyRose;
            this.btnAcceder.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Location = new System.Drawing.Point(188, 306);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(229, 76);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Snow;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Silver;
            this.txtPass.Location = new System.Drawing.Point(188, 219);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(229, 33);
            this.txtPass.TabIndex = 6;
            this.txtPass.Text = "Password";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.MistyRose;
            this.btnReg.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(188, 417);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(229, 76);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Registrarse";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(612, 583);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnReg;
    }
}