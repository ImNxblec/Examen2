namespace Examen2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGGestion = new Button();
            btnSalir = new Button();
            label1 = new Label();
            btnPoderes = new Button();
            btnMisiones = new Button();
            SuspendLayout();
            // 
            // btnGGestion
            // 
            btnGGestion.Location = new Point(79, 123);
            btnGGestion.Name = "btnGGestion";
            btnGGestion.Size = new Size(164, 52);
            btnGGestion.TabIndex = 0;
            btnGGestion.Text = "Gestión de Superhéroes";
            btnGGestion.UseVisualStyleBackColor = true;
            btnGGestion.Click += btnGestion_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(112, 304);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 27);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(65, 49);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 4;
            label1.Text = "Menu Principal";
            // 
            // btnPoderes
            // 
            btnPoderes.Location = new Point(79, 181);
            btnPoderes.Name = "btnPoderes";
            btnPoderes.Size = new Size(164, 52);
            btnPoderes.TabIndex = 5;
            btnPoderes.Text = "Gestión de Poderes";
            btnPoderes.UseVisualStyleBackColor = true;
            btnPoderes.Click += btnPoderes_Click;
            // 
            // btnMisiones
            // 
            btnMisiones.Location = new Point(79, 239);
            btnMisiones.Name = "btnMisiones";
            btnMisiones.Size = new Size(164, 52);
            btnMisiones.TabIndex = 6;
            btnMisiones.Text = "Gestión de Misiones";
            btnMisiones.UseVisualStyleBackColor = true;
            btnMisiones.Click += btnMisiones_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 376);
            Controls.Add(btnMisiones);
            Controls.Add(btnPoderes);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnGGestion);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagina de inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGGestion;
        private Button btnGHabilidades;
        private Button btnGMisiones;
        private Button btnSalir;
        private Label label1;
        private Button btnPoderes;
        private Button btnMisiones;
    }
}
