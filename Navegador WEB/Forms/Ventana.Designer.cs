namespace NavegadorWEB.Forms
{
    partial class Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonAtras = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonAdelante = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonRecargar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonHome = new System.Windows.Forms.ToolStripButton();
            this.ToolStripTextBoxURL = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripButtonBuscar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonNuevaPestanna = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemHistorial = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCache = new System.Windows.Forms.ToolStripMenuItem();
            this.WebBrowserPrincipal = new System.Windows.Forms.WebBrowser();
            this.ProgressBarDescarga = new System.Windows.Forms.ProgressBar();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonAtras,
            this.ToolStripButtonAdelante,
            this.ToolStripButtonRecargar,
            this.ToolStripButtonHome,
            this.ToolStripTextBoxURL,
            this.ToolStripButtonBuscar,
            this.ToolStripButtonNuevaPestanna,
            this.ToolStripButtonCerrar,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(604, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButtonAtras
            // 
            this.ToolStripButtonAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAtras.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonAtras.Image")));
            this.ToolStripButtonAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAtras.Name = "ToolStripButtonAtras";
            this.ToolStripButtonAtras.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonAtras.Text = "toolStripButton1";
            this.ToolStripButtonAtras.Click += new System.EventHandler(this.ToolStripButtonAtras_Click);
            // 
            // ToolStripButtonAdelante
            // 
            this.ToolStripButtonAdelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAdelante.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonAdelante.Image")));
            this.ToolStripButtonAdelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAdelante.Name = "ToolStripButtonAdelante";
            this.ToolStripButtonAdelante.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonAdelante.Text = "toolStripButton2";
            this.ToolStripButtonAdelante.Click += new System.EventHandler(this.ToolStripButtonAdelante_Click);
            // 
            // ToolStripButtonRecargar
            // 
            this.ToolStripButtonRecargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonRecargar.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonRecargar.Image")));
            this.ToolStripButtonRecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonRecargar.Name = "ToolStripButtonRecargar";
            this.ToolStripButtonRecargar.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonRecargar.Text = "toolStripButton3";
            this.ToolStripButtonRecargar.Click += new System.EventHandler(this.ToolStripButtonRecargar_Click);
            // 
            // ToolStripButtonHome
            // 
            this.ToolStripButtonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonHome.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonHome.Image")));
            this.ToolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonHome.Name = "ToolStripButtonHome";
            this.ToolStripButtonHome.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonHome.Text = "toolStripButton1";
            // 
            // ToolStripTextBoxURL
            // 
            this.ToolStripTextBoxURL.Name = "ToolStripTextBoxURL";
            this.ToolStripTextBoxURL.Size = new System.Drawing.Size(400, 25);
            // 
            // ToolStripButtonBuscar
            // 
            this.ToolStripButtonBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonBuscar.Image")));
            this.ToolStripButtonBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonBuscar.Name = "ToolStripButtonBuscar";
            this.ToolStripButtonBuscar.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonBuscar.Text = "toolStripButton4";
            this.ToolStripButtonBuscar.Click += new System.EventHandler(this.ToolStripButtonBuscar_Click);
            // 
            // ToolStripButtonNuevaPestanna
            // 
            this.ToolStripButtonNuevaPestanna.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonNuevaPestanna.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonNuevaPestanna.Image")));
            this.ToolStripButtonNuevaPestanna.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonNuevaPestanna.Name = "ToolStripButtonNuevaPestanna";
            this.ToolStripButtonNuevaPestanna.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonNuevaPestanna.Text = "toolStripButton6";
            this.ToolStripButtonNuevaPestanna.Click += new System.EventHandler(this.ToolStripButtonNuevaPestanna_Click);
            // 
            // ToolStripButtonCerrar
            // 
            this.ToolStripButtonCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonCerrar.Image")));
            this.ToolStripButtonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonCerrar.Name = "ToolStripButtonCerrar";
            this.ToolStripButtonCerrar.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonCerrar.Text = "toolStripButton1";
            this.ToolStripButtonCerrar.Click += new System.EventHandler(this.ToolStripButtonCerrar_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHistorial,
            this.ToolStripMenuItemCache});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // ToolStripMenuItemHistorial
            // 
            this.ToolStripMenuItemHistorial.Name = "ToolStripMenuItemHistorial";
            this.ToolStripMenuItemHistorial.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemHistorial.Text = "Historial";
            this.ToolStripMenuItemHistorial.Click += new System.EventHandler(this.ToolStripMenuItemHistorial_Click);
            // 
            // ToolStripMenuItemCache
            // 
            this.ToolStripMenuItemCache.Name = "ToolStripMenuItemCache";
            this.ToolStripMenuItemCache.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemCache.Text = "¿Borrar Cache?";
            this.ToolStripMenuItemCache.Click += new System.EventHandler(this.ToolStripMenuItemCache_Click);
            // 
            // WebBrowserPrincipal
            // 
            this.WebBrowserPrincipal.Location = new System.Drawing.Point(0, 28);
            this.WebBrowserPrincipal.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserPrincipal.Name = "WebBrowserPrincipal";
            this.WebBrowserPrincipal.Size = new System.Drawing.Size(833, 459);
            this.WebBrowserPrincipal.TabIndex = 2;
            // 
            // ProgressBarDescarga
            // 
            this.ProgressBarDescarga.Location = new System.Drawing.Point(610, 9);
            this.ProgressBarDescarga.Name = "ProgressBarDescarga";
            this.ProgressBarDescarga.Size = new System.Drawing.Size(202, 10);
            this.ProgressBarDescarga.TabIndex = 3;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(836, 487);
            this.ControlBox = false;
            this.Controls.Add(this.ProgressBarDescarga);
            this.Controls.Add(this.WebBrowserPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventana";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonAtras;
        private System.Windows.Forms.ToolStripButton ToolStripButtonAdelante;
        private System.Windows.Forms.ToolStripButton ToolStripButtonRecargar;
        private System.Windows.Forms.WebBrowser WebBrowserPrincipal;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBoxURL;
        private System.Windows.Forms.ToolStripButton ToolStripButtonBuscar;
        private System.Windows.Forms.ToolStripButton ToolStripButtonNuevaPestanna;
        private System.Windows.Forms.ToolStripButton ToolStripButtonHome;
        private System.Windows.Forms.ToolStripButton ToolStripButtonCerrar;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHistorial;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCache;
        private System.Windows.Forms.ProgressBar ProgressBarDescarga;
    }
}