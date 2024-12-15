namespace Examen2.Views.HabilidadesViews
{
    partial class frmGestionHabilidades
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
            txAlias = new TextBox();
            label2 = new Label();
            txNombre = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvHabilidades = new DataGridView();
            panel3 = new Panel();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnSalir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHabilidades).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txAlias);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txNombre);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 31);
            panel1.TabIndex = 0;
            // 
            // txAlias
            // 
            txAlias.Location = new Point(451, 5);
            txAlias.Name = "txAlias";
            txAlias.Size = new Size(283, 23);
            txAlias.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 9);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Alias:";
            // 
            // txNombre
            // 
            txNombre.Location = new Point(80, 5);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(283, 23);
            txNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 8);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHabilidades);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 349);
            panel2.TabIndex = 1;
            // 
            // dgvHabilidades
            // 
            dgvHabilidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabilidades.Dock = DockStyle.Fill;
            dgvHabilidades.Location = new Point(0, 0);
            dgvHabilidades.Name = "dgvHabilidades";
            dgvHabilidades.Size = new Size(800, 349);
            dgvHabilidades.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnActualizar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(btnSalir);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 380);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 70);
            panel3.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(387, 19);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 39);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(486, 19);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(93, 39);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(585, 19);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 39);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(684, 19);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 39);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmGestionHabilidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmGestionHabilidades";
            Text = "frmGestionHabilidades";
            Load += frmGestionHabilidades_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHabilidades).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvHabilidades;
        private Panel panel3;
        private TextBox txAlias;
        private Label label2;
        private TextBox txNombre;
        private Label label1;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnSalir;
    }
}