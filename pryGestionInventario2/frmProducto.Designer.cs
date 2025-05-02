namespace pryGestionInventario2
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation5 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMostrar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnEsconder = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnReporte = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBorrarProductos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnModificarProductos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAgregarProducto = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnVerProducto = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnReporte);
            this.panelMenu.Controls.Add(this.btnBorrarProductos);
            this.panelMenu.Controls.Add(this.btnModificarProductos);
            this.panelMenu.Controls.Add(this.btnAgregarProducto);
            this.panelMenu.Controls.Add(this.btnVerProducto);
            this.guna2Transition1.SetDecoration(this.panelMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 450);
            this.panelMenu.TabIndex = 24;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Animated = true;
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Transition1.SetDecoration(this.btnMostrar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMostrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMostrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMostrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMostrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMostrar.FillColor = System.Drawing.Color.Transparent;
            this.btnMostrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Image = global::pryGestionInventario2.Properties.Resources.flecha_adelante2;
            this.btnMostrar.Location = new System.Drawing.Point(32, 390);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMostrar.Size = new System.Drawing.Size(40, 40);
            this.btnMostrar.TabIndex = 28;
            this.btnMostrar.UseTransparentBackground = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEsconder
            // 
            this.btnEsconder.Animated = true;
            this.btnEsconder.BackColor = System.Drawing.Color.Transparent;
            this.btnEsconder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEsconder.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btnEsconder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnEsconder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEsconder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEsconder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEsconder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEsconder.FillColor = System.Drawing.Color.Transparent;
            this.btnEsconder.FocusedColor = System.Drawing.Color.Transparent;
            this.btnEsconder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEsconder.ForeColor = System.Drawing.Color.White;
            this.btnEsconder.Image = global::pryGestionInventario2.Properties.Resources.flecha_atras;
            this.btnEsconder.Location = new System.Drawing.Point(206, 390);
            this.btnEsconder.Name = "btnEsconder";
            this.btnEsconder.PressedColor = System.Drawing.Color.BlueViolet;
            this.btnEsconder.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEsconder.Size = new System.Drawing.Size(40, 40);
            this.btnEsconder.TabIndex = 25;
            this.btnEsconder.UseTransparentBackground = true;
            this.btnEsconder.Click += new System.EventHandler(this.btnEsconder_Click);
            // 
            // btnReporte
            // 
            this.guna2Transition1.SetDecoration(this.btnReporte, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnReporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReporte.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReporte.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReporte.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = global::pryGestionInventario2.Properties.Resources.reporte;
            this.btnReporte.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReporte.Location = new System.Drawing.Point(12, 339);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(191, 45);
            this.btnReporte.TabIndex = 29;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnBorrarProductos
            // 
            this.guna2Transition1.SetDecoration(this.btnBorrarProductos, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBorrarProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrarProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrarProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrarProductos.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrarProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrarProductos.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrarProductos.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnBorrarProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarProductos.ForeColor = System.Drawing.Color.White;
            this.btnBorrarProductos.Image = global::pryGestionInventario2.Properties.Resources.tacho;
            this.btnBorrarProductos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBorrarProductos.Location = new System.Drawing.Point(12, 265);
            this.btnBorrarProductos.Name = "btnBorrarProductos";
            this.btnBorrarProductos.Size = new System.Drawing.Size(191, 45);
            this.btnBorrarProductos.TabIndex = 28;
            this.btnBorrarProductos.Text = "Borrar Productos";
            this.btnBorrarProductos.Click += new System.EventHandler(this.btnBorrarProductos_Click);
            // 
            // btnModificarProductos
            // 
            this.guna2Transition1.SetDecoration(this.btnModificarProductos, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnModificarProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarProductos.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarProductos.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarProductos.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnModificarProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProductos.ForeColor = System.Drawing.Color.White;
            this.btnModificarProductos.Image = global::pryGestionInventario2.Properties.Resources.lapiz;
            this.btnModificarProductos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModificarProductos.Location = new System.Drawing.Point(12, 191);
            this.btnModificarProductos.Name = "btnModificarProductos";
            this.btnModificarProductos.Size = new System.Drawing.Size(191, 45);
            this.btnModificarProductos.TabIndex = 27;
            this.btnModificarProductos.Text = "Editar Productos";
            this.btnModificarProductos.Click += new System.EventHandler(this.btnModificarProductos_Click);
            // 
            // btnAgregarProducto
            // 
            this.guna2Transition1.SetDecoration(this.btnAgregarProducto, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAgregarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarProducto.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarProducto.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarProducto.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Image = global::pryGestionInventario2.Properties.Resources.plus_sign_vector_icon;
            this.btnAgregarProducto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 122);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(191, 45);
            this.btnAgregarProducto.TabIndex = 26;
            this.btnAgregarProducto.Text = "Agregar Productos";
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnVerProducto
            // 
            this.guna2Transition1.SetDecoration(this.btnVerProducto, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnVerProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerProducto.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerProducto.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnVerProducto.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnVerProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProducto.ForeColor = System.Drawing.Color.White;
            this.btnVerProducto.Image = global::pryGestionInventario2.Properties.Resources.producto_ver;
            this.btnVerProducto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVerProducto.Location = new System.Drawing.Point(12, 49);
            this.btnVerProducto.Name = "btnVerProducto";
            this.btnVerProducto.Size = new System.Drawing.Size(191, 45);
            this.btnVerProducto.TabIndex = 25;
            this.btnVerProducto.Text = "Ver Productos";
            this.btnVerProducto.Click += new System.EventHandler(this.btnVerProducto_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoRoundedCorners = true;
            this.btnCerrar.BorderColor = System.Drawing.Color.DimGray;
            this.btnCerrar.BorderRadius = 21;
            this.guna2Transition1.SetDecoration(this.btnCerrar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrar.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(526, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 45);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEsconder);
            this.Controls.Add(this.panelMenu);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2GradientButton btnBorrarProductos;
        private Guna.UI2.WinForms.Guna2GradientButton btnModificarProductos;
        private Guna.UI2.WinForms.Guna2GradientButton btnAgregarProducto;
        private Guna.UI2.WinForms.Guna2GradientButton btnVerProducto;
        private Guna.UI2.WinForms.Guna2GradientButton btnReporte;
        private Guna.UI2.WinForms.Guna2CircleButton btnEsconder;
        private Guna.UI2.WinForms.Guna2CircleButton btnMostrar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
    }
}

