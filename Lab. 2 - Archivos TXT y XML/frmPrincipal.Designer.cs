namespace Lab._2___Archivos_TXT_y_XML
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            mnCalcularTotalCompras = new ToolStripMenuItem();
            mnAcercaDe = new ToolStripMenuItem();
            mnSalir = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnCalcularTotalCompras, mnAcercaDe, mnSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnCalcularTotalCompras
            // 
            mnCalcularTotalCompras.Name = "mnCalcularTotalCompras";
            mnCalcularTotalCompras.Size = new Size(138, 20);
            mnCalcularTotalCompras.Text = "Calcular total compras";
            mnCalcularTotalCompras.Click += mnCalcularTotalCompras_Click;
            // 
            // mnAcercaDe
            // 
            mnAcercaDe.Name = "mnAcercaDe";
            mnAcercaDe.Size = new Size(71, 20);
            mnAcercaDe.Text = "Acerca de";
            mnAcercaDe.Click += mnAcercaDe_Click;
            // 
            // mnSalir
            // 
            mnSalir.Name = "mnSalir";
            mnSalir.Size = new Size(41, 20);
            mnSalir.Text = "Salir";
            mnSalir.Click += salirToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            Text = "Lab 2";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnCalcularTotalCompras;
        private ToolStripMenuItem mnAcercaDe;
        private ToolStripMenuItem mnSalir;
    }
}