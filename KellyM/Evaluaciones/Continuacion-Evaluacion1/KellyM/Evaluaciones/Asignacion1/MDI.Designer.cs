namespace Asignacion1
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudDePrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depreciacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectivoOTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudDePrestamoToolStripMenuItem,
            this.depreciacionToolStripMenuItem,
            this.efectivoOTarjetaToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // solicitudDePrestamoToolStripMenuItem
            // 
            this.solicitudDePrestamoToolStripMenuItem.Name = "solicitudDePrestamoToolStripMenuItem";
            this.solicitudDePrestamoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.solicitudDePrestamoToolStripMenuItem.Text = "Solicitud de prestamo";
            this.solicitudDePrestamoToolStripMenuItem.Click += new System.EventHandler(this.solicitudDePrestamoToolStripMenuItem_Click);
            // 
            // depreciacionToolStripMenuItem
            // 
            this.depreciacionToolStripMenuItem.Name = "depreciacionToolStripMenuItem";
            this.depreciacionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.depreciacionToolStripMenuItem.Text = "Depreciacion";
            this.depreciacionToolStripMenuItem.Click += new System.EventHandler(this.depreciacionToolStripMenuItem_Click);
            // 
            // efectivoOTarjetaToolStripMenuItem
            // 
            this.efectivoOTarjetaToolStripMenuItem.Name = "efectivoOTarjetaToolStripMenuItem";
            this.efectivoOTarjetaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.efectivoOTarjetaToolStripMenuItem.Text = "Efectivo o tarjeta";
            this.efectivoOTarjetaToolStripMenuItem.Click += new System.EventHandler(this.efectivoOTarjetaToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 472);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pagosToolStripMenuItem;
        private ToolStripMenuItem solicitudDePrestamoToolStripMenuItem;
        private ToolStripMenuItem depreciacionToolStripMenuItem;
        private ToolStripMenuItem efectivoOTarjetaToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
    }
}