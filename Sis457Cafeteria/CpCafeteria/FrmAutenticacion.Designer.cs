namespace CpCafeteria
{
    partial class FrmAutenticacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pctClave = new System.Windows.Forms.PictureBox();
            this.pnpClave = new System.Windows.Forms.Panel();
            this.textClave = new System.Windows.Forms.TextBox();
            this.lblclave = new System.Windows.Forms.Label();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pctLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 360);
            this.panel1.TabIndex = 2;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::CpCafeteria.Properties.Resources.Logo;
            this.pctLogo.Location = new System.Drawing.Point(3, 61);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(222, 241);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnIniciar);
            this.panel3.Controls.Add(this.pctClave);
            this.panel3.Controls.Add(this.pnpClave);
            this.panel3.Controls.Add(this.textClave);
            this.panel3.Controls.Add(this.lblclave);
            this.panel3.Controls.Add(this.pctUsuario);
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Controls.Add(this.pnlUsuario);
            this.panel3.Controls.Add(this.txtUsuario);
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(228, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 360);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 27);
            this.panel2.TabIndex = 27;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Brown;
            this.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCerrar.Image = global::CpCafeteria.Properties.Resources._2931151_delete_x_bin_recycle_remove_exit_close;
            this.btnCerrar.Location = new System.Drawing.Point(280, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Transparent;
            this.btnIniciar.Location = new System.Drawing.Point(41, 298);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(226, 35);
            this.btnIniciar.TabIndex = 26;
            this.btnIniciar.Text = "INICIAR SESION";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pctClave
            // 
            this.pctClave.Image = global::CpCafeteria.Properties.Resources.lock_padlock_symbol_for_security_interface;
            this.pctClave.Location = new System.Drawing.Point(27, 244);
            this.pctClave.Name = "pctClave";
            this.pctClave.Size = new System.Drawing.Size(25, 22);
            this.pctClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctClave.TabIndex = 25;
            this.pctClave.TabStop = false;
            // 
            // pnpClave
            // 
            this.pnpClave.BackColor = System.Drawing.Color.Chocolate;
            this.pnpClave.Location = new System.Drawing.Point(27, 267);
            this.pnpClave.Name = "pnpClave";
            this.pnpClave.Size = new System.Drawing.Size(251, 2);
            this.pnpClave.TabIndex = 24;
            // 
            // textClave
            // 
            this.textClave.BackColor = System.Drawing.Color.Khaki;
            this.textClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClave.Location = new System.Drawing.Point(58, 247);
            this.textClave.Multiline = true;
            this.textClave.Name = "textClave";
            this.textClave.PasswordChar = '*';
            this.textClave.Size = new System.Drawing.Size(220, 22);
            this.textClave.TabIndex = 23;
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclave.Location = new System.Drawing.Point(24, 214);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(115, 22);
            this.lblclave.TabIndex = 22;
            this.lblclave.Text = "Contraseña";
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = global::CpCafeteria.Properties.Resources.profile_user;
            this.pctUsuario.Location = new System.Drawing.Point(27, 173);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(25, 22);
            this.pctUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUsuario.TabIndex = 21;
            this.pctUsuario.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(89, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 34);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "BIENVENIDO";
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.Chocolate;
            this.pnlUsuario.Location = new System.Drawing.Point(27, 196);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(251, 2);
            this.pnlUsuario.TabIndex = 19;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Khaki;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(58, 176);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 22);
            this.txtUsuario.TabIndex = 18;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Khaki;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(24, 143);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 22);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "Usuario";
            // 
            // FrmAutenticacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(530, 360);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAutenticacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Autenticación - Cafetería :::";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pctClave;
        private System.Windows.Forms.Panel pnpClave;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}