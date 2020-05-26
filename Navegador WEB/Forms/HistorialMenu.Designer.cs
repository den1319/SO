namespace NavegadorWEB.Forms
{
    partial class HistorialMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialMenu));
            this.DataGridViewInformacion = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonBorrarHistorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewInformacion
            // 
            this.DataGridViewInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInformacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.URL});
            this.DataGridViewInformacion.Location = new System.Drawing.Point(25, 52);
            this.DataGridViewInformacion.Name = "DataGridViewInformacion";
            this.DataGridViewInformacion.Size = new System.Drawing.Size(763, 340);
            this.DataGridViewInformacion.TabIndex = 0;
            this.DataGridViewInformacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewInformacion_CellDoubleClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 250;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Width = 500;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial";
            // 
            // ButtonBorrarHistorial
            // 
            this.ButtonBorrarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBorrarHistorial.Location = new System.Drawing.Point(634, 398);
            this.ButtonBorrarHistorial.Name = "ButtonBorrarHistorial";
            this.ButtonBorrarHistorial.Size = new System.Drawing.Size(154, 40);
            this.ButtonBorrarHistorial.TabIndex = 2;
            this.ButtonBorrarHistorial.Text = "¿Borrar historial?";
            this.ButtonBorrarHistorial.UseVisualStyleBackColor = true;
            this.ButtonBorrarHistorial.Click += new System.EventHandler(this.ButtonBorrarHistorial_Click);
            // 
            // HistorialMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonBorrarHistorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewInformacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialMenu";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInformacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBorrarHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
    }
}