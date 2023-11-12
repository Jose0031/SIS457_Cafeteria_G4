namespace CpCafeteria
{
    partial class FrmPrincipal
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnVenta = new FontAwesome.Sharp.IconButton();
            this.btnProducto = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.btnEmpleado = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.pbxMaximizar = new System.Windows.Forms.PictureBox();
            this.pbxRestaurar = new System.Windows.Forms.PictureBox();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.iconButton4);
            this.pnlMenu.Controls.Add(this.btnVenta);
            this.pnlMenu.Controls.Add(this.btnProducto);
            this.pnlMenu.Controls.Add(this.btnCliente);
            this.pnlMenu.Controls.Add(this.btnEmpleado);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(206, 511);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnCerrar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 35;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(0, 407);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCerrar.Size = new System.Drawing.Size(206, 50);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "CERRAR SESION";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 357);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(206, 50);
            this.iconButton4.TabIndex = 6;
            this.iconButton4.Text = "ACERCA DE";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnVenta.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenta.IconSize = 35;
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.Location = new System.Drawing.Point(0, 307);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVenta.Size = new System.Drawing.Size(206, 50);
            this.btnVenta.TabIndex = 5;
            this.btnVenta.Text = "VENTAS";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.btnProducto.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducto.IconSize = 35;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(0, 257);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProducto.Size = new System.Drawing.Size(206, 50);
            this.btnProducto.TabIndex = 4;
            this.btnProducto.Text = "PRODUCTOS";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.IconSize = 35;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 207);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCliente.Size = new System.Drawing.Size(206, 50);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnEmpleado.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleado.IconSize = 35;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 157);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(206, 50);
            this.btnEmpleado.TabIndex = 2;
            this.btnEmpleado.Text = "EMPLEADOS";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.White;
            this.pnlLogo.Controls.Add(this.pbxLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(206, 157);
            this.pnlLogo.TabIndex = 1;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Image = global::CpCafeteria.Properties.Resources.coffee_logo_suitable_for_cafes_coffee_shops_and_coffee_brands_vector;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(206, 157);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.pnlBarra.Controls.Add(this.pbxMaximizar);
            this.pnlBarra.Controls.Add(this.pbxRestaurar);
            this.pnlBarra.Controls.Add(this.pbxMinimizar);
            this.pnlBarra.Controls.Add(this.pbxSalir);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(206, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(738, 49);
            this.pnlBarra.TabIndex = 1;
            this.pnlBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseMove);
            // 
            // pbxMaximizar
            // 
            this.pbxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaximizar.BackColor = System.Drawing.Color.White;
            this.pbxMaximizar.Image = global::CpCafeteria.Properties.Resources.maximizaractual1;
            this.pbxMaximizar.Location = new System.Drawing.Point(681, 0);
            this.pbxMaximizar.Name = "pbxMaximizar";
            this.pbxMaximizar.Size = new System.Drawing.Size(30, 30);
            this.pbxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMaximizar.TabIndex = 3;
            this.pbxMaximizar.TabStop = false;
            this.pbxMaximizar.Click += new System.EventHandler(this.pbxMaximizar_Click);
            // 
            // pbxRestaurar
            // 
            this.pbxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxRestaurar.BackColor = System.Drawing.Color.White;
            this.pbxRestaurar.Image = global::CpCafeteria.Properties.Resources.restauraractual1;
            this.pbxRestaurar.Location = new System.Drawing.Point(681, 0);
            this.pbxRestaurar.Name = "pbxRestaurar";
            this.pbxRestaurar.Size = new System.Drawing.Size(30, 30);
            this.pbxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRestaurar.TabIndex = 5;
            this.pbxRestaurar.TabStop = false;
            this.pbxRestaurar.Click += new System.EventHandler(this.pbxRestaurar_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMinimizar.BackColor = System.Drawing.Color.White;
            this.pbxMinimizar.Image = global::CpCafeteria.Properties.Resources.minimizaractual;
            this.pbxMinimizar.Location = new System.Drawing.Point(654, 0);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(30, 30);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 4;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // pbxSalir
            // 
            this.pbxSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSalir.BackColor = System.Drawing.Color.White;
            this.pbxSalir.Image = global::CpCafeteria.Properties.Resources.cerraractual;
            this.pbxSalir.Location = new System.Drawing.Point(708, 0);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(30, 30);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 2;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.Khaki;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(206, 49);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(738, 462);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 511);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnVenta;
        private FontAwesome.Sharp.IconButton btnProducto;
        private FontAwesome.Sharp.IconButton btnCliente;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.PictureBox pbxMaximizar;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.PictureBox pbxRestaurar;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}

