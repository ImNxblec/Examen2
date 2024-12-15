namespace Examen2.Views
{
    partial class frmGestionSuperheroes
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            grdSuperheroe = new DataGridView();
            panel3 = new Panel();
            btnPoderes = new Button();
            btnMisiones = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnSalir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSuperheroe).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 29);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(grdSuperheroe);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 340);
            panel2.TabIndex = 1;
            // 
            // grdSuperheroe
            // 
            grdSuperheroe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSuperheroe.Dock = DockStyle.Fill;
            grdSuperheroe.Location = new Point(0, 0);
            grdSuperheroe.Name = "grdSuperheroe";
            grdSuperheroe.Size = new Size(800, 340);
            grdSuperheroe.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPoderes);
            panel3.Controls.Add(btnMisiones);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnActualizar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(btnSalir);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 369);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 81);
            panel3.TabIndex = 2;
            // 
            // btnPoderes
            // 
            btnPoderes.Location = new Point(398, 21);
            btnPoderes.Name = "btnPoderes";
            btnPoderes.Size = new Size(93, 39);
            btnPoderes.TabIndex = 5;
            btnPoderes.Text = "Lista de poderes";
            btnPoderes.UseVisualStyleBackColor = true;
            btnPoderes.Click += btnPoderes_Click;
            // 
            // btnMisiones
            // 
            btnMisiones.Location = new Point(299, 21);
            btnMisiones.Name = "btnMisiones";
            btnMisiones.Size = new Size(93, 39);
            btnMisiones.TabIndex = 4;
            btnMisiones.Text = "Lista de misiones";
            btnMisiones.UseVisualStyleBackColor = true;
            btnMisiones.Click += btnMisiones_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(200, 21);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(497, 21);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(93, 39);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(596, 21);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 39);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(695, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 39);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmGestionSuperheroes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmGestionSuperheroes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Superhéroes";
            Load += frmGestionSuperheroes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSuperheroe).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private DataGridView grdSuperheroe;
        private Panel panel3;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnPoderes;
        private Button btnMisiones;
    }
}