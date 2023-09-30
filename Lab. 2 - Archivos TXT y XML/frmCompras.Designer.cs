namespace Lab._2___Archivos_TXT_y_XML
{
    partial class frmCompras
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
            groupBox1 = new GroupBox();
            btnCargar = new Button();
            btnBuscar = new Button();
            tbRuta = new TextBox();
            lblRutaArchivo = new Label();
            lvwCompras = new ListView();
            colNumeroId = new ColumnHeader();
            colNombre = new ColumnHeader();
            colApellido = new ColumnHeader();
            colProvincia = new ColumnHeader();
            colEmail = new ColumnHeader();
            colMonto = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(tbRuta);
            groupBox1.Controls.Add(lblRutaArchivo);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 81);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(447, 45);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 3;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(478, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(44, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "...";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbRuta
            // 
            tbRuta.Location = new Point(97, 16);
            tbRuta.Name = "tbRuta";
            tbRuta.ReadOnly = true;
            tbRuta.Size = new Size(365, 23);
            tbRuta.TabIndex = 1;
            // 
            // lblRutaArchivo
            // 
            lblRutaArchivo.AutoSize = true;
            lblRutaArchivo.Location = new Point(12, 19);
            lblRutaArchivo.Name = "lblRutaArchivo";
            lblRutaArchivo.Size = new Size(79, 15);
            lblRutaArchivo.TabIndex = 0;
            lblRutaArchivo.Text = "Ruta archivo: ";
            // 
            // lvwCompras
            // 
            lvwCompras.BackColor = SystemColors.Info;
            lvwCompras.Columns.AddRange(new ColumnHeader[] { colNumeroId, colNombre, colApellido, colProvincia, colEmail, colMonto });
            lvwCompras.Dock = DockStyle.Fill;
            lvwCompras.GridLines = true;
            lvwCompras.Location = new Point(0, 81);
            lvwCompras.Name = "lvwCompras";
            lvwCompras.Size = new Size(548, 369);
            lvwCompras.TabIndex = 1;
            lvwCompras.UseCompatibleStateImageBehavior = false;
            lvwCompras.View = View.Details;
            // 
            // colNumeroId
            // 
            colNumeroId.Text = "N° Identificación ";
            colNumeroId.Width = 120;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 80;
            // 
            // colApellido
            // 
            colApellido.Text = "Apellido";
            colApellido.Width = 80;
            // 
            // colProvincia
            // 
            colProvincia.Text = "Provincia";
            colProvincia.Width = 80;
            // 
            // colEmail
            // 
            colEmail.Text = "Email";
            colEmail.Width = 120;
            // 
            // colMonto
            // 
            colMonto.Text = "Monto";
            colMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(lvwCompras);
            Controls.Add(groupBox1);
            Name = "frmCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblRutaArchivo;
        private Button btnBuscar;
        private TextBox tbRuta;
        private Button btnCargar;
        private ListView lvwCompras;
        private ColumnHeader colNumeroId;
        private ColumnHeader colNombre;
        private ColumnHeader colApellido;
        private ColumnHeader colProvincia;
        private ColumnHeader colEmail;
        private ColumnHeader colMonto;
    }
}