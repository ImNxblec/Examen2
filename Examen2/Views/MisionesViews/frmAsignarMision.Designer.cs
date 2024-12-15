namespace Examen2.Views.MisionesViews
{
    partial class frmAsignarMision
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
            txPoder = new TextBox();
            Poder = new Label();
            txAlias = new TextBox();
            label2 = new Label();
            txNombre = new TextBox();
            label3 = new Label();
            label1 = new Label();
            cbEstado = new ComboBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            dgvMisiones = new DataGridView();
            panel3 = new Panel();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnSalir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMisiones).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txPoder);
            panel1.Controls.Add(Poder);
            panel1.Controls.Add(txAlias);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txNombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbEstado);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 94);
            panel1.TabIndex = 0;
            // 
            // txPoder
            // 
            txPoder.Location = new Point(103, 58);
            txPoder.Name = "txPoder";
            txPoder.Size = new Size(283, 23);
            txPoder.TabIndex = 9;
            // 
            // Poder
            // 
            Poder.AutoSize = true;
            Poder.Location = new Point(40, 61);
            Poder.Name = "Poder";
            Poder.Size = new Size(41, 15);
            Poder.TabIndex = 8;
            Poder.Text = "Poder:";
            // 
            // txAlias
            // 
            txAlias.Location = new Point(474, 29);
            txAlias.Name = "txAlias";
            txAlias.Size = new Size(283, 23);
            txAlias.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 33);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "Alias:";
            // 
            // txNombre
            // 
            txNombre.Location = new Point(103, 29);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(283, 23);
            txNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 32);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(616, 68);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Estado:";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(667, 65);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(121, 23);
            cbEstado.TabIndex = 1;
            cbEstado.SelectedIndexChanged += cbEstado_SelectedIndexChanged;
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
            panel2.Controls.Add(dgvMisiones);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 342);
            panel2.TabIndex = 1;
            // 
            // dgvMisiones
            // 
            dgvMisiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMisiones.Dock = DockStyle.Fill;
            dgvMisiones.Location = new Point(0, 0);
            dgvMisiones.Name = "dgvMisiones";
            dgvMisiones.Size = new Size(800, 342);
            dgvMisiones.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnActualizar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(btnSalir);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 436);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 51);
            panel3.TabIndex = 2;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(497, 6);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(93, 39);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(596, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 39);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(695, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 39);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmAsignarMision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAsignarMision";
            Text = "AsignarMision";
            Load += frmAsignarMision_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMisiones).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private ComboBox cbEstado;
        private TextBox textBox1;
        private DataGridView dgvMisiones;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnSalir;
        private TextBox txAlias;
        private Label label2;
        private TextBox txNombre;
        private Label label3;
        private TextBox txPoder;
        private Label Poder;
    }
}