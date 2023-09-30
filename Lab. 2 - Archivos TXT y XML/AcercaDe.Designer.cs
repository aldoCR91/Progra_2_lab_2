namespace Lab._2___Archivos_TXT_y_XML
{
    partial class frmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            pbLogoCuc = new PictureBox();
            lblYear = new Label();
            lblEstudiante = new Label();
            lblProfesor = new Label();
            lblTitulo = new Label();
            lblCurso = new Label();
            lblCarrera = new Label();
            lblUniversidad = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogoCuc).BeginInit();
            SuspendLayout();
            // 
            // pbLogoCuc
            // 
            pbLogoCuc.Image = (Image)resources.GetObject("pbLogoCuc.Image");
            pbLogoCuc.Location = new Point(26, 44);
            pbLogoCuc.Name = "pbLogoCuc";
            pbLogoCuc.Size = new Size(378, 346);
            pbLogoCuc.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogoCuc.TabIndex = 15;
            pbLogoCuc.TabStop = false;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblYear.Location = new Point(544, 385);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(89, 21);
            lblYear.TabIndex = 14;
            lblYear.Text = "Año: 2023 ";
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstudiante.Location = new Point(495, 327);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(178, 21);
            lblEstudiante.TabIndex = 13;
            lblEstudiante.Text = "Estudiante: Aldo Burgos ";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfesor.Location = new Point(434, 272);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(297, 21);
            lblProfesor.TabIndex = 12;
            lblProfesor.Text = "Profesor: Róger Alberto Rodríguez López ";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(486, 211);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(201, 21);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Lab. 2 - Archivos TXT y XML";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurso.Location = new Point(499, 159);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(174, 21);
            lblCurso.TabIndex = 10;
            lblCurso.Text = "TI-131 Programación 2 ";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarrera.Location = new Point(480, 105);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(219, 21);
            lblCarrera.TabIndex = 9;
            lblCarrera.Text = "Tecnologías de la Información ";
            // 
            // lblUniversidad
            // 
            lblUniversidad.AutoSize = true;
            lblUniversidad.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUniversidad.Location = new Point(435, 44);
            lblUniversidad.Name = "lblUniversidad";
            lblUniversidad.Size = new Size(303, 25);
            lblUniversidad.TabIndex = 8;
            lblUniversidad.Text = "Colegio Universitario de Cartago";
            // 
            // frmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 450);
            Controls.Add(pbLogoCuc);
            Controls.Add(lblYear);
            Controls.Add(lblEstudiante);
            Controls.Add(lblProfesor);
            Controls.Add(lblTitulo);
            Controls.Add(lblCurso);
            Controls.Add(lblCarrera);
            Controls.Add(lblUniversidad);
            MaximumSize = new Size(1200, 720);
            Name = "frmAcercaDe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca de";
            ((System.ComponentModel.ISupportInitialize)pbLogoCuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogoCuc;
        private Label lblYear;
        private Label lblEstudiante;
        private Label lblProfesor;
        private Label lblTitulo;
        private Label lblCurso;
        private Label lblCarrera;
        private Label lblUniversidad;
    }
}